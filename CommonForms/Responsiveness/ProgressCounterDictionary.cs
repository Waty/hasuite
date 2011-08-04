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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace CommonForms.Responsiveness
{
	/// <summary>
	/// A collection of <see cref="ProgressCounter"/> instances, representing
	/// the progress of a business object through a long-running process.
	/// </summary>
	[Serializable]
	public class ProgressCounterDictionary : Dictionary<string, ProgressCounter>
	{
		#region public default constructor
		/// <summary>
		/// Constructor.
		/// </summary>
		public ProgressCounterDictionary() : base()
		{
			
		}
		#endregion
		
		#region protected constructor
		/// <summary>
		/// Constructor to comply with CA2229.
		/// </summary>
		/// <param name="info">Serialization info</param>
		/// <param name="context">Context</param>
		protected ProgressCounterDictionary( SerializationInfo info, StreamingContext context )
			: base( info, context )
		{
			
		}
		#endregion
		
		#region internal Add( string ) method
		/// <summary>
		/// Adds a new ProgressCounter with the supplied name to the collection.
		/// </summary>
		/// <param name="counterName">
		/// The name and narrative for the new counter
		/// </param>
		/// <param name="maximum">
		/// The maximum value for the new counter
		/// </param>
		internal void Add( string counterName, int maximum )
		{
			if( ContainsKey( counterName ) )
				ThrowDuplicateKeyException( counterName );
			base.Add( counterName, new ProgressCounter( counterName, maximum ) );
		}
		#endregion

		#region private Add( ProgressCounter) method
		/// <summary>
		/// Adds the supplied counter to the collection.
		/// </summary>
		/// <param name="counter">The counter to add</param>
		private void Add( ProgressCounter counter )
		{
			if( ContainsKey( counter.Narrative ) )
				ThrowDuplicateKeyException( counter.Narrative );
			base.Add( counter.Narrative, counter );
		}
		#endregion
		
		#region AddRange method
		/// <summary>
		/// Adds the progress counters in the supplied collection to the current
		/// collection.
		/// </summary>
		/// <param name="counters">The counters to add to the collection</param>
		internal void AddRange( ProgressCounterDictionary counters )
		{
			foreach( ProgressCounter pc in counters.Values )
			{
				Add( pc );
			}
		}
		#endregion
		
		#region private ThrowDuplicateKeyException method
		private void ThrowDuplicateKeyException( string counterName )
		{
			StringBuilder sb = new StringBuilder();
			sb.Append( "The collection already contains a progress counter " );
			sb.Append( "with the name " );
			sb.Append( counterName + ". " );
			sb.Append( "The collection contains the following counters " );
			sb.Append( Environment.NewLine );
			foreach( string key in Keys )
			{
				sb.Append( key + Environment.NewLine );
			}
			throw new ArgumentException( sb.ToString() );
		}
		#endregion
	}
}
