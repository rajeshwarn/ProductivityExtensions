#if (NETSTANDARD2_0 || NET4_0 || NET4_5)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;

namespace PRI.ProductivityExtensions.RefreshEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.ComponentModel.RefreshEventHandler">RefreshEventHandler</seealso>
	/// </summary>
	public static partial class RefreshEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// refresheventhandler.BeginInvoke(e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this RefreshEventHandler refresheventhandler, RefreshEventArgs e, AsyncCallback callback)
		{
			if(refresheventhandler == null) throw new ArgumentNullException("refresheventhandler");

			return refresheventhandler.BeginInvoke(e, callback, null);
		}

	}
}
#endif