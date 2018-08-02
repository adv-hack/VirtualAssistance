using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LearningZoneCategories : Proxy<ILearningZoneCategoriesModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="LearningZoneCategoriesLinkCategories" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.AttachLearningZoneCategories, Consensus.Common.IAttachLearningZoneCategoriesModel> _learningZoneCategoriesLinkCategories;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "LZC_CATEGORY_TITLE" field.
        /// </summary>
        public System.String CategoryTitle
        {
            get { return this.Model.CategoryTitle; }
            set { this.Model.CategoryTitle = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_DESCRIPTION_HTML" field.
        /// </summary>
        public System.String DescriptionHtml
        {
            get { return this.Model.DescriptionHtml; }
            set { this.Model.DescriptionHtml = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="!:LearningZoneCategoriesModel" />.
        /// </summary>
        public Collection<Consensus.Common.AttachLearningZoneCategories> LearningZoneCategoriesLinkCategories
        {
            get
            {
                if (_learningZoneCategoriesLinkCategories == null)
                    _learningZoneCategoriesLinkCategories = new ProxyCollection<Consensus.Common.AttachLearningZoneCategories, Consensus.Common.IAttachLearningZoneCategoriesModel>(this.Model.LearningZoneCategoriesLinkCategories, model => new Consensus.Common.AttachLearningZoneCategories(model));
                return _learningZoneCategoriesLinkCategories;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal LearningZoneCategories(ILearningZoneCategoriesModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </returns>
        public static Consensus.Common.LearningZoneCategories Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LearningZoneCategories.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </returns>
        public static Consensus.Common.LearningZoneCategories Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ILearningZoneCategoriesModel model = provider.Common.LearningZoneCategories.Create();
            return model == null ? null : new Consensus.Common.LearningZoneCategories(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LearningZoneCategoriesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LearningZoneCategoriesModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.LearningZoneCategories> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LearningZoneCategories.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LearningZoneCategoriesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LearningZoneCategoriesModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.LearningZoneCategories> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ILearningZoneCategoriesModel> collection = provider.Common.LearningZoneCategories.FetchAll();
            return collection.Select(model => new Consensus.Common.LearningZoneCategories(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LearningZoneCategoriesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearningZoneCategoriesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.LearningZoneCategories FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LearningZoneCategories.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LearningZoneCategoriesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearningZoneCategoriesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.LearningZoneCategories FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ILearningZoneCategoriesModel model = provider.Common.LearningZoneCategories.FetchById(id);
            return model == null ? null : new Consensus.Common.LearningZoneCategories(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LearningZoneCategories.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.LearningZoneCategories.GetTableName();
        }

        #endregion
    }
}
