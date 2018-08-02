using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class AttachLearningZoneCategories : Proxy<IAttachLearningZoneCategoriesModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AttId" /> member.
        /// </summary>
        private Consensus.Common.Attachment _attId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LzcId" /> member.
        /// </summary>
        private Consensus.Common.LearningZoneCategories _lzcId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        public Consensus.Common.Attachment AttId
        {
            get
            {
                if (_attId == null && this.Model.AttId != null)
                    _attId = new Consensus.Common.Attachment(this.Model.AttId);
                if (_attId == null)
                    _attId = Consensus.Common.Attachment.Create();
                return _attId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        public System.String AttIdId
        {
            get { return this.Model.AttIdId; }
            set { this.Model.AttIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        public Consensus.Common.LearningZoneCategories LzcId
        {
            get
            {
                if (_lzcId == null && this.Model.LzcId != null)
                    _lzcId = new Consensus.Common.LearningZoneCategories(this.Model.LzcId);
                if (_lzcId == null)
                    _lzcId = Consensus.Common.LearningZoneCategories.Create();
                return _lzcId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        public System.Int32 LzcIdId
        {
            get { return this.Model.LzcIdId; }
            set { this.Model.LzcIdId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal AttachLearningZoneCategories(IAttachLearningZoneCategoriesModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </returns>
        public static Consensus.Common.AttachLearningZoneCategories Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachLearningZoneCategories.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </returns>
        public static Consensus.Common.AttachLearningZoneCategories Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IAttachLearningZoneCategoriesModel model = provider.Common.AttachLearningZoneCategories.Create();
            return model == null ? null : new Consensus.Common.AttachLearningZoneCategories(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachLearningZoneCategoriesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachLearningZoneCategories> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachLearningZoneCategories.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachLearningZoneCategoriesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachLearningZoneCategories> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> collection = provider.Common.AttachLearningZoneCategories.FetchAll();
            return collection.Select(model => new Consensus.Common.AttachLearningZoneCategories(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.AttachLearningZoneCategories FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachLearningZoneCategories.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.AttachLearningZoneCategories FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IAttachLearningZoneCategoriesModel model = provider.Common.AttachLearningZoneCategories.FetchById(id);
            return model == null ? null : new Consensus.Common.AttachLearningZoneCategories(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachLearningZoneCategories.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.AttachLearningZoneCategories.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instances that match the specified <paramref name="attIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachLearningZoneCategories> FetchAllByAttIdId(System.String attIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachLearningZoneCategories.FetchAllByAttIdId(site,attIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instances that match the specified <paramref name="attIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachLearningZoneCategories> FetchAllByAttIdId(ConsensusSite site, System.String attIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> collection = provider.Common.AttachLearningZoneCategories.FetchAllByAttIdId(attIdId);
            return collection.Select(model => new Consensus.Common.AttachLearningZoneCategories(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </summary>
        /// <param name="lzcIdId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instances that match the specified <paramref name="lzcIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachLearningZoneCategories> FetchAllByLzcIdId(System.Int32 lzcIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachLearningZoneCategories.FetchAllByLzcIdId(site,lzcIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </summary>
        /// <param name="lzcIdId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instances that match the specified <paramref name="lzcIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachLearningZoneCategories> FetchAllByLzcIdId(ConsensusSite site, System.Int32 lzcIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> collection = provider.Common.AttachLearningZoneCategories.FetchAllByLzcIdId(lzcIdId);
            return collection.Select(model => new Consensus.Common.AttachLearningZoneCategories(model));
        }

        #endregion
    }
}
