using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Aka : Proxy<IAkaModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="OrgId" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _orgId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PnId" /> member.
        /// </summary>
        private Consensus.Contact.Person _pnId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "AKA_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "AKA_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "AKA_ORG_ID" field.
        /// </summary>
        public System.String OrgIdId
        {
            get { return this.Model.OrgIdId; }
            set { this.Model.OrgIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "AKA_PN_ID" field.
        /// </summary>
        public Consensus.Contact.Person PnId
        {
            get
            {
                if (_pnId == null && this.Model.PnId != null)
                    _pnId = new Consensus.Contact.Person(this.Model.PnId);
                if (_pnId == null)
                    _pnId = Consensus.Contact.Person.Create();
                return _pnId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "AKA_PN_ID" field.
        /// </summary>
        public System.String PnIdId
        {
            get { return this.Model.PnIdId; }
            set { this.Model.PnIdId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Aka(IAkaModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:AkaModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AkaModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Aka Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Aka.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AkaModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AkaModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Aka Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IAkaModel model = provider.Contact.Aka.Create();
            return model == null ? null : new Consensus.Contact.Aka(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AkaModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AkaModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Aka> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Aka.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AkaModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AkaModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Aka> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IAkaModel> collection = provider.Contact.Aka.FetchAll();
            return collection.Select(model => new Consensus.Contact.Aka(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AkaModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AkaModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Aka FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Aka.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AkaModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AkaModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Aka FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IAkaModel model = provider.Contact.Aka.FetchById(id);
            return model == null ? null : new Consensus.Contact.Aka(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Aka.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Aka.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AkaModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Aka> FetchAllByOrgIdId(System.String orgIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Aka.FetchAllByOrgIdId(site,orgIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AkaModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Aka> FetchAllByOrgIdId(ConsensusSite site, System.String orgIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IAkaModel> collection = provider.Contact.Aka.FetchAllByOrgIdId(orgIdId);
            return collection.Select(model => new Consensus.Contact.Aka(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AkaModel" /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instances that match the specified <paramref name="pnIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Aka> FetchAllByPnIdId(System.String pnIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Aka.FetchAllByPnIdId(site,pnIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AkaModel" /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instances that match the specified <paramref name="pnIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Aka> FetchAllByPnIdId(ConsensusSite site, System.String pnIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IAkaModel> collection = provider.Contact.Aka.FetchAllByPnIdId(pnIdId);
            return collection.Select(model => new Consensus.Contact.Aka(model));
        }

        #endregion
    }
}
