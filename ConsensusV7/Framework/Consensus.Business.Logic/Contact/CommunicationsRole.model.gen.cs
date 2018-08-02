using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents Comminication for the role.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommunicationsRoleModel : LocalCommunications_XrefModel, ICommunicationsRoleModel
    {
        #region fields

        /// <summary>
        ///     The value of the "COMMXREF_RECORD_ID" field.
        /// </summary>
        private LocalRoleModel _role;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Communications_Xref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Communications_Xref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommunicationsXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Communications_Xref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "COMMXREF_RECORD_ID" field.
        /// </summary>
        public LocalRoleModel Role
        {
            get
            {
                if (_role == null)
                    _role = this.Provider.Contact.Role.FetchById(this.RoleId);
                if (_role == null)
                    _role = this.Provider.Contact.Role.Create();
                
                return _role;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMMXREF_RECORD_ID" field.
        /// </summary>
        public String RoleId
        {
            get { return this.ModifiedData.RecordId; }
            set
            {
                if (this.ModifiedData.RecordId != value)
                     _role = null;
                this.ModifiedData.RecordId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCommunicationsRoleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCommunicationsRoleModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCommunicationsRoleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCommunicationsRoleModel(LocalProvider provider, CommunicationsXrefRecord record) : base(provider, record)
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
            if (_role != null)
            {
                _role.Save();
                this.ModifiedData.RecordId = _role.Id == null && this.ModifiedData.RecordId != null ? "" : _role.Id;
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
        ///     Gets the The value of the "COMMXREF_RECORD_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ICommunicationsRoleModel.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMMXREF_RECORD_ID" field.
        /// </summary>
        System.String ICommunicationsRoleModel.RoleId
        {
            get { return this.RoleId; }
            set { this.RoleId = (System.String)value; }
        }

        #endregion
    }
}
