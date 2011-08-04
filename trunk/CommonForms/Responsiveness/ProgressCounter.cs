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

namespace CommonForms.Responsiveness
{
	/// <summary>
	/// Represents the progress of one aspect of a long-running process.
	/// </summary>
	public class ProgressCounter
	{
		#region declarations
		private string _narrative;
		private int _maximum;
		private int _value;
		#endregion
		
		#region constructor
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="narrative">
		/// Text to display beside the ProgressBar, before the [value] of 
		/// [maximum] text.
		/// </param>
		/// <param name="maximum">
		/// The maximum value for this progress counter.
		/// You can change this later by setting the Maximum property.
		/// </param>
		public ProgressCounter( string narrative, int maximum )
		{
			_narrative = narrative;
			_maximum = maximum;
		}
		#endregion
		
		#region Narrative property
		/// <summary>
		/// Gets and sets the text to display for this counter, between the
		/// ProgressBar and the [value] of [maximum] text.
		/// </summary>
		public string Narrative
		{
			get { return _narrative; }
			set { _narrative = value; }
		}
		#endregion

		#region Maximum property
		/// <summary>
		/// Gets and sets the maximum value for this ProgressCounter.
		/// </summary>
		public int Maximum
		{
			get { return _maximum; }
			set
			{ 
				lock( this )
				{
					_maximum = value; 
				}
			}
		}
		#endregion
		
		#region Value property
		/// <summary>
		/// Gets and sets the current value of this ProgressCounter.
		/// </summary>
		public int Value
		{
			get { return _value; }
			set 
			{ 
				lock( this )
				{
					if( value > _maximum )
					{
						string message
							= "Value of "
							+ value
							+ " is not valid for the progress counter '"
							+ _narrative
							+ "'. The value must be between 0 and "
							+ _maximum;
						throw new ArgumentOutOfRangeException( "value", message );
					}
					_value = value; 
				}
			}
		}
		#endregion
		
		#region override ToString method
		/// <summary>
		/// Gets a string version of the progress counter's value and maximum.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return _narrative + " " + _value + " of " + _maximum;
		}
		#endregion
	}
}
