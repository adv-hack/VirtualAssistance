using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Membership;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class BranchCommitteeDetail : BaseControl<Committee, String>
    {
        #region properties
        public override string DataTypeName
        {
            get { return "Committee"; }
        }
        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Committee> DataLoader
        {
            get { return Committee.FetchById; }
        }
        #endregion

        #region methods
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            var BrId = this.Request.QueryString["brid"];
            //this.Brid.FieldValue = BrId;
            // this.TableName.FieldValue = "Committee";

        }
        protected override void RegisterJavascript()
        {
            //this.Comm.ClientOnChange += @"
            //    if(this.getData() != ''){
            //        var data=this.getData();
            //         $('#" + this.ComId.ClientID + @"Field').val(data.id);
            //}";
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            //var ComId = this.Request.QueryString["id"];
            //var RecorId = Committee.FetchById(ComId);

            //if (RecorId != null)
            //{
            //    this.Comm.FieldText = RecorId.Name;
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}