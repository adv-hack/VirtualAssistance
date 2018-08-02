using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MemberBomRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalMemberBomModel
    {
        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if (this.Main == 1)
            {
                var otherDefaults = this.Provider.Membership.MemberBom.FetchAllByProdParentIdId(this.ProdParentIdId).Where(grade => grade.Id != this.Id).ToArray();
                //LocalMemberBomModel[] otherDefaults = this.ProdParentId.GiftAid.Where(giftAid => giftAid.Id != this.Id && (giftAid.EndDate == null || giftAid.Active)).ToArray();
                //otherGiftAids.Execute(giftAid => giftAid.EndDate = giftAid.EndDate ?? DateTime.Today).Execute(giftAid => giftAid.Active = false).Execute(giftAid => giftAid.Save());
                otherDefaults.Execute(grade => grade.Main = 0).Execute(grade => grade.Save());


            }
        }
    }
}
