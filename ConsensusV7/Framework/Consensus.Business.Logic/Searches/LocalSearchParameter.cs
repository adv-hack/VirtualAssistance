using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalSearchParameter : SearchParameter
    {
        #region fields

        /// <summary>
        ///     The parameter to be included within the search.
        /// </summary>
        private String _parameter;

        /// <summary>
        ///     The value of the search parameter. 
        /// </summary>
        private Object _value;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the parameter to be included within the search.
        /// </summary>
        public String Parameter
        {
            get { return _parameter; }
            set { _parameter = value; }
        }

        /// <summary>
        ///    Gets or sets the value of the search parameter. 
        /// </summary>
        public Object Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #endregion

        #region implementations

        String SearchParameter.Parameter
        {
            get { return this.Parameter; }
        }

        Object SearchParameter.Value
        {
            get { return this.Value; }
            set { this.Value = value; }
        }

        #endregion
    }
}
