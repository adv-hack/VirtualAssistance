using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CommunicationsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommunicationsModel : LocalModel<CommunicationsRecord, Int64>, ICommunicationsModel
    {
        #region fields

        /// <summary>
        ///     The value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        private LocalCodeModel _deviceCode;

        /// <summary>
        ///     The collection of <see cref="Communications_XrefModel" /> instances that reference this <see cref="CommunicationsModel" />.
        /// </summary>
        private LocalCollection<LocalCommunications_XrefModel, ICommunications_XrefModel> _commId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Communications.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Communications.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Communications.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        public LocalCodeModel DeviceCode
        {
            get
            {
                if (_deviceCode == null && !String.IsNullOrEmpty(this.DeviceCodeCode))
                    _deviceCode = this.Provider.Common.Code.FetchByTypeAndCode("COMMU", this.DeviceCodeCode);
                if (_deviceCode == null)
                    _deviceCode = this.Provider.Common.Code.Create("COMMU");
                return _deviceCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        public String DeviceCodeCode
        {
            get { return this.ModifiedData.DeviceCode; }
            set
            {
                if (this.ModifiedData.DeviceCode != value)
                     _deviceCode = null;
                this.ModifiedData.DeviceCode = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DIALLING_CODE" field.
        /// </summary>
        public String DiallingCode
        {
            get { return this.ModifiedData.DiallingCode; }
            set { this.ModifiedData.DiallingCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_STD_CODE" field.
        /// </summary>
        public String StdCode
        {
            get { return this.ModifiedData.StdCode; }
            set { this.ModifiedData.StdCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_EXTENSION" field.
        /// </summary>
        public String Extension
        {
            get { return this.ModifiedData.Extension; }
            set { this.ModifiedData.Extension = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_VALID_FROM" field.
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return this.ModifiedData.ValidFrom; }
            set { this.ModifiedData.ValidFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEVICE_VALUE" field.
        /// </summary>
        public String DeviceValue
        {
            get { return this.ModifiedData.DeviceValue; }
            set { this.ModifiedData.DeviceValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEVICE_FULL_VALUE" field.
        /// </summary>
        public String DeviceFullValue
        {
            get { return this.ModifiedData.DeviceFullValue; }
            set { this.ModifiedData.DeviceFullValue = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="Communications_XrefModel" /> instances that reference this <see cref="CommunicationsModel" />.
        /// </summary>
        public LocalCollection<LocalCommunications_XrefModel, ICommunications_XrefModel> CommId
        {
            get
            {
                if (_commId == null)
                    _commId = new LocalCollection<LocalCommunications_XrefModel, ICommunications_XrefModel>(this.Provider.Contact.Communications_Xref.FetchAllByCommunicationId(this.Id));
                
                return _commId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCommunicationsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCommunicationsModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCommunicationsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCommunicationsModel(LocalProvider provider, CommunicationsRecord record) : base(provider, record)
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
            if (_deviceCode != null)
            {
                _deviceCode.Save();
                this.ModifiedData.DeviceCode = _deviceCode.Value1;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_commId != null)
                _commId.Execute(obj => obj.CommunicationId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the recognised type of the device.
        /// </summary>
        System.String ICommunicationsModel.DeviceType
        {
            get { return this.DeviceType; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_ACTIVE" field.
        /// </summary>
        System.Boolean ICommunicationsModel.Active
        {
            get { return this.Active; }
            set { this.Active = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEFAULT" field.
        /// </summary>
        System.Boolean ICommunicationsModel.Default
        {
            get { return this.Default; }
            set { this.Default = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_PREFERRED" field.
        /// </summary>
        System.Boolean ICommunicationsModel.Preferred
        {
            get { return this.Preferred; }
            set { this.Preferred = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_EX_DIRECTORY" field.
        /// </summary>
        System.Boolean ICommunicationsModel.ExDirectory
        {
            get { return this.ExDirectory; }
            set { this.ExDirectory = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel ICommunicationsModel.DeviceCode
        {
            get { return this.DeviceCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        System.String ICommunicationsModel.DeviceCodeCode
        {
            get { return this.DeviceCodeCode; }
            set { this.DeviceCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DIALLING_CODE" field.
        /// </summary>
        System.String ICommunicationsModel.DiallingCode
        {
            get { return this.DiallingCode; }
            set { this.DiallingCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_STD_CODE" field.
        /// </summary>
        System.String ICommunicationsModel.StdCode
        {
            get { return this.StdCode; }
            set { this.StdCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_EXTENSION" field.
        /// </summary>
        System.String ICommunicationsModel.Extension
        {
            get { return this.Extension; }
            set { this.Extension = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_NOTES" field.
        /// </summary>
        System.String ICommunicationsModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_VALID_FROM" field.
        /// </summary>
        System.Nullable<System.DateTime> ICommunicationsModel.ValidFrom
        {
            get { return this.ValidFrom; }
            set { this.ValidFrom = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEVICE_VALUE" field.
        /// </summary>
        System.String ICommunicationsModel.DeviceValue
        {
            get { return this.DeviceValue; }
            set { this.DeviceValue = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEVICE_FULL_VALUE" field.
        /// </summary>
        System.String ICommunicationsModel.DeviceFullValue
        {
            get { return this.DeviceFullValue; }
            set { this.DeviceFullValue = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:Communications_XrefModel" /> instances that reference this <see cref="!:CommunicationsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ICommunications_XrefModel> ICommunicationsModel.CommId
        {
            get { return this.CommId; }
        }

        #endregion
    }
}
