using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventSessionDetail : BaseControl<Session, String>
    {

        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _parentEventId;

        /// <summary>
        ///     Gets or sets the Id of the parent event that the session records are linked to.
        /// </summary>
        public String ParentEventId
        {
            get { return _parentEventId; }
            set { _parentEventId = value; }
        }

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
                return "Session";
            }
        }

        public override Func<String, Session> DataLoader
        {
            get
            {
                return Learning.Session.FetchById;
            }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.ParentEventId = Request.QueryString["eventId"];
            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.EventId.FieldValue = this.ParentEventId;
                this.Type.FieldValue = "D-Session";

                Session session = Learning.Session.CreateFromEvent(this.ParentEventId);

                this.EventSessionDetails.ParentEventId = this.ParentEventId;
                this.EventSessionDetails.DataSource = session;
                this.LocationDetails.DataSource = session;
                this.SessionNoteDetails.DataSource = session;

                this.SessionPriceDetails.ProductId = session.ProductId;                                
            }
            else
            {
                this.SessionPriceDetails.DataTable.Json = "{ SessionId: \"" + this.DataSource.Id + "\" }";

                this.EventSessionDetails.ParentEventId = this.ParentEventId;
                this.EventSessionDetails.DataSource = this.DataSource;
                this.LocationDetails.DataSource = this.DataSource;
                this.SessionNoteDetails.DataSource = this.DataSource;
                this.AllowDelete = this.DataSource.SessionXrefMaster.MainSession != 1;
            }
        }
    }
}