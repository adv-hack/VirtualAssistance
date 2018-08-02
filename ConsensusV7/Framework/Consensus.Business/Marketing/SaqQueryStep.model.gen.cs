using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqQueryStepsRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueryStepModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "QSTEP_QRY_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqQueryModel StepQuery
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QSTEP_QRY_ID" field.
        /// </summary>
        System.Int64 StepQueryId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QSTEP_STEP_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqStepModel Step
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QSTEP_STEP_ID" field.
        /// </summary>
        System.Int64 StepId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_LINK" field.
        /// </summary>
        System.String Link
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ORDER" field.
        /// </summary>
        System.Int16 Order
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_RESULT_COUNT" field.
        /// </summary>
        System.Int64 ResultCount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ORG_TOTAL" field.
        /// </summary>
        System.Int64 OrgTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ROLE_TOTAL" field.
        /// </summary>
        System.Int64 RoleTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_PERSON_TOTAL" field.
        /// </summary>
        System.Int64 PersonTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_LOCKED" field.
        /// </summary>
        System.Byte Locked
        {
            get;
            set;
        }
    }
}
