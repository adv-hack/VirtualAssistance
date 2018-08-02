using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SystemMenu : Proxy<ISystemMenuModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Parent" /> member.
        /// </summary>
        private Consensus.UserInterface.SystemMenu _parent;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SystemMenus" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.SystemMenu, Consensus.UserInterface.ISystemMenuModel> _systemMenus;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Modules" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.SystemMenuXRef, Consensus.UserInterface.ISystemMenuXRefModel> _modules;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "SMENU_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_URL" field.
        /// </summary>
        public System.String Page
        {
            get { return this.Model.Page; }
            set { this.Model.Page = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_GROUP" field.
        /// </summary>
        public System.String Group
        {
            get { return this.Model.Group; }
            set { this.Model.Group = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_ICON" field.
        /// </summary>
        public System.String Icon
        {
            get { return this.Model.Icon; }
            set { this.Model.Icon = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_RELATIVE_PATH" field.
        /// </summary>
        public System.String RelativePath
        {
            get { return this.Model.RelativePath; }
            set { this.Model.RelativePath = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SMENU_SMENU_ID" field.
        /// </summary>
        public Consensus.UserInterface.SystemMenu Parent
        {
            get
            {
                if (_parent == null && this.Model.Parent != null)
                    _parent = new Consensus.UserInterface.SystemMenu(this.Model.Parent);
                if (_parent == null)
                    _parent = Consensus.UserInterface.SystemMenu.Create();
                return _parent;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMENU_SMENU_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> ParentId
        {
            get { return this.Model.ParentId; }
            set { this.Model.ParentId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SystemMenuModel" /> instances that reference this <see cref="!:SystemMenuModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.SystemMenu> SystemMenus
        {
            get
            {
                if (_systemMenus == null)
                    _systemMenus = new ProxyCollection<Consensus.UserInterface.SystemMenu, Consensus.UserInterface.ISystemMenuModel>(this.Model.SystemMenus, model => new Consensus.UserInterface.SystemMenu(model));
                return _systemMenus;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SystemMenuXRefModel" /> instances that reference this <see cref="!:SystemMenuModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.SystemMenuXRef> Modules
        {
            get
            {
                if (_modules == null)
                    _modules = new ProxyCollection<Consensus.UserInterface.SystemMenuXRef, Consensus.UserInterface.ISystemMenuXRefModel>(this.Model.Modules, model => new Consensus.UserInterface.SystemMenuXRef(model));
                return _modules;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SystemMenu(ISystemMenuModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SystemMenuModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SystemMenuModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.SystemMenu Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenu.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SystemMenuModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SystemMenuModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.SystemMenu Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.ISystemMenuModel model = provider.UserInterface.SystemMenu.Create();
            return model == null ? null : new Consensus.UserInterface.SystemMenu(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SystemMenuModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SystemMenuModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.SystemMenu> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenu.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SystemMenuModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SystemMenuModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.SystemMenu> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.ISystemMenuModel> collection = provider.UserInterface.SystemMenu.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.SystemMenu(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SystemMenuModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SystemMenuModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.SystemMenu FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenu.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SystemMenuModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SystemMenuModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.SystemMenu FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.ISystemMenuModel model = provider.UserInterface.SystemMenu.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.SystemMenu(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenu.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.SystemMenu.GetTableName();
        }

        public static IEnumerable<Consensus.UserInterface.SystemMenu> FetchAllByParentId(System.Nullable<System.Int32> parentId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenu.FetchAllByParentId(site,parentId);
        }

        public static IEnumerable<Consensus.UserInterface.SystemMenu> FetchAllByParentId(ConsensusSite site, System.Nullable<System.Int32> parentId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.ISystemMenuModel> collection = provider.UserInterface.SystemMenu.FetchAllByParentId(parentId);
            return collection.Select(model => new Consensus.UserInterface.SystemMenu(model));
        }

        #endregion
    }
}
