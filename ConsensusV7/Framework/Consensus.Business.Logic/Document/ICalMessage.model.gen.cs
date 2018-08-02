using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="IcalmessageRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalICalMessageModel : LocalModel<IcalmessageRecord, Int32>, IICalMessageModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ICM_ICMT_ID" field.
        /// </summary>
        private LocalICalMessageTypeModel _iCalMessageType;

        /// <summary>
        ///     The value of the "ICM_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The collection of <see cref="PackXrefModel" /> instances that reference this <see cref="ICalMessageModel" />.
        /// </summary>
        private LocalCollection<LocalPackXrefModel, IPackXrefModel> _iCalMessageId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<IcalmessageRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.ICalMessage.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<IcalmessageRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.ICalMessage.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<IcalmessageRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.ICalMessage.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ICM_ICMT_ID" field.
        /// </summary>
        public LocalICalMessageTypeModel ICalMessageType
        {
            get
            {
                if (_iCalMessageType == null && this.ICalMessageTypeId != null)
                    _iCalMessageType = this.Provider.Document.ICalMessageType.FetchById(this.ICalMessageTypeId.Value);
                if (_iCalMessageType == null)
                    _iCalMessageType = this.Provider.Document.ICalMessageType.Create();
                
                return _iCalMessageType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ICM_ICMT_ID" field.
        /// </summary>
        public Int32? ICalMessageTypeId
        {
            get { return this.ModifiedData.IcmtId; }
            set
            {
                if (this.ModifiedData.IcmtId != value)
                     _iCalMessageType = null;
                this.ModifiedData.IcmtId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_METHOD" field.
        /// </summary>
        public Byte? Method
        {
            get { return this.ModifiedData.Method; }
            set { this.ModifiedData.Method = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_SUBJECT" field.
        /// </summary>
        public String Subject
        {
            get { return this.ModifiedData.Subject; }
            set { this.ModifiedData.Subject = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_LOCATION" field.
        /// </summary>
        public String Location
        {
            get { return this.ModifiedData.Location; }
            set { this.ModifiedData.Location = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return this.ModifiedData.Text; }
            set { this.ModifiedData.Text = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ICM_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ICM_SELCO_SP_ID" field.
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
        ///     Gets the collection of <see cref="PackXrefModel" /> instances that reference this <see cref="ICalMessageModel" />.
        /// </summary>
        public LocalCollection<LocalPackXrefModel, IPackXrefModel> ICalMessageId
        {
            get
            {
                if (_iCalMessageId == null)
                    _iCalMessageId = new LocalCollection<LocalPackXrefModel, IPackXrefModel>(this.Provider.Document.PackXref.FetchAllByIcmIdId(this.Id));
                
                return _iCalMessageId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalICalMessageModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalICalMessageModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalICalMessageModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalICalMessageModel(LocalProvider provider, IcalmessageRecord record) : base(provider, record)
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
            if (_iCalMessageType != null)
            {
                _iCalMessageType.Save();
                this.ModifiedData.IcmtId = _iCalMessageType.Id;
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
            if (_iCalMessageId != null)
                _iCalMessageId.Execute(obj => obj.IcmIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "ICM_ICMT_ID" field.
        /// </summary>
        Consensus.Document.IICalMessageTypeModel IICalMessageModel.ICalMessageType
        {
            get { return this.ICalMessageType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ICM_ICMT_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IICalMessageModel.ICalMessageTypeId
        {
            get { return this.ICalMessageTypeId; }
            set { this.ICalMessageTypeId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> IICalMessageModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_METHOD" field.
        /// </summary>
        System.Nullable<System.Byte> IICalMessageModel.Method
        {
            get { return this.Method; }
            set { this.Method = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_NAME" field.
        /// </summary>
        System.String IICalMessageModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_DESCRIPTION" field.
        /// </summary>
        System.String IICalMessageModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_SUBJECT" field.
        /// </summary>
        System.String IICalMessageModel.Subject
        {
            get { return this.Subject; }
            set { this.Subject = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_LOCATION" field.
        /// </summary>
        System.String IICalMessageModel.Location
        {
            get { return this.Location; }
            set { this.Location = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_TEXT" field.
        /// </summary>
        System.String IICalMessageModel.Text
        {
            get { return this.Text; }
            set { this.Text = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ICM_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IICalMessageModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ICM_SELCO_SP_ID" field.
        /// </summary>
        System.String IICalMessageModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:ICalMessageModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackXrefModel> IICalMessageModel.ICalMessageId
        {
            get { return this.ICalMessageId; }
        }

        #endregion
    }
}
