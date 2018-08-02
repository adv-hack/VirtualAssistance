using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class LicenseKey : BaseControl
    {
        #region enums

        /// <summary>
        ///     Enumerates the different operational modes for this control.
        /// </summary>
        public enum Modes
        {
            /// <summary>
            ///     The control is being used to request the license signature key for the local installation.
            /// </summary>
            SignatureRequest,

            /// <summary>
            ///     The control is being used to generate a license key for a remote installation.
            /// </summary>
            SignatureGeneration
        }

        #endregion

        #region properties

        /// <summary>
        ///     Gets the name of the data type that is modified by this control.
        /// </summary>
        public override String DataTypeName
        {
            get { return "License Verification"; }
        }

        /// <summary>
        ///     Gets or sets the operational mode for this control.
        /// </summary>
        public Modes Mode
        {
            get
            {
                if (String.Equals(this.Request.QueryString["mode"], "generate", StringComparison.OrdinalIgnoreCase))
                    return Modes.SignatureGeneration;
                else
                    return Modes.SignatureRequest;
            }
        }

        #endregion

        #region page cycle

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.Hash.IsEditable = ConfigurableBoolean.TrueEnforced;
            this.Hash.IsReadOnly = this.Mode == Modes.SignatureRequest ? ConfigurableBoolean.TrueEnforced : ConfigurableBoolean.FalseEnforced;
            this.Sign.IsEditable = ConfigurableBoolean.TrueEnforced;
            this.Sign.IsReadOnly = this.Mode == Modes.SignatureRequest ? ConfigurableBoolean.FalseEnforced : ConfigurableBoolean.TrueEnforced;
            if (this.Mode == Modes.SignatureGeneration)
                this.Hash.ClientOnChange = "generateVerifier();";
        }

        #endregion
    }
}