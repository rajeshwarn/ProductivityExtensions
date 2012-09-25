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

namespace PRI.ProductivityExtensions.ToolStripArrowRenderEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.ToolStripArrowRenderEventHandler">ToolStripArrowRenderEventHandler</seealso>
	/// </summary>
	public static partial class ToolStripArrowRenderEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// toolstriparrowrendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripArrowRenderEventHandler toolstriparrowrendereventhandler, Object sender, ToolStripArrowRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstriparrowrendereventhandler == null) throw new ArgumentNullException("toolstriparrowrendereventhandler");

			return toolstriparrowrendereventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}