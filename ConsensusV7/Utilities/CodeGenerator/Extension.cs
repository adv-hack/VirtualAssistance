﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    /// <summary>
    ///     A generic extension class which enhances the types defined within the Microsoft.NET framework with additional methods.
    /// </summary>
    public static class Extension
    {
        #region constants

        /// <summary>
        ///     The array of scale names used within textual numerics.
        /// </summary>
        private static readonly String[] NumberTextScale = { "", "million", "billion", "trillion", "quadrillian", "quintillion", "sextillion", "septillion", "octillion", "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion", "quattuordecillion", "quindecillion", "sexdecillion", "septendecillion", "octodecillion", "novemdecillion", "vigintillion" };

        /// <summary>
        ///     The array of unit names used within textual numerics.
        /// </summary>
        private static readonly String[] NumberTextUnits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        /// <summary>
        ///     The array of teen names used within textual numerics.
        /// </summary>
        private static readonly String[] NumberTextTeens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        /// <summary>
        ///     The array of names used within textual numerics for tens of units.
        /// </summary>
        private static readonly String[] NumberTextTens = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        /// <summary>
        ///     The word used within textual numerics for thousands of units.
        /// </summary>
        private static readonly String NumberTextThousand = "thousand";

        /// <summary>
        ///     The word used within textual numerics for hundreds of units.
        /// </summary>
        private static readonly String NumberTextHundred = "hundred";

        /// <summary>
        ///     The word used within textual numerics for seperation.
        /// </summary>
        private static readonly String NumberTextSeperator = "and";

        /// <summary>
        ///     The word used within textual numerics for negative numbers.
        /// </summary>
        private static readonly String NumberTextNegative = "minus";

        /// <summary>
        ///     The word used within textual numerics for fractional seperation.
        /// </summary>
        private static readonly String NumberTextPoint = "point";

        #endregion

        #region System.Decimal

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        public static String ToText(this Decimal value)
        {
            return Extension.ToText(value, null, null);
        }

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <param name="unit">
        ///     The name of the integer unit.
        /// </param>
        /// <param name="fractionalUnit">
        ///     The name of the fractional unit.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        public static String ToText(this Decimal value, String unit, String fractionalUnit)
        {
            Boolean nonNegative = value >= 0;
            Decimal absoluteValue = (nonNegative ? value : value * -1);
            String integerText = Extension.ToText((Int64)absoluteValue);
            String decimalText = Extension.ToText((Int64)((absoluteValue % 1) * 100));

            String result = (nonNegative ? "" : Extension.NumberTextNegative + " ");
            result += integerText;
            result += String.IsNullOrEmpty(unit) ? "" : " " + unit;
            result += decimalText == Extension.NumberTextUnits[0] ? "" : String.IsNullOrEmpty(unit) ? " " + Extension.NumberTextPoint + " " : String.IsNullOrEmpty(fractionalUnit) ? " " : " " + Extension.NumberTextSeperator + " ";
            result += decimalText;
            result += decimalText != Extension.NumberTextUnits[0] && !String.IsNullOrEmpty(fractionalUnit) ? " " + fractionalUnit : "";
            return result;
        }

        #endregion

        #region System.Int16

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        public static String ToText(this Int16 value)
        {
            return Extension.ToText((Int64)value);
        }

        #endregion

        #region System.Int32

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        public static String ToText(this Int32 value)
        {
            return Extension.ToText((Int64)value);
        }

        #endregion

        #region System.Int64

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        public static String ToText(this Int64 value)
        {
            Boolean nonNegative = value >= 0;
            UInt64 absoluteValue = (UInt64)(nonNegative ? value : value * -1);
            String textualValue = Extension.ToText(absoluteValue);

            return (nonNegative ? "" : Extension.NumberTextNegative + " ") + textualValue;
        }

        #endregion

        #region System.UInt16

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        public static String ToText(this UInt16 value)
        {
            return Extension.ToText((UInt64)value);
        }

        #endregion

        #region System.UInt32

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        public static String ToText(this UInt32 value)
        {
            return Extension.ToText((UInt64)value);
        }

        #endregion

        #region System.UInt64

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        public static String ToText(this UInt64 value)
        {
            String result = "";

            // Obtain the digital equivelent of the value
            String number = value.ToString();
            Char[] digits = number.Reverse().ToArray();

            // Process the number in hexlets
            for (Int32 index = 0; index < digits.Length; index += 6)
            {
                // Get to the two triplets as text
                String tripletL = Extension.ToText(digits.Skip(index).Skip(3).Take(3).Reverse());
                String tripletR = Extension.ToText(digits.Skip(index).Take(3).Reverse());
                result = (tripletL + (tripletL.Length == 0 ? "" : " " + Extension.NumberTextThousand + " ") + tripletR + (tripletR.Length == 0 ? "" : " ") + Extension.NumberTextScale[index / 6] + " " + result).Trim();
            }

            return String.IsNullOrEmpty(result) ? Extension.NumberTextUnits[0] : result;
        }

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="digits">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        private static String ToText(this IEnumerable<Char> digits)
        {
            String result = "";

            // Get the individual digits within the triplet
            Char digitU = digits.Count() >= 1 ? digits.Reverse().First() : '0';
            Char digitT = digits.Count() >= 2 ? digits.Reverse().ElementAt(1) : Char.MinValue;
            Char digitH = digits.Count() >= 3 ? digits.Reverse().ElementAt(2) : Char.MinValue;

            // Get the individual words for each digit
            String wordH = (digitH == Char.MinValue || digitH == '0') ? "" : Extension.NumberTextUnits[digitH - 48];
            String wordT = (digitT == Char.MinValue || digitT == '0' || (digitT == '1' && digitU != '0')) ? "" : Extension.NumberTextTens[digitT - 49];
            String wordU = (digitT == '1' && digitU != '0' ? Extension.NumberTextTeens[digitU - 49] : (digitU == '0' ? "" : Extension.NumberTextUnits[digitU - 48]));

            // Join the words within the tripet;
            result += wordH + (wordH.Length == 0 ? "" : " " + Extension.NumberTextHundred);
            result += (wordH.Length == 0 || (wordT.Length == 0 && wordU.Length == 0) ? "" : " " + Extension.NumberTextSeperator + " ");
            result += wordT + (wordT.Length == 0 || wordU.Length == 0 ? "" : "-") + wordU;
            return result;
        }

        #endregion

        #region System.String

        /// <summary>
        ///     Removes all leading and trailing whitespace, tab, carriage return and line feed characters from the current <see cref="System.String" /> object.
        /// </summary>
        /// <param name="value">
        ///     The current <see cref="System.String" /> object.
        /// </param>
        /// <returns>
        ///     The current <see cref="System.String" /> object with all leading and trailing whitespace, tab, carriage return and line feed characters removed; 
        ///     or <i>null</i> if the <see cref="System.String" /> object is null, empty or consists only of whitespace, tab, carriage return or line feed characters.
        /// </returns>
        public static String TrimOrNullify(this String value)
        {
            return Extension.TrimOrNullify(value, null);
        }

        /// <summary>
        ///     Removes all leading and trailing whitespace, tab, carriage return and line feed characters from the current <see cref="System.String" /> object.
        /// </summary>
        /// <param name="value">
        ///     The current <see cref="System.String" /> object.
        /// </param>
        /// <param name="defaultValue">
        ///     The default value to return if the <see cref="System.String" /> object is null, empty or consists only of whitespace, tab, carriage return or line feed characters.
        /// </param>
        /// <returns>
        ///     The current <see cref="System.String" /> object with all leading and trailing whitespace, tab, carriage return and line feed characters removed; 
        ///     or the specified <paramref name="defaultValue"/> if the <see cref="System.String" /> object is null, empty or consists only of whitespace, tab, carriage return or line feed characters.
        /// </returns>
        public static String TrimOrNullify(this String value, String defaultValue)
        {
            if (value != null)
                value = value.Trim().Trim('\r', '\n', '\t');

            return String.IsNullOrWhiteSpace(value) ? defaultValue : value;
        }

        /// <summary>
        ///     Returns a copy of this string, converted to pascal case.
        /// </summary>
        /// <param name="value">
        ///     The string value to be converted.
        /// </param>
        /// <returns>
        ///     The specified value, converted to pascal case.
        /// </returns>
        public static String ToPascal(this String value)
        {
            return Extension.ToPascal(value, "");
        }

        /// <summary>
        ///     Returns a copy of this string, converted to pascal case.
        /// </summary>
        /// <param name="value">
        ///     The string value to be converted.
        /// </param>
        /// <param name="separator">
        ///     The string used to separate each element within the string.
        /// </param>
        /// <returns>
        ///     The specified value, converted to pascal case.
        /// </returns>
        public static String ToPascal(this String value, String separator)
        {
            // Tokenise the value
            StringBuilder tokeniser = new StringBuilder();
            foreach (Char character in value)
                if (Char.IsLetterOrDigit(character))
                    tokeniser.Append(character);
                else if (tokeniser[tokeniser.Length - 1] != '⁂')
                    tokeniser.Append('⁂');

            // Perform case-conversion for each token
            IEnumerable<String> tokens = tokeniser.ToString().Split('⁂').Select(item => Char.ToUpper(item[0]) + (item.Length > 1 ? item.Substring(1).ToLower() : ""));
            return String.Join(separator, tokens);
        }

        #endregion

        #region System.Type

        /// <summary>
        ///     Gets whether the type implements the specified interface
        /// </summary>
        public static Boolean Implements<T>(this Type type)
        {
            return type.GetInterfaces().Any(iface => iface == typeof(T));
        }

        /// <summary>
        ///     Gets whether the type implements the specified interface
        /// </summary>
        public static Boolean Implements(this Type type, String interfaceName)
        {
            return type.GetInterfaces().Any(iface => String.Equals(iface.Name, interfaceName, StringComparison.Ordinal));
        }

        #endregion
    }
}
