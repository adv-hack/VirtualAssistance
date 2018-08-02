using Consensus.Searches;
using Consensus.Web.Controls;
using System;

namespace Consensus.Web.BackOffice.marketing
{
    public partial class StepParameterList : BaseListControl
    {
        #region fields
        

        #endregion  
      
        #region properties
        
        /// <summary>
        ///     Gets or sets the ID of the parent object that the opportunity records are linked to.
        /// </summary>
        public long StepId { get; set; }

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
            get { return "Step Parameters"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.StepParameterResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Searches.Search.Create(SearchTypes.SearchStepParameter)
                        .AddParameter("@PA_STEP_ID", this.StepId);
            }

        }
        #endregion
        
        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"marketing/saqparameter\", StepId: " + this.StepId + " }";
        }

        #endregion
    }
}