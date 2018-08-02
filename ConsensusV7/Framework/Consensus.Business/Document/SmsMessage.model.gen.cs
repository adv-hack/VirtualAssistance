using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="SmsMessageRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISmsMessageModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "SMS_SMT_ID" field.
        /// </summary>
        Consensus.Document.ISmsTypeModel SmsMessageType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMS_SMT_ID" field.
        /// </summary>
        System.Nullable<System.Int32> SmsMessageTypeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_TEXT" field.
        /// </summary>
        System.String Text
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_CURRENT" field.
        /// </summary>
        System.Nullable<System.Boolean> Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:SmsMessageModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackXrefModel> SmsId
        {
            get;
        }
    }
}
