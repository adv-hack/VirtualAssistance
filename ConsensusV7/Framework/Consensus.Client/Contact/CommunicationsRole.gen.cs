using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents Comminication for the role.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class CommunicationsRole : Proxy<ICommunicationsRoleModel, Int64>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Role" /> member.
        /// </summary>
        private Consensus.Contact.Role _role;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Communication" /> member.
        /// </summary>
        private Consensus.Contact.Communications _communication;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "COMMXREF_RECORD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "COMMXREF_RECORD_ID" field.
        /// </summary>
        public System.String RoleId
        {
            get { return this.Model.RoleId; }
            set { this.Model.RoleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        public Consensus.Contact.Communications Communication
        {
            get
            {
                if (_communication == null && this.Model.Communication != null)
                    _communication = new Consensus.Contact.Communications(this.Model.Communication);
                if (_communication == null)
                    _communication = Consensus.Contact.Communications.Create();
                return _communication;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        public System.Int64 CommunicationId
        {
            get { return this.Model.CommunicationId; }
            set { this.Model.CommunicationId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal CommunicationsRole(ICommunicationsRoleModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:CommunicationsRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommunicationsRoleModel" /> instance.
        /// </returns>
        public static Consensus.Contact.CommunicationsRole Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommunicationsRole.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CommunicationsRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommunicationsRoleModel" /> instance.
        /// </returns>
        public static Consensus.Contact.CommunicationsRole Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICommunicationsRoleModel model = provider.Contact.CommunicationsRole.Create();
            return model == null ? null : new Consensus.Contact.CommunicationsRole(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommunicationsRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CommunicationsRole> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommunicationsRole.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommunicationsRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CommunicationsRole> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICommunicationsRoleModel> collection = provider.Contact.CommunicationsRole.FetchAll();
            return collection.Select(model => new Consensus.Contact.CommunicationsRole(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommunicationsRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommunicationsRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.CommunicationsRole FetchById(System.Int64 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommunicationsRole.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommunicationsRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommunicationsRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.CommunicationsRole FetchById(ConsensusSite site, System.Int64 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICommunicationsRoleModel model = provider.Contact.CommunicationsRole.FetchById(id);
            return model == null ? null : new Consensus.Contact.CommunicationsRole(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommunicationsRole.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.CommunicationsRole.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:CommunicationsRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CommunicationsRole> FetchAllByRoleId(System.String roleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommunicationsRole.FetchAllByRoleId(site,roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:CommunicationsRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CommunicationsRole> FetchAllByRoleId(ConsensusSite site, System.String roleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICommunicationsRoleModel> collection = provider.Contact.CommunicationsRole.FetchAllByRoleId(roleId);
            return collection.Select(model => new Consensus.Contact.CommunicationsRole(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref="!:CommunicationsRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instances that match the specified <paramref name="communicationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CommunicationsRole> FetchAllByCommunicationId(System.Int64 communicationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommunicationsRole.FetchAllByCommunicationId(site,communicationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref="!:CommunicationsRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instances that match the specified <paramref name="communicationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CommunicationsRole> FetchAllByCommunicationId(ConsensusSite site, System.Int64 communicationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICommunicationsRoleModel> collection = provider.Contact.CommunicationsRole.FetchAllByCommunicationId(communicationId);
            return collection.Select(model => new Consensus.Contact.CommunicationsRole(model));
        }

        #endregion
    }
}
