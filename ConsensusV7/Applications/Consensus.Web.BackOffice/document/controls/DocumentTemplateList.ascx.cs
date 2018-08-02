using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class DocumentTemplateList : BaseListControl
    {
        private String _packId;
        private String _packType;
        public String PackId
        {
            get { return _packId; }
            set { _packId = value; }
        }
        public String PackType
        {
            get { return _packType; }
            set { _packType = value; }
        }

        public override String DataTypeName
        {
            get { return "Document Templates"; }
        }

        public override DataTable DataTable
        {
            get {
                
                return this.DocumentTemplateListTable; }
        }

        public override object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("LIT_ID")
                    .Select("LIT_NAME")
                    .Select("LIT_TEMPLATE")
                    .Select("PACKXREF_ID")
                    .Select("LT_TYPE")
                    .Select("LIT_TYPE")
                    .Select("Type")
                    .Select("LTT_NAME")
                    .Select("IS_COVER_PAGE")
                    .Select("PACKXREF_PACK_ID")
                    .Select("uri")
                    .From(QuerySources.DocumentTemplates)
                    .Where("PACKXREF_PACK_ID", QueryConditionTypes.Equal, this.PackId)
                    .OrderBy("IS_COVER_PAGE",false).ThenBy("Type").ThenBy("LIT_NAME");
            }
           
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //this.DocumentTemplateListTable.CreateUrl += "&packid=" + HttpUtility.UrlEncode(this.PackId)
            //+ "&packtype=" + HttpUtility.UrlEncode(this.PackType);
            this.DocumentTemplateListTable.Url += "&packid=" + HttpUtility.UrlEncode(this.PackId)
           + "&packtype=" + HttpUtility.UrlEncode(this.PackType);

            this.DataTable.Json = "{ uri: \"document/packxref\", PackXrefId: " + HttpUtility.JavaScriptStringEncode(this.PackId, true) + " }";
        }
    }
}