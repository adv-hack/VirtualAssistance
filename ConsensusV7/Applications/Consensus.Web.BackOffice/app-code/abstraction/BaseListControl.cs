using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consensus.Web.BackOffice
{
    public abstract class BaseListControl : BaseControl
    {
        public abstract DataTable DataTable
        {
            get;
        }

        public abstract Object DataSource
        {
            get;
        }

        public virtual string DataBoundValue
        {
            get { return ""; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Data = this.DataSource;
            this.DataTable.DataBoundValue = this.DataBoundValue;
        }
    }
}