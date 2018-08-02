using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    public class TimeField : BaseInputControl<TextBox, DateTime?>, ICanBeMandatory, IHaveDefaultValue, ICanBeHidden, ICanBeReadOnly, IHaveCustomTitle
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the control.
        /// </summary>
        public override DateTime? FieldValue
        {
            get { return this.Field.Text.ConvertTo<DateTime?>(); }
            set { this.Field.Text = value == null ? String.Empty : value.Value.ToString("HH:mm"); }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected override void InitialiseControlTree()
        {
            // Apply initial css styles and create the calendar add-on
            base.InitialiseControlTree();
            this.Field.Attributes["data-type"] = "time";
        }

        /// <summary>
        ///     Initialises the control state.
        /// </summary>
        protected override void InitialiseControlState()
        {
            // Initialise the bootstrap date picker attributes
            base.InitialiseControlState();
            this.ValidatorExpression = @"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$";
            this.ValidatorMessage = "This does not appear to be a valid time.";
            this.Field.TextMode = TextBoxMode.SingleLine;
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
