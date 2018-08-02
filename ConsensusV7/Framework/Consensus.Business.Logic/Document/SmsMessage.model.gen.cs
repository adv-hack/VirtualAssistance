using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="SmsMessageRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSmsMessageModel : LocalModel<SmsMessageRecord, Int32>, ISmsMessageModel
    {
        #region fields

        /// <summary>
        ///     The value of the "SMS_SMT_ID" field.
        /// </summary>
        private LocalSmsTypeModel _smsMessageType;

        /// <summary>
        ///     The value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The collection of <see cref="PackXrefModel" /> instances that reference this <see cref="SmsMessageModel" />.
        /// </summary>
        private LocalCollection<LocalPackXrefModel, IPackXrefModel> _smsId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SmsMessageRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.SmsMessage.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SmsMessageRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.SmsMessage.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SmsMessageRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.SmsMessage.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "SMS_SMT_ID" field.
        /// </summary>
        public LocalSmsTypeModel SmsMessageType
        {
            get
            {
                if (_smsMessageType == null && this.SmsMessageTypeId != null)
                    _smsMessageType = this.Provider.Document.SmsType.FetchById(this.SmsMessageTypeId.Value);
                if (_smsMessageType == null)
                    _smsMessageType = this.Provider.Document.SmsType.Create();
                
                return _smsMessageType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMS_SMT_ID" field.
        /// </summary>
        public Int32? SmsMessageTypeId
        {
            get { return this.ModifiedData.SmtId; }
            set
            {
                if (this.ModifiedData.SmtId != value)
                     _smsMessageType = null;
                this.ModifiedData.SmtId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return this.ModifiedData.Text; }
            set { this.ModifiedData.Text = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_CURRENT" field.
        /// </summary>
        public Boolean? Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SMS_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackXrefModel" /> instances that reference this <see cref="SmsMessageModel" />.
        /// </summary>
        public LocalCollection<LocalPackXrefModel, IPackXrefModel> SmsId
        {
            get
            {
                if (_smsId == null)
                    _smsId = new LocalCollection<LocalPackXrefModel, IPackXrefModel>(this.Provider.Document.PackXref.FetchAllBySmsIdId(this.Id));
                
                return _smsId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSmsMessageModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSmsMessageModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSmsMessageModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSmsMessageModel(LocalProvider provider, SmsMessageRecord record) : base(provider, record)
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
            if (_smsMessageType != null)
            {
                _smsMessageType.Save();
                this.ModifiedData.SmtId = _smsMessageType.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_smsId != null)
                _smsId.Execute(obj => obj.SmsIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "SMS_SMT_ID" field.
        /// </summary>
        Consensus.Document.ISmsTypeModel ISmsMessageModel.SmsMessageType
        {
            get { return this.SmsMessageType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMS_SMT_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ISmsMessageModel.SmsMessageTypeId
        {
            get { return this.SmsMessageTypeId; }
            set { this.SmsMessageTypeId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_NAME" field.
        /// </summary>
        System.String ISmsMessageModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_DESCRIPTION" field.
        /// </summary>
        System.String ISmsMessageModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_TEXT" field.
        /// </summary>
        System.String ISmsMessageModel.Text
        {
            get { return this.Text; }
            set { this.Text = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_CURRENT" field.
        /// </summary>
        System.Nullable<System.Boolean> ISmsMessageModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Nullable<System.Boolean>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel ISmsMessageModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        System.String ISmsMessageModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:SmsMessageModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackXrefModel> ISmsMessageModel.SmsId
        {
            get { return this.SmsId; }
        }

        #endregion
    }
}
