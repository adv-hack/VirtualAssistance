using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MemberLocationRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalMemberLocationModel
    {
        public Boolean Overseas
        {
            get { return this.ModifiedData.Overseas == 1; }
            set { this.ModifiedData.Overseas = (Byte)(value ? 1 : 0); }
        }

        private Decimal _feeamount;
        
        public Decimal FeeAmount
        {
            set { _feeamount = value; }
        }

        public override void Save()
        {
            if (this.SyType.Equals(3))
            {
                base.Save((rec) => this.Provider.DataProvider.Membership.MemberLocation.CreateDiscount(rec, _feeamount));
            }

            else
            {
                base.Save();
            }        
        }
    }

}

