#region Copyright (C) Simon Bridewell
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 3
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

// You can read the full text of the GNU General Public License at:
// http://www.gnu.org/licenses/gpl.html

// See also the Wikipedia entry on the GNU GPL at:
// http://en.wikipedia.org/wiki/GNU_General_Public_License
#endregion

using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CommonForms.Responsiveness
{
	/// <summary>
	/// Base class for a form which remains responsive during long-running
	/// operations and provides regular feedback to the user about the progress
	/// of the operation.
	/// </summary>
	public partial class ResponsiveForm : Form
	{
		#region declarations
		private Exception _exception;
		private Thread _backgroundThread;
		private LongRunningProcessObject _process;
		private ProgressForm _progressForm;
		private bool _allowToClose;
		private bool _isClosing;
		#endregion
		
		#region constructor
		/// <summary>
		/// Constructor.
		/// </summary>
		protected ResponsiveForm()
		{
			// The InitializeComponent() call is required for Windows Forms 
			// designer support.
			InitializeComponent();
			
			//
			// Add constructor code after the InitializeComponent() call.
			//
			_allowToClose = true;
		}
		#endregion

		#region TypesToDisable property
		/// <summary>
		/// Gets a collection of types of control to disable whilst a background
		/// thread is running.
		/// </summary>
		/// <remarks>
		/// Override this property in a derived class to change the list of 
		/// types to be disabled, for example:
		/// <code>
		/// protected static override Collection&lt;Type&gt; TypesToDisable
		/// {
		/// 	get
		/// 	{
		/// 		Collection&lt;Type&gt; types = base.TypesToDisable;
		/// 		types.Add( typeof( CheckBox ) );
		/// 		types.Remove( typeof( PropertyGrid ) );
		/// 		return types;
		/// 	}
		/// }
		/// </code>
		/// </remarks>
		protected virtual Collection<Type> TypesToDisable
		{
			get
			{
				Collection<Type> types = new Collection<Type>();
				types.Add( typeof( Button ) );
				types.Add( typeof( PropertyGrid ) );
				types.Add( typeof( MenuStrip ) );
				types.Add( typeof( ToolStripMenuItem ) );
				return types;
			}
		}
		#endregion

		#region protected methods
		
		#region protected StartBackgroundProcess method
		/// <summary>
		/// Disables form controls and starts the supplied process on a 
		/// background thread. The supplied process needs to invoke the
		/// StopTheClock method on completion.
		/// </summary>
		/// <param name="process">
		/// The <see cref="LongRunningProcessObject"/> class which declares the method
		/// to be started.
		/// </param>
		/// <param name="method">
		/// The name of the method to start on a background thread.
		/// </param>
		/// <param name="progressFormTitle">
		/// Text to display in the title bar of the progress form.
		/// </param>
		protected void StartBackgroundProcess( LongRunningProcessObject process,
		                                       ThreadStart method,
		                                       string progressFormTitle )
		{
			// Store the process
			_process = process;
			
			// Clear any exceptions from previous processes
			_exception = null;

			// Prevent the user from accidentally closing the form whilst the
			// process is still running
			_allowToClose = false;
			
			// Prevent the user from doing anything in the UI which could put
			// the process into an unexpected state while it's running
			DisableControls( this );
			
			// Display a form showing the progress of the process
			_progressForm = new ProgressForm( progressFormTitle );
			_progressForm.Show();
			
			// Start the method running on a background thread
			_backgroundThread = new Thread( method );
			_backgroundThread.IsBackground = true;
			_backgroundThread.Start();
			backgroundProcessTimer.Start();
			
			// Control returns to the caller now. The process is still running
			// in the background and will call the StopTheClock method once it
			// has finished.
		}
		#endregion
		
		#region protected virtual ProvideFeedback method
		/// <summary>
		/// Updates progress bars to provide the user with feedback on the 
		/// progress of a long-running process.
		/// </summary>
		protected virtual void ProvideFeedback()
		{
			if( _progressForm == null )
			{
				throw new InvalidOperationException( "_progressForm is null" );
			}
			
			if( _process == null )
			{
				throw new InvalidOperationException( "_process is null" );
			}
			
			_progressForm.UpdateBars( _process.AllProgressCounters );
		}
		#endregion
		
		#region protected virtual StopTheClock method
		/// <summary>
		/// When overridden in a derived class, stops the timer, calls the 
		/// UpdateUI method, enables any disabled controls and displays the
		/// details of any exception which occurred during the long-running
		/// process.
		/// Run on the UI thread.
		/// </summary>
		/// <remarks>
		/// Override this method to perform any additional tasks which are 
		/// needed upon completion of a long-running process and then call this
		/// base method.
		/// </remarks>
		protected virtual void StopTheClock()
		{
			backgroundProcessTimer.Stop();
			if( _progressForm != null )
			{
				_progressForm.Hide();
			}
			EnableControls( this );
			if( _exception != null )
			{
				ShowExceptionForm();
			}
			_allowToClose = true;
		}
		#endregion

		#region protected HandleException method
		/// <summary>
		/// Shows a form displaying the details of the supplied exception.
		/// </summary>
		/// <param name="ex">The exception to display the details of.</param>
		protected void HandleException( Exception ex )
		{
			if( ex == null )
			{
				return;
			}
			
			// store the exception for the ShowExceptionForm method
			_exception = ex;
			
			System.Diagnostics.Debug.WriteLine( ex.ToString() );
			
			// Remove any progress counters still attached to the process, in
			// case it needs to be rerun without the instance being 
			// reinstantiated.
			if( _process != null )
			{
				if( _process.AllProgressCounters != null )
				{
					foreach( ProgressCounter counter in _process.AllProgressCounters.Values )
					{
						_process.RemoveCounter( counter.Narrative );
					}
				}
			}
			
			if( Thread.CurrentThread.IsBackground )
			{
				// it's a background thread so invoke the method to show the
				// exception form
				if( _isClosing == false )
				{
					Invoke( new MethodInvoker( StopTheClock ) );
				}
			}
			else
			{
				// it's the UI thread so call the method to show the exception
				// form.
				if( _isClosing == false )
				{
					StopTheClock();
				}
			}
		}
		
		private void ShowExceptionForm()
		{
			backgroundProcessTimer.Stop();
			ExceptionForm ef = new ExceptionForm( _exception );
			ef.ShowDialog();
			_exception = null;
		}
		#endregion

		#endregion
		
		#region BackgroundProcessTimer tick event handler
		/// <summary>
		/// Event handler for the tick event of the BackgroundProcessTimer.
		/// Updates the user interface to provide the user with feedback on the
		/// progress of a long-running process.
		/// </summary>
		/// <param name="sender">The control which raised the tick event</param>
		/// <param name="e">More information about the event</param>
		[SuppressMessage("Microsoft.Design", 
		                 "CA1031:DoNotCatchGeneralExceptionTypes")]
		private void BackgroundProcessTimerTick( object sender, 
		                                         EventArgs e )
		{
			try
			{
				ProvideFeedback();
			}
			catch( Exception ex )
			{
				HandleException( ex );
			}
		}
		#endregion

		#region form closing event handler
		private void FormClosingHandler( object sender, FormClosingEventArgs e )
		{
			if( _allowToClose == false )
			{
				string message = "The process is still running - "
					+ "are you sure you want to close this window?";
				string caption = "Close window?";
				DialogResult result =
					CleverMessageBox.Show( message,
					                       caption,
					                       MessageBoxButtons.YesNo,
					                       MessageBoxIcon.Warning, 
					                       this );
				if( result == DialogResult.No )
				{
					// don't close the window
					e.Cancel = true;
				}
				else
				{
					// Close the window and abort any processes associated with
					// it.
					_isClosing = true;
					StopTheClock();
					_backgroundThread.Abort();
				}
			}
		}
		#endregion

		#region private methods
		
		#region private EnableControls method
		/// <summary>
		/// Enables all the controls on the supplied control, and their child
		/// controls, provided they are of a type defined in the TypesToDisable
		/// property
		/// </summary>
		/// <param name="parentControl">
		/// The parent control or form which contains the controls to enable.
		/// </param>
		private void EnableControls( Control parentControl )
		{
			SetControlsEnabled( parentControl, true );
		}
		#endregion
		
		#region private DisableControls method
		/// <summary>
		/// Disables all the controls on the supplied control, and their child
		/// controls, provided they are of a type defined in the TypesToDisable
		/// property
		/// </summary>
		/// <param name="parentControl">
		/// The parent control or form which contains the controls to disable.
		/// </param>
		private void DisableControls( Control parentControl )
		{
			SetControlsEnabled( parentControl, false );
		}
		#endregion
		
		#region private SetControlsEnabled method
		private void SetControlsEnabled( Control parentControl, bool enabling )
		{
			foreach( Control c in parentControl.Controls )
			{
				// Is this a type of control that we want to disable whilst 
				// running a process on a background thread?
				if( TypesToDisable.Contains( c.GetType() ) )
				{
					// Is it a MenuStrip?
					MenuStrip ms = c as MenuStrip;
					if( ms == null )
					{
						// Not a MenuStrip so just enable/disable it
						c.Enabled = enabling;
					}
					else
					{
						// It's a MenuStrip so don't disable/enable it but 
						// disable/enable its child items
						foreach( ToolStripMenuItem i in ms.Items )
						{
							// i is an item in the row of menus
							foreach( ToolStripMenuItem tsmi in i.DropDownItems )
							{
								// tsmi is an option within one of the menus
								tsmi.Enabled = enabling;
							}
						}
					}
				}
				
				// disable/enable any child controls too
				SetControlsEnabled( c, enabling );
			}
		}
		#endregion
		
		#endregion
		
	}
}
