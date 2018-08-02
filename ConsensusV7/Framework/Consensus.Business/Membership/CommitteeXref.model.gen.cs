using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="CommitteeXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommitteeXrefModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "COMXREF_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> AddDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COMXREF_COM_ID" field.
        /// </summary>
        Consensus.Membership.ICommitteeModel Committee
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMXREF_COM_ID" field.
        /// </summary>
        System.String CommitteeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_TABLE_NAME" field.
        /// </summary>
        System.String TableName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_RECORD_ID" field.
        /// </summary>
        System.String RecordId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_DISABLED" field.
        /// </summary>
        System.Nullable<System.Byte> Disabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_ROLE" field.
        /// </summary>
        System.String Role
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }
    }
}
