using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Security;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class QueryDetail : BaseControl<SaqQuery, long>
    {
        public override string DataTypeName
        {
            get { return "Query"; }
        }

        //protected override void PopulateControl()
        //{
        //    base.PopulateControl();                        
        //}

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (this.DataSource == null || this.DataSource.Id == 0)
            {
                if (this.CurrentSession != null && this.CurrentSession.User != null && this.CurrentSession.User.Person != null)
                {
                    this.Owner.FieldValue = this.CurrentSession.User.Person.PrincipalRole.Id;
                    this.Owner.FieldText = this.CurrentSession.User.Person.FullName;
                }
            }
        }

    }
}