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
using System.Xml;

namespace PRI.ProductivityExtensions.XmlResolverExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.XmlResolver">XmlResolver</seealso>
	/// </summary>
	public static partial class XmlResolverable
	{
		/// <summary>
		/// Extends GetEntity so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// xmlresolver.GetEntity&lt;int&gt;(absoluteUri, role);
		/// </example>
		/// </summary>
		public static T GetEntity<T>(this XmlResolver xmlresolver, Uri absoluteUri, String role)
		{
			if(xmlresolver == null) throw new ArgumentNullException("xmlresolver");

			return (T)xmlresolver.GetEntity(absoluteUri, role, typeof(T));
		}

	}
}
#endif