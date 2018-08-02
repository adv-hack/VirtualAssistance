using Consensus.Document;
using Consensus.Searches;
using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class PackDetails : BaseControl<Pack, String>
    {
        public override String DataTypeName
        {
            get { return "Packs"; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.packSellingCompany.DataSource = Common.SellingCompany.FetchAll();
            this.packType.DataSource = Packtype.FetchAll();
            this.packOutputMethod.DataSource = OutputQueue.FetchAll();

            //Gets merge fields list
            var mergeFields = new List<KeyValuePair<string, byte>>();
            var packTypeList = Packtype.FetchAll();

            foreach (var packTypeObject in packTypeList)
            {
                var mergeFieldListFromView = Query.Create()
                       .Select("COLUMN_NAME")                       
                       .From(QuerySources.PackMergeFields)
                       .WhereRaw("(TABLE_NAME = '" + packTypeObject.StoredProc + "' and COLUMN_NAME not like 'PR_ID%')", null)
                       .OrderBy("COLUMN_NAME", true)
                       .Run();

                foreach (var field in mergeFieldListFromView)
                {
                    mergeFields.Add(new KeyValuePair<string, byte>(field.Values.First().ToString(), packTypeObject.Type));
                }
            }

            this.AllMergeFields.DataSource = mergeFields;

            if (this.Id.FieldValue == "")
            {
                this.packRetainAttachments.FieldValue = true;
                this.DataSource.ActPqKeep = 1;
                this.packSellingCompany.FieldValue = this.CurrentSession.User.SellingCompanyId;
            }
            else
            {
                this.packSellingCompany.FieldValue = this.DataSource.PackSellingCompanyIdId;
                Packtype objPackType = Packtype.FetchAll().Where(s => s.Type == this.DataSource.PackType).FirstOrDefault();
                if (objPackType != null)
                {
                    this.packType.FieldValue = objPackType.Type.ToString();
                    this.packType.DisplayMember = objPackType.Desc;
                }
                this.packType.IsReadOnly = ConfigurableBoolean.True;
                //this.packDeliveryFailure.FieldValue = false;
                //this.packDeliveryDelay.FieldValue = false;
                //this.packDeliverySuccess.FieldValue = false;

                if (!string.IsNullOrEmpty(this.DataSource.DsnOptions))
                {
                    var dsnOptions = this.DataSource.DsnOptions.Split(',');
                    foreach (string val in dsnOptions)
                        getDSNOptionsVal(val);
                }

            }
        }
        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
        }


        private void getDSNOptionsVal(string val)
        {
            switch (val.ToUpper())
            {
                case "S":
                    this.packDeliverySuccess.FieldValue = true;
                    break;
                case "D":
                    this.packDeliveryDelay.FieldValue = true;
                    break;
                case "F":
                    this.packDeliveryFailure.FieldValue = true;
                    break;
            }
        }

        protected override void RegisterJavascript()
        {
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "PackDetailJs", @"
            function validateBccEmail(source, arguments) {
                var ValidatorExpression = /^[a-zA-Z0-9._]+[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,4}$/;
                var bccEmailVal = $('#" + this.bccEmailTo.ClientID + @"Field').val();

                arguments.IsValid = (($.trim(bccEmailVal)==='' && bccEmailVal.length==0) || ValidatorExpression.test(bccEmailVal));
              }

            function validateMdnEmail(source, arguments) {
                var ValidatorExpression = /^[a-zA-Z0-9._]+[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,4}$/;
                var MdnEmailVal = $('#" + this.packMDNRespAdd.ClientID + @"Field').val();
                
                arguments.IsValid = (($.trim(MdnEmailVal)==='' && MdnEmailVal.length==0) || ValidatorExpression.test(MdnEmailVal));
              }

            function validateDsnEmail(source, arguments) {
                var ValidatorExpression = /^[a-zA-Z0-9._]+[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,4}$/;
                var DsnEmailVal = $('#" + this.packDSNRespAdd.ClientID + @"Field').val();
                
                arguments.IsValid = (($.trim(DsnEmailVal)==='' && DsnEmailVal.length==0) || ValidatorExpression.test(DsnEmailVal));
              }

", true);

        }

    }
}