using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Document;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="BatchRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBatchModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "BAT_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_PROC" field.
        /// </summary>
        System.String Procedure
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_STATUS" field.
        /// </summary>
        System.String Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_COUNT" field.
        /// </summary>
        System.Nullable<System.Int32> BatchProcessedRecords
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_START_D_T" field.
        /// </summary>
        System.Nullable<System.DateTime> BatchStartedDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RUN_D_T" field.
        /// </summary>
        System.Nullable<System.DateTime> BatchFinishedDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RUN_BY" field.
        /// </summary>
        System.String BatchRunBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_NOTE" field.
        /// </summary>
        System.String BatchNote
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_ERROR_NOTE" field.
        /// </summary>
        System.String BatchErrorNote
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_EXT_FLAG" field.
        /// </summary>
        System.Nullable<System.Byte> ExternallyCompleted
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_DD_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> DdStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_REC_ID" field.
        /// </summary>
        System.String RecId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_RERUN" field.
        /// </summary>
        System.Byte Rerun
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BAT_EC_ID" field.
        /// </summary>
        Consensus.Other.IExportconfigurationsModel BatchEcId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_EC_ID" field.
        /// </summary>
        System.Nullable<System.Int32> BatchEcIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BAT_ARG_ID" field.
        /// </summary>
        System.String ArgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BAT_DI_ID" field.
        /// </summary>
        Consensus.Other.IDataimportsModel BatchDiId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BAT_DI_ID" field.
        /// </summary>
        System.Nullable<System.Int32> BatchDiIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:BatchModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Document.IPrintRequestModel> BatchPrintRequests
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchXrefModel" /> instances that reference this <see cref="!:BatchModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Other.IBatchXrefModel> BatchXref
        {
            get;
        }
    }
}
