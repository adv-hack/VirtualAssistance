using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface QueryModel : IModel, IQuerySelectable
    {
        /// <summary>
        ///    Gets or sets the the maximum number of records to be returned.
        /// </summary>
        Int32? Top
        {
            get;
            set;
        }

        /// <summary>
        ///    Gets or sets whether only distinct results are returned. 
        /// </summary>
        Boolean Distinct
        {
            get;
            set;
        }

        QuerySelection[] Selects { get; set; }

        QuerySource Source { get; set; }

        QueryJoin[] Joins { get; set; }

        QueryCondition[] Wheres { get; set; }

        QueryOrder[] Orders { get; set; }
        
    }
}
