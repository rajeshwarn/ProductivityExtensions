#if (NET4O || NET45 || NET451 || NET452 || NET46 || NET461 || NET462)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace PRI.ProductivityExtensions.PropertyTabChangedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.PropertyTabChangedEventHandler">PropertyTabChangedEventHandler</seealso>
	/// </summary>
	public static partial class PropertyTabChangedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// propertytabchangedeventhandler.BeginInvoke(s, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PropertyTabChangedEventHandler propertytabchangedeventhandler, Object s, PropertyTabChangedEventArgs e, AsyncCallback callback)
		{
			if(propertytabchangedeventhandler == null) throw new ArgumentNullException("propertytabchangedeventhandler");

			return propertytabchangedeventhandler.BeginInvoke(s, e, callback, null);
		}

	}
}
#endif