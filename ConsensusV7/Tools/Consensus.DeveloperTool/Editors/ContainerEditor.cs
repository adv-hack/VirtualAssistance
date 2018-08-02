using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consensus.CodeGenerator
{
    public partial class ContainerEditor : BaseEditor
    {
        #region fields

        /// <summary>
        ///     The domain container instance that is being created or modified.
        /// </summary>
        private DomainContainer DomainContainer;

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="ContainerEditor" /> instance.
        /// </summary>
        public ContainerEditor(DomainContainer domainContainer)
        {
            this.InitializeComponent();
            this.DomainContainer = domainContainer;
        }

        #endregion

        #region methods

        protected override bool ValidateForm()
        {
            Boolean result = base.ValidateForm();
            result = result && this.ValidateForm(this.NameTextbox, !String.IsNullOrEmpty(this.NameTextbox.Text), "Please specify a name for the container", false);
            return result;
        }

        protected override void OnInit()
        {
            this.Size = new Size(400, 225);
            this.NameTextbox.Text = this.DomainContainer.ContainerName;
            this.DescriptionTextbox.Text = this.DomainContainer.ContainerDescription;
        }

        protected override void OnConfirm()
        {
            this.DomainContainer.ContainerName = this.NameTextbox.Text;
            this.DomainContainer.ContainerDescription = this.DescriptionTextbox.Text;
        }

        #endregion
    }
}
