using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="AddressRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAddressModel : IModel<String>
    {
        System.String MailString
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_BUILDING" field.
        /// </summary>
        System.String Building
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_STREET" field.
        /// </summary>
        System.String Street
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_TOWN" field.
        /// </summary>
        System.String Town
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_AREA" field.
        /// </summary>
        System.String Area
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_COUNTY" field.
        /// </summary>
        System.String County
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_POSTCODE" field.
        /// </summary>
        System.String Postcode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_COUNTRY" field.
        /// </summary>
        System.String Country
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_PHONE" field.
        /// </summary>
        System.String Phone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_FAX" field.
        /// </summary>
        System.String Fax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_EMAIL" field.
        /// </summary>
        System.String Email
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_LAT" field.
        /// </summary>
        System.Nullable<System.Decimal> Lat
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_LONG" field.
        /// </summary>
        System.Nullable<System.Decimal> Long
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_GRID_EAST" field.
        /// </summary>
        System.String GridEast
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_GRID_NORTH" field.
        /// </summary>
        System.String GridNorth
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_MAILSORT_CODE" field.
        /// </summary>
        System.String MailsortCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IRoleModel> Roles
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationAddressModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IOrganisationAddressModel> OrganisationAddresses
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> Locations
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> InvoiceBookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> DeliveryBookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> Learners
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> Accounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountXrefModel> AccountXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> Invoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> MerberPeriodInvoice
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }
    }
}
