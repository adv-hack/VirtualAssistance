using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="LearningzonecategoriesRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLearningZoneCategoriesModel : LocalModel<LearningzonecategoriesRecord, Int32>, ILearningZoneCategoriesModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="LearningZoneCategoriesModel" />.
        /// </summary>
        private LocalCollection<LocalAttachLearningZoneCategoriesModel, IAttachLearningZoneCategoriesModel> _learningZoneCategoriesLinkCategories;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LearningzonecategoriesRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.LearningZoneCategories.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LearningzonecategoriesRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.LearningZoneCategories.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<LearningzonecategoriesRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.LearningZoneCategories.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_CATEGORY_TITLE" field.
        /// </summary>
        public String CategoryTitle
        {
            get { return this.ModifiedData.CategoryTitle; }
            set { this.ModifiedData.CategoryTitle = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_DESCRIPTION_HTML" field.
        /// </summary>
        public String DescriptionHtml
        {
            get { return this.ModifiedData.DescriptionHtml; }
            set { this.ModifiedData.DescriptionHtml = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="LearningZoneCategoriesModel" />.
        /// </summary>
        public LocalCollection<LocalAttachLearningZoneCategoriesModel, IAttachLearningZoneCategoriesModel> LearningZoneCategoriesLinkCategories
        {
            get
            {
                if (_learningZoneCategoriesLinkCategories == null)
                    _learningZoneCategoriesLinkCategories = new LocalCollection<LocalAttachLearningZoneCategoriesModel, IAttachLearningZoneCategoriesModel>(this.Provider.Common.AttachLearningZoneCategories.FetchAllByLzcIdId(this.Id));
                
                return _learningZoneCategoriesLinkCategories;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLearningZoneCategoriesModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLearningZoneCategoriesModel(LocalProvider provider, LearningzonecategoriesRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_learningZoneCategoriesLinkCategories != null)
                _learningZoneCategoriesLinkCategories.Execute(obj => obj.LzcIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "LZC_CATEGORY_TITLE" field.
        /// </summary>
        System.String ILearningZoneCategoriesModel.CategoryTitle
        {
            get { return this.CategoryTitle; }
            set { this.CategoryTitle = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_DESCRIPTION" field.
        /// </summary>
        System.String ILearningZoneCategoriesModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_DESCRIPTION_HTML" field.
        /// </summary>
        System.String ILearningZoneCategoriesModel.DescriptionHtml
        {
            get { return this.DescriptionHtml; }
            set { this.DescriptionHtml = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="!:LearningZoneCategoriesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IAttachLearningZoneCategoriesModel> ILearningZoneCategoriesModel.LearningZoneCategoriesLinkCategories
        {
            get { return this.LearningZoneCategoriesLinkCategories; }
        }

        #endregion
    }
}
