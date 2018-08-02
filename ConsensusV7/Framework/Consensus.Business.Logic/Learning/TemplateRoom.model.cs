using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalTemplateRoomModel
    {
        protected internal override void Denormalise()
        {
            base.Denormalise();
            this.ModifiedData.Type = 2;
        }
    }
}
