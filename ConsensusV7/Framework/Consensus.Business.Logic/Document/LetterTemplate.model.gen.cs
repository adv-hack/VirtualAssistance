using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="LettertmpltRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLetterTemplateModel : LocalModel<LettertmpltRecord, String>, ILetterTemplateModel
    {
        #region fields

        /// <summary>
        ///     The value of the "LT_TYPE" field.
        /// </summary>
        private LocalLetterTemplateTypeModel _type;

        /// <summary>
        ///     The value of the "LT_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _sendFrom;

        /// <summary>
        ///     The collection of <see cref="LiteratureModel" /> instances that reference this <see cref="LetterTemplateModel" />.
        /// </summary>
        private LocalCollection<LocalLiteratureModel, ILiteratureModel> _letterTemplateId;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="LetterTemplateModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LettertmpltRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.LetterTemplate.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LettertmpltRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.LetterTemplate.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<LettertmpltRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.LetterTemplate.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_TYPE" field.
        /// </summary>
        public LocalLetterTemplateTypeModel Type
        {
            get
            {
                if (_type == null && this.TypeId != null)
                    _type = this.Provider.Document.LetterTemplateType.FetchById(this.TypeId);
                if (_type == null)
                    _type = this.Provider.Document.LetterTemplateType.Create();
                
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_TYPE" field.
        /// </summary>
        public String TypeId
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_FILE_NAME" field.
        /// </summary>
        public String FileName
        {
            get { return this.ModifiedData.FileName; }
            set { this.ModifiedData.FileName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "LT_SELCO_SP_ID" field.
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
        ///     Gets or sets the value of the "LT_PRINT_ONLY" field.
        /// </summary>
        public Byte? PrintOnly
        {
            get { return this.ModifiedData.PrintOnly; }
            set { this.ModifiedData.PrintOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PDF" field.
        /// </summary>
        public Byte? Pdf
        {
            get { return this.ModifiedData.Pdf; }
            set { this.ModifiedData.Pdf = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel SendFrom
        {
            get
            {
                if (_sendFrom == null && this.SendFromId != null)
                    _sendFrom = this.Provider.Contact.Role.FetchById(this.SendFromId);
                if (_sendFrom == null)
                    _sendFrom = this.Provider.Contact.Role.Create();
                
                return _sendFrom;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        public String SendFromId
        {
            get { return this.ModifiedData.SendProleId; }
            set
            {
                if (this.ModifiedData.SendProleId != value)
                     _sendFrom = null;
                this.ModifiedData.SendProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_CURRENT" field.
        /// </summary>
        public Byte Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_EMAIL_BODY" field.
        /// </summary>
        public Byte EmailBody
        {
            get { return this.ModifiedData.EmailBody; }
            set { this.ModifiedData.EmailBody = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PQ_ID" field.
        /// </summary>
        public String PqId
        {
            get { return this.ModifiedData.PqId; }
            set { this.ModifiedData.PqId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_ATT_ID" field.
        /// </summary>
        public String AttId
        {
            get { return this.ModifiedData.AttId; }
            set { this.ModifiedData.AttId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_LABEL" field.
        /// </summary>
        public Byte? Label
        {
            get { return this.ModifiedData.Label; }
            set { this.ModifiedData.Label = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LiteratureModel" /> instances that reference this <see cref="LetterTemplateModel" />.
        /// </summary>
        public LocalCollection<LocalLiteratureModel, ILiteratureModel> LetterTemplateId
        {
            get
            {
                if (_letterTemplateId == null)
                    _letterTemplateId = new LocalCollection<LocalLiteratureModel, ILiteratureModel>(this.Provider.Document.Literature.FetchAllByLtIdId(this.Id));
                
                return _letterTemplateId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="LetterTemplateModel" />.
        /// </summary>
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByLetterTemplateId(this.Id));
                
                return _payments;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLetterTemplateModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLetterTemplateModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLetterTemplateModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLetterTemplateModel(LocalProvider provider, LettertmpltRecord record) : base(provider, record)
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
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Id == null && this.ModifiedData.Type != null ? "" : _type.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_sendFrom != null)
            {
                _sendFrom.Save();
                this.ModifiedData.SendProleId = _sendFrom.Id == null && this.ModifiedData.SendProleId != null ? "" : _sendFrom.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_letterTemplateId != null)
                _letterTemplateId.Execute(obj => obj.LtIdId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.LetterTemplateId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the file type based of the template record.
        /// </summary>
        System.String ILetterTemplateModel.FileType
        {
            get { return this.FileType; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_NAME" field.
        /// </summary>
        System.String ILetterTemplateModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_TYPE" field.
        /// </summary>
        Consensus.Document.ILetterTemplateTypeModel ILetterTemplateModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_TYPE" field.
        /// </summary>
        System.String ILetterTemplateModel.TypeId
        {
            get { return this.TypeId; }
            set { this.TypeId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_FILE_NAME" field.
        /// </summary>
        System.String ILetterTemplateModel.FileName
        {
            get { return this.FileName; }
            set { this.FileName = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel ILetterTemplateModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_SELCO_SP_ID" field.
        /// </summary>
        System.String ILetterTemplateModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PRINT_ONLY" field.
        /// </summary>
        System.Nullable<System.Byte> ILetterTemplateModel.PrintOnly
        {
            get { return this.PrintOnly; }
            set { this.PrintOnly = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PDF" field.
        /// </summary>
        System.Nullable<System.Byte> ILetterTemplateModel.Pdf
        {
            get { return this.Pdf; }
            set { this.Pdf = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ILetterTemplateModel.SendFrom
        {
            get { return this.SendFrom; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        System.String ILetterTemplateModel.SendFromId
        {
            get { return this.SendFromId; }
            set { this.SendFromId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_CURRENT" field.
        /// </summary>
        System.Byte ILetterTemplateModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_EMAIL_BODY" field.
        /// </summary>
        System.Byte ILetterTemplateModel.EmailBody
        {
            get { return this.EmailBody; }
            set { this.EmailBody = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PQ_ID" field.
        /// </summary>
        System.String ILetterTemplateModel.PqId
        {
            get { return this.PqId; }
            set { this.PqId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_ATT_ID" field.
        /// </summary>
        System.String ILetterTemplateModel.AttId
        {
            get { return this.AttId; }
            set { this.AttId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_LABEL" field.
        /// </summary>
        System.Nullable<System.Byte> ILetterTemplateModel.Label
        {
            get { return this.Label; }
            set { this.Label = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LiteratureModel" /> instances that reference this <see cref="!:LetterTemplateModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ILiteratureModel> ILetterTemplateModel.LetterTemplateId
        {
            get { return this.LetterTemplateId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:LetterTemplateModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> ILetterTemplateModel.Payments
        {
            get { return this.Payments; }
        }

        #endregion
    }
}
