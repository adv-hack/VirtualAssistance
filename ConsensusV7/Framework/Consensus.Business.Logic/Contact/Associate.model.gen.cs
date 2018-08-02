using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="AssociatesRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAssociateModel : LocalModel<AssociatesRecord, Int32>, IAssociateModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        private LocalRoleModel _associatedRole;

        /// <summary>
        ///     The value of the "ASSO_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _role;

        /// <summary>
        ///     The value of the "ASSO_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        private LocalCodeModel _type;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AssociatesRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Associate.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AssociatesRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Associate.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AssociatesRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Associate.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        public LocalRoleModel AssociatedRole
        {
            get
            {
                if (_associatedRole == null && this.AssociatedRoleId != null)
                    _associatedRole = this.Provider.Contact.Role.FetchById(this.AssociatedRoleId);
                if (_associatedRole == null)
                    _associatedRole = this.Provider.Contact.Role.Create();
                
                return _associatedRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        public String AssociatedRoleId
        {
            get { return this.ModifiedData.AssociateId; }
            set
            {
                if (this.ModifiedData.AssociateId != value)
                     _associatedRole = null;
                this.ModifiedData.AssociateId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel Role
        {
            get
            {
                if (_role == null && this.RoleId != null)
                    _role = this.Provider.Contact.Role.FetchById(this.RoleId);
                if (_role == null)
                    _role = this.Provider.Contact.Role.Create();
                
                return _role;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_PROLE_ID" field.
        /// </summary>
        public String RoleId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _role = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Organisation
        {
            get
            {
                if (_organisation == null && this.OrganisationId != null)
                    _organisation = this.Provider.Contact.Organisation.FetchById(this.OrganisationId);
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.Create();
                
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_ORG_ID" field.
        /// </summary>
        public String OrganisationId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _organisation = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_TYPE" field.
        /// </summary>
        public Byte TypeNumber
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("ASSOT_PER", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("ASSOT_PER");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.TypeName; }
            set
            {
                if (this.ModifiedData.TypeName != value)
                     _type = null;
                this.ModifiedData.TypeName = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalAssociateModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalAssociateModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalAssociateModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalAssociateModel(LocalProvider provider, AssociatesRecord record) : base(provider, record)
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
                this.ModifiedData.TypeName = _type.Value1;
            }
            if (_associatedRole != null)
            {
                _associatedRole.Save();
                this.ModifiedData.AssociateId = _associatedRole.Id == null && this.ModifiedData.AssociateId != null ? "" : _associatedRole.Id;
            }
            if (_role != null)
            {
                _role.Save();
                this.ModifiedData.ProleId = _role.Id == null && this.ModifiedData.ProleId != null ? "" : _role.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
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
        ///     Gets the The value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IAssociateModel.AssociatedRole
        {
            get { return this.AssociatedRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        System.String IAssociateModel.AssociatedRoleId
        {
            get { return this.AssociatedRoleId; }
            set { this.AssociatedRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IAssociateModel.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_PROLE_ID" field.
        /// </summary>
        System.String IAssociateModel.RoleId
        {
            get { return this.RoleId; }
            set { this.RoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IAssociateModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_ORG_ID" field.
        /// </summary>
        System.String IAssociateModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_TYPE" field.
        /// </summary>
        System.Byte IAssociateModel.TypeNumber
        {
            get { return this.TypeNumber; }
            set { this.TypeNumber = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        Consensus.Common.ICodeModel IAssociateModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        System.String IAssociateModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IAssociateModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IAssociateModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        #endregion
    }
}
