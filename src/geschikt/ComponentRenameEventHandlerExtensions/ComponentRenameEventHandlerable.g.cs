//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;

namespace PRI.ProductivityExtensions.ComponentRenameEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.ComponentModel.Design.ComponentRenameEventHandler">ComponentRenameEventHandler</seealso>
	/// </summary>
	public static partial class ComponentRenameEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// componentrenameeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ComponentRenameEventHandler componentrenameeventhandler, Object sender, ComponentRenameEventArgs e, AsyncCallback callback)
		{
			if(componentrenameeventhandler == null) throw new ArgumentNullException("componentrenameeventhandler");

			return componentrenameeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}