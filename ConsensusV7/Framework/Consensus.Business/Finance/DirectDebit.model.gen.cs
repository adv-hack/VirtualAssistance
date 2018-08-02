using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="DirectdebitRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IDirectDebitModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "DD_TABLE_NUM" field.
        /// </summary>
        System.Nullable<System.Double> TableNum
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "DD_REC_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel MemberPeriod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DD_REC_ID" field.
        /// </summary>
        System.String MemberPeriodId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TYPE" field.
        /// </summary>
        System.Nullable<System.Int32> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_OIN" field.
        /// </summary>
        System.String ServiceUserNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_REC_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> RecDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_REC_METHOD" field.
        /// </summary>
        System.Nullable<System.Int32> RecMethod
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_EFFECTIVE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EffectiveDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_STATUS" field.
        /// </summary>
        System.Nullable<System.Int32> Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_FREQUENCY" field.
        /// </summary>
        System.Nullable<System.Int32> Frequency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_DAY_OF_MONTH" field.
        /// </summary>
        System.Nullable<System.Int32> DayOfMonth
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_VARIABLE" field.
        /// </summary>
        System.Nullable<System.Int32> Variable
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_MAX_VALUE" field.
        /// </summary>
        System.Nullable<System.Decimal> MaxValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_NAME" field.
        /// </summary>
        System.String BankName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_1" field.
        /// </summary>
        System.String BankAdd1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_2" field.
        /// </summary>
        System.String BankAdd2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_3" field.
        /// </summary>
        System.String BankAdd3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_4" field.
        /// </summary>
        System.String BankAdd4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_POSTCODE" field.
        /// </summary>
        System.String BankPostcode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ACC_NAME" field.
        /// </summary>
        System.String BankAccName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ACC_CODE" field.
        /// </summary>
        System.String BankAccCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_SORT_CODE" field.
        /// </summary>
        System.String SortCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TOTAL" field.
        /// </summary>
        System.Nullable<System.Decimal> Total
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        System.Nullable<System.Int32> NoOfInstallments
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_DUE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> DueDate
        {
            get;
            set;
        }
    }
}
