using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ActLinkXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActLinkXrefModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        Consensus.Activities.IActivityModel Activity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        System.String ActivityId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTLINK_TABLE_NUM" field.
        /// </summary>
        System.Nullable<System.Double> TableNum
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTLINK_REC_ID" field.
        /// </summary>
        System.String RecordId
        {
            get;
            set;
        }
    }
}
