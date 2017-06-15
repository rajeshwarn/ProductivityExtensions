#if (NET4_0 || NET4_5)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.IO.Ports;

namespace PRI.ProductivityExtensions.SerialErrorReceivedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.IO.Ports.SerialErrorReceivedEventHandler">SerialErrorReceivedEventHandler</seealso>
	/// </summary>
	public static partial class SerialErrorReceivedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// serialerrorreceivedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SerialErrorReceivedEventHandler serialerrorreceivedeventhandler, Object sender, SerialErrorReceivedEventArgs e, AsyncCallback callback)
		{
			if(serialerrorreceivedeventhandler == null) throw new ArgumentNullException("serialerrorreceivedeventhandler");

			return serialerrorreceivedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif