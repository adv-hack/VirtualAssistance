using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class RoleDetail : BaseControl<Role, String>
    {

        public override String DataTypeName
        {
            get { return "Role"; }
        }
        protected override void PopulateControl()
        {
            this.StartDate.FieldValue = this.DataSource.StartDate;
            this.EndDate.FieldValue = this.DataSource.EndDate;
            this.Type.FieldValue = this.DataSource.Type.Value1;
            this.JobType.FieldValue = this.DataSource.JobTypeCode;
            this.Payroll.FieldValue = this.DataSource.Payroll;
            this.StaffNo.FieldValue = this.DataSource.StaffNo;
            this.KeyContact.FieldValue = Convert.ToBoolean(this.DataSource.KeyContact);
            this.CostCode.FieldValue = this.DataSource.CostCodeCode;
            this.JobLevel.FieldValue = this.DataSource.JobLevelCode;
            this.HourlyRate.FieldValue = this.DataSource.HourlyRate.ConvertTo<String>();
            this.UnionRolNo.FieldValue = this.DataSource.UnionRolNoCode;
            this.Disabled.FieldValue = Convert.ToBoolean(this.DataSource.IsRoleDisabled);
            this.Principal.FieldValue = Convert.ToBoolean(this.DataSource.IsPrincipal);

            this.SellCompName.DataSource = Common.SellingCompany.FetchAll();
            this.SellCompName.FieldValue = this.DataSource.SellingCompany.Id;

            //Can't change the main role to no if it's already yes
            if (this.Principal.FieldValue == true)
            {
                this.Principal.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            }
        }
    }
}

