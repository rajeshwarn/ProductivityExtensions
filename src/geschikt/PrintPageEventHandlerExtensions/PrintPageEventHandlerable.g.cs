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
using System.Drawing.Printing;

namespace PRI.ProductivityExtensions.PrintPageEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Drawing.Printing.PrintPageEventHandler">PrintPageEventHandler</seealso>
	/// </summary>
	public static partial class PrintPageEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// printpageeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PrintPageEventHandler printpageeventhandler, Object sender, PrintPageEventArgs e, AsyncCallback callback)
		{
			if(printpageeventhandler == null) throw new ArgumentNullException("printpageeventhandler");

			return printpageeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif