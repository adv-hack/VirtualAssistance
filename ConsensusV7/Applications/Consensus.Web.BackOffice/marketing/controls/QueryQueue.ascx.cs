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
    public partial class QueryQueue : BaseControl<SaqQueue, long>
    {
        public override string DataTypeName
        {
            get { return "Entry on Query Queue"; }
        }

        //protected override void PopulateControl()
        //{
        //    base.PopulateControl();                        
        //}
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            long queryId = Convert.ToInt64(Request.QueryString["queryId"]);

            if (this.DataSource == null)
            {
                this.DataSource = Consensus.Marketing.SaqQueue.FetchAllByQueryId(queryId).OrderBy(q => q.Id).LastOrDefault();
                this.QueryId.FieldValue = queryId.ToString();
                this.Status.FieldValue = "1-Awaiting Processing";
      
            }
            
            if (this.DataSource == null)
            {
                this.Dedupe.FieldValue = true;
            }
            
            // "CSV (Comma Separated)" and "TSV (Tab Separated File" with CSV being the default            
            List<object> ddl = new List<object>();
            ddl.Add(new { Name = "CSV (Comma Separated)", Id = "CSV" });
            ddl.Add(new { Name = "TSV (Tab Separated File)", Id = "TSV" });

            this.FileType.DataSource = ddl;
            if (this.DataSource != null)
                this.FileType.FieldValue = this.DataSource.FileType;
            else
                this.FileType.FieldValue = "CSV";

            // Drop down of "Mailing List" and "Membership" with "Mailing List being the default)
            List<object> ddl2 = new List<object>();
            ddl2.Add(new { Name = "Mailing List", Id = "MAIL" });
            //ddl2.Add(new { Name = "Positions and Appointments", Id = "POS" }); // Not included in user story NFPCCB-17644
            ddl2.Add(new { Name = "Membership", Id = "MEM" });

            this.ResultsType.DataSource = ddl2;
            if (this.DataSource != null)
                this.ResultsType.FieldValue = this.DataSource.ResultsType;
            else
                this.ResultsType.FieldValue = "MAIL";

            //Run option (Drop down of 
            //  "Update Record Count" this is in place of Run query and update counts with no process options , = 1
            //  "Create File" this replaces Run query and save as file on server and = 3
            //  "Send Pack by email" this replaces Run query and email template to result set. = 5
            // The default being "Update Record Count".) 
            List<object> ddl3 = new List<object>();
            ddl3.Add(new { Name = "Update Record Count", Id = 1 });
            //ddl3.Add(new { Name = "Run query and save results", Id = 2 }); // Not included in user story NFPCCB-17644
            ddl3.Add(new { Name = "Create File", Id = 3 });
            //ddl3.Add(new { Name = "Run query and email results as file", Id = 4 }); // Not included in user story NFPCCB-17644
            ddl3.Add(new { Name = "Send Pack by email", Id = 5 });

            this.OutputOption.DataSource = ddl3;
            if (this.DataSource != null)
                this.OutputOption.FieldValue = this.DataSource.OutputOption.ToString();
            else
                this.OutputOption.FieldValue = "1";

            // Process actions (drop down list of 
            //      "None" default, = 1 
            //      "Create mailing record", = 2
            //      "Create activity", = 3
            //      "Add profile to person", = 4
            //      "Add profile to organisation", = 5
            //      "Add people to mailing list" = 6
            List<object> ddl4 = new List<object>();
            ddl4.Add(new { Name = "None", Id = 1 });
            ddl4.Add(new { Name = "Create mailing record", Id = 2 });
            ddl4.Add(new { Name = "Create activity", Id = 3 });
            ddl4.Add(new { Name = "Add profile to person", Id = 4 });
            ddl4.Add(new { Name = "Add profile to organisation", Id = 5 });
            ddl4.Add(new { Name = "Add people to mailing list", Id = 6 });

            this.ProcessOption.DataSource = ddl4;
            if (this.DataSource != null)
                this.ProcessOption.FieldValue = this.DataSource.ProcessOption.ToString();
            else
                this.ProcessOption.FieldValue = "1";

            this.MailingList.DataSource = Marketing.MailingList.FetchAll().Where(list => list.StatusCode == "Current").OrderBy(list => list.Title);
        }
        protected override void RegisterJavascript()
        {
          this.ProfileKeyPerson.ClientOnChange = @"
                $('#" + this.ProfValuePerson.ClientID + "Field').val(this.getData().level1); $('#" + this.ProfValue2Person.ClientID + @"Field').val(this.getData().level2);
            ";
          this.ProfileKeyOrg.ClientOnChange = @"
                $('#" + this.ProfValueOrg.ClientID + "Field').val(this.getData().level1); $('#" + this.ProfValue2Org.ClientID + @"Field').val(this.getData().level2);
            ";

            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "GenericProductDetailJs", @"
                
                function ValidatePackCode(source, arguments) {
                    var nOptions = parseInt($('#" + this.OutputOption.ClientID + @"Field').val());
                    
                    if(nOptions && nOptions == 5){
                        var pCode = $('#" + this.Pack.ClientID + @"Field').val();
                        arguments.IsValid = (pCode && pCode.length != 0);
                    }
                }
            ", true);
        }
    }
}