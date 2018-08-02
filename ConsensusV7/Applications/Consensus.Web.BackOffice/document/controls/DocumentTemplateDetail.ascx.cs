using Consensus.Document;
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
    public partial class DocumentTemplateDetail : BaseControl<PackXref, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Document template"; }
        }

        public override Func<String, PackXref> DataLoader
        {
            get { return PackXref.FetchById; }
        }
        #endregion

        #region methods
        protected override void RegisterJavascript()
        {
            this.DocTemplate.ClientOnChange += @"
                if(this.getData() != ''){
                    var data=this.getData();
                        if (data.doc_template_type != 'Word')
                            {
                                $('#" + this.EmailBody.ClientID + @"Group').css('display','none');
                                $('#" + this.EmailBody.ClientID + @"Label').css('display','none');

                                if (data.doc_template_type == 'SMS') {
                                    $('#" + this.SMS.ClientID + @"Field').val(data.doc_template_id);
                                    $('#" + this.ICalendar.ClientID + @"Field').val(null);
                                    $('#" + this.WordTemplate.ClientID + @"Field').val(null);
                                }
                                else if (data.doc_template_type == 'iCalendar'){
                                    $('#" + this.ICalendar.ClientID + @"Field').val(data.doc_template_id);
                                    $('#" + this.SMS.ClientID + @"Field').val(null);
                                    $('#" + this.WordTemplate.ClientID + @"Field').val(null);
                                }
                            }
                        else
                        {
                            $('#" + this.WordTemplate.ClientID + @"Field').val(data.doc_template_id);
                            $('#" + this.ICalendar.ClientID + @"Field').val(null);
                            $('#" + this.SMS.ClientID + @"Field').val(null);

                            $('#" + this.EmailBody.ClientID + @"Group').css('display','block');
                            $('#" + this.EmailBody.ClientID + @"Label').css('display','block');
                            $('#" + this.EmailBody.ClientID + @"').removeAttr('hidden');


        }
                    }";

        }


        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.EmailBody.FieldValue = true;
            this.PackId.FieldValue = this.Request.QueryString["packid"];
            this.DocTemplate.PopupUrl += "packtype=" + Request.QueryString["packtype"];

            var PackId = this.Request.QueryString["packid"];
            var packXref = PackXref.FetchAllByPackIdId(PackId);
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            var packXrefId = this.Request.QueryString["id"];
            var packXref = PackXref.FetchById(packXrefId);

            if (packXref != null)
            {
                if (packXref.LitIdId != null)
                {
                    this.DocTemplate.FieldValue = packXref.LitIdId;
                    this.DocTemplate.FieldText = packXref.LitId.Name;

                    if (packXref.Seq == 99)
                    {
                        this.EmailBody.FieldValue = false;
                    }
                }
                if (packXref.IcmIdId != null)
                {
                    this.DocTemplate.FieldValue = Convert.ToString(packXref.IcmIdId);
                    this.DocTemplate.FieldText = packXref.IcmId.Name;

                    if (packXref.Seq == 99)
                    {
                        this.EmailBody.IsHidden = ConfigurableBoolean.True;
                    }
                }
                if (packXref.SmsIdId != null)
                {
                    this.DocTemplate.FieldValue = Convert.ToString(packXref.SmsIdId);
                    this.DocTemplate.FieldText = packXref.SmsId.Name;

                    if (packXref.Seq == 99)
                    {
                        this.EmailBody.IsHidden = ConfigurableBoolean.True;
                    }
                }
            }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.AllowDelete = true;
        }
        #endregion
    }
}