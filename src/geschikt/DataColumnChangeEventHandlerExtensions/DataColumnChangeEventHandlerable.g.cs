//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data;

namespace PRI.ProductivityExtensions.DataColumnChangeEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Data.DataColumnChangeEventHandler">DataColumnChangeEventHandler</seealso>
	/// </summary>
	public static partial class DataColumnChangeEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datacolumnchangeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataColumnChangeEventHandler datacolumnchangeeventhandler, Object sender, DataColumnChangeEventArgs e, AsyncCallback callback)
		{
			if(datacolumnchangeeventhandler == null) throw new ArgumentNullException("datacolumnchangeeventhandler");

			return datacolumnchangeeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}