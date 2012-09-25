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

namespace PRI.ProductivityExtensions.XmlSerializationFixupCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.Serialization.XmlSerializationFixupCallback">XmlSerializationFixupCallback</seealso>
	/// </summary>
	public static partial class XmlSerializationFixupCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// xmlserializationfixupcallback.BeginInvoke(fixup, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this XmlSerializationFixupCallback xmlserializationfixupcallback, Object fixup, AsyncCallback callback)
		{
			if(xmlserializationfixupcallback == null) throw new ArgumentNullException("xmlserializationfixupcallback");

			return xmlserializationfixupcallback.BeginInvoke(fixup, callback, null);
		}

	}
}