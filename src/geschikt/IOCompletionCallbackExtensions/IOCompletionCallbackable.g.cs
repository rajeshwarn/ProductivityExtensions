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
using System.Threading;

namespace PRI.ProductivityExtensions.IOCompletionCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Threading.IOCompletionCallback">IOCompletionCallback</seealso>
	/// </summary>
	public static partial class IOCompletionCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// iocompletioncallback.BeginInvoke(errorCode, numBytes, pOVERLAP, callback);
		/// </example>
		/// </summary>
		public unsafe static IAsyncResult BeginInvoke(this IOCompletionCallback iocompletioncallback, UInt32 errorCode, UInt32 numBytes, NativeOverlapped* pOVERLAP, AsyncCallback callback)
		{
			if(iocompletioncallback == null) throw new ArgumentNullException("iocompletioncallback");

			return iocompletioncallback.BeginInvoke(errorCode, numBytes, pOVERLAP, callback, null);
		}

	}
}
#endif