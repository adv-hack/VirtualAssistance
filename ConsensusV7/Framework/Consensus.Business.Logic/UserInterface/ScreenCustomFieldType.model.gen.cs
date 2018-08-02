using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenCustomFieldTypeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenCustomFieldTypeModel : LocalModel<ScreenCustomFieldTypeRecord, String>, IScreenCustomFieldTypeModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ScreenCustomFieldModel" /> instances that reference this <see cref="ScreenCustomFieldTypeModel" />.
        /// </summary>
        private LocalCollection<LocalScreenCustomFieldModel, IScreenCustomFieldModel> _customFieldTypes;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldTypeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomFieldType.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldTypeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomFieldType.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenCustomFieldTypeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenCustomFieldType.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFTYPE_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ScreenCustomFieldModel" /> instances that reference this <see cref="ScreenCustomFieldTypeModel" />.
        /// </summary>
        public LocalCollection<LocalScreenCustomFieldModel, IScreenCustomFieldModel> CustomFieldTypes
        {
            get
            {
                if (_customFieldTypes == null)
                    _customFieldTypes = new LocalCollection<LocalScreenCustomFieldModel, IScreenCustomFieldModel>(this.Provider.UserInterface.ScreenCustomField.FetchAllByCftypeId(this.Id));
                
                return _customFieldTypes;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalScreenCustomFieldTypeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalScreenCustomFieldTypeModel(LocalProvider provider, ScreenCustomFieldTypeRecord record) : base(provider, record)
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
            if (_customFieldTypes != null)
                _customFieldTypes.Execute(obj => obj.CftypeId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "CFTYPE_NAME" field.
        /// </summary>
        System.String IScreenCustomFieldTypeModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldModel" /> instances that reference this <see cref="!:ScreenCustomFieldTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenCustomFieldModel> IScreenCustomFieldTypeModel.CustomFieldTypes
        {
            get { return this.CustomFieldTypes; }
        }

        #endregion
    }
}
