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

namespace PRI.ProductivityExtensions.XmlWriterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.XmlWriter">XmlWriter</seealso>
	/// </summary>
	public static partial class XmlWriterable
	{
		/// <summary>
		/// Extends WriteChars so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlwriter.WriteChars(buffer);
		/// </example>
		/// </summary>
		public static void WriteChars(this XmlWriter xmlwriter, Char[] buffer)
		{
			if(xmlwriter == null) throw new ArgumentNullException("xmlwriter");

			if(buffer == null) throw new ArgumentNullException("buffer");

			xmlwriter.WriteChars(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends WriteRaw so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlwriter.WriteRaw(buffer);
		/// </example>
		/// </summary>
		public static void WriteRaw(this XmlWriter xmlwriter, Char[] buffer)
		{
			if(xmlwriter == null) throw new ArgumentNullException("xmlwriter");

			if(buffer == null) throw new ArgumentNullException("buffer");

			xmlwriter.WriteRaw(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends WriteBase64 so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlwriter.WriteBase64(buffer);
		/// </example>
		/// </summary>
		public static void WriteBase64(this XmlWriter xmlwriter, Byte[] buffer)
		{
			if(xmlwriter == null) throw new ArgumentNullException("xmlwriter");

			if(buffer == null) throw new ArgumentNullException("buffer");

			xmlwriter.WriteBase64(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends WriteBinHex so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlwriter.WriteBinHex(buffer);
		/// </example>
		/// </summary>
		public static void WriteBinHex(this XmlWriter xmlwriter, Byte[] buffer)
		{
			if(xmlwriter == null) throw new ArgumentNullException("xmlwriter");

			if(buffer == null) throw new ArgumentNullException("buffer");

			xmlwriter.WriteBinHex(buffer, 0, buffer.Length);
		}

	}
}
#endif