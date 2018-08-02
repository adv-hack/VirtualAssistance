using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Security;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class QuickAccessLink : Proxy<IQuickAccessLinkModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="User" /> member.
        /// </summary>
        private Consensus.Security.UserAccount _user;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "QAL_USER_ID" field.
        /// </summary>
        public Consensus.Security.UserAccount User
        {
            get
            {
                if (_user == null && this.Model.User != null)
                    _user = new Consensus.Security.UserAccount(this.Model.User);
                if (_user == null)
                    _user = Consensus.Security.UserAccount.Create();
                return _user;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QAL_USER_ID" field.
        /// </summary>
        public System.Int32 UserId
        {
            get { return this.Model.UserId; }
            set { this.Model.UserId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_URL" field.
        /// </summary>
        public System.String Url
        {
            get { return this.Model.Url; }
            set { this.Model.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_ICON" field.
        /// </summary>
        public System.String Icon
        {
            get { return this.Model.Icon; }
            set { this.Model.Icon = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal QuickAccessLink(IQuickAccessLinkModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:QuickAccessLinkModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:QuickAccessLinkModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.QuickAccessLink Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return QuickAccessLink.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:QuickAccessLinkModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:QuickAccessLinkModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.QuickAccessLink Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IQuickAccessLinkModel model = provider.UserInterface.QuickAccessLink.Create();
            return model == null ? null : new Consensus.UserInterface.QuickAccessLink(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:QuickAccessLinkModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:QuickAccessLinkModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.QuickAccessLink> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return QuickAccessLink.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:QuickAccessLinkModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:QuickAccessLinkModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.QuickAccessLink> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IQuickAccessLinkModel> collection = provider.UserInterface.QuickAccessLink.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.QuickAccessLink(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:QuickAccessLinkModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:QuickAccessLinkModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:QuickAccessLinkModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.QuickAccessLink FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return QuickAccessLink.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:QuickAccessLinkModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:QuickAccessLinkModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:QuickAccessLinkModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.QuickAccessLink FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IQuickAccessLinkModel model = provider.UserInterface.QuickAccessLink.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.QuickAccessLink(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return QuickAccessLink.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.QuickAccessLink.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:QuickAccessLinkModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:QuickAccessLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:QuickAccessLinkModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.QuickAccessLink> FetchAllByUserId(System.Int32 userId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return QuickAccessLink.FetchAllByUserId(site,userId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:QuickAccessLinkModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:QuickAccessLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:QuickAccessLinkModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.QuickAccessLink> FetchAllByUserId(ConsensusSite site, System.Int32 userId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IQuickAccessLinkModel> collection = provider.UserInterface.QuickAccessLink.FetchAllByUserId(userId);
            return collection.Select(model => new Consensus.UserInterface.QuickAccessLink(model));
        }

        #endregion
    }
}
