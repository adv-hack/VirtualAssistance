using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Dataimports : Proxy<IDataimportsModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="BatchesDataImportID" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Other.Batch, Consensus.Other.IBatchModel> _batchesDataImportID;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "DI_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DI_ACTIVE" field.
        /// </summary>
        public System.Nullable<System.Byte> Active
        {
            get { return this.Model.Active; }
            set { this.Model.Active = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchModel" /> instances that reference this <see cref="!:DataimportsModel" />.
        /// </summary>
        public Collection<Consensus.Other.Batch> BatchesDataImportID
        {
            get
            {
                if (_batchesDataImportID == null)
                    _batchesDataImportID = new ProxyCollection<Consensus.Other.Batch, Consensus.Other.IBatchModel>(this.Model.BatchesDataImportID, model => new Consensus.Other.Batch(model));
                return _batchesDataImportID;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Dataimports(IDataimportsModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:DataimportsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DataimportsModel" /> instance.
        /// </returns>
        public static Consensus.Other.Dataimports Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Dataimports.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:DataimportsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DataimportsModel" /> instance.
        /// </returns>
        public static Consensus.Other.Dataimports Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IDataimportsModel model = provider.Other.Dataimports.Create();
            return model == null ? null : new Consensus.Other.Dataimports(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DataimportsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DataimportsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.Dataimports> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Dataimports.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DataimportsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DataimportsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.Dataimports> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IDataimportsModel> collection = provider.Other.Dataimports.FetchAll();
            return collection.Select(model => new Consensus.Other.Dataimports(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DataimportsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DataimportsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DataimportsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.Dataimports FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Dataimports.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DataimportsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DataimportsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DataimportsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.Dataimports FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IDataimportsModel model = provider.Other.Dataimports.FetchById(id);
            return model == null ? null : new Consensus.Other.Dataimports(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Dataimports.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Other.Dataimports.GetTableName();
        }

        #endregion
    }
}
