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
using System.Windows.Forms;

namespace CommonForms
{
	/// <summary>
	/// A MessageBox which satisfies the FxCop rule 
	/// CA1300:SpecifyMessageBoxOptions.
	/// </summary>
	public static class CleverMessageBox
	{
		#region Show( string, Control ) method
		/// <summary>
		/// Shows the CleverMessageBox to the user.
		/// The CleverMessageBox will have only an OK button, and an Information
		/// icon, and the word "Information" will be used as the caption.
		/// </summary>
		/// <param name="message">
		/// The message to display in the CleverMessageBox.
		/// </param>
		/// <param name="control">
		/// The control from which this method is being called.
		/// </param>
		/// <returns>
		/// A System.Windows.Forms.DialogResult which reflects the button which
		/// the user clicked in response to the MessageBox.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// The supplied control is null.
		/// </exception>
		public static DialogResult Show( string message, Control control )
		{
			return CleverMessageBox.Show( message, "Information", control );
		}
		#endregion
		
		#region Show( string, string, Control ) method
		/// <summary>
		/// Shows the CleverMessageBox to the user.
		/// The CleverMessageBox will have only an OK button, and an Information
		/// icon.
		/// </summary>
		/// <param name="message">
		/// The message to display in the CleverMessageBox.
		/// </param>
		/// <param name="caption">
		/// The caption to display in the title bar of the CleverMessageBox
		/// </param>
		/// <param name="control">
		/// The control from which this method is being called.
		/// </param>
		/// <returns>
		/// A System.Windows.Forms.DialogResult which reflects the button which
		/// the user clicked in response to the MessageBox.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// The supplied control is null.
		/// </exception>
		public static DialogResult Show( string message, 
		                                 string caption, 
		                                 Control control )
		{
			return CleverMessageBox.Show( message, 
			                             caption, 
			                             MessageBoxButtons.OK, 
			                             control );
		}
		#endregion
		
		#region Show( string, string, MessageBoxButtons, Control ) method
		/// <summary>
		/// Shows the CleverMessageBox to the user.
		/// Determines the icon to be shown on the CleverMessageBox based on the
		/// MessageBoxButtons to be shown.
		/// Sets the MessageBoxDefaultButton to the first button on the 
		/// CleverMessageBox.
		/// </summary>
		/// <param name="message">
		/// The message to display in the CleverMessageBox.
		/// </param>
		/// <param name="caption">
		/// The caption to display in the title bar of the CleverMessageBox
		/// </param>
		/// <param name="buttons">
		/// A <see cref="System.Windows.Forms.MessageBoxButtons" /> value 
		/// indicating what buttons should be shown on the CleverMessageBox
		/// </param>
		/// <param name="control">
		/// The control from which this method is being called.
		/// </param>
		/// <returns>
		/// A System.Windows.Forms.DialogResult which reflects the button which
		/// the user clicked in response to the MessageBox.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// The supplied control is null.
		/// </exception>
		public static DialogResult Show( string message,
		                                 string caption,
		                                 MessageBoxButtons buttons,
		                                 Control control )
		{
			return CleverMessageBox.Show( message, 
			                             caption, 
			                             buttons, 
			                             MessageBoxIcon.None,
			                             control );
		}
		#endregion
		
		#region Show( string, string, MessageBoxButtons, MessageBoxIcon, Control ) method
		/// <summary>
		/// Shows the CleverMessageBox to the user.
		/// Sets the MessageBoxDefaultButton to the first button on the 
		/// CleverMessageBox.
		/// </summary>
		/// <param name="message">
		/// The message to display in the CleverMessageBox.
		/// </param>
		/// <param name="caption">
		/// The caption to display in the title bar of the CleverMessageBox
		/// </param>
		/// <param name="buttons">
		/// A <see cref="System.Windows.Forms.MessageBoxButtons" /> value 
		/// indicating what buttons should be shown on the CleverMessageBox
		/// </param>
		/// <param name="icon">
		/// A <see cref="System.Windows.Forms.MessageBoxIcon" /> value 
		/// indicating what icon should be shown in the CleverMessageBox.
		/// </param>
		/// <param name="control">
		/// The control from which this method is being called.
		/// </param>
		/// <returns>
		/// A System.Windows.Forms.DialogResult which reflects the button which
		/// the user clicked in response to the MessageBox.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// The supplied control is null.
		/// </exception>
		public static DialogResult Show( string message,
		                                 string caption,
		                                 MessageBoxButtons buttons,
		                                 MessageBoxIcon icon,
		                                 Control control )
		{
			return CleverMessageBox.Show( message, 
			                             caption, 
			                             buttons, 
			                             icon, 
			                             MessageBoxDefaultButton.Button1, 
			                             control );
		}
		#endregion
		
		#region Show( string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton, Control ) method
		/// <summary>
		/// Shows the CleverMessageBox to the user.
		/// </summary>
		/// <param name="message">
		/// The message to display in the CleverMessageBox.
		/// </param>
		/// <param name="caption">
		/// The caption to display in the title bar of the CleverMessageBox
		/// </param>
		/// <param name="buttons">
		/// A <see cref="System.Windows.Forms.MessageBoxButtons" /> value 
		/// indicating what buttons should be shown on the CleverMessageBox
		/// </param>
		/// <param name="icon">
		/// A <see cref="System.Windows.Forms.MessageBoxIcon" /> value 
		/// indicating what icon should be shown in the CleverMessageBox.
		/// </param>
		/// <param name="defaultButton">
		/// A <see cref="System.Windows.Forms.MessageBoxDefaultButton" /> value 
		/// indicating which button is selected by default.
		/// </param>
		/// <param name="control">
		/// The control from which this method is being called.
		/// </param>
		/// <returns>
		/// A <see cref="System.Windows.Forms.DialogResult" /> which reflects 
		/// the button which the user clicked in response to the CleverMessageBox.
		/// </returns>
		public static DialogResult Show( string message,
		                                 string caption,
		                                 MessageBoxButtons buttons,
		                                 MessageBoxIcon icon,
		                                 MessageBoxDefaultButton defaultButton,
		                                 Control control )
		{
			RightToLeft rightToLeftValue;
			MessageBoxOptions options = (MessageBoxOptions)0;
			if( control == null )
			{
				throw new ArgumentNullException( "control" );
			}

			rightToLeftValue = control.RightToLeft;
			
			if( rightToLeftValue == RightToLeft.Yes )
			{
				options = MessageBoxOptions.RtlReading 
					| MessageBoxOptions.RightAlign;
			}

			return MessageBox.Show( message, 
			                       caption, 
			                       buttons, 
			                       icon, 
			                       defaultButton, 
			                       options );
		}
		#endregion

	}
}
