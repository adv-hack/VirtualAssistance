using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class LicenseDetail : BaseControl<License>
    {
        /// <summary>
        ///     Gets the name of the data-type being modified.
        /// </summary>
        public override String DataTypeName
        {
            get { return "License"; }
        }
    }
}