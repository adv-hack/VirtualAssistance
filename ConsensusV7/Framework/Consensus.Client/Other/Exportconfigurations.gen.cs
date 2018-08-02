using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Exportconfigurations : Proxy<IExportconfigurationsModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="BatchesExportConfigID" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Other.Batch, Consensus.Other.IBatchModel> _batchesExportConfigID;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "EC_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchModel" /> instances that reference this <see cref="!:ExportconfigurationsModel" />.
        /// </summary>
        public Collection<Consensus.Other.Batch> BatchesExportConfigID
        {
            get
            {
                if (_batchesExportConfigID == null)
                    _batchesExportConfigID = new ProxyCollection<Consensus.Other.Batch, Consensus.Other.IBatchModel>(this.Model.BatchesExportConfigID, model => new Consensus.Other.Batch(model));
                return _batchesExportConfigID;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Exportconfigurations(IExportconfigurationsModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ExportconfigurationsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ExportconfigurationsModel" /> instance.
        /// </returns>
        public static Consensus.Other.Exportconfigurations Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Exportconfigurations.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ExportconfigurationsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ExportconfigurationsModel" /> instance.
        /// </returns>
        public static Consensus.Other.Exportconfigurations Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IExportconfigurationsModel model = provider.Other.Exportconfigurations.Create();
            return model == null ? null : new Consensus.Other.Exportconfigurations(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ExportconfigurationsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ExportconfigurationsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.Exportconfigurations> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Exportconfigurations.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ExportconfigurationsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ExportconfigurationsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.Exportconfigurations> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IExportconfigurationsModel> collection = provider.Other.Exportconfigurations.FetchAll();
            return collection.Select(model => new Consensus.Other.Exportconfigurations(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ExportconfigurationsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ExportconfigurationsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ExportconfigurationsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.Exportconfigurations FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Exportconfigurations.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ExportconfigurationsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ExportconfigurationsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ExportconfigurationsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.Exportconfigurations FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IExportconfigurationsModel model = provider.Other.Exportconfigurations.FetchById(id);
            return model == null ? null : new Consensus.Other.Exportconfigurations(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Exportconfigurations.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Other.Exportconfigurations.GetTableName();
        }

        #endregion
    }
}
