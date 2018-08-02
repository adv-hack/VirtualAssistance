using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PackRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPackModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "PACK_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> PackType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_EMAIL_SUBJECT" field.
        /// </summary>
        System.String EmailSubject
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_ACT_PQ_KEEP" field.
        /// </summary>
        System.Nullable<System.Byte> ActPqKeep
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        Consensus.Activities.IC4textModel PackEmailBody
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        System.String PackEmailBodyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_STATUS" field.
        /// </summary>
        System.Byte Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel PackSenderId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        System.String PackSenderIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_CATEGORY" field.
        /// </summary>
        System.String Category
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PACK_PQ_ID" field.
        /// </summary>
        Consensus.Document.IOutputQueueModel PackOutputQueueId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_PQ_ID" field.
        /// </summary>
        System.String PackOutputQueueIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_BCC_EMAIL" field.
        /// </summary>
        System.String BccEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_MDN_EMAIL" field.
        /// </summary>
        System.String MdnEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_DSN_EMAIL" field.
        /// </summary>
        System.String DsnEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACK_DSN_OPTIONS" field.
        /// </summary>
        System.String DsnOptions
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel PackSellingCompanyId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        System.String PackSellingCompanyIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CustomerPackModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ICustomerPackModel> CustomerPacks
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipJoiningPack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipRemind1Pack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipRemind2Pack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipRenewalPack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipLapsedPack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipCancelPack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipRemind3Pack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipRenewedPack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipAppPack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductMembershipModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IProductMembershipModel> MembershipOfferPack
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackProductModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackProductModel> PackProducts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackXrefModel> PackId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Document.IPrintRequestModel> PackPrintRequests
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> Accounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> Invoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:PackModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> SaqQueuePack
        {
            get;
        }
    }
}
