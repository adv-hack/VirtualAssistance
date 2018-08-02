using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="WorkflowRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IWorkflowModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "WF_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DESC" field.
        /// </summary>
        System.String Desc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_REC_TYPE" field.
        /// </summary>
        System.String RecType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_AUTO_LINK" field.
        /// </summary>
        System.Nullable<System.Byte> AutoLink
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_FIRST_WFR_ID" field.
        /// </summary>
        System.String FirstWfrId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DELAY" field.
        /// </summary>
        System.Nullable<System.Int32> Delay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_OCCURS" field.
        /// </summary>
        System.Nullable<System.Byte> Occurs
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DAY_OF_WEEK" field.
        /// </summary>
        System.Nullable<System.Byte> DayOfWeek
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DAILY_FREQ" field.
        /// </summary>
        System.Nullable<System.Byte> DailyFreq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_NORMAL_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> NormalTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_FREQUENCY" field.
        /// </summary>
        System.Nullable<System.Int32> Frequency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_VALID_FROM_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidFromDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_VALID_TO_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidToDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DISABLED" field.
        /// </summary>
        System.Nullable<System.Byte> Disabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_RUN_DATETIME" field.
        /// </summary>
        System.Nullable<System.DateTime> RunDatetime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_LAST_RUN_DTTIME" field.
        /// </summary>
        System.Nullable<System.DateTime> LastRunDttime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_CREATED_BY_V1" field.
        /// </summary>
        System.Boolean CreatedByV1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_GROUP" field.
        /// </summary>
        System.String Group
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_UNIQUE_SYS_NAME" field.
        /// </summary>
        System.String UniqueSysName
        {
            get;
            set;
        }
    }
}
