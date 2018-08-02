using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;
using Consensus.Membership;
using Consensus.Other;
using Consensus.Portal;
using Consensus.Sales;
using Consensus.Security;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="SysParamsRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISellingCompanyModel : IModel<String>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "SP_SELL_COMP_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IRoleModel> Roles
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IOrganisationModel> Organisations
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> Locations
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Contact.ITrainerModel> TrainersSellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> Products
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> Opportunities
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackModel> PackSellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ILetterTemplateModel> LetterTemplates
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ICalMessageModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IICalMessageModel> iCalMessages
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SmsMessageModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ISmsMessageModel> SmsMessages
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> Accounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> Invoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> InvoiceLines
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CostCodeModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.ICostCodeModel> CostSelcoId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CurrencyModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.ICurrencyModel> Currencys
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IGiftaidclaimModel> GiftaidclaimsSellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SysConfigModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.ISysConfigModel> SysConfigSellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityModel> Activities
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> HelpDeskSellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserAccountModel> UserAccounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> MemberPeriods
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ICampaignModel> CampaignSellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Other.IBatchModel> Batches
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserModel> PortalUsers
        {
            get;
        }

        #endregion

        #region methods

        TValue GetConfiguration<TValue>(System.String name, TValue defaultValue);

        void SetConfiguration<TValue>(System.String name, Consensus.Common.SellingCompanyConfigTypes type, TValue value);

        #endregion
    }
}
