using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class MemberBom : Proxy<IMemberBomModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdParentId" /> member.
        /// </summary>
        private Consensus.Learning.Product _prodParentId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="GradeProd" /> member.
        /// </summary>
        private Consensus.Learning.Product _gradeProd;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "MBOM_PARENT_ID" field.
        /// </summary>
        public Consensus.Learning.Product ProdParentId
        {
            get
            {
                if (_prodParentId == null && this.Model.ProdParentId != null)
                    _prodParentId = new Consensus.Learning.Product(this.Model.ProdParentId);
                if (_prodParentId == null)
                    _prodParentId = Consensus.Learning.Product.Create();
                return _prodParentId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MBOM_PARENT_ID" field.
        /// </summary>
        public System.String ProdParentIdId
        {
            get { return this.Model.ProdParentIdId; }
            set { this.Model.ProdParentIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MBOM_PROD_ID" field.
        /// </summary>
        public System.String ProdId
        {
            get { return this.Model.ProdId; }
            set { this.Model.ProdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MBOM_GRADE_ID" field.
        /// </summary>
        public Consensus.Learning.Product GradeProd
        {
            get
            {
                if (_gradeProd == null && this.Model.GradeProd != null)
                    _gradeProd = new Consensus.Learning.Product(this.Model.GradeProd);
                if (_gradeProd == null)
                    _gradeProd = Consensus.Learning.Product.Create();
                return _gradeProd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MBOM_GRADE_ID" field.
        /// </summary>
        public System.String GradeProdId
        {
            get { return this.Model.GradeProdId; }
            set { this.Model.GradeProdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MBOM_MAIN" field.
        /// </summary>
        public System.Nullable<System.Byte> Main
        {
            get { return this.Model.Main; }
            set { this.Model.Main = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal MemberBom(IMemberBomModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Check if same grade already exist.
        /// </summary>
        /// <param name="parentProdId">
        ///     Parent product Id.
        /// </param>
        /// <param name="gradeId">
        ///     Existing Grade Id.
        /// </param>
        /// <param name="MBomId">
        ///     available Grade Id.
        /// </param>
        /// <returns>
        ///     returns true if same grade alraedy exists for memebershipProduct - parentProdId.
        /// </returns>
        public static System.Boolean CheckIfGradeExist(System.String parentProdId, System.String gradeId, System.String MBomId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberBom.CheckIfGradeExist(site,parentProdId,gradeId,MBomId);
        }

        /// <summary>
        ///     Check if same grade already exist.
        /// </summary>
        /// <param name="parentProdId">
        ///     Parent product Id.
        /// </param>
        /// <param name="gradeId">
        ///     Existing Grade Id.
        /// </param>
        /// <param name="MBomId">
        ///     available Grade Id.
        /// </param>
        /// <returns>
        ///     returns true if same grade alraedy exists for memebershipProduct - parentProdId.
        /// </returns>
        public static System.Boolean CheckIfGradeExist(ConsensusSite site, System.String parentProdId, System.String gradeId, System.String MBomId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.MemberBom.CheckIfGradeExist(parentProdId,gradeId,MBomId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberBomModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberBomModel" /> instance.
        /// </returns>
        public static Consensus.Membership.MemberBom Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberBom.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberBomModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberBomModel" /> instance.
        /// </returns>
        public static Consensus.Membership.MemberBom Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMemberBomModel model = provider.Membership.MemberBom.Create();
            return model == null ? null : new Consensus.Membership.MemberBom(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberBomModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberBomModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberBom> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberBom.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberBomModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberBomModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberBom> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberBomModel> collection = provider.Membership.MemberBom.FetchAll();
            return collection.Select(model => new Consensus.Membership.MemberBom(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberBomModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberBomModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.MemberBom FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberBom.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberBomModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberBomModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.MemberBom FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMemberBomModel model = provider.Membership.MemberBom.FetchById(id);
            return model == null ? null : new Consensus.Membership.MemberBom(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberBom.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.MemberBom.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberBomModel" /> instances.
        /// </summary>
        /// <param name="prodParentIdId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instances that match the specified <paramref name="prodParentIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberBom> FetchAllByProdParentIdId(System.String prodParentIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberBom.FetchAllByProdParentIdId(site,prodParentIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberBomModel" /> instances.
        /// </summary>
        /// <param name="prodParentIdId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instances that match the specified <paramref name="prodParentIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberBom> FetchAllByProdParentIdId(ConsensusSite site, System.String prodParentIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberBomModel> collection = provider.Membership.MemberBom.FetchAllByProdParentIdId(prodParentIdId);
            return collection.Select(model => new Consensus.Membership.MemberBom(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberBomModel" /> instances.
        /// </summary>
        /// <param name="gradeProdId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instances that match the specified <paramref name="gradeProdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberBom> FetchAllByGradeProdId(System.String gradeProdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MemberBom.FetchAllByGradeProdId(site,gradeProdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberBomModel" /> instances.
        /// </summary>
        /// <param name="gradeProdId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instances that match the specified <paramref name="gradeProdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.MemberBom> FetchAllByGradeProdId(ConsensusSite site, System.String gradeProdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMemberBomModel> collection = provider.Membership.MemberBom.FetchAllByGradeProdId(gradeProdId);
            return collection.Select(model => new Consensus.Membership.MemberBom(model));
        }

        #endregion
    }
}
