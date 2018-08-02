using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectEntryRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenObjectEntryModel : LocalModel<ScreenObjectEntryRecord, Int32>, IScreenObjectEntryModel
    {
        #region fields

        /// <summary>
        ///     The value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        private LocalScreenObjectModel _screenObject;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectEntryRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectEntry.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectEntryRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectEntry.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectEntryRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectEntry.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        public LocalScreenObjectModel ScreenObject
        {
            get
            {
                if (_screenObject == null)
                    _screenObject = this.Provider.UserInterface.ScreenObject.FetchById(this.ScreenObjectId);
                if (_screenObject == null)
                    _screenObject = this.Provider.UserInterface.ScreenObject.Create();
                
                return _screenObject;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        public Int32 ScreenObjectId
        {
            get { return this.ModifiedData.ObjId; }
            set
            {
                if (this.ModifiedData.ObjId != value)
                     _screenObject = null;
                this.ModifiedData.ObjId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_NORMAL" field.
        /// </summary>
        public String Normal
        {
            get { return this.ModifiedData.ItemNormal; }
            set { this.ModifiedData.ItemNormal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_CUSTOM" field.
        /// </summary>
        public String Custom
        {
            get { return this.ModifiedData.ItemCustom; }
            set { this.ModifiedData.ItemCustom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_HIDE" field.
        /// </summary>
        public Boolean Hide
        {
            get { return this.ModifiedData.ItemHide; }
            set { this.ModifiedData.ItemHide = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenObjectEntryModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalScreenObjectEntryModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenObjectEntryModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalScreenObjectEntryModel(LocalProvider provider, ScreenObjectEntryRecord record) : base(provider, record)
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
            if (_screenObject != null)
            {
                _screenObject.Save();
                this.ModifiedData.ObjId = _screenObject.Id;
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
        ///     Gets the The value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenObjectModel IScreenObjectEntryModel.ScreenObject
        {
            get { return this.ScreenObject; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        System.Int32 IScreenObjectEntryModel.ScreenObjectId
        {
            get { return this.ScreenObjectId; }
            set { this.ScreenObjectId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_NORMAL" field.
        /// </summary>
        System.String IScreenObjectEntryModel.Normal
        {
            get { return this.Normal; }
            set { this.Normal = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_CUSTOM" field.
        /// </summary>
        System.String IScreenObjectEntryModel.Custom
        {
            get { return this.Custom; }
            set { this.Custom = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_HIDE" field.
        /// </summary>
        System.Boolean IScreenObjectEntryModel.Hide
        {
            get { return this.Hide; }
            set { this.Hide = (System.Boolean)value; }
        }

        #endregion
    }
}
