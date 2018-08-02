using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalQueryOrder : QueryOrder
    {
        #region fields

        /// <summary>
        ///     The correlation by which the result is sorted.
        /// </summary>
        private String _correlation;

        /// <summary>
        ///     Specifies whether the result is returned in ascending or descending order.
        /// </summary>
        private Boolean _ascending;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the correlation by which the result is sorted.
        /// </summary>
        public String Correlation
        {
            get { return _correlation; }
            set { _correlation = value; }
        }

        /// <summary>
        ///    Gets or sets whether the result is returned in ascending or descending order. 
        /// </summary>
        public Boolean Ascending
        {
            get { return _ascending; }
            set { _ascending = value; }
        }

        /// <summary>
        ///     Gets the SQL for this query element
        /// </summary>
        internal String Sql
        {
            get { return String.Format(" [{0}] {1} ", this.Correlation, this.Ascending ? "asc" : "desc") + Environment.NewLine; }
        }

        #endregion

        #region implementations

        String QueryOrder.Correlation
        {
            get { return this.Correlation; }
        }

        Boolean QueryOrder.Ascending
        {
            get { return this.Ascending; }
        }


        #endregion
    }
}
