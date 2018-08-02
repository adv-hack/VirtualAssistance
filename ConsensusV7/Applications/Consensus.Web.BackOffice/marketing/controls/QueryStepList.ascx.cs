using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Web;

namespace Consensus.Web.BackOffice.marketing
{
    public partial class QueryStepList : BaseListControl
    {
        #region fields


        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the ID of the parent object that the opportunity records are linked to.
        /// </summary>
        public long QueryId { get; set; }

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

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Query Steps"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.StepResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Searches.Search.Create(SearchTypes.SearchQueryStep)
                    .AddParameter("@PA_QRY_ID", this.QueryId);
            }

        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.DataTable.CreateUrl += "&queryId=" + this.QueryId;
            this.DataTable.Json = "{ uri: \"marketing/saqquerystep\", StepQueryId : " + QueryId + " }";
        }

        #endregion
    }
}