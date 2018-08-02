using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PackXrefRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalPackXrefModel
    {
        /// <summary>
        ///     Updates the seq for the pack xref records
        /// </summary>
        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if ((this.Seq == 0))
            {
                if (!string.IsNullOrEmpty(this.LitId.Id))
                {
                    LocalPackXrefModel[] othercovers = this.PackId.PackId.Where(PackXref => PackXref.PackId.Id == this.PackId.Id && PackXref.Id != this.Id && (PackXref.Seq == 0) && PackXref.LitId.LtId.Type.Id == this.LitId.LtId.Type.Id).ToArray();
                    othercovers.Execute(PackXref => PackXref.Seq = 99).Execute(PackXref => PackXref.Save());
                }
            }
        }
    }
}
