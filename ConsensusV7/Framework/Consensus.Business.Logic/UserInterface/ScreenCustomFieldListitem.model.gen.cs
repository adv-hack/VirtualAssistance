using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenCustomFieldListitemRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenCustomFieldListitemModel : LocalModel<ScreenCustomFieldListitemRecord, Int32>, IScreenCustomFieldListitemModel
    {
        #region fields

        /// <summary>
        ///     The value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        private LocalScreenCustomFieldModel _cfield;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldListitemRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomFieldListitem.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldListitemRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomFieldListitem.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldListitemRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomFieldListitem.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        public LocalScreenCustomFieldModel Cfield
        {
            get
            {
                if (_cfield == null)
                    _cfield = this.Provider.UserInterface.ScreenCustomField.FetchById(this.CfieldId);
                if (_cfield == null)
                    _cfield = this.Provider.UserInterface.ScreenCustomField.Create();
                
                return _cfield;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        public Int32 CfieldId
        {
            get { return this.ModifiedData.CfieldId; }
            set
            {
                if (this.ModifiedData.CfieldId != value)
                     _cfield = null;
                this.ModifiedData.CfieldId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFLITEM_ID_VALUE" field.
        /// </summary>
        public String IdValue
        {
            get { return this.ModifiedData.IdValue; }
            set { this.ModifiedData.IdValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFLITEM_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return this.ModifiedData.Text; }
            set { this.ModifiedData.Text = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalScreenCustomFieldListitemModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalScreenCustomFieldListitemModel(LocalProvider provider, ScreenCustomFieldListitemRecord record) : base(provider, record)
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
            if (_cfield != null)
            {
                _cfield.Save();
                this.ModifiedData.CfieldId = _cfield.Id;
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
        ///     Gets the The value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldModel IScreenCustomFieldListitemModel.Cfield
        {
            get { return this.Cfield; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        System.Int32 IScreenCustomFieldListitemModel.CfieldId
        {
            get { return this.CfieldId; }
            set { this.CfieldId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFLITEM_ID_VALUE" field.
        /// </summary>
        System.String IScreenCustomFieldListitemModel.IdValue
        {
            get { return this.IdValue; }
            set { this.IdValue = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFLITEM_TEXT" field.
        /// </summary>
        System.String IScreenCustomFieldListitemModel.Text
        {
            get { return this.Text; }
            set { this.Text = (System.String)value; }
        }

        #endregion
    }
}
