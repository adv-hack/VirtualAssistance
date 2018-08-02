using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Activities
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Helpdesk : Proxy<IHelpdeskModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="OrgId" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _orgId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProleId" /> member.
        /// </summary>
        private Consensus.Contact.Role _proleId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="GivenToId" /> member.
        /// </summary>
        private Consensus.Contact.Role _givenToId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DetailsId" /> member.
        /// </summary>
        private Consensus.Activities.C4text _detailsId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="FixId" /> member.
        /// </summary>
        private Consensus.Activities.C4text _fixId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="WipId" /> member.
        /// </summary>
        private Consensus.Activities.C4text _wipId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SelcoSpId" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _selcoSpId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PmId" /> member.
        /// </summary>
        private Consensus.Marketing.Promotion _pmId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "HD_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation OrgId
        {
            get
            {
                if (_orgId == null && this.Model.OrgId != null)
                    _orgId = new Consensus.Contact.Organisation(this.Model.OrgId);
                if (_orgId == null)
                    _orgId = Consensus.Contact.Organisation.Create();
                return _orgId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_ORG_ID" field.
        /// </summary>
        public System.String OrgIdId
        {
            get { return this.Model.OrgIdId; }
            set { this.Model.OrgIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_ORG_NAME" field.
        /// </summary>
        public System.String OrgName
        {
            get { return this.Model.OrgName; }
            set { this.Model.OrgName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role ProleId
        {
            get
            {
                if (_proleId == null && this.Model.ProleId != null)
                    _proleId = new Consensus.Contact.Role(this.Model.ProleId);
                if (_proleId == null)
                    _proleId = Consensus.Contact.Role.Create();
                return _proleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_PROLE_ID" field.
        /// </summary>
        public System.String ProleIdId
        {
            get { return this.Model.ProleIdId; }
            set { this.Model.ProleIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_PN_NAME" field.
        /// </summary>
        public System.String PnName
        {
            get { return this.Model.PnName; }
            set { this.Model.PnName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_GIVEN_TO" field.
        /// </summary>
        public System.String GivenTo
        {
            get { return this.Model.GivenTo; }
            set { this.Model.GivenTo = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        public Consensus.Contact.Role GivenToId
        {
            get
            {
                if (_givenToId == null && this.Model.GivenToId != null)
                    _givenToId = new Consensus.Contact.Role(this.Model.GivenToId);
                if (_givenToId == null)
                    _givenToId = Consensus.Contact.Role.Create();
                return _givenToId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        public System.String GivenToIdId
        {
            get { return this.Model.GivenToIdId; }
            set { this.Model.GivenToIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_STATUS" field.
        /// </summary>
        public System.String Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_DETAILS_ID" field.
        /// </summary>
        public Consensus.Activities.C4text DetailsId
        {
            get
            {
                if (_detailsId == null && this.Model.DetailsId != null)
                    _detailsId = new Consensus.Activities.C4text(this.Model.DetailsId);
                if (_detailsId == null)
                    _detailsId = Consensus.Activities.C4text.Create();
                return _detailsId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_DETAILS_ID" field.
        /// </summary>
        public System.String DetailsIdId
        {
            get { return this.Model.DetailsIdId; }
            set { this.Model.DetailsIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_FIX_ID" field.
        /// </summary>
        public Consensus.Activities.C4text FixId
        {
            get
            {
                if (_fixId == null && this.Model.FixId != null)
                    _fixId = new Consensus.Activities.C4text(this.Model.FixId);
                if (_fixId == null)
                    _fixId = Consensus.Activities.C4text.Create();
                return _fixId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_FIX_ID" field.
        /// </summary>
        public System.String FixIdId
        {
            get { return this.Model.FixIdId; }
            set { this.Model.FixIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_CATEGORY" field.
        /// </summary>
        public System.String Category
        {
            get { return this.Model.Category; }
            set { this.Model.Category = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_FIX_CAT" field.
        /// </summary>
        public System.String FixCat
        {
            get { return this.Model.FixCat; }
            set { this.Model.FixCat = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_CALL_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CallDate
        {
            get { return this.Model.CallDate; }
            set { this.Model.CallDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_SEVERITY" field.
        /// </summary>
        public System.String Severity
        {
            get { return this.Model.Severity; }
            set { this.Model.Severity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_WIP_ID" field.
        /// </summary>
        public Consensus.Activities.C4text WipId
        {
            get
            {
                if (_wipId == null && this.Model.WipId != null)
                    _wipId = new Consensus.Activities.C4text(this.Model.WipId);
                if (_wipId == null)
                    _wipId = Consensus.Activities.C4text.Create();
                return _wipId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_WIP_ID" field.
        /// </summary>
        public System.String WipIdId
        {
            get { return this.Model.WipIdId; }
            set { this.Model.WipIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_RES_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ResDate
        {
            get { return this.Model.ResDate; }
            set { this.Model.ResDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SelcoSpId
        {
            get
            {
                if (_selcoSpId == null && this.Model.SelcoSpId != null)
                    _selcoSpId = new Consensus.Common.SellingCompany(this.Model.SelcoSpId);
                if (_selcoSpId == null)
                    _selcoSpId = Consensus.Common.SellingCompany.Create();
                return _selcoSpId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        public System.String SelcoSpIdId
        {
            get { return this.Model.SelcoSpIdId; }
            set { this.Model.SelcoSpIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_PM_ID" field.
        /// </summary>
        public Consensus.Marketing.Promotion PmId
        {
            get
            {
                if (_pmId == null && this.Model.PmId != null)
                    _pmId = new Consensus.Marketing.Promotion(this.Model.PmId);
                if (_pmId == null)
                    _pmId = Consensus.Marketing.Promotion.Create();
                return _pmId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_PM_ID" field.
        /// </summary>
        public System.String PmIdId
        {
            get { return this.Model.PmIdId; }
            set { this.Model.PmIdId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Helpdesk(IHelpdeskModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:HelpdeskModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:HelpdeskModel" /> instance.
        /// </returns>
        public static Consensus.Activities.Helpdesk Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:HelpdeskModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:HelpdeskModel" /> instance.
        /// </returns>
        public static Consensus.Activities.Helpdesk Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IHelpdeskModel model = provider.Activities.Helpdesk.Create();
            return model == null ? null : new Consensus.Activities.Helpdesk(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:HelpdeskModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:HelpdeskModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:HelpdeskModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:HelpdeskModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAll();
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:HelpdeskModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:HelpdeskModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.Helpdesk FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:HelpdeskModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:HelpdeskModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.Helpdesk FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IHelpdeskModel model = provider.Activities.Helpdesk.FetchById(id);
            return model == null ? null : new Consensus.Activities.Helpdesk(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Activities.Helpdesk.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByOrgIdId(System.String orgIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAllByOrgIdId(site,orgIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByOrgIdId(ConsensusSite site, System.String orgIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAllByOrgIdId(orgIdId);
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByProleIdId(System.String proleIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAllByProleIdId(site,proleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByProleIdId(ConsensusSite site, System.String proleIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAllByProleIdId(proleIdId);
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="givenToIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="givenToIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByGivenToIdId(System.String givenToIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAllByGivenToIdId(site,givenToIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="givenToIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="givenToIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByGivenToIdId(ConsensusSite site, System.String givenToIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAllByGivenToIdId(givenToIdId);
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="detailsIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByDetailsIdId(System.String detailsIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAllByDetailsIdId(site,detailsIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="detailsIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByDetailsIdId(ConsensusSite site, System.String detailsIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAllByDetailsIdId(detailsIdId);
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="fixIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="fixIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByFixIdId(System.String fixIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAllByFixIdId(site,fixIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="fixIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="fixIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByFixIdId(ConsensusSite site, System.String fixIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAllByFixIdId(fixIdId);
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="wipIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="wipIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByWipIdId(System.String wipIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAllByWipIdId(site,wipIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="wipIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="wipIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByWipIdId(ConsensusSite site, System.String wipIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAllByWipIdId(wipIdId);
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="selcoSpIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllBySelcoSpIdId(System.String selcoSpIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAllBySelcoSpIdId(site,selcoSpIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="selcoSpIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllBySelcoSpIdId(ConsensusSite site, System.String selcoSpIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAllBySelcoSpIdId(selcoSpIdId);
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="pmIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="pmIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByPmIdId(System.String pmIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Helpdesk.FetchAllByPmIdId(site,pmIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="pmIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="pmIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Helpdesk> FetchAllByPmIdId(ConsensusSite site, System.String pmIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IHelpdeskModel> collection = provider.Activities.Helpdesk.FetchAllByPmIdId(pmIdId);
            return collection.Select(model => new Consensus.Activities.Helpdesk(model));
        }

        #endregion
    }
}
