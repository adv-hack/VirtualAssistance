using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "License_Limit" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class LicenseLimitRecord : Record<Int32>, Cloneable<LicenseLimitRecord>, IEquatable<LicenseLimitRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LL_LIC_ID" field.
        /// </summary>
        private Guid _licId;

        /// <summary>
        ///     the value of the "LL_TYPE" field.
        /// </summary>
        private Int32 _type;

        /// <summary>
        ///     the value of the "LL_VALUE" field.
        /// </summary>
        private Int32 _value;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LL_LIC_ID" field.
        /// </summary>
        public Guid LicId
        {
            get { return _licId; }
            set { _licId = value; }
        }

        /// <summary>
        ///     the value of the "LL_TYPE" field.
        /// </summary>
        public Int32 Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "LL_VALUE" field.
        /// </summary>
        public Int32 Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="LicenseLimitRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="LicenseLimitRecord" /> object instance.
        /// </returns>
        public LicenseLimitRecord Clone()
        {
            LicenseLimitRecord record = new LicenseLimitRecord();
            record.Id = this.Id;
            record.LicId = this.LicId;
            record.Type = this.Type;
            record.Value = this.Value;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="LicenseLimitRecord" /> instance is equal to another <see cref="LicenseLimitRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="LicenseLimitRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(LicenseLimitRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.LicId == that.LicId);
            result = result && (this.Type == that.Type);
            result = result && (this.Value == that.Value);
            return result;
        }

        #endregion
    }
}
