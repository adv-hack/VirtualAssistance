using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class TemplateDetails : BaseControl<BillOfMaterial, String>
    {

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        private Boolean _allowDelete = true;
        
        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        public override bool AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }
   

        public override String DataTypeName
        {
            get 
            {
                String bomType;
                bomType = this.Request.QueryString["bomType"];

                if (bomType == "Syllabus")
                {
                    bomType = "Session";
                }
                return bomType; 
            }
        }

        public override Func<String, BillOfMaterial> DataLoader
        {
            get
            {
                return BillOfMaterial.FetchById;
            }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.TrainersListSection.Visible = false;
            this.RoomsListSection.Visible = false;
            this.ResourcesListSection.Visible = false;

            if (this.DataSource != null)
            {
                this.SessionDetails.ParentProductId = this.DataSource.MasterProductId;
                this.AllowDelete = this.DataSource.MainSession !=1;
            }
            else
                this.SessionDetails.ParentProductId = this.Request.QueryString["masterproductId"]; 

            switch (this.Request.QueryString["bomType"])
            {
                case "Syllabus":
                    if (this.DataSource != null)
                        this.TrainersList.DataTable.Json = "{ BillOfMaterialId: \"" + this.DataSource.Id + "\" }";

                    if (this.DataSource != null)
                        this.RoomsList.DataTable.Json = "{ BillOfMaterialId: \"" + this.DataSource.Id + "\" }";

                    if (this.DataSource != null)
                        this.ResourcesList.DataTable.Json = "{ BillOfMaterialId: \"" + this.DataSource.Id + "\" }";
                    break;
            }


        }
    }
}