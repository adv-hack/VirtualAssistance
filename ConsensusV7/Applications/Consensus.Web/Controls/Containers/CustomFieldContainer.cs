using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    [ParseChildren(false)]
    public class CustomFieldContainer : Panel, ICustomFieldContainer
    {
        /// <summary>
        ///     Identifies where custom fields will be inserted in the panel
        /// </summary>
        private Panel _customFieldInsertPoint;

        /// <summary>
        ///     Can be set to true to prevent custom fields being added to an individual container.
        /// </summary>
        public bool BlockCustomFields { get; set; }

        /// <summary>
        ///     Identifies where custom fields will be inserted in the panel
        /// </summary>
        public Panel CustomFieldInsertPoint
        {
            get
            {
                if (_customFieldInsertPoint == null)
                    _customFieldInsertPoint = new Customisation.CustomFieldInsertPointDiv();
                return _customFieldInsertPoint;
            }
        }

        public string Title { get; set; }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Controls.Add(CustomFieldInsertPoint);
        }
}
}
