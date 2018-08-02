using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class CreditNoteAllocationList : BaseListControl
    {
        #region fields

        private String _invId;


        #endregion


        #region properties
        public String InvId
        {
            get { return _invId; }
            set { _invId = value; }
        }


        public override String DataTypeName
        {
            get { return "Credit Note Allocation List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.CreditNoteAllocation; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PA_ID")
                    .Select("PA_INV_ID")
                    .Select("PA_INV_REF")
                    .Select("PA_CREDIT_ID")
                    .Select("PA_CREDIT_REF")
                    .Select("PA_PAY_ID")
                    .Select("PA_CURR_TYPE")
                    .Select("PA_VALUE")
                    .Select("uri")
                    .From(QuerySources.CreditNoteAllocations)
                    .Where("PA_CREDIT_ID", QueryConditionTypes.Equal, this.InvId);
            }
        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion
    }
}