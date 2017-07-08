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
using System.IO;

namespace PRI.ProductivityExtensions.UnmanagedMemoryAccessorExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.IO.UnmanagedMemoryAccessor">UnmanagedMemoryAccessor</seealso>
	/// </summary>
	public static partial class UnmanagedMemoryAccessorable
	{
		/// <summary>
		/// Extends ReadArray&lt;T&gt; so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// unmanagedmemoryaccessor.ReadArray&lt;T&gt;(position, array);
		/// </example>
		/// </summary>
		public static Int32 ReadArray<T>(this UnmanagedMemoryAccessor unmanagedmemoryaccessor, Int64 position, T[] array) where T : struct
		{
			if(unmanagedmemoryaccessor == null) throw new ArgumentNullException("unmanagedmemoryaccessor");

			if(array == null) throw new ArgumentNullException("array");

			return unmanagedmemoryaccessor.ReadArray(position, array, 0, array.Length);
		}

		/// <summary>
		/// Extends WriteArray&lt;T&gt; so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// unmanagedmemoryaccessor.WriteArray&lt;T&gt;(position, array);
		/// </example>
		/// </summary>
		public static void WriteArray<T>(this UnmanagedMemoryAccessor unmanagedmemoryaccessor, Int64 position, T[] array) where T : struct
		{
			if(unmanagedmemoryaccessor == null) throw new ArgumentNullException("unmanagedmemoryaccessor");

			if(array == null) throw new ArgumentNullException("array");

			unmanagedmemoryaccessor.WriteArray(position, array, 0, array.Length);
		}

	}
}
#endif