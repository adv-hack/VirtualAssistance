using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PayAllocationRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalPayAllocationModel
    {
        ///// <summary>
        /////     The Paid is PA_ID which will be used for reversal.
        ///// </summary>
        private string _paid;
        ///// <summary>
        /////     The Paid is PA_ID which will be used for reversal.
        ///// </summary>
        public string Paid
        {
            set { _paid = value; }
        }
        ///// <summary>
        /////     The Reverse specifies that the record is a reversal.
        ///// </summary>
        private Boolean _reverse;
        ///// <summary>
        /////     The Reverse specifies that the record is a reversal.
        ///// </summary>
        public Boolean Reverse
        {
            set { _reverse = value; }
        }
        public override void Save()
        {
            if (this.IsPersisted || Boolean.Equals(_reverse, 0))
                base.Save();
            else
                base.Save((rec)=>this.Provider.DataProvider.Finance.PayAllocation.CreateReverse(rec,_reverse,_paid));
        }
    }
}
