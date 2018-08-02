using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Membership;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="DelegateRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILearnerModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "DEL_BOOK_ID" field.
        /// </summary>
        Consensus.Learning.IBookingModel Booking
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_BOOK_ID" field.
        /// </summary>
        System.String BookingId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "DEL_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel DelegateOrg
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_ORG_ID" field.
        /// </summary>
        System.String DelegateOrgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "DEL_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel DelegatePerson
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_PERSON_ID" field.
        /// </summary>
        System.String DelegatePersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_QUANTITY" field.
        /// </summary>
        System.Nullable<System.Double> Quantity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_NET_VAL" field.
        /// </summary>
        System.Decimal NetValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_VAT_AMT" field.
        /// </summary>
        System.Decimal VatAmount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_TOT_PRICE" field.
        /// </summary>
        System.Decimal TotalPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_BOOK_APPROVED" field.
        /// </summary>
        System.Nullable<System.Byte> Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "DEL_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel DelegateRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_PROLE_ID" field.
        /// </summary>
        System.String DelegateRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_SPEC_REQ" field.
        /// </summary>
        System.String SpecReq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_BADGE_NAME" field.
        /// </summary>
        System.String BadgeName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "DEL_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel MemberPeriod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_MEP_ID" field.
        /// </summary>
        System.String MemberPeriodId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_DIET_REQUIRE" field.
        /// </summary>
        System.String DietRequire
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_SURNAME" field.
        /// </summary>
        System.String Surname
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_MEM_REF" field.
        /// </summary>
        System.String MemRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "DEL_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel DelegateAddress
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_ADD_ID" field.
        /// </summary>
        System.String DelegateAddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "DEL_TBA_GENDER" field.
        /// </summary>
        Consensus.Common.ICodeModel TbaGender
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_TBA_GENDER" field.
        /// </summary>
        System.String TbaGenderCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        Consensus.Common.ICodeModel TbaNationality
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DEL_TBA_NATIONALITY" field.
        /// </summary>
        System.String TbaNationalityCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_TBA_ETHNICITY" field.
        /// </summary>
        System.String TbaEthnicity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_AUTH_STATUS" field.
        /// </summary>
        System.Nullable<System.Int32> AuthStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DEL_MEDICAL_DET" field.
        /// </summary>
        System.String MedicalDet
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:LearnerModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }
    }
}
