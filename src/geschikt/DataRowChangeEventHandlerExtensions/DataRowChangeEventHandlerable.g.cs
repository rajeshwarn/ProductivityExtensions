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

namespace PRI.ProductivityExtensions.DataRowChangeEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Data.DataRowChangeEventHandler">DataRowChangeEventHandler</seealso>
	/// </summary>
	public static partial class DataRowChangeEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datarowchangeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataRowChangeEventHandler datarowchangeeventhandler, Object sender, DataRowChangeEventArgs e, AsyncCallback callback)
		{
			if(datarowchangeeventhandler == null) throw new ArgumentNullException("datarowchangeeventhandler");

			return datarowchangeeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}