using Consensus.Learning;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning
{
    public partial class TemplateList : BaseListControl
    {

        #region enums

        /// <summary>
        ///     Enumerates the different modes that the associate list can be used for.
        /// </summary>
        public enum TemplateListMode
        {
            Product,
            Syllabus,
            EXAM,
            Accommodation,
            Activity
        }

        #endregion

        #region fields

        /// <summary>
        ///     The ID of the parent object that the bill of material records are linked to.
        /// </summary>
        private String _bomproductId;

        /// <summary>
        ///     The bom type
        /// </summary>
        private TemplateListMode _templateMode;


        #endregion



        #region properties

        /// <summary>
        ///     Gets or sets the ID of the parent object that the price records are linked to.
        /// </summary>
        public String BOMParentId
        {
            get { return _bomproductId; }
            set { _bomproductId = value; }
        }

        /// <summary>
        ///    Gets or sets the BOM Type to screenObjectDisplay
        /// </summary>
        public TemplateListMode TemplateMode
        {
            get { return _templateMode; }
            set { _templateMode = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { 
                switch (this.TemplateMode)
                {
                    case TemplateListMode.Syllabus: return "Session Template List";
                    case TemplateListMode.EXAM: return "Exam Template List";
                    case TemplateListMode.Activity: return "Activity Template List";
                    case TemplateListMode.Accommodation: return "Accommodation Template List";
                    default: return "Product Template List";
                }
                
            }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.TemplateListResults; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("BOM_ID")
                    .Select("BOM_SYLLABUS_ID")
                    .Select("PROD_NAME")
                    .Select("PROD_REF")
                    .Select("BOM_ACT_TYPE")
                    .Select("BOM_ACT_SESSION_NAME")
                    .Select("BOM_TYPE_SUB")
                    .Select("BOM_MAIN_SESSION")
                    .Select("BOM_SESSION")
                    .Select("BOM_ELEMENT")
                    .Select("BOM_MANDATORY")
                    .Select("BOM_CHARGEABLE")
                    .Select("BOM_INVOICE_PRINT")
                    .Select("BOM_SHOW_SALES")
                    .Select("BOM_START_DAY")
                    .Select("BOM_END_DAY")
                    .Select("BOM_START_TIME")
                    .Select("BOM_END_TIME")
                    .Select("BOM_START_DAY_TEXT")
                    .Select("BOM_END_DAY_TEXT")
                    .Select("PROD_START_DATE_FIXED")
                    .Select("PROD_END_DATE_FIXED")
                    .Select("PROD_START_DATE_TYPE")
                    .Select("PROD_END_DATE_TYPE")
                    .Select("TXREF_DEL_QTY")
                    .Select("TXREF_QTY")
                    .Select("PSG_NAME")
                    .Select("uri")
                    .From(QuerySources.BOMs)
                    .Where("BOM_PARENT_ID", QueryConditionTypes.Equal, this.BOMParentId)
                    .And("BOM_TYPE", QueryConditionTypes.Equal, this.TemplateMode.ToString())
                    .OrderBy("BOM_START_DAY", true);
            }
        }

        #endregion
        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            switch (this.TemplateMode)
            {
                case TemplateListMode.Syllabus:
                    this.DataTable.Url += "templatedetails&id={{Id}}";
                    break;
                case TemplateListMode.EXAM: 
                    this.DataTable.Columns[4].Visible = true;
                    this.DataTable.Columns[5].Visible = false;
                    this.DataTable.Columns[6].Visible = false;
                    this.DataTable.Columns[10].Visible = false;
                    this.DataTable.Columns[15].Visible = true;
                    this.DataTable.Columns[16].Visible = true;
                    this.DataTable.Columns[17].Visible = true;
                    this.DataTable.Columns[18].Visible = true;
                    break;
                case TemplateListMode.Activity:
                    this.DataTable.Url += "activitytemplatedetails&id={{Id}}";
                    this.DataTable.Columns[0].Visible = true;
                    this.DataTable.Columns[1].Visible = true;
                    this.DataTable.Columns[2].Visible = false;
                    this.DataTable.Columns[3].Visible = false;
                    this.DataTable.Columns[5].Visible = false;
                    this.DataTable.Columns[6].Visible = false;
                    this.DataTable.Columns[7].Visible = false;
                    this.DataTable.Columns[8].Visible = false;
                    this.DataTable.Columns[9].Visible = false;
                    this.DataTable.Columns[10].Visible = false;
                    break;
                case TemplateListMode.Accommodation: 
                    this.DataTable.Columns[4].Visible = true;
                    this.DataTable.Columns[5].Visible = false;
                    this.DataTable.Columns[6].Visible = false;
                    this.DataTable.Columns[10].Visible = false;
                    break;
                default:
                    this.DataTable.Url += "producttemplatedetails&id={{Id}}";
                    this.DataTable.Columns[2].Visible = false;
                    this.DataTable.Columns[3].Visible = true;
                    this.DataTable.Columns[10].Visible = false;
                    this.DataTable.Columns[11].Visible = false;
                    this.DataTable.Columns[12].Visible = false;
                    this.DataTable.Columns[13].Visible = false;
                    break;
            }

            this.DataTable.Url += "&bomType=" + this.TemplateMode + "&masterproductId=" + HttpUtility.UrlEncode(this.BOMParentId); 
            this.DataTable.Json = "{ uri: \"learning/billofmaterial\", masterproductId: " + HttpUtility.JavaScriptStringEncode(this.BOMParentId, true) + ",type: " + HttpUtility.JavaScriptStringEncode(this.TemplateMode.ToString(), true) + "}";
        }

        #endregion
    }
}