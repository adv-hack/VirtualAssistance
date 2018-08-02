using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="AttachmentDataRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAttachmentDataModel : LocalModel<AttachmentDataRecord, Int32>, IAttachmentDataModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ATTD_ATT_ID" field.
        /// </summary>
        private LocalAttachmentModel _attId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachmentDataRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.AttachmentData.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachmentDataRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.AttachmentData.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachmentDataRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.AttachmentData.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ATTD_ATT_ID" field.
        /// </summary>
        public LocalAttachmentModel AttId
        {
            get
            {
                if (_attId == null && this.AttIdId != null)
                    _attId = this.Provider.Common.Attachment.FetchById(this.AttIdId);
                if (_attId == null)
                    _attId = this.Provider.Common.Attachment.Create();
                
                return _attId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTD_ATT_ID" field.
        /// </summary>
        public String AttIdId
        {
            get { return this.ModifiedData.AttId; }
            set
            {
                if (this.ModifiedData.AttId != value)
                     _attId = null;
                this.ModifiedData.AttId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_VERSION_NO" field.
        /// </summary>
        public Double? VersionNo
        {
            get { return this.ModifiedData.VersionNo; }
            set { this.ModifiedData.VersionNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_BINARY" field.
        /// </summary>
        public Byte[] Binary
        {
            get { return this.ModifiedData.Binary; }
            set { this.ModifiedData.Binary = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return this.ModifiedData.Text; }
            set { this.ModifiedData.Text = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalAttachmentDataModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalAttachmentDataModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalAttachmentDataModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalAttachmentDataModel(LocalProvider provider, AttachmentDataRecord record) : base(provider, record)
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
            if (_attId != null)
            {
                _attId.Save();
                this.ModifiedData.AttId = _attId.Id == null && this.ModifiedData.AttId != null ? "" : _attId.Id;
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
        ///     Gets the The value of the "ATTD_ATT_ID" field.
        /// </summary>
        Consensus.Common.IAttachmentModel IAttachmentDataModel.AttId
        {
            get { return this.AttId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTD_ATT_ID" field.
        /// </summary>
        System.String IAttachmentDataModel.AttIdId
        {
            get { return this.AttIdId; }
            set { this.AttIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_VERSION_NO" field.
        /// </summary>
        System.Nullable<System.Double> IAttachmentDataModel.VersionNo
        {
            get { return this.VersionNo; }
            set { this.VersionNo = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_BINARY" field.
        /// </summary>
        System.Byte[] IAttachmentDataModel.Binary
        {
            get { return this.Binary; }
            set { this.Binary = (System.Byte[])value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_TEXT" field.
        /// </summary>
        System.String IAttachmentDataModel.Text
        {
            get { return this.Text; }
            set { this.Text = (System.String)value; }
        }

        void IAttachmentDataModel.Save()
        {
            this.Save();
        }

        void IAttachmentDataModel.Delete()
        {
            this.Delete();
        }

        #endregion
    }
}
