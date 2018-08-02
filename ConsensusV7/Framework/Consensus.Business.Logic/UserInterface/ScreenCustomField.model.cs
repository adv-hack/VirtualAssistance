using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenCustomFieldRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalScreenCustomFieldModel
    {
        /// <summary>
        /// Delete the values when deleting the custom field
        /// </summary>
        protected override void ResolveDeleteDependent()
        {
            foreach (LocalScreenCustomFieldValueModel value in this.CustomFieldValues)
            {
                value.Delete();
            }
        }
    }
}
