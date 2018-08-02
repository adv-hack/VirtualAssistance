using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="SysConfigRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSysConfigModel : LocalModel<SysConfigRecord, Int32>, ISysConfigModel
    {
        #region fields

        /// <summary>
        ///     The value of the "SC_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysConfigRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.SysConfig.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysConfigRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.SysConfig.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysConfigRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.SysConfig.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return this.ModifiedData.AddDate; }
            set { this.ModifiedData.AddDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SC_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SC_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SpId; }
            set
            {
                if (this.ModifiedData.SpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SpId = value;
            }
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

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSysConfigModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSysConfigModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSysConfigModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSysConfigModel(LocalProvider provider, SysConfigRecord record) : base(provider, record)
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
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SpId = _sellingCompany.Id == null && this.ModifiedData.SpId != null ? "" : _sellingCompany.Id;
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
        ///     Gets or sets the value of the "SC_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ISysConfigModel.AddDate
        {
            get { return this.AddDate; }
            set { this.AddDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SC_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel ISysConfigModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SC_SP_ID" field.
        /// </summary>
        System.String ISysConfigModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_KEY_NAME" field.
        /// </summary>
        System.String ISysConfigModel.KeyName
        {
            get { return this.KeyName; }
            set { this.KeyName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_VALUE_TO_USE" field.
        /// </summary>
        System.Nullable<System.Byte> ISysConfigModel.ValueToUse
        {
            get { return this.ValueToUse; }
            set { this.ValueToUse = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_LABEL_NAME" field.
        /// </summary>
        System.String ISysConfigModel.LabelName
        {
            get { return this.LabelName; }
            set { this.LabelName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_CHAR_VALUE" field.
        /// </summary>
        System.String ISysConfigModel.CharValue
        {
            get { return this.CharValue; }
            set { this.CharValue = (System.String)value; }
        }

        #endregion
    }
}
