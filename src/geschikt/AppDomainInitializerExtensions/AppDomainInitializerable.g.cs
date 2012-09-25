//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace PRI.ProductivityExtensions.AppDomainInitializerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.AppDomainInitializer">AppDomainInitializer</seealso>
	/// </summary>
	public static partial class AppDomainInitializerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// appdomaininitializer.BeginInvoke(args, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this AppDomainInitializer appdomaininitializer, String[] args, AsyncCallback callback)
		{
			if(appdomaininitializer == null) throw new ArgumentNullException("appdomaininitializer");

			return appdomaininitializer.BeginInvoke(args, callback, null);
		}

	}
}