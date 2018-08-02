using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ViewLog : Proxy<IViewLogModel, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "VIEW_TABLE" field.
        /// </summary>
        public System.String Table
        {
            get { return this.Model.Table; }
            set { this.Model.Table = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_REC_ID" field.
        /// </summary>
        public System.String RecId
        {
            get { return this.Model.RecId; }
            set { this.Model.RecId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_SOURCE" field.
        /// </summary>
        public System.Byte Source
        {
            get { return this.Model.Source; }
            set { this.Model.Source = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_REC_ID2" field.
        /// </summary>
        public System.String RecId2
        {
            get { return this.Model.RecId2; }
            set { this.Model.RecId2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_TABLE2" field.
        /// </summary>
        public System.String Table2
        {
            get { return this.Model.Table2; }
            set { this.Model.Table2 = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ViewLog(IViewLogModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ViewLogModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ViewLogModel" /> instance.
        /// </returns>
        public static Consensus.Common.ViewLog Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ViewLog.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ViewLogModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ViewLogModel" /> instance.
        /// </returns>
        public static Consensus.Common.ViewLog Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IViewLogModel model = provider.Common.ViewLog.Create();
            return model == null ? null : new Consensus.Common.ViewLog(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ViewLogModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ViewLogModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ViewLog> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ViewLog.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ViewLogModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ViewLogModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ViewLog> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IViewLogModel> collection = provider.Common.ViewLog.FetchAll();
            return collection.Select(model => new Consensus.Common.ViewLog(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ViewLogModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ViewLogModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ViewLogModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ViewLog FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ViewLog.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ViewLogModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ViewLogModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ViewLogModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ViewLog FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IViewLogModel model = provider.Common.ViewLog.FetchById(id);
            return model == null ? null : new Consensus.Common.ViewLog(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ViewLog.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.ViewLog.GetTableName();
        }

        #endregion
    }
}
