using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="BranchXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBranchXrefModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "BRXREF_BR_ID" field.
        /// </summary>
        Consensus.Membership.IBranchModel Branch
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BRXREF_BR_ID" field.
        /// </summary>
        System.String BranchId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_TABLE_NAME" field.
        /// </summary>
        System.String TableName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_RECORD_ID" field.
        /// </summary>
        System.String RecordId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BRXREF_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BRXREF_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }
    }
}
