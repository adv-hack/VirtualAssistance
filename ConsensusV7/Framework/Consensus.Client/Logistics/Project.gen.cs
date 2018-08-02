using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Marketing;

namespace Consensus.Logistics
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Project : Proxy<IProjectModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CampaignProject" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.Campaign, Consensus.Marketing.ICampaignModel> _campaignProject;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PROJ_STATUS" field.
        /// </summary>
        public System.String Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_ORG_ID" field.
        /// </summary>
        public System.String OrgId
        {
            get { return this.Model.OrgId; }
            set { this.Model.OrgId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_SELCO_SP_ID" field.
        /// </summary>
        public System.String SelcoSpId
        {
            get { return this.Model.SelcoSpId; }
            set { this.Model.SelcoSpId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:ProjectModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.Campaign> CampaignProject
        {
            get
            {
                if (_campaignProject == null)
                    _campaignProject = new ProxyCollection<Consensus.Marketing.Campaign, Consensus.Marketing.ICampaignModel>(this.Model.CampaignProject, model => new Consensus.Marketing.Campaign(model));
                return _campaignProject;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Project(IProjectModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProjectModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProjectModel" /> instance.
        /// </returns>
        public static Consensus.Logistics.Project Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Project.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProjectModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProjectModel" /> instance.
        /// </returns>
        public static Consensus.Logistics.Project Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Logistics.IProjectModel model = provider.Logistics.Project.Create();
            return model == null ? null : new Consensus.Logistics.Project(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProjectModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProjectModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Logistics.Project> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Project.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProjectModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProjectModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Logistics.Project> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Logistics.IProjectModel> collection = provider.Logistics.Project.FetchAll();
            return collection.Select(model => new Consensus.Logistics.Project(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProjectModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProjectModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProjectModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Logistics.Project FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Project.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProjectModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProjectModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProjectModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Logistics.Project FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Logistics.IProjectModel model = provider.Logistics.Project.FetchById(id);
            return model == null ? null : new Consensus.Logistics.Project(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Project.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Logistics.Project.GetTableName();
        }

        #endregion
    }
}
