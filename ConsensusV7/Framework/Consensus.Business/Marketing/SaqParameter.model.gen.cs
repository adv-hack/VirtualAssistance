using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqStepParamsRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqParameterModel : IModel<Int64>
    {
        /// <summary>
        ///     Gets the The value of the "STPRM_STEP_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqStepModel Step
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STPRM_STEP_ID" field.
        /// </summary>
        System.Int64 StepId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "STPRM_F_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqFilterFieldModel FilterField
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STPRM_F_ID" field.
        /// </summary>
        System.Int64 FilterFieldId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_CONDITION" field.
        /// </summary>
        System.String Condition
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_VALUE" field.
        /// </summary>
        System.String Value
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_OPERAND" field.
        /// </summary>
        System.String Operand
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_ORDER" field.
        /// </summary>
        System.Int32 Order
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_PRE_BRACKET" field.
        /// </summary>
        System.String PreBracket
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_POST_BRACKET" field.
        /// </summary>
        System.String PostBracket
        {
            get;
            set;
        }
    }
}
