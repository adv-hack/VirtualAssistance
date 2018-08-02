using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class BaseEditor : System.Windows.Forms.Form
    {
        #region fields

        /// <summary>
        ///     The button used to cancel the editor.
        /// </summary>
        private System.Windows.Forms.Button _cancellationButton;

        /// <summary>
        ///     The button used to confirm the editor.
        /// </summary>
        private System.Windows.Forms.Button _confirmationButton;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the button used to cancel the editor.
        /// </summary>
        public System.Windows.Forms.Button CancellationButton
        {
            get
            {
                if (_cancellationButton == null)
                {
                    _cancellationButton = new System.Windows.Forms.Button();
                    _cancellationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
                    _cancellationButton.Click += this.CancellationButton_Click;
                    _cancellationButton.Location = new Point(this.Size.Width - 184, this.Size.Height - 74);
                    _cancellationButton.TabIndex = 9999;
                    _cancellationButton.Text = "Cancel";
                }
                return _cancellationButton;
            }
        }

        /// <summary>
        ///     Gets the button used to cancel the editor.
        /// </summary>
        public System.Windows.Forms.Button ConfirmationButton
        {
            get
            {
                if (_confirmationButton == null)
                {
                    _confirmationButton = new System.Windows.Forms.Button();
                    _confirmationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
                    _confirmationButton.Click += this.ConfirmationButton_Click;
                    _confirmationButton.Location = new Point(this.Size.Width - 103, this.Size.Height - 74);
                    _confirmationButton.TabIndex = 9998;
                    _confirmationButton.Text = "OK";
                }
                return _confirmationButton;
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Creates a new instance of the base editor form.
        /// </summary>
        public BaseEditor()
        {
            this.InitializeComponent();
            this.InitializeControls();
        }

        #endregion

        #region event handlers

        private void BaseEditor_Load(object sender, EventArgs e)
        {
            this.InitializeControls();
            this.OnInit();
        }

        private void BaseEditor_Shown(object sender, EventArgs e)
        {
            this.OnShow();
        }

        private void CancellationButton_Click(object sender, EventArgs e)
        {
            this.OnCancel();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close(); 
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.OnConfirm();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        #region methods

        private void InitializeComponent()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new Font("Segoe UI", 8);
            this.Icon = Consensus.CodeGenerator.Properties.Resources.Advanced;
            this.Shown += BaseEditor_Shown;
            this.Load += BaseEditor_Load;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Size = new Size(600, 300);
        }

        private void InitializeControls()
        {
            if (!this.Controls.Contains(this.ConfirmationButton))
                this.Controls.Add(this.ConfirmationButton);
            if (!this.Controls.Contains(this.CancellationButton))
                this.Controls.Add(this.CancellationButton);

            this.CancellationButton.Location = new Point(this.Size.Width - 184, this.Size.Height - 74);
            this.ConfirmationButton.Location = new Point(this.Size.Width - 103, this.Size.Height - 74);
            this.AcceptButton = this.ConfirmationButton;
            this.CancelButton = this.CancellationButton;
        }

        protected virtual void OnInit()
        {
        }

        protected virtual void OnShow()
        {
        }

        protected virtual void OnConfirm()
        {
        }

        protected virtual void OnCancel()
        {
        }

        protected virtual Boolean ValidateForm()
        {
            return true;
        }

        protected Boolean ValidateForm(System.Windows.Forms.TabPage tabPage, System.Windows.Forms.Control control, Boolean condition, String errorMessage, Boolean canIgnore)
        {
            Boolean result = this.ValidateForm(control, condition, errorMessage, canIgnore);
            if (!result)
                (tabPage.Parent as System.Windows.Forms.TabControl).SelectedTab = tabPage;

            return result;
        }

        protected Boolean ValidateForm(System.Windows.Forms.Control control, Boolean condition, String errorMessage, Boolean canIgnore)
        {
            Boolean result = true;
            if (!condition)
                if (!(result = System.Windows.Forms.MessageBox.Show(errorMessage, "Warning", canIgnore ? System.Windows.Forms.MessageBoxButtons.YesNo : System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes))
                    control.Focus();

            return result;
        }

        #endregion
    }
}
