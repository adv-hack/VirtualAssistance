using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class LicenseLimitDetail : BaseControl<LicenseLimit>
    {

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        private Boolean _allowDelete = false;

        /// <summary>
        ///     Gets the name of the data type being modified.
        /// </summary>
        public override string DataTypeName
        {
            get { return "License Limitation"; }
        }

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        public override bool AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);            
        }

    }
}