using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class TrainerNotesDetail : BaseControl<Trainer, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Trainer"; }
        }

        #endregion

        protected override void PopulateControl()
        {
            base.PopulateControl();           
        }
    }
}