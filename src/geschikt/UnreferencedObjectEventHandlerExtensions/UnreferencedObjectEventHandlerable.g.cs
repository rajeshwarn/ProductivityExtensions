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
using System.Xml.Serialization;

namespace PRI.ProductivityExtensions.UnreferencedObjectEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.Serialization.UnreferencedObjectEventHandler">UnreferencedObjectEventHandler</seealso>
	/// </summary>
	public static partial class UnreferencedObjectEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// unreferencedobjecteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UnreferencedObjectEventHandler unreferencedobjecteventhandler, Object sender, UnreferencedObjectEventArgs e, AsyncCallback callback)
		{
			if(unreferencedobjecteventhandler == null) throw new ArgumentNullException("unreferencedobjecteventhandler");

			return unreferencedobjecteventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif