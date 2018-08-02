using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalQuerySource : QuerySource
    {
        #region fields

        /// <summary>
        ///     The source of the query or the join.
        /// </summary>
        private QuerySources _source;

        /// <summary>
        ///     The alias applied to the query source.
        /// </summary>
        private String _alias;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the source of the query or the join.
        /// </summary>
        public QuerySources Source
        {
            get { return _source; }
            set { _source = value; }
        }

        /// <summary>
        ///    Gets or sets the alias applied to the query source.
        /// </summary>
        public String Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        /// <summary>
        ///     Gets the SQL for this query element
        /// </summary>
        internal virtual String Sql
        {
            get
            {
                String sourceName = String.Format(this.Source < 0 ? "{0}" : "vConsensus{0}", this.Source);
                String aliasName = this.Alias.TrimOrNullify() ?? sourceName;
                return String.Concat(" from ", String.Format("[{0}] as [{1}]", sourceName, aliasName)) + Environment.NewLine;
            }
        }

        #endregion

        #region implementations

        QuerySources QuerySource.Source
        {
            get { return this.Source; }
        }

        String QuerySource.Alias
        {
            get { return this.Alias; }
        }

        #endregion
    }
}
