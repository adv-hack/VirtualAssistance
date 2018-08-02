using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "License_Module" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class LicenseModuleRecord : Record<Int32>, Cloneable<LicenseModuleRecord>, IEquatable<LicenseModuleRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LM_LIC_ID" field.
        /// </summary>
        private Guid _licId;

        /// <summary>
        ///     the value of the "LM_MOD_ID" field.
        /// </summary>
        private Guid _modId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LM_LIC_ID" field.
        /// </summary>
        public Guid LicId
        {
            get { return _licId; }
            set { _licId = value; }
        }

        /// <summary>
        ///     the value of the "LM_MOD_ID" field.
        /// </summary>
        public Guid ModId
        {
            get { return _modId; }
            set { _modId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="LicenseModuleRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="LicenseModuleRecord" /> object instance.
        /// </returns>
        public LicenseModuleRecord Clone()
        {
            LicenseModuleRecord record = new LicenseModuleRecord();
            record.Id = this.Id;
            record.LicId = this.LicId;
            record.ModId = this.ModId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="LicenseModuleRecord" /> instance is equal to another <see cref="LicenseModuleRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="LicenseModuleRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(LicenseModuleRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.LicId == that.LicId);
            result = result && (this.ModId == that.ModId);
            return result;
        }

        #endregion
    }
}
