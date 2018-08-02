using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Sales;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class QueryDataProtection : BaseControl<SaqQuery, long>
    {
        public override string DataTypeName
        {
            get { return "Query Data Protection"; }
        }

        //protected override void PopulateControl()
        //{
        //    base.PopulateControl();                        
        //}
        
    }
}