#if (NETSTANDARD2_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
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

namespace PRI.ProductivityExtensions.UploadFileCompletedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Net.UploadFileCompletedEventHandler">UploadFileCompletedEventHandler</seealso>
	/// </summary>
	public static partial class UploadFileCompletedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// uploadfilecompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UploadFileCompletedEventHandler uploadfilecompletedeventhandler, Object sender, UploadFileCompletedEventArgs e, AsyncCallback callback)
		{
			if(uploadfilecompletedeventhandler == null) throw new ArgumentNullException("uploadfilecompletedeventhandler");

			return uploadfilecompletedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif