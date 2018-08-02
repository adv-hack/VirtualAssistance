using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PaymentRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPaymentCardModel : IPaymentModel
    {
        /// <summary>
        ///     Gets or sets the value of the "PAY_CCARD_TYPE" field.
        /// </summary>
        System.String CardType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_EXPY_DTE" field.
        /// </summary>
        System.Nullable<System.DateTime> CardExpiryDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_ISSUE_NO" field.
        /// </summary>
        System.String CardIssueNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_VALID_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CardStartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CARD_SEC_ID" field.
        /// </summary>
        System.String CardSecurityNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_GATEWAY_ACC_ID" field.
        /// </summary>
        System.String GatewayAccount
        {
            get;
            set;
        }
    }
}
