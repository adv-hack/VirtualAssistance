using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="AssociatesRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalAssociateModel
    {
        protected internal override void Denormalise()
        {
            this.TypeNumber = this.Type == null ? (Byte)0 : this.Type.Value3.ConvertTo<Byte>(0);
        }
    }
}
