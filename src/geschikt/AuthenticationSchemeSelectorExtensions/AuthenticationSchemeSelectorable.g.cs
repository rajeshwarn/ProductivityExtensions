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

namespace PRI.ProductivityExtensions.AuthenticationSchemeSelectorExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Net.AuthenticationSchemeSelector">AuthenticationSchemeSelector</seealso>
	/// </summary>
	public static partial class AuthenticationSchemeSelectorable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// authenticationschemeselector.BeginInvoke(httpRequest, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this AuthenticationSchemeSelector authenticationschemeselector, HttpListenerRequest httpRequest, AsyncCallback callback)
		{
			if(authenticationschemeselector == null) throw new ArgumentNullException("authenticationschemeselector");

			return authenticationschemeselector.BeginInvoke(httpRequest, callback, null);
		}

	}
}
#endif