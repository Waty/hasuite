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
using System.ComponentModel;
using System.Reflection;
using System.Xml.Serialization;

namespace CommonForms.Responsiveness
{
	/// <summary>
	/// Base class for a long-running process which facilitates reporting of
	/// it's progress via classes such as <see cref="ProgressCounter"/> and
	/// <see cref="ResponsiveForm"/>
	/// TODO: rename to LongRunningProcessObject (after checking in changes)
	/// TODO: method for starting process in the background?
	/// </summary>
	public abstract class LongRunningProcessObject 
		: XmlSerializableItem<LongRunningProcessObject>
	{
		private ProgressCounterDictionary _myCounters;
		private Collection<LongRunningProcessObject> _subProcesses;
		
		#region protected constructor
		/// <summary>
		/// Constructor.
		/// </summary>
		protected LongRunningProcessObject()
		{
			_myCounters = new ProgressCounterDictionary();
			_subProcesses = new Collection<LongRunningProcessObject>();
		}
		#endregion
		
		#region AddCounter method
		/// <summary>
		/// Adds a counter with the supplied name to the collection of progress
		/// counters.
		/// </summary>
		/// <param name="counterName">
		/// The name and display narrative of the counter to add.
		/// </param>
		/// <param name="maximum">
		/// The maximum value for the new counter
		/// </param>
		public void AddCounter( string counterName, int maximum )
		{
			_myCounters.Add( counterName, maximum );
		}
		#endregion
		
		#region RemoveCounter method
		/// <summary>
		/// Removes the counter with the supplied name from the collection of
		/// progress counters.
		/// </summary>
		/// <param name="counterName">
		/// The name of the counter to remove.
		/// </param>
		public void RemoveCounter( string counterName )
		{
			_myCounters.Remove( counterName );
		}
		#endregion
		
		#region MyProgressCounters property
		/// <summary>
		/// Gets the progress counters for just this process, and not those of
		/// any sub processes.
		/// </summary>
		[Browsable( false )]
		[XmlIgnore] // don't serialize this property
		public ProgressCounterDictionary MyProgressCounters
		{
			get { return _myCounters; }
		}
		#endregion
		
		#region AllProgressCounters property
		/// <summary>
		/// Gets the progress counters for this process and all sub processes.
		/// </summary>
		[Browsable( false )]
		[XmlIgnore] // don't serialize this property
		public ProgressCounterDictionary AllProgressCounters
		{
			get
			{
				// Get a copy of this process' counters
				ProgressCounterDictionary counters = new ProgressCounterDictionary();
				counters.AddRange( _myCounters );
				
				// Get the counters from any sub processes
				PropertyInfo[] properties = this.GetType().GetProperties();
				foreach( PropertyInfo property in properties )
				{
					if( property.PropertyType.IsSubclassOf( typeof( LongRunningProcessObject ) ) )
					{
						// then it's a LongRunningProcess so get its counters
						LongRunningProcessObject subProcess 
							= (LongRunningProcessObject) property.GetValue( this, null );
						if( subProcess != null )
						{
							counters.AddRange( subProcess.AllProgressCounters );
						}
					}
				}
				
				return counters;
			}
		}
		#endregion
		
	}
}
