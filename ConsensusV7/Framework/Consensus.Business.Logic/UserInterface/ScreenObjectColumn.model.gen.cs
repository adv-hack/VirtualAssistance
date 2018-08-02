using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectColumnRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenObjectColumnModel : LocalModel<ScreenObjectColumnRecord, Int32>, IScreenObjectColumnModel
    {
        #region fields

        /// <summary>
        ///     The value of the "OBJCOL_OBJ_ID" field.
        /// </summary>
        private LocalScreenObjectModel _screenObject;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectColumnRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectColumn.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectColumnRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectColumn.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectColumnRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectColumn.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "OBJCOL_OBJ_ID" field.
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
        ///     Gets or sets the unique code for the value of the "OBJCOL_OBJ_ID" field.
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
        ///     Gets or sets the value of the "OBJCOL_ORDINAL" field.
        /// </summary>
        public Int32 Ordinal
        {
            get { return this.ModifiedData.Ordinal; }
            set { this.ModifiedData.Ordinal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_CUSTOM" field.
        /// </summary>
        public String CustomTitle
        {
            get { return this.ModifiedData.Custom; }
            set { this.ModifiedData.Custom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_EXPORTABLE" field.
        /// </summary>
        public Boolean Exportable
        {
            get { return this.ModifiedData.Exportable; }
            set { this.ModifiedData.Exportable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_VISIBLE" field.
        /// </summary>
        public Boolean Visible
        {
            get { return this.ModifiedData.Visible; }
            set { this.ModifiedData.Visible = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalScreenObjectColumnModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalScreenObjectColumnModel(LocalProvider provider, ScreenObjectColumnRecord record) : base(provider, record)
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
        ///     Gets the The value of the "OBJCOL_OBJ_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenObjectModel IScreenObjectColumnModel.ScreenObject
        {
            get { return this.ScreenObject; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJCOL_OBJ_ID" field.
        /// </summary>
        System.Int32 IScreenObjectColumnModel.ScreenObjectId
        {
            get { return this.ScreenObjectId; }
            set { this.ScreenObjectId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_ORDINAL" field.
        /// </summary>
        System.Int32 IScreenObjectColumnModel.Ordinal
        {
            get { return this.Ordinal; }
            set { this.Ordinal = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_CUSTOM" field.
        /// </summary>
        System.String IScreenObjectColumnModel.CustomTitle
        {
            get { return this.CustomTitle; }
            set { this.CustomTitle = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_EXPORTABLE" field.
        /// </summary>
        System.Boolean IScreenObjectColumnModel.Exportable
        {
            get { return this.Exportable; }
            set { this.Exportable = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_VISIBLE" field.
        /// </summary>
        System.Boolean IScreenObjectColumnModel.Visible
        {
            get { return this.Visible; }
            set { this.Visible = (System.Boolean)value; }
        }

        #endregion
    }
}
