//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Microsoft.Win32;

namespace PRI.ProductivityExtensions.PowerModeChangedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="Microsoft.Win32.PowerModeChangedEventHandler">PowerModeChangedEventHandler</seealso>
	/// </summary>
	public static partial class PowerModeChangedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// powermodechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PowerModeChangedEventHandler powermodechangedeventhandler, Object sender, PowerModeChangedEventArgs e, AsyncCallback callback)
		{
			if(powermodechangedeventhandler == null) throw new ArgumentNullException("powermodechangedeventhandler");

			return powermodechangedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}