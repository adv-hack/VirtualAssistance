using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a free-text input control.
    /// </summary>    
    public class HtmlTextField : TextField /*HiddenField*/
    {
        /*
        Panel _editorDiv;

        protected Panel EditorDiv
        {
            get
            {
                if (_editorDiv == null)
                {
                    _editorDiv = new Panel();
                }
                return _editorDiv;
            }
        }

        protected override void InitialiseControlTree()
        {
            // TODO - move placeholder and any other attributes that need to be applied to the div from the field to the div.
            this.Field.ID = String.Format("{0}Field", this.ID);
            this.Controls.Add(this.Field);
            this.EditorDiv.ID = String.Format("{0}Editor", this.ID);
            this.Controls.Add(this.EditorDiv);
        }
        */

        protected override void InitialiseControlTree()
        {
            this.TextMode = TextBoxMode.MultiLine;
            if (this.Width == null || this.Width == Unit.Empty)
            {
                this.Width = new Unit(100, UnitType.Percentage);
            }
            base.InitialiseControlTree();
        }

        protected override void InitialiseControlState()
        { 
            base.InitialiseControlState();

            // Construct the configuration for the popup
            StringBuilder javascript = new StringBuilder();
            javascript.AppendFormat("var {0} = new consensus.web.htmlTextField('{0}', {{" + Environment.NewLine, this.ClientID);
            //javascript.AppendFormat(@"btns: [
            //    ['viewHTML'],
            //    ['undo', 'redo'], // Only supported in Blink browsers
            //    ['formatting', 'color'],
            //    ['strong', 'em', 'del'],
            //    ['superscript', 'subscript'],
            //    ['link'],
            //    ['insertImage'],
            //    ['justifyLeft', 'justifyCenter', 'justifyRight', 'justifyFull'],
            //    ['unorderedList', 'orderedList'],
            //    ['horizontalRule'],
            //    ['removeformat'],
            //    ['fullscreen']
            //]" + Environment.NewLine);
            if (this.IsEditable < 0 || this.IsReadOnly > 0)
            {
                javascript.AppendFormat("disabled: true");
            }
            javascript.AppendFormat("}});");

            // Register the javascript
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, javascript.ToString(), true);
        }
    }
}
