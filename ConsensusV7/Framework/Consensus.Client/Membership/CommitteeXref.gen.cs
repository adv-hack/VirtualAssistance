using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class CommitteeXref : Proxy<ICommitteeXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Committee" /> member.
        /// </summary>
        private Consensus.Membership.Committee _committee;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_ADD_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> AddDate
        {
            get { return this.Model.AddDate; }
            set { this.Model.AddDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COMXREF_COM_ID" field.
        /// </summary>
        public Consensus.Membership.Committee Committee
        {
            get
            {
                if (_committee == null && this.Model.Committee != null)
                    _committee = new Consensus.Membership.Committee(this.Model.Committee);
                if (_committee == null)
                    _committee = Consensus.Membership.Committee.Create();
                return _committee;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMXREF_COM_ID" field.
        /// </summary>
        public System.String CommitteeId
        {
            get { return this.Model.CommitteeId; }
            set { this.Model.CommitteeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_TABLE_NAME" field.
        /// </summary>
        public System.String TableName
        {
            get { return this.Model.TableName; }
            set { this.Model.TableName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_RECORD_ID" field.
        /// </summary>
        public System.String RecordId
        {
            get { return this.Model.RecordId; }
            set { this.Model.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_DISABLED" field.
        /// </summary>
        public System.Nullable<System.Byte> Disabled
        {
            get { return this.Model.Disabled; }
            set { this.Model.Disabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_ROLE" field.
        /// </summary>
        public System.String Role
        {
            get { return this.Model.Role; }
            set { this.Model.Role = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal CommitteeXref(ICommitteeXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public static System.Boolean CheckIfPersonExist(System.String committeeid, System.String personid, System.String committeexrefid)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommitteeXref.CheckIfPersonExist(site,committeeid,personid,committeexrefid);
        }

        public static System.Boolean CheckIfPersonExist(ConsensusSite site, System.String committeeid, System.String personid, System.String committeexrefid)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.CommitteeXref.CheckIfPersonExist(committeeid,personid,committeexrefid);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CommitteeXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommitteeXrefModel" /> instance.
        /// </returns>
        public static Consensus.Membership.CommitteeXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommitteeXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CommitteeXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommitteeXrefModel" /> instance.
        /// </returns>
        public static Consensus.Membership.CommitteeXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.ICommitteeXrefModel model = provider.Membership.CommitteeXref.Create();
            return model == null ? null : new Consensus.Membership.CommitteeXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommitteeXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommitteeXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.CommitteeXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommitteeXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommitteeXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommitteeXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.CommitteeXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.ICommitteeXrefModel> collection = provider.Membership.CommitteeXref.FetchAll();
            return collection.Select(model => new Consensus.Membership.CommitteeXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommitteeXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommitteeXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.CommitteeXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommitteeXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommitteeXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommitteeXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.CommitteeXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.ICommitteeXrefModel model = provider.Membership.CommitteeXref.FetchById(id);
            return model == null ? null : new Consensus.Membership.CommitteeXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommitteeXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.CommitteeXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeXrefModel" /> instances.
        /// </summary>
        /// <param name="committeeId">
        ///     The value which identifies the <see cref="!:CommitteeXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeXrefModel" /> instances that match the specified <paramref name="committeeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.CommitteeXref> FetchAllByCommitteeId(System.String committeeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CommitteeXref.FetchAllByCommitteeId(site,committeeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeXrefModel" /> instances.
        /// </summary>
        /// <param name="committeeId">
        ///     The value which identifies the <see cref="!:CommitteeXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeXrefModel" /> instances that match the specified <paramref name="committeeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Membership.CommitteeXref> FetchAllByCommitteeId(ConsensusSite site, System.String committeeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.ICommitteeXrefModel> collection = provider.Membership.CommitteeXref.FetchAllByCommitteeId(committeeId);
            return collection.Select(model => new Consensus.Membership.CommitteeXref(model));
        }

        #endregion
    }
}
