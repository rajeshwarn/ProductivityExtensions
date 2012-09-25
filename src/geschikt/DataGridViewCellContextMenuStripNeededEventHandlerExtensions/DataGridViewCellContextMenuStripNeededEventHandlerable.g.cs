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

namespace PRI.ProductivityExtensions.DataGridViewCellContextMenuStripNeededEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler">DataGridViewCellContextMenuStripNeededEventHandler</seealso>
	/// </summary>
	public static partial class DataGridViewCellContextMenuStripNeededEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datagridviewcellcontextmenustripneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellContextMenuStripNeededEventHandler datagridviewcellcontextmenustripneededeventhandler, Object sender, DataGridViewCellContextMenuStripNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellcontextmenustripneededeventhandler == null) throw new ArgumentNullException("datagridviewcellcontextmenustripneededeventhandler");

			return datagridviewcellcontextmenustripneededeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}