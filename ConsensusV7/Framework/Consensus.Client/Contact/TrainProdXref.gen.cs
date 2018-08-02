using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class TrainProdXref : Proxy<ITrainProdXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Trainer" /> member.
        /// </summary>
        private Consensus.Contact.Trainer _trainer;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_RCV_FROM" field.
        /// </summary>
        public System.String RcvFrom
        {
            get { return this.Model.RcvFrom; }
            set { this.Model.RcvFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_RCV_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> RcvDate
        {
            get { return this.Model.RcvDate; }
            set { this.Model.RcvDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        public Consensus.Contact.Trainer Trainer
        {
            get
            {
                if (_trainer == null && this.Model.Trainer != null)
                    _trainer = new Consensus.Contact.Trainer(this.Model.Trainer);
                if (_trainer == null)
                    _trainer = Consensus.Contact.Trainer.Create();
                return _trainer;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        public System.String TrainerId
        {
            get { return this.Model.TrainerId; }
            set { this.Model.TrainerId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_LOC_ID" field.
        /// </summary>
        public System.String LocId
        {
            get { return this.Model.LocId; }
            set { this.Model.LocId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TPXREF_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "TPXREF_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_STATUS" field.
        /// </summary>
        public System.String Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_GRADE" field.
        /// </summary>
        public System.String Grade
        {
            get { return this.Model.Grade; }
            set { this.Model.Grade = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_COST" field.
        /// </summary>
        public System.Nullable<System.Decimal> Cost
        {
            get { return this.Model.Cost; }
            set { this.Model.Cost = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal TrainProdXref(ITrainProdXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:TrainProdXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TrainProdXrefModel" /> instance.
        /// </returns>
        public static Consensus.Contact.TrainProdXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TrainProdXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:TrainProdXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TrainProdXrefModel" /> instance.
        /// </returns>
        public static Consensus.Contact.TrainProdXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ITrainProdXrefModel model = provider.Contact.TrainProdXref.Create();
            return model == null ? null : new Consensus.Contact.TrainProdXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TrainProdXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.TrainProdXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TrainProdXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TrainProdXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.TrainProdXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainProdXrefModel> collection = provider.Contact.TrainProdXref.FetchAll();
            return collection.Select(model => new Consensus.Contact.TrainProdXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TrainProdXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TrainProdXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.TrainProdXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TrainProdXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TrainProdXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TrainProdXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.TrainProdXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ITrainProdXrefModel model = provider.Contact.TrainProdXref.FetchById(id);
            return model == null ? null : new Consensus.Contact.TrainProdXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TrainProdXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.TrainProdXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instances that match the specified <paramref name="trainerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.TrainProdXref> FetchAllByTrainerId(System.String trainerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TrainProdXref.FetchAllByTrainerId(site,trainerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instances that match the specified <paramref name="trainerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.TrainProdXref> FetchAllByTrainerId(ConsensusSite site, System.String trainerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainProdXrefModel> collection = provider.Contact.TrainProdXref.FetchAllByTrainerId(trainerId);
            return collection.Select(model => new Consensus.Contact.TrainProdXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.TrainProdXref> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TrainProdXref.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.TrainProdXref> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITrainProdXrefModel> collection = provider.Contact.TrainProdXref.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Contact.TrainProdXref(model));
        }

        #endregion
    }
}
