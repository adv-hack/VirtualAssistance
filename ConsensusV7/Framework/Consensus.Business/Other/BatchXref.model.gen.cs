using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="BatchXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBatchXrefModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the Link between the batch xref and batch.
        /// </summary>
        Consensus.Other.IBatchModel Batch
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for Link between the batch xref and batch.
        /// </summary>
        System.String BatchId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_RECORD_ID" field.
        /// </summary>
        System.String RecordId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_TABLE_NAME" field.
        /// </summary>
        System.String TableName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_LINK_ID" field.
        /// </summary>
        System.String LinkId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_LINK_URL" field.
        /// </summary>
        System.String LinkUrl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BATXR_STATUS" field.
        /// </summary>
        System.Byte Status
        {
            get;
            set;
        }
    }
}
