#if (NETSTANDARD2_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Security.Authentication.ExtendedProtection;

namespace PRI.ProductivityExtensions.ExtendedProtectionPolicyTypeConverterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicyTypeConverter">ExtendedProtectionPolicyTypeConverter</seealso>
	/// </summary>
	public static partial class ExtendedProtectionPolicyTypeConverterable
	{
		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ExtendedProtectionPolicyTypeConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// extendedprotectionpolicytypeconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ExtendedProtectionPolicyTypeConverter extendedprotectionpolicytypeconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(extendedprotectionpolicytypeconverter == null) throw new ArgumentNullException("extendedprotectionpolicytypeconverter");

			return (T)extendedprotectionpolicytypeconverter.ConvertTo(context, culture, value, typeof(T));
		}

	}
}
#endif