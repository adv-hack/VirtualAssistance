using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ProfileProduct : Proxy<IProfileProductModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PROF_PROD_ID" field.
        /// </summary>
        public Consensus.Learning.Product Product
        {
            get
            {
                if (_product == null && this.Model.Product != null)
                    _product = new Consensus.Learning.Product(this.Model.Product);
                if (_product == null)
                    _product = Consensus.Learning.Product.Create();
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_KEY" field.
        /// </summary>
        public System.String Key
        {
            get { return this.Model.Key; }
            set { this.Model.Key = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE" field.
        /// </summary>
        public System.String Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE3" field.
        /// </summary>
        public System.String Value3
        {
            get { return this.Model.Value3; }
            set { this.Model.Value3 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        public System.String Value2
        {
            get { return this.Model.Value2; }
            set { this.Model.Value2 = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ProfileProduct(IProfileProductModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProfileProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileProductModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileProduct Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileProduct.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProfileProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileProductModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileProduct Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileProductModel model = provider.Common.ProfileProduct.Create();
            return model == null ? null : new Consensus.Common.ProfileProduct(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileProductModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileProduct> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileProduct.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileProductModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileProduct> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileProductModel> collection = provider.Common.ProfileProduct.FetchAll();
            return collection.Select(model => new Consensus.Common.ProfileProduct(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileProduct FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileProduct.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileProduct FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileProductModel model = provider.Common.ProfileProduct.FetchById(id);
            return model == null ? null : new Consensus.Common.ProfileProduct(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileProduct.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.ProfileProduct.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ProfileProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileProduct> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileProduct.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ProfileProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileProduct> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileProductModel> collection = provider.Common.ProfileProduct.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Common.ProfileProduct(model));
        }

        #endregion
    }
}
