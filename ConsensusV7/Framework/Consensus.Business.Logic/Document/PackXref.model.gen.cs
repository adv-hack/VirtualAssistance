using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PackXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPackXrefModel : LocalModel<PackXrefRecord, String>, IPackXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        private LocalPackModel _packId;

        /// <summary>
        ///     The value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        private LocalLiteratureModel _litId;

        /// <summary>
        ///     The value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        private LocalSmsMessageModel _smsId;

        /// <summary>
        ///     The value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        private LocalICalMessageModel _icmId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PackXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.PackXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PackXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.PackXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PackXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.PackXref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        public LocalPackModel PackId
        {
            get
            {
                if (_packId == null)
                    _packId = this.Provider.Document.Pack.FetchById(this.PackIdId);
                if (_packId == null)
                    _packId = this.Provider.Document.Pack.Create();
                
                return _packId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        public String PackIdId
        {
            get { return this.ModifiedData.PackId; }
            set
            {
                if (this.ModifiedData.PackId != value)
                     _packId = null;
                this.ModifiedData.PackId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        public LocalLiteratureModel LitId
        {
            get
            {
                if (_litId == null && this.LitIdId != null)
                    _litId = this.Provider.Document.Literature.FetchById(this.LitIdId);
                if (_litId == null)
                    _litId = this.Provider.Document.Literature.Create();
                
                return _litId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        public String LitIdId
        {
            get { return this.ModifiedData.LitId; }
            set
            {
                if (this.ModifiedData.LitId != value)
                     _litId = null;
                this.ModifiedData.LitId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKXREF_SEQ" field.
        /// </summary>
        public Int32? Seq
        {
            get { return this.ModifiedData.Seq; }
            set { this.ModifiedData.Seq = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        public LocalSmsMessageModel SmsId
        {
            get
            {
                if (_smsId == null && this.SmsIdId != null)
                    _smsId = this.Provider.Document.SmsMessage.FetchById(this.SmsIdId.Value);
                if (_smsId == null)
                    _smsId = this.Provider.Document.SmsMessage.Create();
                
                return _smsId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        public Int32? SmsIdId
        {
            get { return this.ModifiedData.SmsId; }
            set
            {
                if (this.ModifiedData.SmsId != value)
                     _smsId = null;
                this.ModifiedData.SmsId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        public LocalICalMessageModel IcmId
        {
            get
            {
                if (_icmId == null && this.IcmIdId != null)
                    _icmId = this.Provider.Document.ICalMessage.FetchById(this.IcmIdId.Value);
                if (_icmId == null)
                    _icmId = this.Provider.Document.ICalMessage.Create();
                
                return _icmId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        public Int32? IcmIdId
        {
            get { return this.ModifiedData.IcmId; }
            set
            {
                if (this.ModifiedData.IcmId != value)
                     _icmId = null;
                this.ModifiedData.IcmId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPackXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPackXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPackXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPackXrefModel(LocalProvider provider, PackXrefRecord record) : base(provider, record)
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
            if (_packId != null)
            {
                _packId.Save();
                this.ModifiedData.PackId = _packId.Id == null && this.ModifiedData.PackId != null ? "" : _packId.Id;
            }
            if (_litId != null)
            {
                _litId.Save();
                this.ModifiedData.LitId = _litId.Id == null && this.ModifiedData.LitId != null ? "" : _litId.Id;
            }
            if (_smsId != null)
            {
                _smsId.Save();
                this.ModifiedData.SmsId = _smsId.Id;
            }
            if (_icmId != null)
            {
                _icmId.Save();
                this.ModifiedData.IcmId = _icmId.Id;
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
        ///     Gets the The value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel IPackXrefModel.PackId
        {
            get { return this.PackId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        System.String IPackXrefModel.PackIdId
        {
            get { return this.PackIdId; }
            set { this.PackIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        Consensus.Document.ILiteratureModel IPackXrefModel.LitId
        {
            get { return this.LitId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        System.String IPackXrefModel.LitIdId
        {
            get { return this.LitIdId; }
            set { this.LitIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKXREF_SEQ" field.
        /// </summary>
        System.Nullable<System.Int32> IPackXrefModel.Seq
        {
            get { return this.Seq; }
            set { this.Seq = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        Consensus.Document.ISmsMessageModel IPackXrefModel.SmsId
        {
            get { return this.SmsId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IPackXrefModel.SmsIdId
        {
            get { return this.SmsIdId; }
            set { this.SmsIdId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        Consensus.Document.IICalMessageModel IPackXrefModel.IcmId
        {
            get { return this.IcmId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IPackXrefModel.IcmIdId
        {
            get { return this.IcmIdId; }
            set { this.IcmIdId = (System.Nullable<System.Int32>)value; }
        }

        #endregion
    }
}
