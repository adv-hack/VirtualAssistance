using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="TimeSpentRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITimeSpentModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "TIM_RCV_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> RcvDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_RCV_FROM" field.
        /// </summary>
        System.String RcvFrom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ACT_ID" field.
        /// </summary>
        System.String ActId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ROLE_ID" field.
        /// </summary>
        System.String RoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_HOURS" field.
        /// </summary>
        System.Nullable<System.Double> Hours
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_DESC" field.
        /// </summary>
        System.String Desc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ORG_ID" field.
        /// </summary>
        System.String OrgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRA_HOURS" field.
        /// </summary>
        System.Nullable<System.Double> TraHours
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_HOU_CHARGE" field.
        /// </summary>
        System.Nullable<System.Double> HouCharge
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRA_CHARGE" field.
        /// </summary>
        System.Nullable<System.Double> TraCharge
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_MILEAGE" field.
        /// </summary>
        System.Nullable<System.Decimal> Mileage
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_EXPENSES" field.
        /// </summary>
        System.Nullable<System.Decimal> Expenses
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_CST_AC" field.
        /// </summary>
        System.Nullable<System.Double> CstAc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_UNT_TYPE" field.
        /// </summary>
        System.String UntType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        Consensus.Common.ICodeModel TimTypeDropdown
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        System.String TimTypeDropdownCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRAIN_SY_TYPE" field.
        /// </summary>
        System.Int16 TrainSyType
        {
            get;
            set;
        }
    }
}
