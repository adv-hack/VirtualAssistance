using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Packtype : Proxy<IPacktypeModel, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_TYPE" field.
        /// </summary>
        public System.Byte Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_DESC" field.
        /// </summary>
        public System.String Desc
        {
            get { return this.Model.Desc; }
            set { this.Model.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_STORED_PROC" field.
        /// </summary>
        public System.String StoredProc
        {
            get { return this.Model.StoredProc; }
            set { this.Model.StoredProc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_URL" field.
        /// </summary>
        public System.String Url
        {
            get { return this.Model.Url; }
            set { this.Model.Url = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Packtype(IPacktypeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PacktypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PacktypeModel" /> instance.
        /// </returns>
        public static Consensus.Document.Packtype Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Packtype.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PacktypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PacktypeModel" /> instance.
        /// </returns>
        public static Consensus.Document.Packtype Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPacktypeModel model = provider.Document.Packtype.Create();
            return model == null ? null : new Consensus.Document.Packtype(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PacktypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PacktypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Packtype> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Packtype.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PacktypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PacktypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Packtype> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPacktypeModel> collection = provider.Document.Packtype.FetchAll();
            return collection.Select(model => new Consensus.Document.Packtype(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PacktypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PacktypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PacktypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Packtype FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Packtype.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PacktypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PacktypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PacktypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Packtype FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPacktypeModel model = provider.Document.Packtype.FetchById(id);
            return model == null ? null : new Consensus.Document.Packtype(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Packtype.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.Packtype.GetTableName();
        }

        #endregion
    }
}
