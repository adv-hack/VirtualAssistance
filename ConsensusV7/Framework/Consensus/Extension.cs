using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;

namespace Consensus
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

        #region System.Object

        public static Boolean In<T>(this T value, params T[] values)
        {
            return values.Any(val => Object.Equals(val, value));
        }

        #endregion

        #region System.Byte[]

        /// <summary>
        ///     Converts the specified byte array into a hexadecimal string.
        /// </summary>
        /// <param name="value">
        ///     The byte array to be converted.
        /// </param>
        /// <returns>The hexadecimal string which represents the byte array</returns>
        public static String ToHexString(this Byte[] value)
        {
            return String.Join("", value.Select(b => b.ToString("x2")));
        }

        #endregion

        #region System.Collections.Generic.IEnumerable

        /// <summary>
        ///     Executes the specified <paramref nodeName="action"/> on each element of the current <see cref="IEnumerable&lt;T&gt;" /> collection
        /// </summary>
        /// <typeparam nodeName="T">
        ///     The type of elements in the collection.
        /// </typeparam>
        /// <param nodeName="collection">
        ///     The collection of elements for which the action will be executed.
        /// </param>
        /// <param nodeName="action">
        ///     The action to be executed.
        /// </param>
        public static IEnumerable<T> Execute<T>(this IEnumerable<T> collection, Action<T> action)
        {
            if (collection != null && collection.Count() > 0)
                foreach (T element in collection)
                    action.Invoke(element);

            return collection;
        }
        
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
        public static String Textify(this Decimal value)
        {
            return Extension.Textify(value, null, null);
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
        public static String Textify(this Decimal value, String unit, String fractionalUnit)
        {
            Boolean nonNegative = value >= 0;
            Decimal absoluteValue = (nonNegative ? value : value * -1);
            String integerText = Extension.Textify((Int64)absoluteValue);
            String decimalText = Extension.Textify((Int64)((absoluteValue % 1) * 100));

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
        public static String Textify(this Int16 value)
        {
            return Extension.Textify((Int64)value);
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
        public static String Textify(this Int32 value)
        {
            return Extension.Textify((Int64)value);
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
        public static String Textify(this Int64 value)
        {
            Boolean nonNegative = value >= 0;
            UInt64 absoluteValue = (UInt64)(nonNegative ? value : value * -1);
            String textualValue = Extension.Textify(absoluteValue);

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
        public static String Textify(this UInt16 value)
        {
            return Extension.Textify((UInt64)value);
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
        public static String Textify(this UInt32 value)
        {
            return Extension.Textify((UInt64)value);
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
        public static String Textify(this UInt64 value)
        {
            String result = "";

            // Obtain the digital equivelent of the value
            String number = value.ToString();
            Char[] digits = number.Reverse().ToArray();

            // Process the number in hexlets
            for (Int32 index = 0; index < digits.Length; index += 6)
            {
                // Get to the two triplets as text
                String tripletL = Extension.Textify(digits.Skip(index).Skip(3).Take(3).Reverse());
                String tripletR = Extension.Textify(digits.Skip(index).Take(3).Reverse());
                result = (tripletL + (tripletL.Length == 0 ? "" : " " + Extension.NumberTextThousand + " ") + tripletR + (tripletR.Length == 0 ? "" : " ") + Extension.NumberTextScale[index / 6] + " " + result).Trim();
            }

            return String.IsNullOrEmpty(result) ? Extension.NumberTextUnits[0] : result;
        }

        /// <summary>
        ///     Returns the textual representation of the specified number.
        /// </summary>
        /// <param name="value">
        ///     The value to be written in its textual representation.
        /// </param>
        /// <returns>
        ///     The textual representation of the specified number.
        /// </returns>
        private static String Textify(this IEnumerable<Char> digits)
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
            IEnumerable<String> tokens = tokeniser.ToString().Split(new Char[] { '⁂' }, StringSplitOptions.RemoveEmptyEntries).Select(item => Char.ToUpper(item[0]) + (item.Length > 1 ? item.Substring(1).ToLower() : ""));
            return String.Join(separator, tokens);
        }

        /// <summary>
        ///     Converts a <see cref="String"/> value containing HTML into it's plain-text equivalent.
        /// </summary>
        //public static String HtmlToText(this String value)
        //{
        //    HtmlGenericControl element = new HtmlGenericControl();
        //    element.InnerHtml = value;
        //    return element.InnerText;
        //}

        public static String HtmlToText(this String html)
        {
            var text = html;
            if (!String.IsNullOrEmpty(text))
            {
                //const string tagWhiteSpace = @"(>|$)(\W|\n|\r)+<";//matches one or more (white space or line breaks) between '>' and '<'
                const string tagWhiteSpace = @">(\s|\n|\r)+<";//matches one or more (white space or line breaks) between '>' and '<'
                const string stripFormatting = @"<[^>]*(>|$)";//match any character between '<' and '>', even when end tag is missing
                const string lineBreak = @"<(br|BR|li|LI)\s{0,1}\/{0,1}>";//matches: <br>,<br/>,<br />,<BR>,<BR/>,<BR /> + similar for li
                const string paraBreak = @"<(p|P)(\/{0,1}>|\s)";//matches: <p>,<p/>,<P>,<P/>,<p ,<P 
                var lineBreakRegex = new Regex(lineBreak, RegexOptions.Multiline);
                var paraBreakRegex = new Regex(paraBreak, RegexOptions.Multiline);
                var stripFormattingRegex = new Regex(stripFormatting, RegexOptions.Multiline);
                var tagWhiteSpaceRegex = new Regex(tagWhiteSpace, RegexOptions.Multiline);
                               
                //Decode html specific characters
                text = System.Net.WebUtility.HtmlDecode(text);
                //Remove tag whitespace/line breaks
                // Putting a single space between tags will not always be correct, but is more likely to come up with an overall sensible result than no space.
                text = tagWhiteSpaceRegex.Replace(text, "> <");
                //Replace <br /> with line breaks
                text = lineBreakRegex.Replace(text, Environment.NewLine);
                // Insert a line break before <p 
                MatchCollection paraBreaks = paraBreakRegex.Matches(text);
                foreach (Match pBreak in paraBreaks)
                {
                    if (pBreak.Index != 0)
                    {
                        text = text.Insert(pBreak.Index, Environment.NewLine);
                    }
                }
                //Strip formatting
                text = stripFormattingRegex.Replace(text, string.Empty);

                return text;
            }
            return text;
        }

        #endregion

        #region System.String[]

        public static String GetPrefix(this IEnumerable<String> values)
        {
            Int32 maximumLength = values.Count() == 0 ? 0 : values.Select(value => value.LastIndexOf("$") + 2).Min();
            Int32 prefixLength = Enumerable.Range(0, maximumLength).LastOrDefault(length => values.GroupBy(value => value.Substring(0, Math.Min(value.Length, length))).Count() == 1);
            return prefixLength == 0 ? String.Empty : values.GroupBy(value => value.Substring(0, Math.Min(value.Length, prefixLength))).First().Key;
        }

        #endregion

        #region System.Type

        public static bool IsNullable(this Type type)
        {
            return
                type != null &&
                type.IsGenericType &&
                type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        /// <summary>
        ///     These are types that can use MinValue as a marker to indicate they should be saved as null.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsSignedNumericOrDate(this Type type)
        {
            // Note: this should match the logic in the same extension method in Tools/Consensus.Developer.Tool/Extension.cs
            if (type == null || type.IsEnum)
                return false;

            if (IsNullable(type))
                return IsSignedNumericOrDate(Nullable.GetUnderlyingType(type));

            switch (Type.GetTypeCode(type))
            {
                //case TypeCode.Byte:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                //case TypeCode.SByte:
                case TypeCode.Single:
                //case TypeCode.UInt16:
                //case TypeCode.UInt32:
                //case TypeCode.UInt64:
                case TypeCode.DateTime:
                    return true;
                default:
                    return false;
            }
        }

        public static object GetDefaultValue(this Type t)
        {
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }

        #endregion
    }
}
