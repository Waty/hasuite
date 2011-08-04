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
using System.Drawing;
using System.Windows.Forms;

namespace CommonForms.Responsiveness
{
	/// <summary>
	/// A dialogue to show the progress of a long-running process.
	/// </summary>
	internal partial class ProgressForm : Form
	{
		private int _topPosition;
		
		#region internal constructor
		/// <summary>
		/// Constructor.
		/// </summary>
		internal ProgressForm( string formTitle )
		{
			//
			// The InitializeComponent() call is required for Windows Forms 
			// designer support.
			//
			InitializeComponent();
			
			//
			// Add constructor code after the InitializeComponent() call.
			//
			this.ClientSize = new Size( 600, 0 );
			this.Text = formTitle;
		}
		#endregion
		
		#region internal UpdateBars method
		/// <summary>
		/// Updates the progress bars on the form with the supplied counters.
		/// </summary>
		/// <param name="counters">
		/// The counters to represent on the form with progress bars
		/// </param>
		internal void UpdateBars( ProgressCounterDictionary counters )
		{
			lock( counters )
			{
				foreach( Control c in this.Controls )
				{
					if( c is ProgressControl )
					{
						this.Controls.Remove( c );
					}
				}
				_topPosition = 0;
				foreach( ProgressCounter counter in counters.Values )
				{
					AddControl( counter );
				}
			}
		}
		#endregion

		#region internal AddControl method
		/// <summary>
		/// Adds a ProgressControl to the form
		/// </summary>
		/// <param name="counter">
		/// The progress counter to represent on the control.
		/// </param>
		internal void AddControl( ProgressCounter counter )
		{
			ProgressControl control = new ProgressControl( counter );
			control.Name = counter.Narrative;
			control.Left = 0;
			control.Top = _topPosition;
			control.Width = this.Width;
			_topPosition += control.Height;
			this.Controls.Add( control );
		}
		#endregion

	}
}
