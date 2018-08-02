using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;

namespace Consensus.Web.Controls
{
    public class HiddenField : BaseInputControl<HtmlInputHidden, String>
    {
        public override String FieldValue
        {
            get { return this.Field.Value; }
            set { this.Field.Value = value; }
        }

        protected override void InitialiseControlTree()
        {
            this.CssClass += " hidden";
            this.Field.ID = String.Format("{0}Field", this.ID);
            this.Controls.Add(this.Field);
        }

        protected override void InitialiseControlState()
        {
            this.Label.Visible = false;
            this.Error.Visible = false;
        }
    }
}
