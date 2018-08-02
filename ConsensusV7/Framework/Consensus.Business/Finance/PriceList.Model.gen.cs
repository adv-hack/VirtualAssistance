using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PriceListRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPriceListModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "PL_CURRENCY" field.
        /// </summary>
        System.String Currency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VALID_FROM" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidFrom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VALID_UNTIL" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidUntil
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_ORG_ONLY" field.
        /// </summary>
        System.Nullable<System.Byte> OrgOnly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VAT_CODE" field.
        /// </summary>
        System.String VatCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PriceModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPriceModel> Prices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }
    }
}
