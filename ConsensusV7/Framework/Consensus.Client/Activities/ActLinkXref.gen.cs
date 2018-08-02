using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ActLinkXref : Proxy<IActLinkXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Activity" /> member.
        /// </summary>
        private Consensus.Activities.Activity _activity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        public Consensus.Activities.Activity Activity
        {
            get
            {
                if (_activity == null && this.Model.Activity != null)
                    _activity = new Consensus.Activities.Activity(this.Model.Activity);
                if (_activity == null)
                    _activity = Consensus.Activities.Activity.Create();
                return _activity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        public System.String ActivityId
        {
            get { return this.Model.ActivityId; }
            set { this.Model.ActivityId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTLINK_TABLE_NUM" field.
        /// </summary>
        public System.Nullable<System.Double> TableNum
        {
            get { return this.Model.TableNum; }
            set { this.Model.TableNum = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTLINK_REC_ID" field.
        /// </summary>
        public System.String RecordId
        {
            get { return this.Model.RecordId; }
            set { this.Model.RecordId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ActLinkXref(IActLinkXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ActLinkXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActLinkXrefModel" /> instance.
        /// </returns>
        public static Consensus.Activities.ActLinkXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActLinkXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ActLinkXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActLinkXrefModel" /> instance.
        /// </returns>
        public static Consensus.Activities.ActLinkXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IActLinkXrefModel model = provider.Activities.ActLinkXref.Create();
            return model == null ? null : new Consensus.Activities.ActLinkXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActLinkXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActLinkXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActLinkXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActLinkXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActLinkXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActLinkXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActLinkXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActLinkXrefModel> collection = provider.Activities.ActLinkXref.FetchAll();
            return collection.Select(model => new Consensus.Activities.ActLinkXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActLinkXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActLinkXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActLinkXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.ActLinkXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActLinkXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActLinkXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActLinkXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActLinkXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.ActLinkXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IActLinkXrefModel model = provider.Activities.ActLinkXref.FetchById(id);
            return model == null ? null : new Consensus.Activities.ActLinkXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActLinkXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Activities.ActLinkXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActLinkXrefModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ActLinkXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActLinkXrefModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActLinkXref> FetchAllByActivityId(System.String activityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActLinkXref.FetchAllByActivityId(site,activityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActLinkXrefModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ActLinkXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActLinkXrefModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActLinkXref> FetchAllByActivityId(ConsensusSite site, System.String activityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActLinkXrefModel> collection = provider.Activities.ActLinkXref.FetchAllByActivityId(activityId);
            return collection.Select(model => new Consensus.Activities.ActLinkXref(model));
        }

        #endregion
    }
}
