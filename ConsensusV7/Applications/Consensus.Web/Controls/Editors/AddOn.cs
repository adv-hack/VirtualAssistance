using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Represents an addon which can be added to an input control.
    /// </summary>
    public class AddOn : WebControl
    {
        #region fields

        /// <summary>
        ///     The HTML control used to render the icon for the addon.
        /// </summary>
        private HtmlGenericControl _iconControl;

        /// <summary>
        ///     The CSS class applied to the addon.
        /// </summary>
        private String _cssClass;

        /// <summary>
        ///     Specifies if the add-on is rendered to the client.
        /// </summary>
        private Boolean _visible;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the HTML control used to render the icon for the addon.
        /// </summary>
        protected HtmlGenericControl IconControl
        {
            get
            {
                if (_iconControl == null)
                    _iconControl = new HtmlGenericControl("i");

                return _iconControl;
            }
        }

        /// <summary>
        ///     Gets the <see cref="HtmlTextWriterTag" /> value that corresponds to this Web server control.
        /// </summary>
        protected override HtmlTextWriterTag TagKey
        {
            get { return HtmlTextWriterTag.Span; }
        }

        /// <summary>
        ///    Gets or sets the icon displayed in the addon.
        /// </summary>
        public String Icon
        {
            get
            {
                String cssClass = this.IconControl.Attributes["class"];
                if (!String.IsNullOrEmpty(cssClass) && cssClass.StartsWith("icons8-", StringComparison.OrdinalIgnoreCase))
                    cssClass = cssClass.Substring(7);

                return cssClass;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.IconControl.Attributes["class"] = "";
                else
                    this.IconControl.Attributes["class"] = String.Format("icons8-{0}", value);
            }
        }

        /// <summary>
        ///    Gets or sets the client-side function for handling the client event for the addon.
        /// </summary>
        public String OnClick
        {
            get { return this.Attributes["onclick"]; }
            set { this.Attributes["onclick"] = value; }
        }

        /// <summary>
        ///    Gets or sets the CSS class applied to the addon.
        /// </summary>
        public override String CssClass
        {
            get { return _cssClass; }
            set { _cssClass = value; }
        }

        /// <summary>
        ///    Gets or sets whether the add-on is rendered to the client.
        /// </summary>
        public new Boolean Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new AddOn
        /// </summary>
        public AddOn()
        {
            this.Visible = true;
        }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Controls.Add(this.IconControl);
            base.CssClass = "input-group-addon " + this.CssClass;
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            base.CssClass += this.Visible ? "" : " hidden";
        }

        #endregion
    }
}
