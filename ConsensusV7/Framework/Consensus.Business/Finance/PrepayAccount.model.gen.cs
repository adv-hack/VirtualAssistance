using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="MasterClubRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPrepayAccountModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "MSTC_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_MEMB_VAL" field.
        /// </summary>
        System.Decimal TotalPaidToDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_CONTACT" field.
        /// </summary>
        Consensus.Contact.IRoleModel Contact
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_CONTACT" field.
        /// </summary>
        System.String ContactId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_PAY_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> PayDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_TOT_POINTS" field.
        /// </summary>
        System.Decimal TotalPoints
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_REMAIN_PTS" field.
        /// </summary>
        System.Decimal RemainPts
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_STOP_FLAG" field.
        /// </summary>
        System.Nullable<System.Byte> Stopped
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAMED_USERS" field.
        /// </summary>
        System.Nullable<System.Byte> NamedUsers
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_CURRENCY_TYPE" field.
        /// </summary>
        System.String CurrencyType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel Membership
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_MEP_ID" field.
        /// </summary>
        System.String MembershipId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAMED_BOOKERS" field.
        /// </summary>
        System.Nullable<System.Byte> NamedBookers
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_UNIQUE_REF" field.
        /// </summary>
        System.String UniqueRef
        {
            get;
            set;
        }
    }
}
