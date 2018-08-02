using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="MasterClubRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPrepayAccountModel : LocalModel<MasterClubRecord, String>, IPrepayAccountModel
    {
        #region fields

        /// <summary>
        ///     The value of the "MSTC_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "MSTC_CONTACT" field.
        /// </summary>
        private LocalRoleModel _contact;

        /// <summary>
        ///     The value of the "MSTC_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "MSTC_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "MSTC_MEP_ID" field.
        /// </summary>
        private LocalMemberPeriodModel _membership;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MasterClubRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.PrepayAccount.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MasterClubRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.PrepayAccount.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<MasterClubRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.PrepayAccount.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Organisation
        {
            get
            {
                if (_organisation == null && this.OrganisationId != null)
                    _organisation = this.Provider.Contact.Organisation.FetchById(this.OrganisationId);
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.Create();
                
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_ORG_ID" field.
        /// </summary>
        public String OrganisationId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _organisation = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_MEMB_VAL" field.
        /// </summary>
        public Decimal TotalPaidToDate
        {
            get { return this.ModifiedData.MembVal; }
            set { this.ModifiedData.MembVal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_CONTACT" field.
        /// </summary>
        public LocalRoleModel Contact
        {
            get
            {
                if (_contact == null && this.ContactId != null)
                    _contact = this.Provider.Contact.Role.FetchById(this.ContactId);
                if (_contact == null)
                    _contact = this.Provider.Contact.Role.Create();
                
                return _contact;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_CONTACT" field.
        /// </summary>
        public String ContactId
        {
            get { return this.ModifiedData.Contact; }
            set
            {
                if (this.ModifiedData.Contact != value)
                     _contact = null;
                this.ModifiedData.Contact = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_PAY_DATE" field.
        /// </summary>
        public DateTime? PayDate
        {
            get { return this.ModifiedData.PayDate; }
            set { this.ModifiedData.PayDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_TOT_POINTS" field.
        /// </summary>
        public Decimal TotalPoints
        {
            get { return this.ModifiedData.TotPoints; }
            set { this.ModifiedData.TotPoints = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_REMAIN_PTS" field.
        /// </summary>
        public Decimal RemainPts
        {
            get { return this.ModifiedData.RemainPts; }
            set { this.ModifiedData.RemainPts = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("MSTCS", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("MSTCS");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_STATUS" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.Status; }
            set
            {
                if (this.ModifiedData.Status != value)
                     _status = null;
                this.ModifiedData.Status = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_PROD_ID" field.
        /// </summary>
        public LocalProductModel Product
        {
            get
            {
                if (_product == null && this.ProductId != null)
                    _product = this.Provider.Learning.Product.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.Product.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_PROD_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _product = null;
                this.ModifiedData.ProdId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_STOP_FLAG" field.
        /// </summary>
        public Byte? Stopped
        {
            get { return this.ModifiedData.StopFlag; }
            set { this.ModifiedData.StopFlag = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAMED_USERS" field.
        /// </summary>
        public Byte? NamedUsers
        {
            get { return this.ModifiedData.NamedUsers; }
            set { this.ModifiedData.NamedUsers = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return this.ModifiedData.CurrencyType; }
            set { this.ModifiedData.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_MEP_ID" field.
        /// </summary>
        public LocalMemberPeriodModel Membership
        {
            get
            {
                if (_membership == null && this.MembershipId != null)
                    _membership = this.Provider.Membership.MemberPeriod.FetchById(this.MembershipId);
                if (_membership == null)
                    _membership = this.Provider.Membership.MemberPeriod.Create();
                
                return _membership;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_MEP_ID" field.
        /// </summary>
        public String MembershipId
        {
            get { return this.ModifiedData.MepId; }
            set
            {
                if (this.ModifiedData.MepId != value)
                     _membership = null;
                this.ModifiedData.MepId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAMED_BOOKERS" field.
        /// </summary>
        public Byte? NamedBookers
        {
            get { return this.ModifiedData.NamedBookers; }
            set { this.ModifiedData.NamedBookers = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_UNIQUE_REF" field.
        /// </summary>
        public String UniqueRef
        {
            get { return this.ModifiedData.UniqueRef; }
            set { this.ModifiedData.UniqueRef = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPrepayAccountModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPrepayAccountModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPrepayAccountModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPrepayAccountModel(LocalProvider provider, MasterClubRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status = _status.Value1;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_contact != null)
            {
                _contact.Save();
                this.ModifiedData.Contact = _contact.Id == null && this.ModifiedData.Contact != null ? "" : _contact.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
            if (_membership != null)
            {
                _membership.Save();
                this.ModifiedData.MepId = _membership.Id == null && this.ModifiedData.MepId != null ? "" : _membership.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "MSTC_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IPrepayAccountModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_ORG_ID" field.
        /// </summary>
        System.String IPrepayAccountModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_MEMB_VAL" field.
        /// </summary>
        System.Decimal IPrepayAccountModel.TotalPaidToDate
        {
            get { return this.TotalPaidToDate; }
            set { this.TotalPaidToDate = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_CONTACT" field.
        /// </summary>
        Consensus.Contact.IRoleModel IPrepayAccountModel.Contact
        {
            get { return this.Contact; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_CONTACT" field.
        /// </summary>
        System.String IPrepayAccountModel.ContactId
        {
            get { return this.ContactId; }
            set { this.ContactId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPrepayAccountModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_PAY_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPrepayAccountModel.PayDate
        {
            get { return this.PayDate; }
            set { this.PayDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_TOT_POINTS" field.
        /// </summary>
        System.Decimal IPrepayAccountModel.TotalPoints
        {
            get { return this.TotalPoints; }
            set { this.TotalPoints = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_REMAIN_PTS" field.
        /// </summary>
        System.Decimal IPrepayAccountModel.RemainPts
        {
            get { return this.RemainPts; }
            set { this.RemainPts = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IPrepayAccountModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_STATUS" field.
        /// </summary>
        System.String IPrepayAccountModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_TYPE" field.
        /// </summary>
        System.String IPrepayAccountModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IPrepayAccountModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_PROD_ID" field.
        /// </summary>
        System.String IPrepayAccountModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_STOP_FLAG" field.
        /// </summary>
        System.Nullable<System.Byte> IPrepayAccountModel.Stopped
        {
            get { return this.Stopped; }
            set { this.Stopped = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAMED_USERS" field.
        /// </summary>
        System.Nullable<System.Byte> IPrepayAccountModel.NamedUsers
        {
            get { return this.NamedUsers; }
            set { this.NamedUsers = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_CURRENCY_TYPE" field.
        /// </summary>
        System.String IPrepayAccountModel.CurrencyType
        {
            get { return this.CurrencyType; }
            set { this.CurrencyType = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel IPrepayAccountModel.Membership
        {
            get { return this.Membership; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_MEP_ID" field.
        /// </summary>
        System.String IPrepayAccountModel.MembershipId
        {
            get { return this.MembershipId; }
            set { this.MembershipId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAMED_BOOKERS" field.
        /// </summary>
        System.Nullable<System.Byte> IPrepayAccountModel.NamedBookers
        {
            get { return this.NamedBookers; }
            set { this.NamedBookers = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAME" field.
        /// </summary>
        System.String IPrepayAccountModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_UNIQUE_REF" field.
        /// </summary>
        System.String IPrepayAccountModel.UniqueRef
        {
            get { return this.UniqueRef; }
            set { this.UniqueRef = (System.String)value; }
        }

        #endregion
    }
}
