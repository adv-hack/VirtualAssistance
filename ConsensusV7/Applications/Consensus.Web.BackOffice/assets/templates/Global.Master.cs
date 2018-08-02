using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.assets.templates
{
    public partial class Global : System.Web.UI.MasterPage
    {
        public bool Debug { get; set; }
        public Global()
        {
#if DEBUG
            Debug = true;
#else
            Debug = false;
#endif
        }
        /// <summary>
        ///     Specifies a time-specific that can be appended to URLs
        /// </summary>
        public String ResourceSuffix
        {
#if DEBUG
            get { return "?" + DateTime.Now.ToString("yyyyMMddhhmmss"); }
#else
            get { return ""; }
#endif
        }
        
    }
}