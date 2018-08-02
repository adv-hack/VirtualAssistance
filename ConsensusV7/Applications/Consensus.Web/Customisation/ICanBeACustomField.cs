using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface ICanBeACustomField
    {
        /// <summary>
        ///     Gets or sets whether the field is a custom field
        /// </summary>
        bool IsCustomField { get; set; }

        /// <summary>
        ///     The field Id for the custom field.
        /// </summary>
        int CustomFieldId { get; set; }
    }
}
