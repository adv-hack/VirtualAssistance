using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "License" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class LicenseRecord : Record<Guid>, Cloneable<LicenseRecord>, IEquatable<LicenseRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LIC_ACTIVE" field.
        /// </summary>
        private DateTime _active;

        /// <summary>
        ///     the value of the "LIC_EXPIRY" field.
        /// </summary>
        private DateTime? _expiry;

        /// <summary>
        ///     the value of the "LIC_OWNER" field.
        /// </summary>
        private String _owner;

        /// <summary>
        ///     the value of the "LIC_SIGNATURE" field.
        /// </summary>
        private Byte[] _signature;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LIC_ACTIVE" field.
        /// </summary>
        public DateTime Active
        {
            get { return _active; }
            set { _active = value; }
        }

        /// <summary>
        ///     the value of the "LIC_EXPIRY" field.
        /// </summary>
        public DateTime? Expiry
        {
            get { return _expiry; }
            set { _expiry = value; }
        }

        /// <summary>
        ///     the value of the "LIC_OWNER" field.
        /// </summary>
        public String Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        /// <summary>
        ///     the value of the "LIC_SIGNATURE" field.
        /// </summary>
        public Byte[] Signature
        {
            get { return _signature; }
            set { _signature = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="LicenseRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="LicenseRecord" /> object instance.
        /// </returns>
        public LicenseRecord Clone()
        {
            LicenseRecord record = new LicenseRecord();
            record.Id = this.Id;
            record.Active = this.Active;
            record.Expiry = this.Expiry;
            record.Owner = this.Owner;
            record.Signature = this.Signature;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="LicenseRecord" /> instance is equal to another <see cref="LicenseRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="LicenseRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(LicenseRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Active == that.Active);
            result = result && (this.Expiry == that.Expiry);
            result = result && (this.Owner.TrimOrNullify() == that.Owner.TrimOrNullify());
            result = result && (this.Signature == that.Signature);
            return result;
        }

        #endregion
    }
}
