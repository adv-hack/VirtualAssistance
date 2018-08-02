using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "SystemMenusXRef" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SystemmenusxrefRecord : Record<Int32>, Cloneable<SystemmenusxrefRecord>, IEquatable<SystemmenusxrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        private Int32 _smenuId;

        /// <summary>
        ///     the value of the "SMXREF_MOD_ID" field.
        /// </summary>
        private Guid _modId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        public Int32 SmenuId
        {
            get { return _smenuId; }
            set { _smenuId = value; }
        }

        /// <summary>
        ///     the value of the "SMXREF_MOD_ID" field.
        /// </summary>
        public Guid ModId
        {
            get { return _modId; }
            set { _modId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SystemmenusxrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SystemmenusxrefRecord" /> object instance.
        /// </returns>
        public SystemmenusxrefRecord Clone()
        {
            SystemmenusxrefRecord record = new SystemmenusxrefRecord();
            record.Id = this.Id;
            record.SmenuId = this.SmenuId;
            record.ModId = this.ModId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SystemmenusxrefRecord" /> instance is equal to another <see cref="SystemmenusxrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SystemmenusxrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SystemmenusxrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.SmenuId == that.SmenuId);
            result = result && (this.ModId == that.ModId);
            return result;
        }

        #endregion
    }
}
