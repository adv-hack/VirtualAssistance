using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenCustomFieldListitemRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalScreenCustomFieldListitemModel
    {
        protected internal override void Denormalise()
        {
            base.Denormalise();
            // If the user leaves the code (IdValue) blank then 
            // the UI does not retrieve the selected values on pages.
            // Fill blank codes with one constructed from the description.
            // noting that this is not guarenteed to be unique
            if (string.IsNullOrEmpty(this.IdValue))
            {
                this.IdValue = System.Text.RegularExpressions.Regex.Replace(this.Text, "\\s+", "").ToUpper();
                if (IdValue.Length > 11)
                    IdValue = IdValue.Substring(0, 11);
            }
        }
    }
}
