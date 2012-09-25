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

namespace PRI.ProductivityExtensions.SplitterEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.SplitterEventHandler">SplitterEventHandler</seealso>
	/// </summary>
	public static partial class SplitterEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// splittereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SplitterEventHandler splittereventhandler, Object sender, SplitterEventArgs e, AsyncCallback callback)
		{
			if(splittereventhandler == null) throw new ArgumentNullException("splittereventhandler");

			return splittereventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}