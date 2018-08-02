using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public abstract class LocalQueryCondition : QueryCondition
    {
        #region fields

        /// <summary>
        ///    The ordinal number of the condition 
        /// </summary>
        private Int32 _ordinal;

        /// <summary>
        ///    The correlation that is evaluated.
        /// </summary>
        private String _correlation;

        /// <summary>
        ///    The type of the condition
        /// </summary>
        private QueryConditionTypes _type;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the ordinal number of the condition 
        /// </summary>
        public Int32 Ordinal
        {
            get { return _ordinal; }
            set { _ordinal = value; }
        }

        /// <summary>
        ///    Gets or sets the correlation that is evaluated.
        /// </summary>
        public String Correlation
        {
            get { return _correlation; }
            set { _correlation = value; }
        }

        /// <summary>
        ///    Gets or sets the type of the condition
        /// </summary>
        public QueryConditionTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     Gets the SQL for this query element
        /// </summary>
        internal abstract String Sql
        {
            get;
        }

        #endregion

        #region implementations

        String QueryCondition.Correlation
        {
            get { return this.Correlation; }
        }

        QueryConditionTypes QueryCondition.Type
        {
            get { return this.Type; }
        }

        #endregion
    }

    public class LocalQueryConditionValue : LocalQueryCondition
    {
        #region fields

        /// <summary>
        ///    The value of the condition.
        /// </summary>
        private Object _value;

        /// <summary>
        ///    The naming convention for the parameter.
        /// </summary>
        private String _parameterPrefix;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the value of the condition.
        /// </summary>
        public Object Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        ///    Gets or sets the naming convention for the parameter.
        /// </summary>
        public String ParameterPrefix
        {
            get { return _parameterPrefix; }
            set { _parameterPrefix = value; }
        }

        /// <summary>
        ///    Gets the name of the parameter.
        /// </summary>
        public String ParameterName
        {
            get { return String.Concat("@", this.ParameterPrefix, this.Ordinal); }
        }

        internal override String Sql
        {
            get
            {
                String conditionFormat;
                switch (this.Type)
                {
                    case QueryConditionTypes.NotEqual: conditionFormat = " [{0}] <> {1} "; break;
                    case QueryConditionTypes.LessThan: conditionFormat = " [{0}] < {1} "; break;
                    case QueryConditionTypes.LessThanOrEqual: conditionFormat = " [{0}] <= {1} "; break;
                    case QueryConditionTypes.GreaterThan: conditionFormat = " [{0}] > {1} "; break;
                    case QueryConditionTypes.GreaterThanOrEqual: conditionFormat = " [{0}] >= {1} "; break;
                    case QueryConditionTypes.Contains: conditionFormat = " [{0}] like '%' + {1} + '%' "; break;
                    case QueryConditionTypes.StartsWith: conditionFormat = " [{0}] like {1} + '%' "; break;
                    case QueryConditionTypes.EndsWith: conditionFormat = " [{0}] like '%' + {1} "; break;
                    case QueryConditionTypes.DoesNotContain: conditionFormat = " [{0}] not like '%' + {1} + '%'"; break;
                    case QueryConditionTypes.DoesNotStartWith: conditionFormat = " [{0}] not like {1} + '%'"; break;
                    case QueryConditionTypes.DoesNotEndWith: conditionFormat = " [{0}] not like '%' + {1} "; break;
                    default: conditionFormat = " [{0}] = {1} "; break;
                }
                return String.Format(conditionFormat, this.Correlation, this.ParameterName) + Environment.NewLine;
            }
        }

        #endregion
    }

    public class LocalQueryConditionCorrelation : LocalQueryCondition
    {
        #region fields

        /// <summary>
        ///    The correlation that this matched.
        /// </summary>
        private String _matchCorrelation;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the correlation that this matched.
        /// </summary>
        public String MatchCorrelation
        {
            get { return _matchCorrelation; }
            set { _matchCorrelation = value; }
        }

        internal override String Sql
        {
            get
            {
                String conditionFormat;
                switch (this.Type)
                {
                    case QueryConditionTypes.NotEqual: conditionFormat = " [{0}] <> [{1}] "; break;
                    case QueryConditionTypes.LessThan: conditionFormat = " [{0}] < [{1}] "; break;
                    case QueryConditionTypes.LessThanOrEqual: conditionFormat = " [{0}] <= [{1}] "; break;
                    case QueryConditionTypes.GreaterThan: conditionFormat = " [{0}] > [{1}] "; break;
                    case QueryConditionTypes.GreaterThanOrEqual: conditionFormat = " [{0}] >= [{1}] "; break;
                    case QueryConditionTypes.Contains: conditionFormat = " [{0}] like '%' + [{1}] + '%' "; break;
                    case QueryConditionTypes.StartsWith: conditionFormat = " [{0}] like [{1}] + '%' "; break;
                    case QueryConditionTypes.EndsWith: conditionFormat = " [{0}] like '%' + [{1}] "; break;
                    case QueryConditionTypes.DoesNotContain: conditionFormat = " [{0}] not like '%' + [{1}] + '%'"; break;
                    case QueryConditionTypes.DoesNotStartWith: conditionFormat = " [{0}] not like [{1}] + '%'"; break;
                    case QueryConditionTypes.DoesNotEndWith: conditionFormat = " [{0}] not like '%' + [{1}] "; break;
                    default: conditionFormat = " [{0}] = [{1}] "; break;
                }
                return String.Format(conditionFormat, this.Correlation, this.MatchCorrelation) + Environment.NewLine;
            }
        }

        #endregion
    }

    public class LocalQueryConditionRaw : LocalQueryConditionValue
    {
        #region fields

        /// <summary>
        ///    The raw SQL condition that will be matched.
        /// </summary>
        private String _rawCondition;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the raw SQL condition that will be matched.
        /// </summary>
        public String RawCondition
        {
            get { return _rawCondition; }
            set { _rawCondition = value; }
        }

        internal override String Sql
        {
            get
            {
                return this.RawCondition.Replace("@value", this.ParameterName) + Environment.NewLine;
            }
        }

        #endregion
    }
}
