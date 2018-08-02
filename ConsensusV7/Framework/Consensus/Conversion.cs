using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Consensus
{
    /// <summary>
    ///     The generic extension conversion class provides conversion from a <see cref="T:System.Object" /> to any other required type,
    ///     with the option for falling back to a specified default value where conversion cannot be achieved
    /// </summary>
    public static class Conversion
    {
        #region constants

        /// <summary>
        ///     The method name used to identify custom conversion methods defined in the Conversion class
        /// </summary>
        private const String TRY_PARSE_METHOD = "TryParse";

        /// <summary>
        ///     The delimiters used to separate elements within a flagged enumeration
        /// </summary>
        private static readonly String[] ENUMERATOR_DELIMITERS = { ",", "|" };

        /// <summary>
        ///     The method name used to identify generic conversion methods
        /// </summary>
        private const String CONVERSION_METHOD = "ConvertTo";

        /// <summary>
        ///     The collection of strings considered equal to a True boolean value
        /// </summary>
        private static readonly String[] BOOLEAN_EQUIVELENT_T = { "T", "True", "Y", "Yes", "1", "X" };

        /// <summary>
        ///     The collection of strings considered equal to a False boolean value
        /// </summary>
        private static readonly String[] BOOLEAN_EQUIVELENT_F = { "F", "False", "N", "No", "0", "O" };

        #endregion

        #region extensions

        /// <summary>
        ///     Converts the current value to the specified data type, falling back to a default value for the data type where conversion cannot be achieved
        /// </summary>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <param name="type">
        ///     The required data type which the value will be converted to, if possible
        /// </param>
        /// <returns>
        ///     Returns the converted value or, where conversion fails, the default value for the specified data type.
        /// </returns>
        public static Object ConvertTo(this Object value, Type type)
        {
            return Conversion.AttemptConversion(value, type, type.IsValueType ? Activator.CreateInstance(type) : null);
        }

        /// <summary>
        ///     Converts the current value to the specified data type, falling back to a default value where conversion cannot be achieved
        /// </summary>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <param name="type">
        ///     The required data type which the value will be converted to, if possible
        /// </param>
        /// <param name="defaultValue">
        ///     The default value to be returned if conversion cannot be achieved
        /// </param>
        /// <returns>
        ///     Returns the converted value or, where conversion fails, the specified default value
        /// </returns>
        public static Object ConvertTo(this Object value, Type type, Object defaultValue)
        {
            return Conversion.AttemptConversion(value, type, defaultValue);
        }

        /// <summary>
        ///     Converts the current value to the specified data type, falling back to a default value for the data type where conversion cannot be achieved
        /// </summary>
        /// <typeparam name="T">
        ///     The required data type which the value will be converted to, if possible
        /// </typeparam>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <returns>
        ///     Returns the converted value or, where conversion fails, the default value for the specified data type
        /// </returns>
        public static T ConvertTo<T>(this Object value)
        {
            return Conversion.AttemptConversion<T>(value, default(T));
        }

        /// <summary>
        ///     Converts the current value to the specified data type, falling back to a default value where conversion cannot be achieved
        /// </summary>
        /// <typeparam name="T">
        ///     The required data type which the value will be converted to, if possible
        /// </typeparam>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <param name="defaultValue">
        ///     The default value to be returned if conversion cannot be achieved
        /// </param>
        /// <returns>
        ///     Returns the converted value or, where conversion fails, the specified default value
        /// </returns>
        public static T ConvertTo<T>(this Object value, T defaultValue)
        {
            return Conversion.AttemptConversion<T>(value, defaultValue);
        }

        #endregion

        #region conversions

        /// <summary>
        ///     Converts the current value to the specified data type, falling back to a default value where conversion cannot be achieved
        /// </summary>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <param name="type">
        ///     The required data type which the value will be converted to, if possible
        /// </param>
        /// <param name="defaultValue">
        ///     The default value to be returned if conversion cannot be achieved
        /// </param>
        /// <returns>
        ///     Returns the converted value or, where conversion fails, the specified default value
        /// </returns>
        private static Object AttemptConversion(Object value, Type type, Object defaultValue)
        {
            Object result = defaultValue;

            // Identify the conversion method, matched by name
            MethodInfo method = typeof(Conversion).GetMethods(BindingFlags.Public | BindingFlags.Static).Where(m =>
                m.Name.Equals(CONVERSION_METHOD) &&
                m.IsGenericMethod &&
                m.GetGenericArguments().Length == 1 &&
                m.GetParameters().Length == 2).FirstOrDefault();

            if (method != null)
            {
                // If the method is found, specify the generic type for the method
                method = method.MakeGenericMethod(type);
                if (method != null)
                {
                    // Invoke the method to perform the conversion
                    Object[] methodParams = { value, defaultValue };
                    result = method.Invoke(null, methodParams);
                }
            }

            return result;
        }

        /// <summary>
        ///    Converts the specified <paramref name="value" /> to the specified data type, falling back to a default value where conversion cannot be achieved
        /// </summary>
        /// <typeparam name="T">
        ///     The data type which the specified value should be converted to, if possible.
        /// </typeparam>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <param name="defaultValue">
        ///     The default value to be returned if conversion cannot be achieved
        /// </param>
        /// <returns>
        ///     Returns the converted value or, where conversion fails, the specified default value
        /// </returns>
        private static T AttemptConversion<T>(Object value, T defaultValue)
        {
            // Defines the value to be returned.  This local variable is uninitialised to ensure that all scenarios have been catered for within this method,
            // as a compiler warning will be generated (for using an uninitialised local variable) if any scenarios is missed.
            T returnValue;
            T parsedValue;

            // Identify the absolute type (for System.Nullable wrapped types)
            Type absoluteType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
            Boolean isNumeric = (value != null && value != DBNull.Value) && (value.GetType().IsEnum || value.GetType() == typeof(SByte) || value.GetType() == typeof(Int16) || value.GetType() == typeof(Int32) || value.GetType() == typeof(Int64) || value.GetType() == typeof(Decimal) || value.GetType() == typeof(Double) || value.GetType() == typeof(Single) || value.GetType() == typeof(Byte) || value.GetType() == typeof(UInt16) || value.GetType() == typeof(UInt32) || value.GetType() == typeof(UInt64));

            // Check if the value is null (or a null-equivelent)
            if (value == null || (Object)(value) == DBNull.Value)
            {
                // If the specified type is a value type, then null cannot be converted because value types (structs) are non-nullable
                if (typeof(T).IsValueType)
                {
                    // Conversion failed - value type does not allow null value
                    returnValue = defaultValue;
                }
                else
                {
                    returnValue = (T)(Object)null;
                }
            }

            // Perform boxing if specified value is already of the required type or can be assigned to the specified type
            else if (value != null && (value is T || typeof(T).IsAssignableFrom(value.GetType())))
            {
                returnValue = (T)value;
            }

            // If conversion can be achieved dynamically, using a custom-conversion method, perform the conversion and return the result of the conversion
            else if (Conversion.AttemptCustomConversion<T>(value, out parsedValue))
            {
                returnValue = parsedValue;
            }

            // If the specified type is an enumerator, invoke custom conversion logic to perform the conversion
            else if (Conversion.AttemptEnumeratorConversion<T>(value, out parsedValue))
            {
                returnValue = parsedValue;
            }

            // If conversion can be achieved dynamically, using a standard Microsoft.NET method, perform the conversion and return the result of the conversion
            else if (Conversion.AttemptStandardConversion<T>(value, out parsedValue))
            {
                returnValue = parsedValue;
            }

            else if (absoluteType == typeof(Guid) && value.GetType().IsEnum)
            {
                EnumerationGuid guid = value.GetType().GetField(value.ToString(), BindingFlags.Public | BindingFlags.Static).GetCustomAttributes().OfType<EnumerationGuid>().FirstOrDefault();
                if (guid != null)
                    returnValue = (T)(Object)guid.Guid;
                else
                    returnValue = defaultValue;
            }

            // If converting to a string, use the ToString method with a predefined formatting standard.  For enumerators, use the value of the description attribute 
            else if (typeof(T) == typeof(String))
            {
                if (value is Enum)
                    returnValue = (T)(Object)(value.GetType().GetField(value.ToString(), BindingFlags.Public | BindingFlags.Static).GetCustomAttributes(true).OfType<DescriptionAttribute>().Select(attr => attr.Description).FirstOrDefault() ?? value.ToString());
                else if (value is Int16 || value is Int32 || value is Int64)
                    returnValue = (T)(Object)Convert.ToInt64(value).ToString("0");
                else if (value is UInt16 || value is UInt32 || value is UInt64)
                    returnValue = (T)(Object)Convert.ToUInt64(value).ToString("0");
                else if (value is Decimal)
                    returnValue = (T)(Object)((Decimal)value).ToString("0.00");
                else if (value is Double)
                    returnValue = (T)(Object)((Double)value).ToString("0.00");
                else if (value is Single)
                    returnValue = (T)(Object)((Single)value).ToString("0.00");
                else if (value is DateTime)
                    returnValue = (T)(Object)((DateTime)value).ToString("dd MMMM yyyy");
                else if (value is TimeSpan)
                    returnValue = (T)(Object)((TimeSpan)value).ToString("HH:mm");
                else if (value is Boolean)
                    returnValue = (T)(Object)((Boolean)value ? "Yes" : "No");
                else
                    returnValue = (T)(Object)value.ToString();
            }

            // Attempt conversion from one numeral type to another numeral type
            else if (isNumeric && absoluteType == typeof(SByte))
            {
                try { returnValue = (T)(Object)Convert.ToSByte(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(Int16) )
            {
                try { returnValue = (T)(Object)Convert.ToInt16(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(Int32))
            {
                try { returnValue = (T)(Object)Convert.ToInt32(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(Int64))
            {
                try { returnValue = (T)(Object)Convert.ToInt64(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(Decimal))
            {
                try { returnValue = (T)(Object)Convert.ToDecimal(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(Double))
            {
                try { returnValue = (T)(Object)Convert.ToDouble(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(Single))
            {
                try { returnValue = (T)(Object)Convert.ToSingle(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(Byte))
            {
                try { returnValue = (T)(Object)Convert.ToByte(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(UInt16))
            {
                try { returnValue = (T)(Object)Convert.ToUInt16(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(UInt32))
            {
                try { returnValue = (T)(Object)Convert.ToUInt32(value); }
                catch { returnValue = defaultValue; }
            }
            else if (isNumeric && absoluteType == typeof(UInt64))
            {
                try { returnValue = (T)(Object)Convert.ToUInt64(value); }
                catch { returnValue = defaultValue; }
            }
            else if (absoluteType == typeof(Byte))
            {
                try {
                    returnValue = value.ToString() == "True" ? (T)(Object)Convert.ToByte(1) : (T)(Object)Convert.ToByte(0);

                }
                catch { returnValue = defaultValue; }
            }

            // If all conversion attempts have failed, fall back to the specified default value
            else
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        /// <summary>
        ///     Dynamically identifies a custom method for converting the specified value to the required data type and
        ///     returns a <see cref="T:System.Boolean" /> to indicate whether conversion succeeded (<b>true</b>) or failed (<b>true</b>)
        /// </summary>
        /// <typeparam name="T">
        ///     The data type which the specified value should be converted to, if possible.
        /// </typeparam>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <param name="result">
        ///     The converted equivelent of the specified <i>value</i>, or the default value for the specified type, <i>T</i>, where conversion has failed.
        /// </param>
        /// <returns>
        ///     A <see cref="T:System.Boolean" /> value which indicates if conversion succeeded
        /// </returns>
        private static Boolean AttemptCustomConversion<T>(Object value, out T result)
        {
            Boolean success;

            if (value == null || value == DBNull.Value)
            {
                // Conversion failed, no value provided
                result = default(T);
                success = false;
            }
            else
            {
                // Identify, through reflection, the public static method which executes custom conversion logic
                Type[] methodParameters = { value.GetType(), typeof(T).MakeByRefType() };
                MethodInfo methodInfo = typeof(Conversion).GetMethod(Conversion.TRY_PARSE_METHOD, BindingFlags.Public | BindingFlags.Static, null, methodParameters, null);
                if (methodInfo == null)
                {
                    methodParameters = new Type[] { typeof(Object), typeof(T).MakeByRefType() };
                    methodInfo = typeof(Conversion).GetMethod(Conversion.TRY_PARSE_METHOD, BindingFlags.Public | BindingFlags.Static, null, methodParameters, null);
                }

                // Ensure that a method was found and that the method returns a boolean value
                if (methodInfo != null && methodInfo.ReturnType == typeof(Boolean))
                {
                    // Invoke the method to perform the conversion
                    Object[] methodInput = { value, null };
                    Boolean methodResult = (Boolean)methodInfo.Invoke(null, methodInput);
                    if (methodResult && methodInput[1] is T)
                    {
                        result = (T)methodInput[1];
                        success = true;
                    }
                    else
                    {
                        // Conversion failure: method returned false or unexpected value
                        result = default(T);
                        success = false;
                    }
                }
                else
                {
                    // Conversion failure: no suitable conversion method found
                    result = default(T);
                    success = false;
                }
            }

            return success;
        }

        /// <summary>
        ///     Dynamically identifies the standard Microsoft.NET method for converting the specified value to the required data type
        ///     and returns a <see cref="T:System.Boolean" /> to indicate whether conversion succeeded (<b>true</b>) or failed (<b>true</b>)
        /// </summary>
        /// <typeparam name="T">
        ///     The data type which the specified value should be converted to, if possible.
        /// </typeparam>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <param name="result">
        ///     The converted equivelent of the specified <i>value</i>, or the default value for the specified type, <i>T</i>, where conversion has failed.
        /// </param>
        /// <returns>
        ///     A <see cref="T:System.Boolean" /> value which indicates if conversion succeeded
        /// </returns>
        private static Boolean AttemptStandardConversion<T>(Object value, out T result)
        {
            Boolean success;

            Type absoluteType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
            if (value == null || value == DBNull.Value)
            {
                // Conversion failed, no value provided
                result = default(T);
                success = false;
            }
            else if (absoluteType == typeof(DateTime) && String.IsNullOrEmpty(value.ToString()))
            {
                // System.ComponentModel.DateTimeConverter class will deem a string value to be a valid date time when the string
                // value has zero-length (i.e. is an empty string) - the class returns, for this value, the default(DateTime) as the
                // conversion result

                // String values which have zero-length or consist only of whitespace should NOT be considered valid therefore the
                // behaviour of the System.ComponentModel.DateTimeConverter class is overridden here.
                result = default(T);
                success = false;
            }
            else
            {
                // Get the converter and validate the conversion
                TypeConverter converter = TypeDescriptor.GetConverter(absoluteType);
                if (converter != null && converter.CanConvertFrom(value.GetType()))
                {
                    // The TypeConverter.IsValid method does nothing more than call the ConvertFrom method within a Try...Catch handler and
                    // then returns true if no exception is caught or false, where an exception occurs.  The generally accepted recommendation
                    // is to use the IsValid method before calling ConvertFrom however:

                    //    - The main reason given is so that the ConvertFrom call does not need to be wrapped in a Try...Catch handler which is
                    //      beleived to be offer lower performance however, the IsValid method contains such a handler therefore using the IsValid
                    //      method does NOT offer any increase in performance as the Try...Catch handler is still used, but merely relocated to
                    //      another method

                    //    - Using the IsValid method and relying on the internal Try...Catch handler results in TWO calls being made to the ConvertFrom
                    //      method - the first within the IsValid method and then the second to obtain the conversion result.  Implementing the Try...Catch
                    //      handler and calling the ConvertFrom directly requires only one call to the method

                    //    - Whilst the ConvertFrom and ConvertTo methods include method overloadeds so that a Culture can be specified, Culture-aware
                    //      conversion was not considered when the IsValid method was implemented in the standard .NET type converters.  As a result,
                    //      values may be reported as either valid or invalid for conversion incorrectly (example: 31/12/1999 is a valid UK date, whilst
                    //      the DateTimeConverter class can convert this value using the CURRENT culture, it will report the valid as INVALID for
                    //      conversion as the validation is only ever completed using the INVARIANT culture).
                    try { result = (T)converter.ConvertFrom(null, CultureInfo.CurrentCulture, value); success = true; }
                    catch { result = default(T); success = false; }
                }
                else
                {
                    result = default(T);
                    success = false;
                }
            }

            return success;
        }

        /// <summary>
        ///     Performs custom conversion for enumeration values to allow flagged enumerators to be converted from, using compound numeric values or delimited strings
        /// </summary>
        /// <typeparam name="T">
        ///     The data type which the specified value should be converted to, if possible.
        /// </typeparam>
        /// <param name="value">
        ///     The value to be converted
        /// </param>
        /// <param name="result">
        ///     The converted equivelent of the specified <i>value</i>, or the default value for the specified type, <i>T</i>, where conversion has failed.
        /// </param>
        /// <returns>
        ///     A <see cref="T:System.Boolean" /> value which indicates if conversion succeeded
        /// </returns>
        private static Boolean AttemptEnumeratorConversion<T>(Object value, out T result)
        {
            Boolean success;

            // Get the type or, for nullable types, the underlying type
            Type underlyingType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);

            if (value == null || value == DBNull.Value)
            {
                // Conversion failed, no value provided
                result = default(T);
                success = false;
            }
            else if (!underlyingType.IsEnum)
            {
                // Conversion failed, type is not an enumerator
                result = default(T);
                success = false;
            }
            else if (value is Guid)
            {
                result = default(T);
                success = false;

                // Loop through each defined enumeration and compare the enumeration guid with the guid specified.
                foreach (T enumeration in Enum.GetValues(underlyingType))
                {
                    EnumerationGuid guid = underlyingType.GetField(enumeration.ToString(), BindingFlags.Public | BindingFlags.Static).GetCustomAttributes<EnumerationGuid>().FirstOrDefault();
                    if (guid != null && Guid.Equals(guid.Guid, value))
                    {
                        result = enumeration;
                        success = true;
                        break;
                    }
                }
            }
            else if (value is String)
            {
                success = true;
                Int64 checkedValue = 0;

                // Remove leading and trailing spaces from each element and separate by multiple known delimiters (commas, pipes, etc)
                IEnumerable<String> stringValueCollection = value.ToString().Split(Conversion.ENUMERATOR_DELIMITERS, StringSplitOptions.RemoveEmptyEntries).Select(val => val.Trim());
                foreach (String stringValue in stringValueCollection)
                {
                    // Get the enumeration which matches the string value (case-insensitive)
                    IEnumerable<T> enumeration = Enum.GetValues(underlyingType).OfType<T>().Where(enumValue => String.Equals(stringValue, Enum.GetName(underlyingType, enumValue), StringComparison.OrdinalIgnoreCase));
                    if (enumeration.Count() == 0)
                        success = false;
                    else
                        checkedValue |= Convert.ToInt64(enumeration.First());
                }

                // Convert the compounded result to the enumerators underlying type, if all enumeration values were converted successfully
                if (success)
                    result = (T)Convert.ChangeType(checkedValue, Enum.GetUnderlyingType(underlyingType));
                else
                    result = default(T);
            }
            else if (value is Byte || value is SByte || value is Int16 || value is UInt16 || value is Int32 || value is UInt32 || value is Int64 || value is UInt64)
            {
                Int64 checkedValue = 0;
                Int64 numeralValue = Convert.ToInt64(value);

                // Test the specified numeric value against each enumeration value and compound the value to the result
                foreach (Object enumeration in Enum.GetValues(underlyingType))
                {
                    Int64 enumValue = Convert.ToInt64(enumeration);
                    if ((numeralValue & enumValue) == enumValue)
                        checkedValue |= enumValue;
                }

                // Convert the compounded result to the enumerators underlying type
                result = (T)Enum.ToObject(underlyingType, Convert.ChangeType(checkedValue, Enum.GetUnderlyingType(underlyingType)));
                success = true;
            }
            else
            {
                // Conversion failure: value is neither a string nor a numeric type
                result = default(T);
                success = false;
            }

            return success;
        }

        /// <summary>
        ///     Custom conversion method - converts "Y", "Yes", "T", "True"
        /// </summary>
        /// <param name="value"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static Boolean TryParse(Object value, out Boolean result)
        {
            return Conversion.TryParse(value == null ? null : value.ToString(), out result);
        }

        /// <summary>
        ///     Custom conversion method - converts "Y", "Yes", "T", "True"
        /// </summary>
        /// <param name="value"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static Boolean TryParse(String value, out Boolean result)
        {
            Boolean success = false;
            result = default(Boolean);

            // Check if the character is considered equal to True
            if (success = BOOLEAN_EQUIVELENT_T.Any(str => String.Equals(str, value, StringComparison.OrdinalIgnoreCase)))
            {
                success = true;
                result = true;
            }

            // Check if the character is considered equal to False
            else if (success = BOOLEAN_EQUIVELENT_F.Any(str => String.Equals(str, value, StringComparison.OrdinalIgnoreCase)))
            {
                success = true;
                result = false;
            }

            return success;
        }

        #endregion
    }
}
