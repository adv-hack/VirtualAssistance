using Consensus.Sales;
using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.marketing;

namespace Consensus.Web.BackOffice.marketing
{
    public partial class QueryPage : BaseStandardPage<SaqQuery, long>
    {
        public override Func<long, SaqQuery> DataLoader
        {
            get { return SaqQuery.FetchById; }
        }

        //private SaqQuery FetchByNullableId(long? id)
        //{
        //    //return string.IsNullOrEmpty(id) ? SaqQuery.FetchById(Convert.ToInt64(id)) : null;
        //    return id.HasValue ? SaqQuery.FetchById(id.CustomisationValue) : null;
        //}

        public override Func<SaqQuery> DataCreator
        {
            get { return SaqQuery.Create; }
        }

        public override string DefaultTitle
        {
            get { return "Query - "+ this.Data.Name; }
        }

        public override string DefaultIcon
        {
            get
            {
                return "search_property";
            }
        }

        protected override void PopulateControls()
        {
            base.PopulateControls();
            // Get the role to be displayed
            SaqQuery query = this.Data;

            this.QueryDetail.DataSource = query;
            this.QueryDataProtection.DataSource = query;

            this.QueryStepList.QueryId = query.Id;
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
    }
}