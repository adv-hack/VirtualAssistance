using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Membership;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="DelegateRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLearnerModel : LocalModel<DelegateRecord, String>, ILearnerModel
    {
        #region fields

        /// <summary>
        ///     The value of the "DEL_BOOK_ID" field.
        /// </summary>
        private LocalBookingModel _booking;

        /// <summary>
        ///     The value of the "DEL_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _delegateOrg;

        /// <summary>
        ///     The value of the "DEL_PERSON_ID" field.
        /// </summary>
        private LocalPersonModel _delegatePerson;

        /// <summary>
        ///     The value of the "DEL_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _delegateRole;

        /// <summary>
        ///     The value of the "DEL_MEP_ID" field.
        /// </summary>
        private LocalMemberPeriodModel _memberPeriod;

        /// <summary>
        ///     The value of the "DEL_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _delegateAddress;

        /// <summary>
        ///     The value of the "DEL_TBA_GENDER" field.
        /// </summary>
        private LocalCodeModel _tbaGender;

        /// <summary>
        ///     The value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        private LocalCodeModel _tbaNationality;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="LearnerModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<DelegateRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Learner.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<DelegateRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Learner.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<DelegateRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Learner.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_BOOK_ID" field.
        /// </summary>
        public LocalBookingModel Booking
        {
            get
            {
                if (_booking == null && this.BookingId != null)
                    _booking = this.Provider.Learning.Booking.FetchById(this.BookingId);
                if (_booking == null)
                    _booking = this.Provider.Learning.Booking.Create();
                
                return _booking;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_BOOK_ID" field.
        /// </summary>
        public String BookingId
        {
            get { return this.ModifiedData.BookId; }
            set
            {
                if (this.ModifiedData.BookId != value)
                     _booking = null;
                this.ModifiedData.BookId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel DelegateOrg
        {
            get
            {
                if (_delegateOrg == null && this.DelegateOrgId != null)
                    _delegateOrg = this.Provider.Contact.Organisation.FetchById(this.DelegateOrgId);
                if (_delegateOrg == null)
                    _delegateOrg = this.Provider.Contact.Organisation.Create();
                
                return _delegateOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_ORG_ID" field.
        /// </summary>
        public String DelegateOrgId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _delegateOrg = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_PERSON_ID" field.
        /// </summary>
        public LocalPersonModel DelegatePerson
        {
            get
            {
                if (_delegatePerson == null && this.DelegatePersonId != null)
                    _delegatePerson = this.Provider.Contact.Person.FetchById(this.DelegatePersonId);
                if (_delegatePerson == null)
                    _delegatePerson = this.Provider.Contact.Person.Create();
                
                return _delegatePerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_PERSON_ID" field.
        /// </summary>
        public String DelegatePersonId
        {
            get { return this.ModifiedData.PersonId; }
            set
            {
                if (this.ModifiedData.PersonId != value)
                     _delegatePerson = null;
                this.ModifiedData.PersonId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_QUANTITY" field.
        /// </summary>
        public Double? Quantity
        {
            get { return this.ModifiedData.Quantity; }
            set { this.ModifiedData.Quantity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_NET_VAL" field.
        /// </summary>
        public Decimal NetValue
        {
            get { return this.ModifiedData.NetVal; }
            set { this.ModifiedData.NetVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_VAT_AMT" field.
        /// </summary>
        public Decimal VatAmount
        {
            get { return this.ModifiedData.VatAmt; }
            set { this.ModifiedData.VatAmt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_TOT_PRICE" field.
        /// </summary>
        public Decimal TotalPrice
        {
            get { return this.ModifiedData.TotPrice; }
            set { this.ModifiedData.TotPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_BOOK_APPROVED" field.
        /// </summary>
        public Byte? Status
        {
            get { return this.ModifiedData.BookApproved; }
            set { this.ModifiedData.BookApproved = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel DelegateRole
        {
            get
            {
                if (_delegateRole == null && this.DelegateRoleId != null)
                    _delegateRole = this.Provider.Contact.Role.FetchById(this.DelegateRoleId);
                if (_delegateRole == null)
                    _delegateRole = this.Provider.Contact.Role.Create();
                
                return _delegateRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_PROLE_ID" field.
        /// </summary>
        public String DelegateRoleId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _delegateRole = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_SPEC_REQ" field.
        /// </summary>
        public String SpecReq
        {
            get { return this.ModifiedData.SpecReq; }
            set { this.ModifiedData.SpecReq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_BADGE_NAME" field.
        /// </summary>
        public String BadgeName
        {
            get { return this.ModifiedData.BadgeName; }
            set { this.ModifiedData.BadgeName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_MEP_ID" field.
        /// </summary>
        public LocalMemberPeriodModel MemberPeriod
        {
            get
            {
                if (_memberPeriod == null && this.MemberPeriodId != null)
                    _memberPeriod = this.Provider.Membership.MemberPeriod.FetchById(this.MemberPeriodId);
                if (_memberPeriod == null)
                    _memberPeriod = this.Provider.Membership.MemberPeriod.Create();
                
                return _memberPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_MEP_ID" field.
        /// </summary>
        public String MemberPeriodId
        {
            get { return this.ModifiedData.MepId; }
            set
            {
                if (this.ModifiedData.MepId != value)
                     _memberPeriod = null;
                this.ModifiedData.MepId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_DIET_REQUIRE" field.
        /// </summary>
        public String DietRequire
        {
            get { return this.ModifiedData.DietRequire; }
            set { this.ModifiedData.DietRequire = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_SURNAME" field.
        /// </summary>
        public String Surname
        {
            get { return this.ModifiedData.Surname; }
            set { this.ModifiedData.Surname = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_MEM_REF" field.
        /// </summary>
        public String MemRef
        {
            get { return this.ModifiedData.MemRef; }
            set { this.ModifiedData.MemRef = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_ADD_ID" field.
        /// </summary>
        public LocalAddressModel DelegateAddress
        {
            get
            {
                if (_delegateAddress == null && this.DelegateAddressId != null)
                    _delegateAddress = this.Provider.Contact.Address.FetchById(this.DelegateAddressId);
                if (_delegateAddress == null)
                    _delegateAddress = this.Provider.Contact.Address.Create();
                
                return _delegateAddress;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_ADD_ID" field.
        /// </summary>
        public String DelegateAddressId
        {
            get { return this.ModifiedData.AddId; }
            set
            {
                if (this.ModifiedData.AddId != value)
                     _delegateAddress = null;
                this.ModifiedData.AddId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_TBA_GENDER" field.
        /// </summary>
        public LocalCodeModel TbaGender
        {
            get
            {
                if (_tbaGender == null && !String.IsNullOrEmpty(this.TbaGenderCode))
                    _tbaGender = this.Provider.Common.Code.FetchByTypeAndCode("GEND", this.TbaGenderCode);
                if (_tbaGender == null)
                    _tbaGender = this.Provider.Common.Code.Create("GEND");
                return _tbaGender;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_TBA_GENDER" field.
        /// </summary>
        public String TbaGenderCode
        {
            get { return this.ModifiedData.TbaGender; }
            set
            {
                if (this.ModifiedData.TbaGender != value)
                     _tbaGender = null;
                this.ModifiedData.TbaGender = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        public LocalCodeModel TbaNationality
        {
            get
            {
                if (_tbaNationality == null && !String.IsNullOrEmpty(this.TbaNationalityCode))
                    _tbaNationality = this.Provider.Common.Code.FetchByTypeAndCode("NTNLT", this.TbaNationalityCode);
                if (_tbaNationality == null)
                    _tbaNationality = this.Provider.Common.Code.Create("NTNLT");
                return _tbaNationality;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        public String TbaNationalityCode
        {
            get { return this.ModifiedData.TbaNationality; }
            set
            {
                if (this.ModifiedData.TbaNationality != value)
                     _tbaNationality = null;
                this.ModifiedData.TbaNationality = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_TBA_ETHNICITY" field.
        /// </summary>
        public String TbaEthnicity
        {
            get { return this.ModifiedData.TbaEthnicity; }
            set { this.ModifiedData.TbaEthnicity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_AUTH_STATUS" field.
        /// </summary>
        public Int32? AuthStatus
        {
            get { return this.ModifiedData.AuthStatus; }
            set { this.ModifiedData.AuthStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_MEDICAL_DET" field.
        /// </summary>
        public String MedicalDet
        {
            get { return this.ModifiedData.MedicalDet; }
            set { this.ModifiedData.MedicalDet = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="LearnerModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByDelegateId(this.Id));
                
                return _elements;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLearnerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLearnerModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLearnerModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLearnerModel(LocalProvider provider, DelegateRecord record) : base(provider, record)
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
            if (_tbaGender != null)
            {
                _tbaGender.Save();
                this.ModifiedData.TbaGender = _tbaGender.Value1;
            }
            if (_tbaNationality != null)
            {
                _tbaNationality.Save();
                this.ModifiedData.TbaNationality = _tbaNationality.Value1;
            }
            if (_booking != null)
            {
                _booking.Save();
                this.ModifiedData.BookId = _booking.Id == null && this.ModifiedData.BookId != null ? "" : _booking.Id;
            }
            if (_delegateOrg != null)
            {
                _delegateOrg.Save();
                this.ModifiedData.OrgId = _delegateOrg.Id == null && this.ModifiedData.OrgId != null ? "" : _delegateOrg.Id;
            }
            if (_delegatePerson != null)
            {
                _delegatePerson.Save();
                this.ModifiedData.PersonId = _delegatePerson.Id == null && this.ModifiedData.PersonId != null ? "" : _delegatePerson.Id;
            }
            if (_delegateRole != null)
            {
                _delegateRole.Save();
                this.ModifiedData.ProleId = _delegateRole.Id == null && this.ModifiedData.ProleId != null ? "" : _delegateRole.Id;
            }
            if (_memberPeriod != null)
            {
                _memberPeriod.Save();
                this.ModifiedData.MepId = _memberPeriod.Id == null && this.ModifiedData.MepId != null ? "" : _memberPeriod.Id;
            }
            if (_delegateAddress != null)
            {
                _delegateAddress.Save();
                this.ModifiedData.AddId = _delegateAddress.Id == null && this.ModifiedData.AddId != null ? "" : _delegateAddress.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_elements != null)
                _elements.Execute(obj => obj.DelegateId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "DEL_BOOK_ID" field.
        /// </summary>
        Consensus.Learning.IBookingModel ILearnerModel.Booking
        {
            get { return this.Booking; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_BOOK_ID" field.
        /// </summary>
        System.String ILearnerModel.BookingId
        {
            get { return this.BookingId; }
            set { this.BookingId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel ILearnerModel.DelegateOrg
        {
            get { return this.DelegateOrg; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_ORG_ID" field.
        /// </summary>
        System.String ILearnerModel.DelegateOrgId
        {
            get { return this.DelegateOrgId; }
            set { this.DelegateOrgId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel ILearnerModel.DelegatePerson
        {
            get { return this.DelegatePerson; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_PERSON_ID" field.
        /// </summary>
        System.String ILearnerModel.DelegatePersonId
        {
            get { return this.DelegatePersonId; }
            set { this.DelegatePersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_QUANTITY" field.
        /// </summary>
        System.Nullable<System.Double> ILearnerModel.Quantity
        {
            get { return this.Quantity; }
            set { this.Quantity = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_NET_VAL" field.
        /// </summary>
        System.Decimal ILearnerModel.NetValue
        {
            get { return this.NetValue; }
            set { this.NetValue = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_VAT_AMT" field.
        /// </summary>
        System.Decimal ILearnerModel.VatAmount
        {
            get { return this.VatAmount; }
            set { this.VatAmount = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_TOT_PRICE" field.
        /// </summary>
        System.Decimal ILearnerModel.TotalPrice
        {
            get { return this.TotalPrice; }
            set { this.TotalPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_BOOK_APPROVED" field.
        /// </summary>
        System.Nullable<System.Byte> ILearnerModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ILearnerModel.DelegateRole
        {
            get { return this.DelegateRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_PROLE_ID" field.
        /// </summary>
        System.String ILearnerModel.DelegateRoleId
        {
            get { return this.DelegateRoleId; }
            set { this.DelegateRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_NOTES" field.
        /// </summary>
        System.String ILearnerModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_SPEC_REQ" field.
        /// </summary>
        System.String ILearnerModel.SpecReq
        {
            get { return this.SpecReq; }
            set { this.SpecReq = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_BADGE_NAME" field.
        /// </summary>
        System.String ILearnerModel.BadgeName
        {
            get { return this.BadgeName; }
            set { this.BadgeName = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel ILearnerModel.MemberPeriod
        {
            get { return this.MemberPeriod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_MEP_ID" field.
        /// </summary>
        System.String ILearnerModel.MemberPeriodId
        {
            get { return this.MemberPeriodId; }
            set { this.MemberPeriodId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_DIET_REQUIRE" field.
        /// </summary>
        System.String ILearnerModel.DietRequire
        {
            get { return this.DietRequire; }
            set { this.DietRequire = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_SURNAME" field.
        /// </summary>
        System.String ILearnerModel.Surname
        {
            get { return this.Surname; }
            set { this.Surname = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_MEM_REF" field.
        /// </summary>
        System.String ILearnerModel.MemRef
        {
            get { return this.MemRef; }
            set { this.MemRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel ILearnerModel.DelegateAddress
        {
            get { return this.DelegateAddress; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_ADD_ID" field.
        /// </summary>
        System.String ILearnerModel.DelegateAddressId
        {
            get { return this.DelegateAddressId; }
            set { this.DelegateAddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_TBA_GENDER" field.
        /// </summary>
        Consensus.Common.ICodeModel ILearnerModel.TbaGender
        {
            get { return this.TbaGender; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_TBA_GENDER" field.
        /// </summary>
        System.String ILearnerModel.TbaGenderCode
        {
            get { return this.TbaGenderCode; }
            set { this.TbaGenderCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        Consensus.Common.ICodeModel ILearnerModel.TbaNationality
        {
            get { return this.TbaNationality; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        System.String ILearnerModel.TbaNationalityCode
        {
            get { return this.TbaNationalityCode; }
            set { this.TbaNationalityCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_TBA_ETHNICITY" field.
        /// </summary>
        System.String ILearnerModel.TbaEthnicity
        {
            get { return this.TbaEthnicity; }
            set { this.TbaEthnicity = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_AUTH_STATUS" field.
        /// </summary>
        System.Nullable<System.Int32> ILearnerModel.AuthStatus
        {
            get { return this.AuthStatus; }
            set { this.AuthStatus = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_MEDICAL_DET" field.
        /// </summary>
        System.String ILearnerModel.MedicalDet
        {
            get { return this.MedicalDet; }
            set { this.MedicalDet = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:LearnerModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> ILearnerModel.Elements
        {
            get { return this.Elements; }
        }

        #endregion
    }
}
