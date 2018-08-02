using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.crm;

namespace Consensus.Web.BackOffice.learning
{
    public partial class CoursePage : BaseStandardPage<Product, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Course - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "conference_foreground_selected"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Product> DataLoader
        {
            get { return Product.FetchById; }
        }

        public override Func<Product> DataCreator
        {
            get { return Product.Create; }
        }


        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.CourseDetails.DataSource = this.Data;
            this.FinanceDetails.DataSource = this.Data;
            this.MainSessionDetails.DataSource = this.Data;
            this.RelationshipsList.ProductParentId = this.Data.Id;
            this.PricesList.PriceParentId = this.Data.Id;
            this.PricesList.ParentSyProduct = "1";
            this.PacksList.PackParentId = this.Data.Id;
            this.PacksList.ParentSyProduct = "1";

            this.CourseTemplateList.BOMParentId = this.Data.Id;
            this.CourseTemplateList.TemplateMode = TemplateList.TemplateListMode.Syllabus;

            this.ProductTemplateList.BOMParentId = this.Data.Id;
            this.ProductTemplateList.TemplateMode = TemplateList.TemplateListMode.Product;

            this.SelectionGroupList.ParentId = this.Data.Id;
            this.SelectionGroupList.Type = SelectionGroupList.SelectionGroupMode.Product;

            this.ProfileList.ProfileParentId = this.Data.Id;
            this.ProfileList.ProfileMode = ProfileList.ProfileListMode.PROF_COURSE_ID;
            this.OnlineDetails.DataSource = this.Data;
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion
    }
}