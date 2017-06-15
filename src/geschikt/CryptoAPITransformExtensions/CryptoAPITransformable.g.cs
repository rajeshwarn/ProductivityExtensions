#if (NET4_0 || NET4_5)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Security.Cryptography;

namespace PRI.ProductivityExtensions.CryptoAPITransformExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Security.Cryptography.CryptoAPITransform">CryptoAPITransform</seealso>
	/// </summary>
	public static partial class CryptoAPITransformable
	{
		/// <summary>
		/// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// cryptoapitransform.TransformBlock(inputBuffer, outputBuffer, outputOffset);
		/// </example>
		/// </summary>
		public static Int32 TransformBlock(this CryptoAPITransform cryptoapitransform, Byte[] inputBuffer, Byte[] outputBuffer, Int32 outputOffset)
		{
			if(cryptoapitransform == null) throw new ArgumentNullException("cryptoapitransform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return cryptoapitransform.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
		}

		/// <summary>
		/// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// cryptoapitransform.TransformFinalBlock(inputBuffer);
		/// </example>
		/// </summary>
		public static Byte[] TransformFinalBlock(this CryptoAPITransform cryptoapitransform, Byte[] inputBuffer)
		{
			if(cryptoapitransform == null) throw new ArgumentNullException("cryptoapitransform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return cryptoapitransform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
		}

	}
}
#endif