using Consensus.Document;
using Consensus.Searches;
using Consensus.UserInterface;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class SMSDetail : BaseControl<SmsMessage,String>
    {
        #region properties
        public override String DataTypeName
        {
            get { return "SMS template"; }
        }
        #endregion

        #region methods
        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Type.DataSource = SmsType.FetchAll();
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            //this.SellingCompany.DataSource = Searches.RestCall.Create<Common.SellingCompany>("FetchAll");

            //var mergeFields = new List<KeyValuePair<string, string>>();

            //Query to get Merge Fields from View 
            var mergeFieldListFromView = Query.Create()
                   .Select("COLUMN_NAME")
                   .Select("SMT_ID")
                   .From(QuerySources.SmsMergeFields);

            this.MessageMerge.DisplayMember = "COLUMN_NAME";
            if (this.DataSource != null && this.DataSource.Id > 0)
            {
                this.LockField(this.Type);
                /*
                //Gets Merged fields based on selected type
                var selectedTypeMergeFieldsFromView = mergeFieldListFromView.Where("SMT_ID", QueryConditionTypes.Equal, this.DataSource.SmsMessageTypeId.ToString()).Run();
                var mergedFieldsForEdit = new List<string>();
                foreach (var field in selectedTypeMergeFieldsFromView)
                {
                    mergedFieldsForEdit.Add(field.Values.First().ToString());
                }
                this.MessageMerge.DataSource = mergedFieldsForEdit;
                */
                // MessageMerge has the ClientSideInitialise property set. Apply the Query definition to the DataSource - do not Run it (it will be run client side)
                this.MessageMerge.DataSource = mergeFieldListFromView.Where("SMT_ID", QueryConditionTypes.Equal, this.DataSource.SmsMessageTypeId.ToString());
            }
            else
            {
                this.SellingCompany.FieldValue = this.CurrentSession.User.SellingCompanyId;

                //    /*
                //    //Fetch all merge fields
                //    var allMergeFieldFromView = mergeFieldListFromView.Run();

                //    foreach (var field in allMergeFieldFromView)
                //    {
                //        mergeFields.Add(new KeyValuePair<string, string>(field.Values.First().ToString(), field.Values.Last().ToString()));
                //    }

                //    this.AllMergeFields.DataSource = mergeFields;
                //    */
                this.MessageMerge.DataSource = mergeFieldListFromView.Where("SMT_ID", QueryConditionTypes.Equal, "-1");
            }

        }

        #endregion
    }
}