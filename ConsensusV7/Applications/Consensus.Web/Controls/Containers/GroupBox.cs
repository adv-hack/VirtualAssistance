using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a container, with a heading.
    /// </summary>
    [ParseChildren(false)]
    public class GroupBox : WebControl, IHaveCustomTitle, ICanBeHidden, ICustomFieldContainer
    {
        #region fields

        /// <summary>
        ///     The heading element displayed at the top of the group box.
        /// </summary>
        private HtmlGenericControl _header;

        /// <summary>
        ///     Specifies whether the field is hidden.
        /// </summary>
        private ConfigurableBoolean _isHidden;

        /// <summary>
        ///     Identifies where custom fields will be inserted in the group box
        /// </summary>
        private Panel _customFieldInsertPoint;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the HTML element that is rendered for this control.
        /// </summary>
        protected override HtmlTextWriterTag TagKey
        {
            get { return HtmlTextWriterTag.Div; }
        }

        /// <summary>
        ///    Gets or sets the 
        /// </summary>
        protected HtmlGenericControl Header
        {
            get
            {
                if (_header == null)
                    _header = new HtmlGenericControl("h3");

                return _header;
            }
        }

        /// <summary>
        ///    Gets or sets the title for the group box
        /// </summary>
        public String Title
        {
            get { return this.Header.InnerText; }
            set { this.Header.InnerText = value; }
        }

        /// <summary>
        ///     Gets or sets whether the field is hidden.
        /// </summary>
        public ConfigurableBoolean IsHidden
        {
            get { return _isHidden; }
            set { _isHidden = value; }
        }

        public Panel CustomFieldInsertPoint
        {
            get
            {
                if (_customFieldInsertPoint == null)
                    _customFieldInsertPoint = new Customisation.CustomFieldInsertPointDiv();
                return _customFieldInsertPoint;
            }
        }

        /// <summary>
        ///     Can be set to true to prevent custom fields being added to an individual container.
        /// </summary>
        public bool BlockCustomFields { get; set; }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new grouping container.
        /// </summary>
        public GroupBox()
        {
            this.CssClass = "consensus-group";
        }

        #endregion

        #region page cycle

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected override void OnInit(EventArgs e)
        {
            if (string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(Title))
            {
                string newID = "GroupBox_" + Regex.Replace(Title, "[^a-zA-Z0-9_]+", "", RegexOptions.Compiled);
                if (this.FindControl(newID) != null)
                {
                    for (int sfx = 1; sfx < 20; sfx++)
                    {
                        string sfxID = newID + "_" + sfx.ToString();
                        if (this.Page.FindControl(sfxID) == null)
                        {
                            ID = sfxID;
                            break;
                        }
                    }
                }
                else
                {
                    ID = newID;
                }
            }
            this.Controls.AddAt(0, this.Header);
            base.OnInit(e);
            this.Controls.Add(CustomFieldInsertPoint);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (this.IsHidden == ConfigurableBoolean.True || this.IsHidden == ConfigurableBoolean.TrueEnforced)
                this.Attributes.Add("hidden", "hidden");
            else
                this.Attributes.Remove("hidden");
        }

        //protected override void CreateChildControls()
        //{
        //    base.CreateChildControls();
        //    this.Controls.Add(CustomFieldInsertPoint);
        //}

        #endregion
    }
}
