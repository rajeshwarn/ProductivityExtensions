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
using System.Net;

namespace PRI.ProductivityExtensions.OpenWriteCompletedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Net.OpenWriteCompletedEventHandler">OpenWriteCompletedEventHandler</seealso>
	/// </summary>
	public static partial class OpenWriteCompletedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// openwritecompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this OpenWriteCompletedEventHandler openwritecompletedeventhandler, Object sender, OpenWriteCompletedEventArgs e, AsyncCallback callback)
		{
			if(openwritecompletedeventhandler == null) throw new ArgumentNullException("openwritecompletedeventhandler");

			return openwritecompletedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif