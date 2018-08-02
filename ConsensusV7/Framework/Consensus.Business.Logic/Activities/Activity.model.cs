using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.HtmlControls;
using Consensus.Common;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalActivityModel
    {
        #region fields

        /// <summary>
        ///     The instance of the LocalActivityXrefModel which represents the activity end user.
        /// </summary>
        private LocalActivityXrefModel _endUser;

        /// <summary>
        ///     The instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        private LocalActivityXrefModel _salesPerson;

        private LocalCollection<Common.LocalAttachmentModel, Common.IAttachmentModel> _attachments;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        public LocalActivityXrefModel EndUser
        {
            get
            {
                if (_endUser == null)
                    _endUser = this.ActivityXRefs.FirstOrDefault(xref => xref.ActivityReferenceType == ActivityReferenceTypes.EndUser);

                if (_endUser == null)
                    _endUser = this.CreateXRef(ActivityReferenceTypes.EndUser);

                return _endUser;
            }
        }

        /// <summary>
        ///     Gets the instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        public LocalActivityXrefModel SalesPerson
        {
            get
            {
                if (_salesPerson == null)
                    _salesPerson = this.ActivityXRefs.FirstOrDefault(xref => xref.ActivityReferenceType == ActivityReferenceTypes.SalesPerson);

                if (_salesPerson == null)
                    _salesPerson = this.CreateXRef(ActivityReferenceTypes.SalesPerson);

                return _salesPerson;
            }
        }

        public String EndUserId
        {
            get
            {
                return this.EndUser.PersonRoleId;
            }
            set
            {
                this.EndUser.PersonRoleId = value;
            }
        }

        public String EndUserPersonId
        {
            get
            {
                return this.EndUser.PersonId;
            }
            set
            {
                this.EndUser.PersonId = value;
            }
        }

        public String EndUserOrganisationId
        {
            get
            {
                return this.EndUser.OrganisationId;
            }
            set
            {
                this.EndUser.OrganisationId = value;
            }
        }
        public String SalesPersonId
        {
            get
            {
                return this.SalesPerson.PersonRoleId;
            }
            set
            {
                this.SalesPerson.PersonRoleId = value;
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Provides denormalisation of the activity data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();
            if (this.NoteHtml != null)
                this.Note = this.NoteHtml.HtmlToText();
        }

        /// <summary>
        ///     Creates a new LocalActivityXrefModel model for this activity, pre-initialised with the specified type.
        /// </summary>
        private LocalActivityXrefModel CreateXRef(ActivityReferenceTypes type)
        {
            LocalActivityXrefModel model = this.Provider.Activities.ActivityXref.Create();
            model.ActivityReferenceType = type;

            this.ActivityXRefs.Add(model);
            return model;
        }

        /// <summary>
        ///     List of attachments for an activity. Created here to aid saving from the activity dialog.
        /// </summary>
        public LocalCollection<Common.LocalAttachmentModel, Common.IAttachmentModel> Attachments
        {
            get
            {
                if (_attachments == null)
                    _attachments = new LocalCollection<Common.LocalAttachmentModel, Common.IAttachmentModel>(this.Provider.Common.Attachment.FetchAllByUrlAndRecordId("Activities/Activity", this.Id));

                return _attachments;
            }
        }

        #endregion
    }
}

