//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace PRI.ProductivityExtensions.DataGridViewRowErrorTextNeededEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DataGridViewRowErrorTextNeededEventHandler">DataGridViewRowErrorTextNeededEventHandler</seealso>
	/// </summary>
	public static partial class DataGridViewRowErrorTextNeededEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datagridviewrowerrortextneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowErrorTextNeededEventHandler datagridviewrowerrortextneededeventhandler, Object sender, DataGridViewRowErrorTextNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowerrortextneededeventhandler == null) throw new ArgumentNullException("datagridviewrowerrortextneededeventhandler");

			return datagridviewrowerrortextneededeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}