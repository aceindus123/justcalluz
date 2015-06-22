#region Source Control Header


//////////////////////////////////////////////////////////////////////////////
///<remarks>
/// Convert data from any type (early or late-bound).
///</remarks>
//////////////////////////////////////////////////////////////////////////////
#endregion


using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System;

namespace IndusAbroad.safeConvert
{
	/// <summary> 
	/// Convert data from any type (early or late-bound).
	/// </summary> 
	public sealed class SafeConvert
	{
		//
		// constructors
		//
		/// <summary>
		/// construction is not allowed
		/// </summary>
		private SafeConvert()
		{
		}

		//
		// member functions
		//
		/// <summary>
		/// Converts to Byte datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultByte"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>Byte value</returns>
		public static Byte ToByte(Object inputValue)
		{
			return ToByte(inputValue, SafeConvert.DefaultByte);
		}

		/// <summary>
		/// Converts to Byte datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>Byte value</returns>
		public static Byte ToByte(Object inputValue, Byte defaultValue)
		{
			try
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToByte(inputValue);
			}
			catch
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to Int16 datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultInt16"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>Int16 value</returns>
		public static Int16 ToInt16(Object inputValue)
		{
			return ToInt16(inputValue, SafeConvert.DefaultInt16);
		}

		/// <summary>
		/// Converts to Int16 datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>Int16 value</returns>
		public static Int16 ToInt16(Object inputValue, Int16 defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToInt16(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to Int32 datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultInt32"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>Int32 value</returns>
		public static Int32 ToInt32(Object inputValue)
		{
			return ToInt32(inputValue, SafeConvert.DefaultInt32);
		}

		/// <summary>
		/// Converts to Int32 datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>Int32 value</returns>
		public static Int32 ToInt32(Object inputValue, Int32 defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToInt32(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to Int64 datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultInt64"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>Int64 value</returns>
		public static Int64 ToInt64(Object inputValue)
		{
			return ToInt64(inputValue, SafeConvert.DefaultInt64);
		}


		/// <summary>
		/// Converts to Int64 datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>Int64 value</returns>
		public static Int64 ToInt64(Object inputValue, Int64 defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToInt64(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to unsigned UInt16 datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultUInt16"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>UInt16 value</returns>
		public static UInt16 ToUInt16(Object inputValue)
		{
			return ToUInt16(inputValue, SafeConvert.DefaultUInt16);
		}

		/// <summary>
		/// Converts to unsigned UInt16 datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>UInt16 value</returns>
		public static UInt16 ToUInt16(Object inputValue, UInt16 defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToUInt16(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to unsigned UInt32 datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultUInt32"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>UInt32 value</returns>
		public static UInt32 ToUInt32(Object inputValue)
		{
			return ToUInt32(inputValue, SafeConvert.DefaultUInt32);
		}

		/// <summary>
		/// Converts to unsigned UInt32 datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>UInt32 value</returns>
		public static UInt32 ToUInt32(Object inputValue, UInt32 defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToUInt32(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to unsigned UInt64 datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultUInt64"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>UInt64 value</returns>
		public static UInt64 ToUInt64(Object inputValue)
		{
			return ToUInt64(inputValue, SafeConvert.DefaultUInt64);
		}


		/// <summary>
		/// Converts to Int64 datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>UInt64 value</returns>
		public static UInt64 ToUInt64(Object inputValue, UInt64 defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToUInt64(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to Decimal datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultDecimal"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>Decimal value</returns>
		public static Decimal ToDecimal(Object inputValue)
		{
			return ToDecimal(inputValue, SafeConvert.DefaultDecimal);
		}


		/// <summary>
		/// Converts to Decimal datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>Decimal value</returns>
		public static Decimal ToDecimal(Object inputValue, Decimal defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToDecimal(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to Double datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultDouble"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>Double value</returns>
		public static Double ToDouble(Object inputValue)
		{
			return ToDouble(inputValue, SafeConvert.DefaultDouble);
		}


		/// <summary>
		/// Converts to Decimal datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>Double value</returns>
		public static Double ToDouble(Object inputValue, Double defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToDouble(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to Single datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultSingle"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>Single value</returns>
		public static Single ToSingle(Object inputValue)
		{
			return ToSingle(inputValue, SafeConvert.DefaultSingle);
		}


		/// <summary>
		/// Converts to Single datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>Single value</returns>
		public static Single ToSingle(Object inputValue, Single defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return Convert.ToSingle(inputValue);
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to boolean datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="EMC.OMEGA.Framework.Core.SafeConvert.DefaultBoolean"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>Boolean value</returns>
		public static Boolean ToBoolean(Object inputValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return SafeConvert.DefaultBoolean;
				
				return Boolean.Parse(inputValue.ToString());
			}
			catch 
			{
				if (inputValue.ToString().Equals(
					true))
					return true;

				return SafeConvert.DefaultBoolean;
			}
		}


		/// <summary>
		/// Converts to String datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="String.Empty"/> if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>String value</returns>
		public static String ToString(Object inputValue)
		{
			return ToString(inputValue, String.Empty);
		}

		/// <summary>
		/// Converts to String datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>String value</returns>
		public static String ToString(Object inputValue, String defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return inputValue.ToString();
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Converts to DateTime datatype from an arbitrary Object.
		/// </summary>
		/// <remarks>Returns <see cref="System.DateTime.MinValue"/>
		/// if conversion fails.</remarks>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <returns>DateTime value</returns>
		public static DateTime ToDateTime(Object inputValue)
		{
			return ToDateTime(inputValue, DateTime.MinValue);
		}

		/// <summary>
		/// Converts to DateTime datatype from an arbitrary Object.
		/// </summary>
		/// <param name="inputValue">An arbitrary Object</param>
		/// <param name="defaultValue">inputValue to be returned if conversion fails or is null.</param>
		/// <returns>DateTime value</returns>
		public static DateTime ToDateTime(Object inputValue, DateTime defaultValue)
		{
			try 
			{
				// rule: if input is "null" save exception processing, return default
				if ((DBNull.Value == inputValue) || (null == inputValue))
					return defaultValue;
				
				return DateTime.Parse(inputValue.ToString());
			}
			catch 
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// default <see cref="System.DateTime"/>
		/// </summary>
		public static DateTime DefaultDateTime
		{
			get
			{
				return SafeConvert.defaultDateTime;
			}
		}

		/// <summary>
		/// safely parse enum identifier to instance
		/// </summary>
		/// <param name="enumType">enum type</param>
		/// <param name="identifier">identifier</param>
		/// <param name="defaultValue">default value</param>
		/// <returns>enum value</returns>
		public static Object ToEnum(Type enumType, String identifier,
			Object defaultValue)
		{
			// rule: if identifier is null then return default
			if (null == identifier)
				return defaultValue;
			// safely parse
			try
			{
				return Enum.Parse(enumType, identifier);
			}
			catch
			{
				return defaultValue;
			}
		}

		//
		// constant data
		//
		/// <summary>
		/// default <see cref="System.Byte"/>
		/// </summary>
		public const Byte DefaultByte = 0;
		/// <summary>
		/// default <see cref="System.Int16"/>
		/// </summary>
		public const Int16 DefaultInt16 = -1;
		/// <summary>
		/// default <see cref="System.Int32"/>
		/// </summary>
		public const Int32 DefaultInt32 = -1;
		/// <summary>
		/// default <see cref="System.Int64"/>
		/// </summary>
		public const Int64 DefaultInt64 = -1;
		/// <summary>
		/// default <see cref="System.UInt16"/>
		/// </summary>
		public const UInt16 DefaultUInt16 = 0;
		/// <summary>
		/// default <see cref="System.UInt32"/>
		/// </summary>
		public const UInt32 DefaultUInt32 = 0;
		/// <summary>
		/// default <see cref="System.UInt64"/>
		/// </summary>
		public const UInt64 DefaultUInt64 = 0;
		/// <summary>
		/// default <see cref="System.Decimal"/>
		/// </summary>
		public const Decimal DefaultDecimal = 0;
		/// <summary>
		/// default <see cref="System.Double"/>
		/// </summary>
		public const Double DefaultDouble = 0;
		/// <summary>
		/// default <see cref="System.Single"/>
		/// </summary>
		public const Single DefaultSingle = 0;
		/// <summary>
		/// default <see cref="System.Boolean"/>
		/// </summary>
		public const Boolean DefaultBoolean = false;

		//
		// member data
		//
		private static readonly DateTime defaultDateTime = DateTime.MinValue;
	} 
}
