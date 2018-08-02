using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents A configuration value that applies to a selling company.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSellingCompanyConfigModel : LocalModel<SysConfigRecord, Int32>, ISellingCompanyConfigModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysConfigRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.SellingCompanyConfig.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysConfigRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.SellingCompanyConfig.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysConfigRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.SellingCompanyConfig.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SpId; }
            set { this.ModifiedData.SpId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_KEY_NAME" field.
        /// </summary>
        public String KeyName
        {
            get { return this.ModifiedData.KeyName; }
            set { this.ModifiedData.KeyName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_VALUE_TO_USE" field.
        /// </summary>
        public Byte? ValueToUse
        {
            get { return this.ModifiedData.ValueToUse; }
            set { this.ModifiedData.ValueToUse = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_LABEL_NAME" field.
        /// </summary>
        public String LabelName
        {
            get { return this.ModifiedData.LabelName; }
            set { this.ModifiedData.LabelName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_CHAR_VALUE" field.
        /// </summary>
        public String CharValue
        {
            get { return this.ModifiedData.CharValue; }
            set { this.ModifiedData.CharValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return this.ModifiedData.RecordId; }
            set { this.ModifiedData.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_INT_VALUE" field.
        /// </summary>
        public Int32? IntValue
        {
            get { return this.ModifiedData.IntValue; }
            set { this.ModifiedData.IntValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_DATETIME_VALUE" field.
        /// </summary>
        public DateTime? DatetimeValue
        {
            get { return this.ModifiedData.DatetimeValue; }
            set { this.ModifiedData.DatetimeValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_DECIMAL_VALUE" field.
        /// </summary>
        public Decimal? DecimalValue
        {
            get { return this.ModifiedData.DecimalValue; }
            set { this.ModifiedData.DecimalValue = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSellingCompanyConfigModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSellingCompanyConfigModel(LocalProvider provider, SysConfigRecord record) : base(provider, record)
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
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the configuration value.
        /// </summary>
        System.Object ISellingCompanyConfigModel.Value
        {
            get { return this.Value; }
            set { this.Value = (System.Object)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_SP_ID" field.
        /// </summary>
        System.String ISellingCompanyConfigModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_KEY_NAME" field.
        /// </summary>
        System.String ISellingCompanyConfigModel.KeyName
        {
            get { return this.KeyName; }
            set { this.KeyName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_VALUE_TO_USE" field.
        /// </summary>
        System.Nullable<System.Byte> ISellingCompanyConfigModel.ValueToUse
        {
            get { return this.ValueToUse; }
            set { this.ValueToUse = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_LABEL_NAME" field.
        /// </summary>
        System.String ISellingCompanyConfigModel.LabelName
        {
            get { return this.LabelName; }
            set { this.LabelName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_CHAR_VALUE" field.
        /// </summary>
        System.String ISellingCompanyConfigModel.CharValue
        {
            get { return this.CharValue; }
            set { this.CharValue = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_RECORD_ID" field.
        /// </summary>
        System.String ISellingCompanyConfigModel.RecordId
        {
            get { return this.RecordId; }
            set { this.RecordId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_INT_VALUE" field.
        /// </summary>
        System.Nullable<System.Int32> ISellingCompanyConfigModel.IntValue
        {
            get { return this.IntValue; }
            set { this.IntValue = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_DATETIME_VALUE" field.
        /// </summary>
        System.Nullable<System.DateTime> ISellingCompanyConfigModel.DatetimeValue
        {
            get { return this.DatetimeValue; }
            set { this.DatetimeValue = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_DECIMAL_VALUE" field.
        /// </summary>
        System.Nullable<System.Decimal> ISellingCompanyConfigModel.DecimalValue
        {
            get { return this.DecimalValue; }
            set { this.DecimalValue = (System.Nullable<System.Decimal>)value; }
        }

        #endregion
    }
}
