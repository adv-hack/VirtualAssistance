using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "SAQ_STEP_PARAMS" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SaqStepParamsRecord : Record<Int64>, Cloneable<SaqStepParamsRecord>, IEquatable<SaqStepParamsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "STPRM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "STPRM_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "STPRM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "STPRM_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "STPRM_STEP_ID" field.
        /// </summary>
        private Int64 _stepId;

        /// <summary>
        ///     the value of the "STPRM_F_ID" field.
        /// </summary>
        private Int64 _fId;

        /// <summary>
        ///     the value of the "STPRM_CONDITION" field.
        /// </summary>
        private String _condition;

        /// <summary>
        ///     the value of the "STPRM_VALUE" field.
        /// </summary>
        private String _value;

        /// <summary>
        ///     the value of the "STPRM_OPERAND" field.
        /// </summary>
        private String _operand;

        /// <summary>
        ///     the value of the "STPRM_KEEP_WITH_PREVIOUS" field.
        /// </summary>
        private Byte _keepWithPrevious;

        /// <summary>
        ///     the value of the "STPRM_ORDER" field.
        /// </summary>
        private Int32 _order;

        /// <summary>
        ///     the value of the "STPRM_PRE_BRACKET" field.
        /// </summary>
        private String _preBracket;

        /// <summary>
        ///     the value of the "STPRM_POST_BRACKET" field.
        /// </summary>
        private String _postBracket;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "STPRM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_STEP_ID" field.
        /// </summary>
        public Int64 StepId
        {
            get { return _stepId; }
            set { _stepId = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_F_ID" field.
        /// </summary>
        public Int64 FId
        {
            get { return _fId; }
            set { _fId = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_CONDITION" field.
        /// </summary>
        public String Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_VALUE" field.
        /// </summary>
        public String Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_OPERAND" field.
        /// </summary>
        public String Operand
        {
            get { return _operand; }
            set { _operand = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_KEEP_WITH_PREVIOUS" field.
        /// </summary>
        public Byte KeepWithPrevious
        {
            get { return _keepWithPrevious; }
            set { _keepWithPrevious = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_ORDER" field.
        /// </summary>
        public Int32 Order
        {
            get { return _order; }
            set { _order = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_PRE_BRACKET" field.
        /// </summary>
        public String PreBracket
        {
            get { return _preBracket; }
            set { _preBracket = value; }
        }

        /// <summary>
        ///     the value of the "STPRM_POST_BRACKET" field.
        /// </summary>
        public String PostBracket
        {
            get { return _postBracket; }
            set { _postBracket = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SaqStepParamsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SaqStepParamsRecord" /> object instance.
        /// </returns>
        public SaqStepParamsRecord Clone()
        {
            SaqStepParamsRecord record = new SaqStepParamsRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.StepId = this.StepId;
            record.FId = this.FId;
            record.Condition = this.Condition;
            record.Value = this.Value;
            record.Operand = this.Operand;
            record.KeepWithPrevious = this.KeepWithPrevious;
            record.Order = this.Order;
            record.PreBracket = this.PreBracket;
            record.PostBracket = this.PostBracket;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SaqStepParamsRecord" /> instance is equal to another <see cref="SaqStepParamsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SaqStepParamsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SaqStepParamsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.StepId == that.StepId);
            result = result && (this.FId == that.FId);
            result = result && (this.Condition.TrimOrNullify() == that.Condition.TrimOrNullify());
            result = result && (this.Value.TrimOrNullify() == that.Value.TrimOrNullify());
            result = result && (this.Operand.TrimOrNullify() == that.Operand.TrimOrNullify());
            result = result && (this.KeepWithPrevious == that.KeepWithPrevious);
            result = result && (this.Order == that.Order);
            result = result && (this.PreBracket.TrimOrNullify() == that.PreBracket.TrimOrNullify());
            result = result && (this.PostBracket.TrimOrNullify() == that.PostBracket.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
