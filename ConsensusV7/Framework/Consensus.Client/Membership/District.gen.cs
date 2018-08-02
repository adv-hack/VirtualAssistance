using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Membership
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class District : Proxy<IDistrictModel, String>
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
        ///     The client-consumable proxy instance for the <see cref="Region" /> member.
        /// </summary>
        private Consensus.Common.Code _region;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CommiteeDistrict" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.Committee, Consensus.Membership.ICommitteeModel> _commiteeDistrict;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "DIS_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_STATUS" field.
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
        ///     Gets or sets the unique code for the value of the "DIS_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_TYPE" field.
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
        ///     Gets or sets the unique code for the value of the "DIS_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_CATEGORY" field.
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
        ///     Gets or sets the unique code for the value of the "DIS_CATEGORY" field.
        /// </summary>
        public System.String CategoryCode
        {
            get { return this.Model.CategoryCode; }
            set { this.Model.CategoryCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_GROUP" field.
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
        ///     Gets or sets the unique code for the value of the "DIS_GROUP" field.
        /// </summary>
        public System.String GroupCode
        {
            get { return this.Model.GroupCode; }
            set { this.Model.GroupCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_REGION" field.
        /// </summary>
        public Consensus.Common.Code Region
        {
            get
            {
                if (_region == null && this.Model.Region != null)
                    _region = new Consensus.Common.Code(this.Model.Region);
                if (_region == null)
                    _region = Consensus.Common.Code.Create();
                return _region;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_REGION" field.
        /// </summary>
        public System.String RegionCode
        {
            get { return this.Model.RegionCode; }
            set { this.Model.RegionCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DIS_WEB" field.
        /// </summary>
        public System.Byte Web
        {
            get { return this.Model.Web; }
            set { this.Model.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DIS_EXT_URL" field.
        /// </summary>
        public System.String ExtUrl
        {
            get { return this.Model.ExtUrl; }
            set { this.Model.ExtUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeModel" /> instances that reference this <see cref="!:DistrictModel" />.
        /// </summary>
        public Collection<Consensus.Membership.Committee> CommiteeDistrict
        {
            get
            {
                if (_commiteeDistrict == null)
                    _commiteeDistrict = new ProxyCollection<Consensus.Membership.Committee, Consensus.Membership.ICommitteeModel>(this.Model.CommiteeDistrict, model => new Consensus.Membership.Committee(model));
                return _commiteeDistrict;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal District(IDistrictModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:DistrictModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DistrictModel" /> instance.
        /// </returns>
        public static Consensus.Membership.District Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return District.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:DistrictModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DistrictModel" /> instance.
        /// </returns>
        public static Consensus.Membership.District Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IDistrictModel model = provider.Membership.District.Create();
            return model == null ? null : new Consensus.Membership.District(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DistrictModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DistrictModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.District> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return District.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DistrictModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DistrictModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.District> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IDistrictModel> collection = provider.Membership.District.FetchAll();
            return collection.Select(model => new Consensus.Membership.District(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DistrictModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DistrictModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DistrictModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.District FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return District.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DistrictModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DistrictModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DistrictModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.District FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IDistrictModel model = provider.Membership.District.FetchById(id);
            return model == null ? null : new Consensus.Membership.District(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return District.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.District.GetTableName();
        }

        #endregion
    }
}
