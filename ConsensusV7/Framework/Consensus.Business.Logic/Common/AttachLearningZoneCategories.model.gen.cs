using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="AttachlearningzonecategoriesRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAttachLearningZoneCategoriesModel : LocalModel<AttachlearningzonecategoriesRecord, Int32>, IAttachLearningZoneCategoriesModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        private LocalAttachmentModel _attId;

        /// <summary>
        ///     The value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        private LocalLearningZoneCategoriesModel _lzcId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachlearningzonecategoriesRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.AttachLearningZoneCategories.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachlearningzonecategoriesRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.AttachLearningZoneCategories.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachlearningzonecategoriesRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.AttachLearningZoneCategories.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        public LocalAttachmentModel AttId
        {
            get
            {
                if (_attId == null)
                    _attId = this.Provider.Common.Attachment.FetchById(this.AttIdId);
                if (_attId == null)
                    _attId = this.Provider.Common.Attachment.Create();
                
                return _attId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        public String AttIdId
        {
            get { return this.ModifiedData.AttId; }
            set
            {
                if (this.ModifiedData.AttId != value)
                     _attId = null;
                this.ModifiedData.AttId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        public LocalLearningZoneCategoriesModel LzcId
        {
            get
            {
                if (_lzcId == null)
                    _lzcId = this.Provider.Common.LearningZoneCategories.FetchById(this.LzcIdId);
                if (_lzcId == null)
                    _lzcId = this.Provider.Common.LearningZoneCategories.Create();
                
                return _lzcId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        public Int32 LzcIdId
        {
            get { return this.ModifiedData.LzcId; }
            set
            {
                if (this.ModifiedData.LzcId != value)
                     _lzcId = null;
                this.ModifiedData.LzcId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalAttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalAttachLearningZoneCategoriesModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalAttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalAttachLearningZoneCategoriesModel(LocalProvider provider, AttachlearningzonecategoriesRecord record) : base(provider, record)
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
            if (_attId != null)
            {
                _attId.Save();
                this.ModifiedData.AttId = _attId.Id == null && this.ModifiedData.AttId != null ? "" : _attId.Id;
            }
            if (_lzcId != null)
            {
                _lzcId.Save();
                this.ModifiedData.LzcId = _lzcId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        Consensus.Common.IAttachmentModel IAttachLearningZoneCategoriesModel.AttId
        {
            get { return this.AttId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        System.String IAttachLearningZoneCategoriesModel.AttIdId
        {
            get { return this.AttIdId; }
            set { this.AttIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        Consensus.Common.ILearningZoneCategoriesModel IAttachLearningZoneCategoriesModel.LzcId
        {
            get { return this.LzcId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        System.Int32 IAttachLearningZoneCategoriesModel.LzcIdId
        {
            get { return this.LzcIdId; }
            set { this.LzcIdId = (System.Int32)value; }
        }

        #endregion
    }
}
