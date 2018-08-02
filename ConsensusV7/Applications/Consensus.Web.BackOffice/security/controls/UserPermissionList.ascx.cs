using Consensus.Security;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class UserPermissionList : BaseControl<UserPrincipal, Int32>
    {
        /// <summary>
        ///     Gets the name of the data type being modified
        /// </summary>
        public override String DataTypeName
        {
            get { return "User Permissions"; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            // Create a column for each standard permission
            foreach (Enum enumeration in Enum.GetValues(typeof(UserPermissionActions)))
            {
                LiteralControl script = new LiteralControl() { Text = "return createPermissionColumn(row, '" + enumeration.ToString() + "');" };
                DataTableCustomColumn column = new DataTableCustomColumn();
                column.Title = enumeration.ToString();
                column.Controls.Add(script);
                column.Width = new Unit(95, UnitType.Pixel);
                column.Orderable = false;
                this.PermissionList.Columns.Add(column);
            }

            // Create a column for the additional permissions
            LiteralControl buttonScript = new LiteralControl() { Text = "return createPermissionOption(row);" };
            DataTableCustomColumn buttonColumn = new DataTableCustomColumn();
            buttonColumn.Controls.Add(buttonScript);
            buttonColumn.CssClass = "consensus-visible-edit";
            buttonColumn.Orderable = false;
            buttonColumn.Width = new Unit(25, UnitType.Pixel);
            this.PermissionList.Columns.Add(buttonColumn);
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.PermissionList.Data = this.DataSource.PermissionSets.OrderBy(ps => ps.Module).ThenBy(ps => ps.Name);
        }
    }
}