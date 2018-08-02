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
    public partial class HistoryLink : Proxy<IHistoryLinkModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="User" /> member.
        /// </summary>
        private Consensus.Security.UserAccount _user;

        #endregion

        #region properties

        public System.Boolean IsModified
        {
            get { return this.Model.IsModified; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HL_MOD_DATE" field.
        /// </summary>
        public System.DateTime ModDate
        {
            get { return this.Model.ModDate; }
            set { this.Model.ModDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HL_USER_ID" field.
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
        ///     Gets or sets the unique code for the value of the "HL_USER_ID" field.
        /// </summary>
        public System.Int32 UserId
        {
            get { return this.Model.UserId; }
            set { this.Model.UserId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HL_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HL_URL" field.
        /// </summary>
        public System.String Url
        {
            get { return this.Model.Url; }
            set { this.Model.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HL_ICON" field.
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
        internal HistoryLink(IHistoryLinkModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public void SaveAndCleanUp()
        {
            this.Model.SaveAndCleanUp();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.HistoryLink FetchByUserIDAndURL(System.Int32 userId, System.String URL)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return HistoryLink.FetchByUserIDAndURL(site,userId,URL);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.HistoryLink FetchByUserIDAndURL(ConsensusSite site, System.Int32 userId, System.String URL)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IHistoryLinkModel model = provider.UserInterface.HistoryLink.FetchByUserIDAndURL(userId,URL);
            return model == null ? null : new Consensus.UserInterface.HistoryLink(model);
        }

        /// <summary>
        ///     Creates a new <see cref="!:HistoryLinkModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:HistoryLinkModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.HistoryLink Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return HistoryLink.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:HistoryLinkModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:HistoryLinkModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.HistoryLink Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IHistoryLinkModel model = provider.UserInterface.HistoryLink.Create();
            return model == null ? null : new Consensus.UserInterface.HistoryLink(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:HistoryLinkModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:HistoryLinkModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.HistoryLink> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return HistoryLink.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:HistoryLinkModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:HistoryLinkModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.HistoryLink> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IHistoryLinkModel> collection = provider.UserInterface.HistoryLink.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.HistoryLink(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:HistoryLinkModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:HistoryLinkModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HistoryLinkModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.HistoryLink FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return HistoryLink.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:HistoryLinkModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:HistoryLinkModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HistoryLinkModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.HistoryLink FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IHistoryLinkModel model = provider.UserInterface.HistoryLink.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.HistoryLink(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return HistoryLink.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.HistoryLink.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HistoryLinkModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:HistoryLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HistoryLinkModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.HistoryLink> FetchAllByUserId(System.Int32 userId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return HistoryLink.FetchAllByUserId(site,userId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HistoryLinkModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:HistoryLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HistoryLinkModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.HistoryLink> FetchAllByUserId(ConsensusSite site, System.Int32 userId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IHistoryLinkModel> collection = provider.UserInterface.HistoryLink.FetchAllByUserId(userId);
            return collection.Select(model => new Consensus.UserInterface.HistoryLink(model));
        }

        #endregion
    }
}
