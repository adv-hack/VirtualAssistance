using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ProdSelectGroup : Proxy<IProdSelectGroupModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdId" /> member.
        /// </summary>
        private Consensus.Learning.Product _prodId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="BOMSelectGroup" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.BillOfMaterial, Consensus.Learning.IBillOfMaterialModel> _bOMSelectGroup;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CourseSelectionGroups" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.CourseSelectGroups, Consensus.Learning.ICourseSelectGroupsModel> _courseSelectionGroups;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PSG_PROD_ID" field.
        /// </summary>
        public Consensus.Learning.Product ProdId
        {
            get
            {
                if (_prodId == null && this.Model.ProdId != null)
                    _prodId = new Consensus.Learning.Product(this.Model.ProdId);
                if (_prodId == null)
                    _prodId = Consensus.Learning.Product.Create();
                return _prodId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PSG_PROD_ID" field.
        /// </summary>
        public System.String ProdIdId
        {
            get { return this.Model.ProdIdId; }
            set { this.Model.ProdIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_TYPE" field.
        /// </summary>
        public System.Byte Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_MIN" field.
        /// </summary>
        public System.Byte Min
        {
            get { return this.Model.Min; }
            set { this.Model.Min = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_MAX" field.
        /// </summary>
        public System.Byte Max
        {
            get { return this.Model.Max; }
            set { this.Model.Max = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_ORDER" field.
        /// </summary>
        public System.Byte Order
        {
            get { return this.Model.Order; }
            set { this.Model.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_ERROR_MESSAGE" field.
        /// </summary>
        public System.String ErrorMessage
        {
            get { return this.Model.ErrorMessage; }
            set { this.Model.ErrorMessage = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProdSelectGroupModel" />.
        /// </summary>
        public Collection<Consensus.Learning.BillOfMaterial> BOMSelectGroup
        {
            get
            {
                if (_bOMSelectGroup == null)
                    _bOMSelectGroup = new ProxyCollection<Consensus.Learning.BillOfMaterial, Consensus.Learning.IBillOfMaterialModel>(this.Model.BOMSelectGroup, model => new Consensus.Learning.BillOfMaterial(model));
                return _bOMSelectGroup;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CourseSelectGroupsModel" /> instances that reference this <see cref="!:ProdSelectGroupModel" />.
        /// </summary>
        public Collection<Consensus.Learning.CourseSelectGroups> CourseSelectionGroups
        {
            get
            {
                if (_courseSelectionGroups == null)
                    _courseSelectionGroups = new ProxyCollection<Consensus.Learning.CourseSelectGroups, Consensus.Learning.ICourseSelectGroupsModel>(this.Model.CourseSelectionGroups, model => new Consensus.Learning.CourseSelectGroups(model));
                return _courseSelectionGroups;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ProdSelectGroup(IProdSelectGroupModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProdSelectGroupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProdSelectGroupModel" /> instance.
        /// </returns>
        public static Consensus.Learning.ProdSelectGroup Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProdSelectGroup.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProdSelectGroupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProdSelectGroupModel" /> instance.
        /// </returns>
        public static Consensus.Learning.ProdSelectGroup Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IProdSelectGroupModel model = provider.Learning.ProdSelectGroup.Create();
            return model == null ? null : new Consensus.Learning.ProdSelectGroup(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProdSelectGroupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProdSelectGroupModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProdSelectGroup> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProdSelectGroup.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProdSelectGroupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProdSelectGroupModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProdSelectGroup> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProdSelectGroupModel> collection = provider.Learning.ProdSelectGroup.FetchAll();
            return collection.Select(model => new Consensus.Learning.ProdSelectGroup(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProdSelectGroupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProdSelectGroupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProdSelectGroupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.ProdSelectGroup FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProdSelectGroup.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProdSelectGroupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProdSelectGroupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProdSelectGroupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.ProdSelectGroup FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IProdSelectGroupModel model = provider.Learning.ProdSelectGroup.FetchById(id);
            return model == null ? null : new Consensus.Learning.ProdSelectGroup(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProdSelectGroup.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.ProdSelectGroup.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProdSelectGroupModel" /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref="!:ProdSelectGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProdSelectGroupModel" /> instances that match the specified <paramref name="prodIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProdSelectGroup> FetchAllByProdIdId(System.String prodIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProdSelectGroup.FetchAllByProdIdId(site,prodIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProdSelectGroupModel" /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref="!:ProdSelectGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProdSelectGroupModel" /> instances that match the specified <paramref name="prodIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProdSelectGroup> FetchAllByProdIdId(ConsensusSite site, System.String prodIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProdSelectGroupModel> collection = provider.Learning.ProdSelectGroup.FetchAllByProdIdId(prodIdId);
            return collection.Select(model => new Consensus.Learning.ProdSelectGroup(model));
        }

        #endregion
    }
}
