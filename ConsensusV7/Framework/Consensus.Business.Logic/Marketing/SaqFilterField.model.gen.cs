using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqFilterRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqFilterFieldModel : LocalModel<SaqFilterRecord, Int64>, ISaqFilterFieldModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="SaqParameterModel" /> instances that reference this <see cref="SaqFilterFieldModel" />.
        /// </summary>
        private LocalCollection<LocalSaqParameterModel, ISaqParameterModel> _saqParameterFilterField;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqFilterRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.SaqFilterField.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqFilterRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.SaqFilterField.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqFilterRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.SaqFilterField.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DISPLAY_ORDER" field.
        /// </summary>
        public Int16 DisplayOrder
        {
            get { return this.ModifiedData.DisplayOrder; }
            set { this.ModifiedData.DisplayOrder = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DISPLAY" field.
        /// </summary>
        public Byte Display
        {
            get { return this.ModifiedData.Display; }
            set { this.ModifiedData.Display = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_TABLE_PREFIX" field.
        /// </summary>
        public String TablePrefix
        {
            get { return this.ModifiedData.TablePrefix; }
            set { this.ModifiedData.TablePrefix = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_TABLE_DESC" field.
        /// </summary>
        public String TableDesc
        {
            get { return this.ModifiedData.TableDesc; }
            set { this.ModifiedData.TableDesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_NAME" field.
        /// </summary>
        public String ColumnName
        {
            get { return this.ModifiedData.ColumnName; }
            set { this.ModifiedData.ColumnName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_TYPE" field.
        /// </summary>
        public String ColumnType
        {
            get { return this.ModifiedData.ColumnType; }
            set { this.ModifiedData.ColumnType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_LENGTH" field.
        /// </summary>
        public Int32? ColumnLength
        {
            get { return this.ModifiedData.ColumnLength; }
            set { this.ModifiedData.ColumnLength = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_DESC" field.
        /// </summary>
        public String ColumnDesc
        {
            get { return this.ModifiedData.ColumnDesc; }
            set { this.ModifiedData.ColumnDesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_LOOKUP" field.
        /// </summary>
        public Byte CodeLookup
        {
            get { return this.ModifiedData.CodeLookup; }
            set { this.ModifiedData.CodeLookup = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_HEADER" field.
        /// </summary>
        public String CodeHeader
        {
            get { return this.ModifiedData.CodeHeader; }
            set { this.ModifiedData.CodeHeader = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_VAL" field.
        /// </summary>
        public Byte? CodeVal
        {
            get { return this.ModifiedData.CodeVal; }
            set { this.ModifiedData.CodeVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_ID_IN_LOOKUP" field.
        /// </summary>
        public Byte IdInLookup
        {
            get { return this.ModifiedData.IdInLookup; }
            set { this.ModifiedData.IdInLookup = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DEFAULT_OPERAND" field.
        /// </summary>
        public String DefaultOperand
        {
            get { return this.ModifiedData.DefaultOperand; }
            set { this.ModifiedData.DefaultOperand = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqParameterModel" /> instances that reference this <see cref="SaqFilterFieldModel" />.
        /// </summary>
        public LocalCollection<LocalSaqParameterModel, ISaqParameterModel> SaqParameterFilterField
        {
            get
            {
                if (_saqParameterFilterField == null)
                    _saqParameterFilterField = new LocalCollection<LocalSaqParameterModel, ISaqParameterModel>(this.Provider.Marketing.SaqParameter.FetchAllByFilterFieldId(this.Id));
                
                return _saqParameterFilterField;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqFilterFieldModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSaqFilterFieldModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqFilterFieldModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSaqFilterFieldModel(LocalProvider provider, SaqFilterRecord record) : base(provider, record)
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
            if (_saqParameterFilterField != null)
                _saqParameterFilterField.Execute(obj => obj.FilterFieldId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "F_DISPLAY_ORDER" field.
        /// </summary>
        System.Int16 ISaqFilterFieldModel.DisplayOrder
        {
            get { return this.DisplayOrder; }
            set { this.DisplayOrder = (System.Int16)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DISPLAY" field.
        /// </summary>
        System.Byte ISaqFilterFieldModel.Display
        {
            get { return this.Display; }
            set { this.Display = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_TABLE_PREFIX" field.
        /// </summary>
        System.String ISaqFilterFieldModel.TablePrefix
        {
            get { return this.TablePrefix; }
            set { this.TablePrefix = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_TABLE_DESC" field.
        /// </summary>
        System.String ISaqFilterFieldModel.TableDesc
        {
            get { return this.TableDesc; }
            set { this.TableDesc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_NAME" field.
        /// </summary>
        System.String ISaqFilterFieldModel.ColumnName
        {
            get { return this.ColumnName; }
            set { this.ColumnName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_TYPE" field.
        /// </summary>
        System.String ISaqFilterFieldModel.ColumnType
        {
            get { return this.ColumnType; }
            set { this.ColumnType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_LENGTH" field.
        /// </summary>
        System.Nullable<System.Int32> ISaqFilterFieldModel.ColumnLength
        {
            get { return this.ColumnLength; }
            set { this.ColumnLength = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_DESC" field.
        /// </summary>
        System.String ISaqFilterFieldModel.ColumnDesc
        {
            get { return this.ColumnDesc; }
            set { this.ColumnDesc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_LOOKUP" field.
        /// </summary>
        System.Byte ISaqFilterFieldModel.CodeLookup
        {
            get { return this.CodeLookup; }
            set { this.CodeLookup = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_HEADER" field.
        /// </summary>
        System.String ISaqFilterFieldModel.CodeHeader
        {
            get { return this.CodeHeader; }
            set { this.CodeHeader = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_VAL" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqFilterFieldModel.CodeVal
        {
            get { return this.CodeVal; }
            set { this.CodeVal = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_ID_IN_LOOKUP" field.
        /// </summary>
        System.Byte ISaqFilterFieldModel.IdInLookup
        {
            get { return this.IdInLookup; }
            set { this.IdInLookup = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DEFAULT_OPERAND" field.
        /// </summary>
        System.String ISaqFilterFieldModel.DefaultOperand
        {
            get { return this.DefaultOperand; }
            set { this.DefaultOperand = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqParameterModel" /> instances that reference this <see cref="!:SaqFilterFieldModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqParameterModel> ISaqFilterFieldModel.SaqParameterFilterField
        {
            get { return this.SaqParameterFilterField; }
        }

        #endregion
    }
}
