using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public struct Version : IComparable, IComparable<Version>, IEquatable<Version>
    {
        #region fields

        /// <summary>
        ///     The major version number.
        /// </summary>
        private UInt16 _major;

        /// <summary>
        ///     The minor version number.
        /// </summary>
        private UInt16 _minor;

        /// <summary>
        ///     The monthly release number.
        /// </summary>
        private UInt16 _month;

        /// <summary>
        ///     The patch version number.
        /// </summary>
        private UInt16 _patch;

        /// <summary>
        ///     The build version number.
        /// </summary>
        private UInt64 _build;

        #endregion		

        #region properties

        /// <summary>
        ///    Gets or sets the major version number.
        /// </summary>
        public UInt16 Major
        {
            get { return _major; }
            set { _major = value; }
        }

        /// <summary>
        ///    Gets or sets the minor version number.
        /// </summary>
        public UInt16 Minor
        {
            get { return _minor; }
            set { _minor = value; }
        }

        /// <summary>
        ///    Gets or sets the monthly release number.
        /// </summary>
        public UInt16 Month
        {
            get { return _month; }
            set { _month = value; }
        }

        /// <summary>
        ///    Gets or sets the patch version number.
        /// </summary>
        public UInt16 Patch
        {
            get { return _patch; }
            set { _patch = value; }
        }

        /// <summary>
        ///    Gets or sets the build version number
        /// </summary>
        public UInt64 Build
        {
            get { return _build; }
            set { _build = value; }
        }

        #endregion		

        #region constructors

        /// <summary>
		///     Initialises a new <see cref="Version" /> instance.
		/// </summary>
        public Version(String version)
        {
            if (String.IsNullOrEmpty(version))
                throw new ArgumentNullException("version", "Version cannot be null or empty");

            String[] components = version.Split('.');
            _major = components.Length >= 1 ? components[0].ConvertTo<UInt16>() : (UInt16)0;
            _minor = components.Length >= 1 ? components[1].ConvertTo<UInt16>() : (UInt16)0;
            _month = components.Length >= 1 ? components[2].ConvertTo<UInt16>() : (UInt16)0;
            _patch = components.Length >= 1 ? components[3].ConvertTo<UInt16>() : (UInt16)0;
            _build = components.Length >= 1 ? components[4].ConvertTo<UInt64>() : (UInt64)0;
        }

		/// <summary>
		///     Initialises a new <see cref="Version" /> instance.
		/// </summary>
        public Version(UInt16 major, UInt16 minor, UInt16 month, UInt16 patch, UInt64 build)
        {
            _major = major;
            _minor = minor;
            _month = month;
            _patch = patch;
            _build = build;
        }
		
        #endregion		

        #region operators

        /// <summary>
        ///     Determines whether the first <see cref="Version" /> object is more than the second <see cref="Version" /> object.
        /// </summary>
        /// <param name="versionA">
        ///     The first <see cref="Version" /> object to be compared.
        /// </param>
        /// <param name="versionB">
        ///     The second <see cref="Version" /> object to be compared.
        /// </param>
        /// <returns>
        ///     true if <paramref name="versionA" /> is more than <paramref name="versionB" />; otherwise, false.
        /// </returns>
        public static Boolean operator >(Version versionA, Version versionB)
        {
            if (Object.ReferenceEquals(versionB, null))
                return !Object.ReferenceEquals(versionA, null);
            else
                return versionA.CompareTo(versionB) > 0;
        }

        /// <summary>
        ///     Determines whether the first <see cref="Version" /> object is more than or equal to the second <see cref="Version" /> object.
        /// </summary>
        /// <param name="versionA">
        ///     The first <see cref="Version" /> object to be compared.
        /// </param>
        /// <param name="versionB">
        ///     The second <see cref="Version" /> object to be compared.
        /// </param>
        /// <returns>
        ///     true if <paramref name="versionA" /> is more than or equal to <paramref name="versionB" />; otherwise, false.
        /// </returns>
        public static Boolean operator >=(Version versionA, Version versionB)
        {
            return versionA == versionB || versionA > versionB;   
        }

        /// <summary>
        ///     Determines whether the first <see cref="Version" /> object is less than the second <see cref="Version" /> object.
        /// </summary>
        /// <param name="versionA">
        ///     The first <see cref="Version" /> object to be compared.
        /// </param>
        /// <param name="versionB">
        ///     The second <see cref="Version" /> object to be compared.
        /// </param>
        /// <returns>
        ///     true if <paramref name="versionA" /> is less than <paramref name="versionB" />; otherwise, false.
        /// </returns>
        public static Boolean operator <(Version versionA, Version versionB)
        {
            if (Object.ReferenceEquals(versionA, null))
                return !Object.ReferenceEquals(versionB, null);
            else
                return versionA.CompareTo(versionB) < 0;
        }

        /// <summary>
        ///     Determines whether the first <see cref="Version" /> object is less than or equal to the second <see cref="Version" /> object.
        /// </summary>
        /// <param name="versionA">
        ///     The first <see cref="Version" /> object to be compared.
        /// </param>
        /// <param name="versionB">
        ///     The second <see cref="Version" /> object to be compared.
        /// </param>
        /// <returns>
        ///     true if <paramref name="versionA" /> is less than or equal to <paramref name="versionB" />; otherwise, false.
        /// </returns>
        public static Boolean operator <=(Version versionA, Version versionB)
        {
            return versionA == versionB || versionA < versionB;
        }

        /// <summary>
        ///     Determines whether the two specified <see cref="Version" /> objects are equal.
        /// </summary>
        /// <param name="versionA">
        ///     The first <see cref="Version" /> object to be compared.
        /// </param>
        /// <param name="versionB">
        ///     The second <see cref="Version" /> object to be compared.
        /// </param>
        /// <returns>
        ///     true if <paramref name="versionA" /> is equal to <paramref name="versionB" />; otherwise, false.
        /// </returns>
        public static Boolean operator ==(Version versionA, Version versionB)
        {
            return Object.ReferenceEquals(versionA, null) ? Object.ReferenceEquals(versionB, null) : versionA.Equals(versionB);
        }

        /// <summary>
        ///     Determines whether the two specified <see cref="Version" /> objects are inequal.
        /// </summary>
        /// <param name="versionA">
        ///     The first <see cref="Version" /> object to be compared.
        /// </param>
        /// <param name="versionB">
        ///     The second <see cref="Version" /> object to be compared.
        /// </param>
        /// <returns>
        ///     true if <paramref name="versionA" /> is inequal to <paramref name="versionB" />; otherwise, false.
        /// </returns>
        public static Boolean operator !=(Version versionA, Version versionB)
        {
            return !(versionA == versionB);
        }

        #endregion

        #region methods

        /// <summary>
        ///     Compares the current <see cref="Version" /> object to a specified object and returns an indication of their relative values.
        /// </summary>
        /// <param name="version">
        ///     An object to compare, or null.
        /// </param>
        /// <returns>
        ///     A signed integer that indicates the relative values of the two objects, as shown in the following table:
        ///     <list type="bullet">
        ///         <item>Less than zero - The current <see cref="Version" /> object is ealier than the <paramref name="other" /> <see cref="Version" /> specified.</item>
        ///         <item>Zero           - The current <see cref="Version" /> object is the same as the <paramref name="other" /> <see cref="Version" /> specified.</item>
        ///         <item>More than zero - The current <see cref="Version" /> object is later than the <paramref name="other" /> <see cref="Version" /> specified.</item>
        ///     </list>
        /// </returns>
        public Int32 CompareTo(Object other)
        {
            return (other is Version) ? this.CompareTo((Version)other) : 1;
        }

        /// <summary>
        ///     Compares the current <see cref="Version" /> object to a specified <see cref="Version" /> object and returns an indication of their relative values.
        /// </summary>
        /// <param name="value">
        ///     A <see cref="Version" /> object to compare to the current <see cref="Version" /> object, or null.
        /// </param>
        /// <returns>
        ///     A signed integer that indicates the relative values of the two objects, as shown in the following table:
        ///     <list type="bullet">
        ///         <item>Less than zero - The current <see cref="Version" /> object is ealier than the <paramref name="other" /> <see cref="Version" /> specified.</item>
        ///         <item>Zero           - The current <see cref="Version" /> object is the same as the <paramref name="other" /> <see cref="Version" /> specified.</item>
        ///         <item>More than zero - The current <see cref="Version" /> object is later than the <paramref name="other" /> <see cref="Version" /> specified.</item>
        ///     </list>
        /// </returns>
        public Int32 CompareTo(Version other)
        {
            if (this.Major != other.Major)
                return (this.Major > other.Major) ? 5 : -5;
            else if (this.Minor != other.Minor)
                return (this.Minor > other.Minor) ? 4 : -4;
            else if (this.Month != other.Month)
                return (this.Month > other.Month) ? 3 : -3;
            else if (this.Patch != other.Patch)
                return (this.Patch > other.Patch) ? 2 : -2;
            else if (this.Build != other.Build)
                return (this.Build > other.Build) ? 1 : -1;
            else
                return 0;
        }

        /// <summary>
        ///     Returns a value indicating whether the current <see cref="Version" /> object and a specified <see cref="Version" /> object represent the same value.
        /// </summary>
        /// <param name="other">
        ///     An object to compare, or null.
        /// </param>
        /// <returns>
        ///     true if every component of the current <see cref="Version" /> object matches the corresponding component of the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public override Boolean Equals(Object other)
        {
            return (other is Version) ? this.Equals((Version)other) : false;
        }

        /// <summary>
        ///     Returns a value indicating whether the current <see cref="Version" /> object and a specified <see cref="Version" /> object represent the same value.
        /// </summary>
        /// <param name="other">
        ///     A <see cref="Version" /> object to compare to the current <see cref="Version" /> object, or null.
        /// </param>
        /// <returns>
        ///     true if every component of the current <see cref="Version" /> object matches the corresponding component of the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public Boolean Equals(Version other)
        {
            return this.CompareTo(other) == 0;
        }

        /// <summary>
        ///     Returns a hash code for the current <see cref="Version" /> object.
        /// </summary>
        /// <returns>
        ///     A 32-bit signed integer hash code.
        /// </returns>
        public override Int32 GetHashCode()
        {
            Int32 hash = 43;
            unchecked
            {
                hash = hash * 79 + this.Major.GetHashCode();
                hash = hash * 79 + this.Minor.GetHashCode();
                hash = hash * 79 + this.Month.GetHashCode();
                hash = hash * 79 + this.Patch.GetHashCode();
                hash = hash * 79 + this.Build.GetHashCode();
            }
            return hash;
        }

        /// <summary>
        ///     Converts the value of the current <see cref="Version" /> object to its equivalent <see cref="String" /> representation.
        /// </summary>
        /// <returns>
        ///     The <see cref="String" /> representation of the values of the major, minor, revision and patch components of the current <see cref="Version" /> object.
        /// </returns>
        public override String ToString()
        {
            return this.ToString(5);
        }

        /// <summary>
        ///     Converts the value of the current <see cref="Version" /> object to its equivalent <see cref="String" /> representation.
        /// </summary>
        /// <param name="count">
        ///     The number of components to include.
        /// </param>
        /// <returns>
        ///     The <see cref="String" /> representation of the values of the major, minor, revision and patch components of the current <see cref="Version" /> object.
        /// </returns>
        public String ToString(Int32 count)
        {
            String[] allComponents = { this.Major.ToString(), this.Minor.ToString(), this.Month.ToString(), this.Patch.ToString(), this.Build.ToString() };
            String[] useComponents = allComponents.Take(Math.Min(Math.Max(count, 1), 5)).ToArray();
            return String.Join(".", useComponents);
        }

        #endregion
    }
}
