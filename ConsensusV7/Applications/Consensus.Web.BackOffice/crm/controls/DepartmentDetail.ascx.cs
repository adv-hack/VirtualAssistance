using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Contact;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class DepartmentDetail : BaseControl<OrganisationDepartment, String>
    {

        public override String DataTypeName
        {
            get { return "Department"; }
        }

        public override Func<String, OrganisationDepartment> DataLoader
        {
            get { return OrganisationDepartment.FetchById; }
        }
    }
}