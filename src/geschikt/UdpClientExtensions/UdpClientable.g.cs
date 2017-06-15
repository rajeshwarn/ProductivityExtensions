#if (NET4_5 || NET4_0)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Net.Sockets;

namespace PRI.ProductivityExtensions.UdpClientExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Net.Sockets.UdpClient">UdpClient</seealso>
	/// </summary>
	public static partial class UdpClientable
	{
		/// <summary>
		/// Extends BeginSend so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpclient.BeginSend(datagram, bytes, endPoint, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSend(this UdpClient udpclient, Byte[] datagram, Int32 bytes, System.Net.IPEndPoint endPoint, AsyncCallback requestCallback)
		{
			if(udpclient == null) throw new ArgumentNullException("udpclient");

			return udpclient.BeginSend(datagram, bytes, endPoint, requestCallback, null);
		}

		/// <summary>
		/// Extends BeginSend so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpclient.BeginSend(datagram, bytes, hostname, port, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSend(this UdpClient udpclient, Byte[] datagram, Int32 bytes, String hostname, Int32 port, AsyncCallback requestCallback)
		{
			if(udpclient == null) throw new ArgumentNullException("udpclient");

			return udpclient.BeginSend(datagram, bytes, hostname, port, requestCallback, null);
		}

		/// <summary>
		/// Extends BeginSend so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpclient.BeginSend(datagram, bytes, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSend(this UdpClient udpclient, Byte[] datagram, Int32 bytes, AsyncCallback requestCallback)
		{
			if(udpclient == null) throw new ArgumentNullException("udpclient");

			return udpclient.BeginSend(datagram, bytes, requestCallback, null);
		}

		/// <summary>
		/// Extends BeginReceive so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpclient.BeginReceive(requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginReceive(this UdpClient udpclient, AsyncCallback requestCallback)
		{
			if(udpclient == null) throw new ArgumentNullException("udpclient");

			return udpclient.BeginReceive(requestCallback, null);
		}

	}
}
#endif
