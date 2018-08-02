using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalQuerySelect : QuerySelection
    {
        #region fields

        /// <summary>
        ///     The column that is returned by the query.
        /// </summary>
        private String _column;

        /// <summary>
        ///     The alias for the sele3ction.
        /// </summary>
        private String _alias;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the column that is returned by the query.
        /// </summary>
        public String Column
        {
            get { return _column; }
            set { _column = value; }
        }

        /// <summary>
        ///    Gets or sets the alias for the selection.
        /// </summary>
        public String Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        /// <summary>
        ///     Gets the SQL for this query element
        /// </summary>
        internal String Sql
        {
            get { return String.Format(String.IsNullOrEmpty(this.Alias) ? " [{0}] " : " [{0}] as [{1}] ", this.Column.Replace(".", "].["), this.Alias) + Environment.NewLine; }
        }

        #endregion

        #region implementations

        /// <summary>
        ///    Gets the column that is returned by the query.
        /// </summary>
        String QuerySelection.Column
        {
            get { return this.Column; }
        }

        /// <summary>
        ///    Gets the alias for the selection.
        /// </summary>
        String QuerySelection.Alias
        {
            get { return this.Alias; }
        }

        #endregion
    }
}
