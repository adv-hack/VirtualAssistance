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
    public abstract class TextBase : BaseInputControl<TextBox, String>, ICanBeMandatory, ICanBeHidden, ICanBeReadOnly, IHaveCustomTitle
    {
        #region fields

        /// <summary>
        ///     The formatted url for the hyperlink rendered in non-edit mode.
        /// </summary>
        private String _hyperlinkUrl;

        /// <summary>
        ///     The anchor tag used to display the selected value as a hyperlink.
        /// </summary>
        private HtmlAnchor _hyperlink;

        /// <summary>
        ///     The text mode used for data entry.
        /// </summary>
        private TextBoxMode _textMode;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the anchor tag used to display the selected value as a hyperlink.
        /// </summary>
        protected HtmlAnchor Hyperlink
        {
            get
            {
                if (_hyperlink == null)
                    _hyperlink = new HtmlAnchor();

                return _hyperlink;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the control.
        /// </summary>
        public override String FieldValue
        {
            get { return this.Field.Text; }
            set { this.Field.Text = value; }
        }

        /// <summary>
        ///     Gets or sets the behavioural mode of the textbox
        /// </summary>
        /// <remarks>
        ///     The rendering of the HTML input element may be affected by different internet browsers when the input "type" is set to time.
        ///     To prevent this, the input element HTML will be rendered to set the "type" to text but the validator expression will enforce the entry of a time value.
        /// </remarks>
        public TextBoxMode TextMode
        {
            get
            {
                return this._textMode;
            }
            set
            {
                this._textMode = value;
                switch (value)
                {
                    case TextBoxMode.Date: this.Field.TextMode = TextBoxMode.SingleLine; break;
                    case TextBoxMode.DateTime: this.Field.TextMode = TextBoxMode.SingleLine; break;
                    case TextBoxMode.Time: this.Field.TextMode = TextBoxMode.SingleLine; break;
                    default: this.Field.TextMode = value; break;
                }
            }
        }

        /// <summary>
        ///    Gets or sets the formatted url for the hyperlink rendered in non-edit mode.
        /// </summary>
        public String HyperlinkUrl
        {
            get { return _hyperlinkUrl; }
            set { _hyperlinkUrl = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected override void InitialiseControlTree()
        {
            // Add the hidden field to the control tree and create the search add-on.
            base.InitialiseControlTree();
            this.Controls.Add(this.Hyperlink);
        }

        /// <summary>
        ///     Initialises the control state.
        /// </summary>
        protected override void InitialiseControlState()
        {
            base.InitialiseControlState();
            this.InitialiseHyperlink();

            // Adjust input field according to the mode being used.
            switch (this.TextMode)
            {
                case TextBoxMode.MultiLine:
                    this.Field.Rows = 8;
                    break;
                case TextBoxMode.Password:
                    this.FieldAttributes["value"] = this.FieldValue;
                    break;
                case TextBoxMode.Date:
                case TextBoxMode.DateTime:
                case TextBoxMode.Time:
                    this.Field.Attributes["data-type"] = this.TextMode.ToString().ToLower();
                    break;
            }
        }

        public override void InitialiseValidators()
        {
            // Apply the validator based on the mode being used.
            base.InitialiseValidators();
            if (String.IsNullOrEmpty(this.ValidatorExpression))
            {
                switch (this.TextMode)
                {
                    case TextBoxMode.Phone:
                        this.ValidatorExpression = @"^(?:(?:\(?(?:00|\+)([1-4]\d\d|[1-9]\d?)\)?)?[\-\.\ \\\/]?)?((?:\(?\d{1,}\)?[\-\.\ \\\/]?){0,})(?:[\-\.\ \\\/]?(?:#|ext\.?|extension|x)[\-\.\ \\\/]?(\d+))?$";
                        this.ValidatorMessage = "This does not appear to be a valid telephone number.";
                        break;
                    case TextBoxMode.Email:
                        this.ValidatorExpression = @"^(?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])$";
                        this.ValidatorMessage = "This does not appear to be a valid email address.";
                        break;
                    case TextBoxMode.Number:
                        this.ValidatorExpression = @"^-?[0-9]+([.,][0-9]{1,3})?$";
                        this.ValidatorMessage = "This does not appear to be a valid number.";
                        break;
                    case TextBoxMode.Time:
                        this.ValidatorExpression = @"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$";
                        this.ValidatorMessage = "This does not appear to be a valid time.";
                        break;
                    case TextBoxMode.Url:
                        this.ValidatorExpression = @"^((http|ftp|https|www)://)?([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$";
                        this.ValidatorMessage = "This does not appear to be a valid URL.";
                        break;

                }
            }
        }

        /// <summary>
        ///     Initialises the hyperlink attributes for the control.
        /// </summary>
        protected virtual void InitialiseHyperlink()
        {
            if (this.Hyperlink.Visible = !String.IsNullOrEmpty(this.HyperlinkUrl))
            {
                String absoluteUrl = this.HyperlinkUrl.StartsWith("~") ? VirtualPathUtility.ToAbsolute(this.HyperlinkUrl) : this.HyperlinkUrl;
                this.Attributes.Add("consensus-input-link", absoluteUrl);
                this.Hyperlink.Attributes.Add("class", "consensus-input-link");
                this.Hyperlink.Attributes.Add("href", absoluteUrl.Replace("{text}", this.FieldValue));
                this.Hyperlink.InnerText = this.FieldValue;
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the title or display text for the control.
        /// </summary>
        String IHaveCustomTitle.Title
        {
            get { return this.LabelText; }
            set { this.LabelText = value; }
        }

        #endregion
    }
}
