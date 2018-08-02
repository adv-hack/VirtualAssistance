using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="CommitteeXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommitteeXrefModel : LocalModel<CommitteeXrefRecord, String>, ICommitteeXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "COMXREF_COM_ID" field.
        /// </summary>
        private LocalCommitteeModel _committee;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommitteeXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.CommitteeXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommitteeXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.CommitteeXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommitteeXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.CommitteeXref.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return this.ModifiedData.AddDate; }
            set { this.ModifiedData.AddDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COMXREF_COM_ID" field.
        /// </summary>
        public LocalCommitteeModel Committee
        {
            get
            {
                if (_committee == null && this.CommitteeId != null)
                    _committee = this.Provider.Membership.Committee.FetchById(this.CommitteeId);
                if (_committee == null)
                    _committee = this.Provider.Membership.Committee.Create();
                
                return _committee;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMXREF_COM_ID" field.
        /// </summary>
        public String CommitteeId
        {
            get { return this.ModifiedData.ComId; }
            set
            {
                if (this.ModifiedData.ComId != value)
                     _committee = null;
                this.ModifiedData.ComId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return this.ModifiedData.TableName; }
            set { this.ModifiedData.TableName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return this.ModifiedData.RecordId; }
            set { this.ModifiedData.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_DISABLED" field.
        /// </summary>
        public Byte? Disabled
        {
            get { return this.ModifiedData.Disabled; }
            set { this.ModifiedData.Disabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_ROLE" field.
        /// </summary>
        public String Role
        {
            get { return this.ModifiedData.Role; }
            set { this.ModifiedData.Role = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return this.ModifiedData.Date; }
            set { this.ModifiedData.Date = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCommitteeXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCommitteeXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCommitteeXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCommitteeXrefModel(LocalProvider provider, CommitteeXrefRecord record) : base(provider, record)
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
            if (_committee != null)
            {
                _committee.Save();
                this.ModifiedData.ComId = _committee.Id == null && this.ModifiedData.ComId != null ? "" : _committee.Id;
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
        ///     Gets or sets the value of the "COMXREF_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ICommitteeXrefModel.AddDate
        {
            get { return this.AddDate; }
            set { this.AddDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COMXREF_COM_ID" field.
        /// </summary>
        Consensus.Membership.ICommitteeModel ICommitteeXrefModel.Committee
        {
            get { return this.Committee; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMXREF_COM_ID" field.
        /// </summary>
        System.String ICommitteeXrefModel.CommitteeId
        {
            get { return this.CommitteeId; }
            set { this.CommitteeId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_TABLE_NAME" field.
        /// </summary>
        System.String ICommitteeXrefModel.TableName
        {
            get { return this.TableName; }
            set { this.TableName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_RECORD_ID" field.
        /// </summary>
        System.String ICommitteeXrefModel.RecordId
        {
            get { return this.RecordId; }
            set { this.RecordId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_DISABLED" field.
        /// </summary>
        System.Nullable<System.Byte> ICommitteeXrefModel.Disabled
        {
            get { return this.Disabled; }
            set { this.Disabled = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_ROLE" field.
        /// </summary>
        System.String ICommitteeXrefModel.Role
        {
            get { return this.Role; }
            set { this.Role = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMXREF_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ICommitteeXrefModel.Date
        {
            get { return this.Date; }
            set { this.Date = (System.Nullable<System.DateTime>)value; }
        }

        #endregion
    }
}
