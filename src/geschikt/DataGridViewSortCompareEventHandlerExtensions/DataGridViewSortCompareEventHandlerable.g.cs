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

namespace PRI.ProductivityExtensions.DataGridViewSortCompareEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DataGridViewSortCompareEventHandler">DataGridViewSortCompareEventHandler</seealso>
	/// </summary>
	public static partial class DataGridViewSortCompareEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datagridviewsortcompareeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewSortCompareEventHandler datagridviewsortcompareeventhandler, Object sender, DataGridViewSortCompareEventArgs e, AsyncCallback callback)
		{
			if(datagridviewsortcompareeventhandler == null) throw new ArgumentNullException("datagridviewsortcompareeventhandler");

			return datagridviewsortcompareeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}