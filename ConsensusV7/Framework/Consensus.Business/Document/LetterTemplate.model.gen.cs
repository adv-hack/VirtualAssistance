using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="LettertmpltRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILetterTemplateModel : IModel<String>
    {
        /// <summary>
        ///     Gets the file type based of the template record.
        /// </summary>
        System.String FileType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LT_TYPE" field.
        /// </summary>
        Consensus.Document.ILetterTemplateTypeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_TYPE" field.
        /// </summary>
        System.String TypeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_FILE_NAME" field.
        /// </summary>
        System.String FileName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LT_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PRINT_ONLY" field.
        /// </summary>
        System.Nullable<System.Byte> PrintOnly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PDF" field.
        /// </summary>
        System.Nullable<System.Byte> Pdf
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel SendFrom
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        System.String SendFromId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_CURRENT" field.
        /// </summary>
        System.Byte Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_EMAIL_BODY" field.
        /// </summary>
        System.Byte EmailBody
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PQ_ID" field.
        /// </summary>
        System.String PqId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_ATT_ID" field.
        /// </summary>
        System.String AttId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_LABEL" field.
        /// </summary>
        System.Nullable<System.Byte> Label
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LiteratureModel" /> instances that reference this <see cref="!:LetterTemplateModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ILiteratureModel> LetterTemplateId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:LetterTemplateModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }
    }
}
