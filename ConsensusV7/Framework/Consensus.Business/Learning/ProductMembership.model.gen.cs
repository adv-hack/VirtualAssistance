using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Document;
using Consensus.Membership;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductMembershipModel : IProductModel
    {
        #region properties

        /// <summary>
        ///     Gets or sets whether the membership product has a fixed renewal date.
        /// </summary>
        System.Boolean IsRenewalFixed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the day on which the fixed renewal occurs.
        /// </summary>
        System.Int32 RenewalDay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the month on which the fixed renewal occurs.
        /// </summary>
        System.Int32 RenewalMonth
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the minimum number of days allowed for a renewing membership.
        /// </summary>
        System.Int32 RenewalExclusion
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_NEW" field.
        /// </summary>
        Consensus.Document.IPackModel JoiningPack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_NEW" field.
        /// </summary>
        System.String JoiningPackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND1" field.
        /// </summary>
        Consensus.Document.IPackModel Remind1Pack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND1" field.
        /// </summary>
        System.String Remind1PackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND2" field.
        /// </summary>
        Consensus.Document.IPackModel Remind2Pack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND2" field.
        /// </summary>
        System.String Remind2PackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_RENEW" field.
        /// </summary>
        Consensus.Document.IPackModel RenewalPack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_RENEW" field.
        /// </summary>
        System.String RenewalPackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_LAPSED" field.
        /// </summary>
        Consensus.Document.IPackModel LapsedPack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_LAPSED" field.
        /// </summary>
        System.String LapsedPackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_CANCEL" field.
        /// </summary>
        Consensus.Document.IPackModel CancelPack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_CANCEL" field.
        /// </summary>
        System.String CancelPackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_GROUP" field.
        /// </summary>
        System.Nullable<System.Byte> MsGroup
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_RENEW_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> RenewDays
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MEM_INV_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> MemInvType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_REMIND3" field.
        /// </summary>
        Consensus.Document.IPackModel Remind3Pack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_REMIND3" field.
        /// </summary>
        System.String Remind3PackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM1_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> Reminder1Days
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM2_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> Reminder2Days
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_RM3_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> Reminder3Days
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MS_LAPS_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> LapsedDays
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_RENEWED" field.
        /// </summary>
        Consensus.Document.IPackModel RenewedPack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_RENEWED" field.
        /// </summary>
        System.String RenewedPackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXCL_CALC" field.
        /// </summary>
        System.Nullable<System.Byte> ExclCalc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SG_NO" field.
        /// </summary>
        System.Nullable<System.Int32> NumberOfSpecialistGroups
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_APP" field.
        /// </summary>
        Consensus.Document.IPackModel AppPack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_APP" field.
        /// </summary>
        System.String AppPackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MS_OFF" field.
        /// </summary>
        Consensus.Document.IPackModel OfferPack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MS_OFF" field.
        /// </summary>
        System.String OfferPackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NO_INV_RENEW" field.
        /// </summary>
        System.Nullable<System.Byte> NoInvRenew
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PREFIX" field.
        /// </summary>
        System.String Prefix
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NON_RENEW_MEMB" field.
        /// </summary>
        System.Byte NonRenewMemb
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        System.Nullable<System.Int32> DdNoOfInstallments
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DD_FREQUENCY" field.
        /// </summary>
        System.Nullable<System.Int32> DdFrequency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MEM_FIRST_BOOK" field.
        /// </summary>
        System.Byte MemFirstBook
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:ProductMembershipModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> MemberPeriods
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:ProductMembershipModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Calculates the proposed end date for a membership that is based upon this product, based on the specified start date.
        /// </summary>
        /// <param name="startDate">
        ///     The proposed start date for the membership.
        /// </param>
        /// <returns>
        ///     The proposed end date for the membership.
        /// </returns>
        System.DateTime CalculateMembershipEndDate(System.DateTime startDate);

        /// <summary>
        ///     Calculates the price for a new membership that is based upon this product.
        /// </summary>
        /// <param name="personId">
        ///     The person that the membership is for.
        /// </param>
        /// <param name="startDate">
        ///     The date on which the membership will start.
        /// </param>
        /// <param name="endDate">
        ///     The date on which the membership will end.
        /// </param>
        /// <param name="priceList">
        ///     The price list from which the price is selected.
        /// </param>
        System.Object CalculateMembershipPrice(System.String personId, System.Int32 quantity, System.DateTime startDate, System.DateTime endDate, System.String priceList);

        #endregion
    }
}
