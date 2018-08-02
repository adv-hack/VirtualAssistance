using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a dropdown list of values.
    /// </summary>
    public class ListField : ListBase, IHaveListItems, ICanBeACustomField
    {
        #region properties


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

        /// <summary>
        ///     Gets the items displayed in this list.
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public ListItemCollection Items
        {
            get { return this.Field.Items; }
        }

        #endregion

        #region page lifecycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        #endregion
    }
}
