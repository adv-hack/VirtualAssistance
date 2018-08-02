using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Membership;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Learner : Proxy<ILearnerModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Booking" /> member.
        /// </summary>
        private Consensus.Learning.Booking _booking;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DelegateOrg" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _delegateOrg;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DelegatePerson" /> member.
        /// </summary>
        private Consensus.Contact.Person _delegatePerson;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DelegateRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _delegateRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MemberPeriod" /> member.
        /// </summary>
        private Consensus.Membership.MemberPeriod _memberPeriod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DelegateAddress" /> member.
        /// </summary>
        private Consensus.Contact.Address _delegateAddress;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="TbaGender" /> member.
        /// </summary>
        private Consensus.Common.Code _tbaGender;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="TbaNationality" /> member.
        /// </summary>
        private Consensus.Common.Code _tbaNationality;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "DEL_BOOK_ID" field.
        /// </summary>
        public Consensus.Learning.Booking Booking
        {
            get
            {
                if (_booking == null && this.Model.Booking != null)
                    _booking = new Consensus.Learning.Booking(this.Model.Booking);
                if (_booking == null)
                    _booking = Consensus.Learning.Booking.Create();
                return _booking;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_BOOK_ID" field.
        /// </summary>
        public System.String BookingId
        {
            get { return this.Model.BookingId; }
            set { this.Model.BookingId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation DelegateOrg
        {
            get
            {
                if (_delegateOrg == null && this.Model.DelegateOrg != null)
                    _delegateOrg = new Consensus.Contact.Organisation(this.Model.DelegateOrg);
                if (_delegateOrg == null)
                    _delegateOrg = Consensus.Contact.Organisation.Create();
                return _delegateOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_ORG_ID" field.
        /// </summary>
        public System.String DelegateOrgId
        {
            get { return this.Model.DelegateOrgId; }
            set { this.Model.DelegateOrgId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_PERSON_ID" field.
        /// </summary>
        public Consensus.Contact.Person DelegatePerson
        {
            get
            {
                if (_delegatePerson == null && this.Model.DelegatePerson != null)
                    _delegatePerson = new Consensus.Contact.Person(this.Model.DelegatePerson);
                if (_delegatePerson == null)
                    _delegatePerson = Consensus.Contact.Person.Create();
                return _delegatePerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_PERSON_ID" field.
        /// </summary>
        public System.String DelegatePersonId
        {
            get { return this.Model.DelegatePersonId; }
            set { this.Model.DelegatePersonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_QUANTITY" field.
        /// </summary>
        public System.Nullable<System.Double> Quantity
        {
            get { return this.Model.Quantity; }
            set { this.Model.Quantity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_NET_VAL" field.
        /// </summary>
        public System.Decimal NetValue
        {
            get { return this.Model.NetValue; }
            set { this.Model.NetValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_VAT_AMT" field.
        /// </summary>
        public System.Decimal VatAmount
        {
            get { return this.Model.VatAmount; }
            set { this.Model.VatAmount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_TOT_PRICE" field.
        /// </summary>
        public System.Decimal TotalPrice
        {
            get { return this.Model.TotalPrice; }
            set { this.Model.TotalPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_BOOK_APPROVED" field.
        /// </summary>
        public System.Nullable<System.Byte> Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role DelegateRole
        {
            get
            {
                if (_delegateRole == null && this.Model.DelegateRole != null)
                    _delegateRole = new Consensus.Contact.Role(this.Model.DelegateRole);
                if (_delegateRole == null)
                    _delegateRole = Consensus.Contact.Role.Create();
                return _delegateRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_PROLE_ID" field.
        /// </summary>
        public System.String DelegateRoleId
        {
            get { return this.Model.DelegateRoleId; }
            set { this.Model.DelegateRoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_SPEC_REQ" field.
        /// </summary>
        public System.String SpecReq
        {
            get { return this.Model.SpecReq; }
            set { this.Model.SpecReq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_BADGE_NAME" field.
        /// </summary>
        public System.String BadgeName
        {
            get { return this.Model.BadgeName; }
            set { this.Model.BadgeName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_MEP_ID" field.
        /// </summary>
        public Consensus.Membership.MemberPeriod MemberPeriod
        {
            get
            {
                if (_memberPeriod == null && this.Model.MemberPeriod != null)
                    _memberPeriod = new Consensus.Membership.MemberPeriod(this.Model.MemberPeriod);
                if (_memberPeriod == null)
                    _memberPeriod = Consensus.Membership.MemberPeriod.Create();
                return _memberPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_MEP_ID" field.
        /// </summary>
        public System.String MemberPeriodId
        {
            get { return this.Model.MemberPeriodId; }
            set { this.Model.MemberPeriodId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_DIET_REQUIRE" field.
        /// </summary>
        public System.String DietRequire
        {
            get { return this.Model.DietRequire; }
            set { this.Model.DietRequire = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_SURNAME" field.
        /// </summary>
        public System.String Surname
        {
            get { return this.Model.Surname; }
            set { this.Model.Surname = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_MEM_REF" field.
        /// </summary>
        public System.String MemRef
        {
            get { return this.Model.MemRef; }
            set { this.Model.MemRef = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address DelegateAddress
        {
            get
            {
                if (_delegateAddress == null && this.Model.DelegateAddress != null)
                    _delegateAddress = new Consensus.Contact.Address(this.Model.DelegateAddress);
                if (_delegateAddress == null)
                    _delegateAddress = Consensus.Contact.Address.Create();
                return _delegateAddress;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_ADD_ID" field.
        /// </summary>
        public System.String DelegateAddressId
        {
            get { return this.Model.DelegateAddressId; }
            set { this.Model.DelegateAddressId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_TBA_GENDER" field.
        /// </summary>
        public Consensus.Common.Code TbaGender
        {
            get
            {
                if (_tbaGender == null && this.Model.TbaGender != null)
                    _tbaGender = new Consensus.Common.Code(this.Model.TbaGender);
                if (_tbaGender == null)
                    _tbaGender = Consensus.Common.Code.Create();
                return _tbaGender;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_TBA_GENDER" field.
        /// </summary>
        public System.String TbaGenderCode
        {
            get { return this.Model.TbaGenderCode; }
            set { this.Model.TbaGenderCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        public Consensus.Common.Code TbaNationality
        {
            get
            {
                if (_tbaNationality == null && this.Model.TbaNationality != null)
                    _tbaNationality = new Consensus.Common.Code(this.Model.TbaNationality);
                if (_tbaNationality == null)
                    _tbaNationality = Consensus.Common.Code.Create();
                return _tbaNationality;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        public System.String TbaNationalityCode
        {
            get { return this.Model.TbaNationalityCode; }
            set { this.Model.TbaNationalityCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_TBA_ETHNICITY" field.
        /// </summary>
        public System.String TbaEthnicity
        {
            get { return this.Model.TbaEthnicity; }
            set { this.Model.TbaEthnicity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_AUTH_STATUS" field.
        /// </summary>
        public System.Nullable<System.Int32> AuthStatus
        {
            get { return this.Model.AuthStatus; }
            set { this.Model.AuthStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_MEDICAL_DET" field.
        /// </summary>
        public System.String MedicalDet
        {
            get { return this.Model.MedicalDet; }
            set { this.Model.MedicalDet = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:LearnerModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Learner(ILearnerModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public static Consensus.Learning.Learner DelegatesToConfirm(System.String bookId, System.String approver)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.DelegatesToConfirm(site,bookId,approver);
        }

        public static Consensus.Learning.Learner DelegatesToConfirm(ConsensusSite site, System.String bookId, System.String approver)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ILearnerModel model = provider.Learning.Learner.DelegatesToConfirm(bookId,approver);
            return model == null ? null : new Consensus.Learning.Learner(model);
        }

        public static Consensus.Learning.Learner CancelBooking(System.String bookId, System.String userLoginId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.CancelBooking(site,bookId,userLoginId);
        }

        public static Consensus.Learning.Learner CancelBooking(ConsensusSite site, System.String bookId, System.String userLoginId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ILearnerModel model = provider.Learning.Learner.CancelBooking(bookId,userLoginId);
            return model == null ? null : new Consensus.Learning.Learner(model);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LearnerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LearnerModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Learner Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LearnerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LearnerModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Learner Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ILearnerModel model = provider.Learning.Learner.Create();
            return model == null ? null : new Consensus.Learning.Learner(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LearnerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LearnerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LearnerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LearnerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ILearnerModel> collection = provider.Learning.Learner.FetchAll();
            return collection.Select(model => new Consensus.Learning.Learner(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LearnerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LearnerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Learner FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LearnerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LearnerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Learner FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ILearnerModel model = provider.Learning.Learner.FetchById(id);
            return model == null ? null : new Consensus.Learning.Learner(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.Learner.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByBookingId(System.String bookingId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.FetchAllByBookingId(site,bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByBookingId(ConsensusSite site, System.String bookingId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ILearnerModel> collection = provider.Learning.Learner.FetchAllByBookingId(bookingId);
            return collection.Select(model => new Consensus.Learning.Learner(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateOrgId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByDelegateOrgId(System.String delegateOrgId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.FetchAllByDelegateOrgId(site,delegateOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateOrgId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByDelegateOrgId(ConsensusSite site, System.String delegateOrgId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ILearnerModel> collection = provider.Learning.Learner.FetchAllByDelegateOrgId(delegateOrgId);
            return collection.Select(model => new Consensus.Learning.Learner(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegatePersonId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegatePersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByDelegatePersonId(System.String delegatePersonId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.FetchAllByDelegatePersonId(site,delegatePersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegatePersonId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegatePersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByDelegatePersonId(ConsensusSite site, System.String delegatePersonId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ILearnerModel> collection = provider.Learning.Learner.FetchAllByDelegatePersonId(delegatePersonId);
            return collection.Select(model => new Consensus.Learning.Learner(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateRoleId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByDelegateRoleId(System.String delegateRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.FetchAllByDelegateRoleId(site,delegateRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateRoleId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByDelegateRoleId(ConsensusSite site, System.String delegateRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ILearnerModel> collection = provider.Learning.Learner.FetchAllByDelegateRoleId(delegateRoleId);
            return collection.Select(model => new Consensus.Learning.Learner(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.FetchAllByMemberPeriodId(site,memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByMemberPeriodId(ConsensusSite site, System.String memberPeriodId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ILearnerModel> collection = provider.Learning.Learner.FetchAllByMemberPeriodId(memberPeriodId);
            return collection.Select(model => new Consensus.Learning.Learner(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateAddressId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateAddressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByDelegateAddressId(System.String delegateAddressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Learner.FetchAllByDelegateAddressId(site,delegateAddressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateAddressId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateAddressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Learner> FetchAllByDelegateAddressId(ConsensusSite site, System.String delegateAddressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ILearnerModel> collection = provider.Learning.Learner.FetchAllByDelegateAddressId(delegateAddressId);
            return collection.Select(model => new Consensus.Learning.Learner(model));
        }

        #endregion
    }
}
