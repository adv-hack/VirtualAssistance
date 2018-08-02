using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Associate : Proxy<IAssociateModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AssociatedRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _associatedRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Role" /> member.
        /// </summary>
        private Consensus.Contact.Role _role;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        public Consensus.Contact.Role AssociatedRole
        {
            get
            {
                if (_associatedRole == null && this.Model.AssociatedRole != null)
                    _associatedRole = new Consensus.Contact.Role(this.Model.AssociatedRole);
                if (_associatedRole == null)
                    _associatedRole = Consensus.Contact.Role.Create();
                return _associatedRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        public System.String AssociatedRoleId
        {
            get { return this.Model.AssociatedRoleId; }
            set { this.Model.AssociatedRoleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Role
        {
            get
            {
                if (_role == null && this.Model.Role != null)
                    _role = new Consensus.Contact.Role(this.Model.Role);
                if (_role == null)
                    _role = Consensus.Contact.Role.Create();
                return _role;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_PROLE_ID" field.
        /// </summary>
        public System.String RoleId
        {
            get { return this.Model.RoleId; }
            set { this.Model.RoleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ASSO_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_TYPE" field.
        /// </summary>
        public System.Byte TypeNumber
        {
            get { return this.Model.TypeNumber; }
            set { this.Model.TypeNumber = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Associate(IAssociateModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:AssociateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AssociateModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Associate Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Associate.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AssociateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AssociateModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Associate Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IAssociateModel model = provider.Contact.Associate.Create();
            return model == null ? null : new Consensus.Contact.Associate(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AssociateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AssociateModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Associate> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Associate.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AssociateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AssociateModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Associate> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IAssociateModel> collection = provider.Contact.Associate.FetchAll();
            return collection.Select(model => new Consensus.Contact.Associate(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AssociateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AssociateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Associate FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Associate.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AssociateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AssociateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Associate FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IAssociateModel model = provider.Contact.Associate.FetchById(id);
            return model == null ? null : new Consensus.Contact.Associate(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Associate.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Associate.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="associatedRoleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="associatedRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Associate> FetchAllByAssociatedRoleId(System.String associatedRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Associate.FetchAllByAssociatedRoleId(site,associatedRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="associatedRoleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="associatedRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Associate> FetchAllByAssociatedRoleId(ConsensusSite site, System.String associatedRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IAssociateModel> collection = provider.Contact.Associate.FetchAllByAssociatedRoleId(associatedRoleId);
            return collection.Select(model => new Consensus.Contact.Associate(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Associate> FetchAllByRoleId(System.String roleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Associate.FetchAllByRoleId(site,roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Associate> FetchAllByRoleId(ConsensusSite site, System.String roleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IAssociateModel> collection = provider.Contact.Associate.FetchAllByRoleId(roleId);
            return collection.Select(model => new Consensus.Contact.Associate(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Associate> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Associate.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Associate> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IAssociateModel> collection = provider.Contact.Associate.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Contact.Associate(model));
        }

        #endregion
    }
}
