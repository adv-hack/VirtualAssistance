using Consensus.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class WordTemplateDetails : BaseControl<LetterTemplate, String>
    {
        public override string DataTypeName
        {
            get { return "Word Template"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.Type.DataSource = LetterTemplateType.FetchAll().Where(x => x.Type == 1 || x.Type==2);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            //this.PrintQueue.DataSource = OutputQueue.FetchAll();

            if(this.DataSource.Id == null)
            {
                //defaults for new templates
                this.Current.FieldValue = true;
                this.SellingCompany.FieldValue = Common.SellingCompany.FetchDefault().Id;
            }
        }
    }
}