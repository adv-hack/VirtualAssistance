using Consensus.UserInterface;
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
    ///     Provides the abstraction for all controls within the web application.
    /// </summary>
    [ParseChildren(false)]
    public class BaseControl : WebControl
    {
        #region page cycle

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.InitialiseControlTree();
            this.InitialiseControlValue();
        }

        /// <summary>
        ///     Initialises the control state.
        /// </summary>
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.InitialiseControlState();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected virtual void InitialiseControlTree()
        {
        }

        /// <summary>
        ///     Sets the initial value of the control.
        /// </summary>
        protected virtual void InitialiseControlValue()
        {
        }

        /// <summary>
        ///     Initialises the control state.
        /// </summary>
        protected virtual void InitialiseControlState()
        {
        }

        #endregion
    }
}
