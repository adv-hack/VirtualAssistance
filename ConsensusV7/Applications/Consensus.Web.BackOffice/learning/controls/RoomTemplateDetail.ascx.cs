using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class RoomTemplateDetail : BaseControl<TemplateRoom, String>
    {
        public override String DataTypeName
        {
            get { return "Room"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, TemplateRoom> DataLoader
        {
            get { return TemplateRoom.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {

            base.OnInit(e);
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();

        }
    }
}