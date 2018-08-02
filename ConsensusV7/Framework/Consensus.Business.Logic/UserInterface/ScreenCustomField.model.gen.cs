using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenCustomFieldRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenCustomFieldModel : LocalModel<ScreenCustomFieldRecord, Int32>, IScreenCustomFieldModel
    {
        #region fields

        /// <summary>
        ///     The value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        private LocalScreenCustomFieldTypeModel _cftype;

        /// <summary>
        ///     The collection of <see cref="ScreenCustomFieldListitemModel" /> instances that reference this <see cref="ScreenCustomFieldModel" />.
        /// </summary>
        private LocalCollection<LocalScreenCustomFieldListitemModel, IScreenCustomFieldListitemModel> _customFieldListItems;

        /// <summary>
        ///     The collection of <see cref="ScreenCustomFieldValueModel" /> instances that reference this <see cref="ScreenCustomFieldModel" />.
        /// </summary>
        private LocalCollection<LocalScreenCustomFieldValueModel, IScreenCustomFieldValueModel> _customFieldValues;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomField.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomField.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomField.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_URL" field.
        /// </summary>
        public String Url
        {
            get { return this.ModifiedData.Url; }
            set { this.ModifiedData.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_PARENT_CONTROL" field.
        /// </summary>
        public String ParentControl
        {
            get { return this.ModifiedData.ParentControl; }
            set { this.ModifiedData.ParentControl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_LABEL" field.
        /// </summary>
        public String Label
        {
            get { return this.ModifiedData.Label; }
            set { this.ModifiedData.Label = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        public LocalScreenCustomFieldTypeModel Cftype
        {
            get
            {
                if (_cftype == null)
                    _cftype = this.Provider.UserInterface.ScreenCustomFieldType.FetchById(this.CftypeId);
                if (_cftype == null)
                    _cftype = this.Provider.UserInterface.ScreenCustomFieldType.Create();
                
                return _cftype;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        public String CftypeId
        {
            get { return this.ModifiedData.CftypeId; }
            set
            {
                if (this.ModifiedData.CftypeId != value)
                     _cftype = null;
                this.ModifiedData.CftypeId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_POPUP_URL" field.
        /// </summary>
        public String PopupUrl
        {
            get { return this.ModifiedData.PopupUrl; }
            set { this.ModifiedData.PopupUrl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_DECIMALS" field.
        /// </summary>
        public Int32? Decimals
        {
            get { return this.ModifiedData.Decimals; }
            set { this.ModifiedData.Decimals = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_PAGE" field.
        /// </summary>
        public String Page
        {
            get { return this.ModifiedData.Page; }
            set { this.ModifiedData.Page = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_TABLE" field.
        /// </summary>
        public String Table
        {
            get { return this.ModifiedData.Table; }
            set { this.ModifiedData.Table = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ScreenCustomFieldListitemModel" /> instances that reference this <see cref="ScreenCustomFieldModel" />.
        /// </summary>
        public LocalCollection<LocalScreenCustomFieldListitemModel, IScreenCustomFieldListitemModel> CustomFieldListItems
        {
            get
            {
                if (_customFieldListItems == null)
                    _customFieldListItems = new LocalCollection<LocalScreenCustomFieldListitemModel, IScreenCustomFieldListitemModel>(this.Provider.UserInterface.ScreenCustomFieldListitem.FetchAllByCfieldId(this.Id));
                
                return _customFieldListItems;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ScreenCustomFieldValueModel" /> instances that reference this <see cref="ScreenCustomFieldModel" />.
        /// </summary>
        public LocalCollection<LocalScreenCustomFieldValueModel, IScreenCustomFieldValueModel> CustomFieldValues
        {
            get
            {
                if (_customFieldValues == null)
                    _customFieldValues = new LocalCollection<LocalScreenCustomFieldValueModel, IScreenCustomFieldValueModel>(this.Provider.UserInterface.ScreenCustomFieldValue.FetchAllByCfieldId(this.Id));
                
                return _customFieldValues;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalScreenCustomFieldModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalScreenCustomFieldModel(LocalProvider provider, ScreenCustomFieldRecord record) : base(provider, record)
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
            if (_cftype != null)
            {
                _cftype.Save();
                this.ModifiedData.CftypeId = _cftype.Id == null && this.ModifiedData.CftypeId != null ? "" : _cftype.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_customFieldListItems != null)
                _customFieldListItems.Execute(obj => obj.CfieldId = this.Id).Execute(obj => obj.Save());
            if (_customFieldValues != null)
                _customFieldValues.Execute(obj => obj.CfieldId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_URL" field.
        /// </summary>
        System.String IScreenCustomFieldModel.Url
        {
            get { return this.Url; }
            set { this.Url = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_PARENT_CONTROL" field.
        /// </summary>
        System.String IScreenCustomFieldModel.ParentControl
        {
            get { return this.ParentControl; }
            set { this.ParentControl = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_NAME" field.
        /// </summary>
        System.String IScreenCustomFieldModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_LABEL" field.
        /// </summary>
        System.String IScreenCustomFieldModel.Label
        {
            get { return this.Label; }
            set { this.Label = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldTypeModel IScreenCustomFieldModel.Cftype
        {
            get { return this.Cftype; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        System.String IScreenCustomFieldModel.CftypeId
        {
            get { return this.CftypeId; }
            set { this.CftypeId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_POPUP_URL" field.
        /// </summary>
        System.String IScreenCustomFieldModel.PopupUrl
        {
            get { return this.PopupUrl; }
            set { this.PopupUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_DECIMALS" field.
        /// </summary>
        System.Nullable<System.Int32> IScreenCustomFieldModel.Decimals
        {
            get { return this.Decimals; }
            set { this.Decimals = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_PAGE" field.
        /// </summary>
        System.String IScreenCustomFieldModel.Page
        {
            get { return this.Page; }
            set { this.Page = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_TABLE" field.
        /// </summary>
        System.String IScreenCustomFieldModel.Table
        {
            get { return this.Table; }
            set { this.Table = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances that reference this <see cref="!:ScreenCustomFieldModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenCustomFieldListitemModel> IScreenCustomFieldModel.CustomFieldListItems
        {
            get { return this.CustomFieldListItems; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldValueModel" /> instances that reference this <see cref="!:ScreenCustomFieldModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenCustomFieldValueModel> IScreenCustomFieldModel.CustomFieldValues
        {
            get { return this.CustomFieldValues; }
        }

        #endregion
    }
}
