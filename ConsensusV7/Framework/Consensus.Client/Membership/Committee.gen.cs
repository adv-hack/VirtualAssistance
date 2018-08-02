using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Committee : Proxy<ICommitteeModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Category" /> member.
        /// </summary>
        private Consensus.Common.Code _category;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Group" /> member.
        /// </summary>
        private Consensus.Common.Code _group;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DisId" /> member.
        /// </summary>
        private Consensus.Membership.District _disId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdId" /> member.
        /// </summary>
        private Consensus.Learning.Product _prodId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BrId" /> member.
        /// </summary>
        private Consensus.Membership.Branch _brId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CommitteeXrefCommitteeId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.CommitteeXref, Consensus.Membership.ICommitteeXrefModel> _committeeXrefCommitteeId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "COM_ADD_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> AddDate
        {
            get { return this.Model.AddDate; }
            set { this.Model.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_STATUS" field.
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
        ///     Gets or sets the unique code for the value of the "COM_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_TYPE" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_CATEGORY" field.
        /// </summary>
        public Consensus.Common.Code Category
        {
            get
            {
                if (_category == null && this.Model.Category != null)
                    _category = new Consensus.Common.Code(this.Model.Category);
                if (_category == null)
                    _category = Consensus.Common.Code.Create();
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_CATEGORY" field.
        /// </summary>
        public System.String CategoryCode
        {
            get { return this.Model.CategoryCode; }
            set { this.Model.CategoryCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_GROUP" field.
        /// </summary>
        public Consensus.Common.Code Group
        {
            get
            {
                if (_group == null && this.Model.Group != null)
                    _group = new Consensus.Common.Code(this.Model.Group);
                if (_group == null)
                    _group = Consensus.Common.Code.Create();
                return _group;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_GROUP" field.
        /// </summary>
        public System.String GroupCode
        {
            get { return this.Model.GroupCode; }
            set { this.Model.GroupCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_DIS_ID" field.
        /// </summary>
        public Consensus.Membership.District DisId
        {
            get
            {
                if (_disId == null && this.Model.DisId != null)
                    _disId = new Consensus.Membership.District(this.Model.DisId);
                if (_disId == null)
                    _disId = Consensus.Membership.District.Create();
                return _disId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_DIS_ID" field.
        /// </summary>
        public System.String DisIdId
        {
            get { return this.Model.DisIdId; }
            set { this.Model.DisIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "COM_PROD_ID" field.
        /// </summary>
        public System.String ProdIdId
        {
            get { return this.Model.ProdIdId; }
            set { this.Model.ProdIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_BR_ID" field.
        /// </summary>
        public Consensus.Membership.Branch BrId
        {
            get
            {
                if (_brId == null && this.Model.BrId != null)
                    _brId = new Consensus.Membership.Branch(this.Model.BrId);
                if (_brId == null)
                    _brId = Consensus.Membership.Branch.Create();
                return _brId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_BR_ID" field.
        /// </summary>
        public System.String BrIdId
        {
            get { return this.Model.BrIdId; }
            set { this.Model.BrIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_EXT_URL" field.
        /// </summary>
        public System.String ExtUrl
        {
            get { return this.Model.ExtUrl; }
            set { this.Model.ExtUrl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_SHOW_ON_ORG" field.
        /// </summary>
        public System.Nullable<System.Byte> ShowOnOrg
        {
            get { return this.Model.ShowOnOrg; }
            set { this.Model.ShowOnOrg = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_NO_PEOPLE" field.
        /// </summary>
        public System.Nullable<System.Int32> NoPeople
        {
            get { return this.Model.NoPeople; }
            set { this.Model.NoPeople = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeXrefModel" /> instances that reference this <see cref="!:CommitteeModel" />.
        /// </summary>
        public Collection<Consensus.Membership.CommitteeXref> CommitteeXrefCommitteeId
        {
            get
            {
                if (_committeeXrefCommitteeId == null)
                    _committeeXrefCommitteeId = new ProxyCollection<Consensus.Membership.CommitteeXref, Consensus.Membership.ICommitteeXrefModel>(this.Model.CommitteeXrefCommitteeId, model => new Consensus.Membership.CommitteeXref(model));
                return _committeeXrefCommitteeId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Committee(ICommitteeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:CommitteeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommitteeModel" /> instance.
        /// </returns>
        public static Consensus.Membership.Committee Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Committee.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CommitteeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommitteeModel" /> instance.
        /// </returns>
        public static Consensus.Membership.Committee Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.ICommitteeModel model = provider.Membership.Committee.Create();
            return model == null ? null : new Consensus.Membership.Committee(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommitteeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommitteeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Committee> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Committee.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommitteeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommitteeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Committee> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.ICommitteeModel> collection = provider.Membership.Committee.FetchAll();
            return collection.Select(model => new Consensus.Membership.Committee(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommitteeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommitteeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.Committee FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Committee.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommitteeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommitteeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.Committee FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.ICommitteeModel model = provider.Membership.Committee.FetchById(id);
            return model == null ? null : new Consensus.Membership.Committee(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Committee.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.Committee.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="disIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="disIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Committee> FetchAllByDisIdId(System.String disIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Committee.FetchAllByDisIdId(site,disIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="disIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="disIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Committee> FetchAllByDisIdId(ConsensusSite site, System.String disIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.ICommitteeModel> collection = provider.Membership.Committee.FetchAllByDisIdId(disIdId);
            return collection.Select(model => new Consensus.Membership.Committee(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="prodIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Committee> FetchAllByProdIdId(System.String prodIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Committee.FetchAllByProdIdId(site,prodIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="prodIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Committee> FetchAllByProdIdId(ConsensusSite site, System.String prodIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.ICommitteeModel> collection = provider.Membership.Committee.FetchAllByProdIdId(prodIdId);
            return collection.Select(model => new Consensus.Membership.Committee(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="brIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="brIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Committee> FetchAllByBrIdId(System.String brIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Committee.FetchAllByBrIdId(site,brIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="brIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="brIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Committee> FetchAllByBrIdId(ConsensusSite site, System.String brIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.ICommitteeModel> collection = provider.Membership.Committee.FetchAllByBrIdId(brIdId);
            return collection.Select(model => new Consensus.Membership.Committee(model));
        }

        #endregion
    }
}
