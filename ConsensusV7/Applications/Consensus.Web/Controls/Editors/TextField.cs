using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a free-text input control.
    /// </summary>    
    public class TextField : TextBase, IHaveMaxLength, ICanBeValidated, IHaveDefaultValue, ICanBeACustomField
    {
        /// <summary>
        ///     Gets or sets the maximum number of characters that can be entered into the field.
        /// </summary>
        public Int32 MaximumLength
        {
            get { return this.Field.MaxLength; }
            set { this.Field.MaxLength = value; }
        }

        /// <summary>
        ///     Gets or sets whether the field is a custom field
        /// </summary>
        public bool IsCustomField { get; set; }

        /// <summary>
        ///     The field Id for a custom field.
        /// </summary>
        public int CustomFieldId
        {
            get
            {
                string fieldId = this.FieldAttributes["custom-field-id"];
                return string.IsNullOrEmpty(fieldId) ? 0 : fieldId.ConvertTo<int>();
            }
            set
            {
                this.FieldAttributes["custom-field-id"] = value.ToString();
            }
        }
    }
}
