using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class OrganisationDepartment : Proxy<IOrganisationDepartmentModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "DEPT_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Organisation
        {
            get
            {
                if (_organisation == null && this.Model.Organisation != null)
                    _organisation = new Consensus.Contact.Organisation(this.Model.Organisation);
                if (_organisation == null)
                    _organisation = Consensus.Contact.Organisation.Create();
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEPT_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEPT_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal OrganisationDepartment(IOrganisationDepartmentModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </returns>
        public static Consensus.Contact.OrganisationDepartment Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationDepartment.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </returns>
        public static Consensus.Contact.OrganisationDepartment Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IOrganisationDepartmentModel model = provider.Contact.OrganisationDepartment.Create();
            return model == null ? null : new Consensus.Contact.OrganisationDepartment(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationDepartmentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationDepartmentModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationDepartment> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationDepartment.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationDepartmentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationDepartmentModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationDepartment> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IOrganisationDepartmentModel> collection = provider.Contact.OrganisationDepartment.FetchAll();
            return collection.Select(model => new Consensus.Contact.OrganisationDepartment(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationDepartmentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationDepartmentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.OrganisationDepartment FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationDepartment.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationDepartmentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationDepartmentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.OrganisationDepartment FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IOrganisationDepartmentModel model = provider.Contact.OrganisationDepartment.FetchById(id);
            return model == null ? null : new Consensus.Contact.OrganisationDepartment(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationDepartment.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.OrganisationDepartment.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationDepartmentModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OrganisationDepartmentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationDepartmentModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationDepartment> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationDepartment.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationDepartmentModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OrganisationDepartmentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationDepartmentModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationDepartment> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IOrganisationDepartmentModel> collection = provider.Contact.OrganisationDepartment.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Contact.OrganisationDepartment(model));
        }

        #endregion
    }
}
