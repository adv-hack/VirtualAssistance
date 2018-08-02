using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SystemMenuXRef : Proxy<ISystemMenuXRefModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SystemMenu" /> member.
        /// </summary>
        private Consensus.UserInterface.SystemMenu _systemMenu;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        public Consensus.UserInterface.SystemMenu SystemMenu
        {
            get
            {
                if (_systemMenu == null && this.Model.SystemMenu != null)
                    _systemMenu = new Consensus.UserInterface.SystemMenu(this.Model.SystemMenu);
                if (_systemMenu == null)
                    _systemMenu = Consensus.UserInterface.SystemMenu.Create();
                return _systemMenu;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        public System.Int32 SystemMenuId
        {
            get { return this.Model.SystemMenuId; }
            set { this.Model.SystemMenuId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SystemMenuXRef(ISystemMenuXRefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SystemMenuXRefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SystemMenuXRefModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.SystemMenuXRef Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenuXRef.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SystemMenuXRefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SystemMenuXRefModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.SystemMenuXRef Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.ISystemMenuXRefModel model = provider.UserInterface.SystemMenuXRef.Create();
            return model == null ? null : new Consensus.UserInterface.SystemMenuXRef(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SystemMenuXRefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SystemMenuXRefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.SystemMenuXRef> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenuXRef.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SystemMenuXRefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SystemMenuXRefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.SystemMenuXRef> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.ISystemMenuXRefModel> collection = provider.UserInterface.SystemMenuXRef.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.SystemMenuXRef(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SystemMenuXRefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SystemMenuXRefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuXRefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.SystemMenuXRef FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenuXRef.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SystemMenuXRefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SystemMenuXRefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuXRefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.SystemMenuXRef FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.ISystemMenuXRefModel model = provider.UserInterface.SystemMenuXRef.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.SystemMenuXRef(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenuXRef.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.SystemMenuXRef.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SystemMenuXRefModel" /> instances.
        /// </summary>
        /// <param name="systemMenuId">
        ///     The value which identifies the <see cref="!:SystemMenuXRefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuXRefModel" /> instances that match the specified <paramref name="systemMenuId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.SystemMenuXRef> FetchAllBySystemMenuId(System.Int32 systemMenuId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SystemMenuXRef.FetchAllBySystemMenuId(site,systemMenuId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SystemMenuXRefModel" /> instances.
        /// </summary>
        /// <param name="systemMenuId">
        ///     The value which identifies the <see cref="!:SystemMenuXRefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuXRefModel" /> instances that match the specified <paramref name="systemMenuId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.SystemMenuXRef> FetchAllBySystemMenuId(ConsensusSite site, System.Int32 systemMenuId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.ISystemMenuXRefModel> collection = provider.UserInterface.SystemMenuXRef.FetchAllBySystemMenuId(systemMenuId);
            return collection.Select(model => new Consensus.UserInterface.SystemMenuXRef(model));
        }

        #endregion
    }
}
