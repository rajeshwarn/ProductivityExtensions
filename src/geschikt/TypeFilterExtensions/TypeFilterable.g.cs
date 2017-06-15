#if (NETSTANDARD1_5 || NETSTANDARD1_6 || NETSTANDARD2_0 || NET4_0 || NET4_5)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;

namespace PRI.ProductivityExtensions.TypeFilterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Reflection.TypeFilter">TypeFilter</seealso>
	/// </summary>
	public static partial class TypeFilterable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// typefilter.BeginInvoke(m, filterCriteria, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TypeFilter typefilter, Type m, Object filterCriteria, AsyncCallback callback)
		{
			if(typefilter == null) throw new ArgumentNullException("typefilter");

			return typefilter.BeginInvoke(m, filterCriteria, callback, null);
		}

	}
}
#endif