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

namespace PRI.ProductivityExtensions.TimerCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Threading.TimerCallback">TimerCallback</seealso>
	/// </summary>
	public static partial class TimerCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// timercallback.BeginInvoke(state, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TimerCallback timercallback, Object state, AsyncCallback callback)
		{
			if(timercallback == null) throw new ArgumentNullException("timercallback");

			return timercallback.BeginInvoke(state, callback, null);
		}

	}
}