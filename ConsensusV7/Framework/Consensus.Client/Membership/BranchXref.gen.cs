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
    public partial class BranchXref : Proxy<IBranchXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Branch" /> member.
        /// </summary>
        private Consensus.Membership.Branch _branch;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "BRXREF_BR_ID" field.
        /// </summary>
        public Consensus.Membership.Branch Branch
        {
            get
            {
                if (_branch == null && this.Model.Branch != null)
                    _branch = new Consensus.Membership.Branch(this.Model.Branch);
                if (_branch == null)
                    _branch = Consensus.Membership.Branch.Create();
                return _branch;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BRXREF_BR_ID" field.
        /// </summary>
        public System.String BranchId
        {
            get { return this.Model.BranchId; }
            set { this.Model.BranchId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_TABLE_NAME" field.
        /// </summary>
        public System.String TableName
        {
            get { return this.Model.TableName; }
            set { this.Model.TableName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_RECORD_ID" field.
        /// </summary>
        public System.String RecordId
        {
            get { return this.Model.RecordId; }
            set { this.Model.RecordId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BRXREF_STATUS" field.
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
        ///     Gets or sets the unique code for the value of the "BRXREF_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BRXREF_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal BranchXref(IBranchXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Checks if district already exist for that branch in database.
        /// </summary>
        /// <param name="branchid">
        ///     BranchId.
        /// </param>
        /// <param name="districtid">
        ///     DistrictId.
        /// </param>
        /// <param name="branchxrefid">
        ///     BranchXrefId.
        /// </param>
        /// <returns>
        ///     Whether that district already exist for that branch in database.
        /// </returns>
        public static System.Boolean CheckIfDistrictExist(System.String branchid, System.String districtid, System.String branchxrefid)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BranchXref.CheckIfDistrictExist(site,branchid,districtid,branchxrefid);
        }

        /// <summary>
        ///     Checks if district already exist for that branch in database.
        /// </summary>
        /// <param name="branchid">
        ///     BranchId.
        /// </param>
        /// <param name="districtid">
        ///     DistrictId.
        /// </param>
        /// <param name="branchxrefid">
        ///     BranchXrefId.
        /// </param>
        /// <returns>
        ///     Whether that district already exist for that branch in database.
        /// </returns>
        public static System.Boolean CheckIfDistrictExist(ConsensusSite site, System.String branchid, System.String districtid, System.String branchxrefid)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.BranchXref.CheckIfDistrictExist(branchid,districtid,branchxrefid);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BranchXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BranchXrefModel" /> instance.
        /// </returns>
        public static Consensus.Membership.BranchXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BranchXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BranchXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BranchXrefModel" /> instance.
        /// </returns>
        public static Consensus.Membership.BranchXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IBranchXrefModel model = provider.Membership.BranchXref.Create();
            return model == null ? null : new Consensus.Membership.BranchXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BranchXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BranchXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.BranchXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BranchXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BranchXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BranchXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.BranchXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IBranchXrefModel> collection = provider.Membership.BranchXref.FetchAll();
            return collection.Select(model => new Consensus.Membership.BranchXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BranchXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BranchXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.BranchXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BranchXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BranchXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BranchXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.BranchXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IBranchXrefModel model = provider.Membership.BranchXref.FetchById(id);
            return model == null ? null : new Consensus.Membership.BranchXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BranchXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.BranchXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BranchXrefModel" /> instances.
        /// </summary>
        /// <param name="branchId">
        ///     The value which identifies the <see cref="!:BranchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchXrefModel" /> instances that match the specified <paramref name="branchId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.BranchXref> FetchAllByBranchId(System.String branchId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BranchXref.FetchAllByBranchId(site,branchId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BranchXrefModel" /> instances.
        /// </summary>
        /// <param name="branchId">
        ///     The value which identifies the <see cref="!:BranchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchXrefModel" /> instances that match the specified <paramref name="branchId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.BranchXref> FetchAllByBranchId(ConsensusSite site, System.String branchId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IBranchXrefModel> collection = provider.Membership.BranchXref.FetchAllByBranchId(branchId);
            return collection.Select(model => new Consensus.Membership.BranchXref(model));
        }

        #endregion
    }
}
