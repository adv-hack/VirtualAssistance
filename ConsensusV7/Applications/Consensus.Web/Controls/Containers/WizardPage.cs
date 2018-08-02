using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Defines a page within a wizard.
    /// </summary>
    [ParseChildren(false)]
    public class WizardPage : Panel
    {
        #region fields

        /// <summary>
        ///     The title for the wizard.
        /// </summary>
        private String _title;

        /// <summary>
        ///     Specifies if the page is displayed in the wizard.
        /// </summary>
        private Boolean? _visible;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the title for the wizard.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///    Gets or sets whether the page is displayed in the wizard. 
        /// </summary>
        public new Boolean Visible
        {
            get { return _visible ?? true; }
            set { _visible = value; }
        }

        #endregion
    }
}
