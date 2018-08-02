using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectColumnRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalScreenObjectColumnModel
    {
        protected override void Initialise()
        {
            base.Initialise();
            this.Exportable = true;
            this.Visible = true;
        }
    }
}
