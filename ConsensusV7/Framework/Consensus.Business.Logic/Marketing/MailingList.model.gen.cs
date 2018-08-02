using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="ListRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMailingListModel : LocalModel<ListRecord, String>, IMailingListModel
    {
        #region fields

        /// <summary>
        ///     The value of the "LIST_USER_ID" field.
        /// </summary>
        private LocalRoleModel _owner;

        /// <summary>
        ///     The value of the "LIST_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "LIST_NOTES_HTML" field.
        /// </summary>
        private LocalNotesModel _notesHtml;

        /// <summary>
        ///     The collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="MailingListModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueueModel, ISaqQueueModel> _saqQueueMailingList;

        /// <summary>
        ///     The collection of <see cref="MailingListMemberModel" /> instances that reference this <see cref="MailingListModel" />.
        /// </summary>
        private LocalCollection<LocalMailingListMemberModel, IMailingListMemberModel> _mailingListMemberList;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ListRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.MailingList.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ListRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.MailingList.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ListRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.MailingList.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return this.ModifiedData.RcvDate; }
            set { this.ModifiedData.RcvDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return this.ModifiedData.RcvFrom; }
            set { this.ModifiedData.RcvFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return this.ModifiedData.Date; }
            set { this.ModifiedData.Date = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_USER_ID" field.
        /// </summary>
        public LocalRoleModel Owner
        {
            get
            {
                if (_owner == null && this.OwnerId != null)
                    _owner = this.Provider.Contact.Role.FetchById(this.OwnerId);
                if (_owner == null)
                    _owner = this.Provider.Contact.Role.Create();
                
                return _owner;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_USER_ID" field.
        /// </summary>
        public String OwnerId
        {
            get { return this.ModifiedData.UserId; }
            set
            {
                if (this.ModifiedData.UserId != value)
                     _owner = null;
                this.ModifiedData.UserId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("LU1", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("LU1");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_STATUS" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.Status; }
            set
            {
                if (this.ModifiedData.Status != value)
                     _status = null;
                this.ModifiedData.Status = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_LIMIT" field.
        /// </summary>
        public Double? Limit
        {
            get { return this.ModifiedData.Limit; }
            set { this.ModifiedData.Limit = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_WEB_ENABLED" field.
        /// </summary>
        public Byte WebEnabled
        {
            get { return this.ModifiedData.WebEnabled; }
            set { this.ModifiedData.WebEnabled = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_NOTES_HTML" field.
        /// </summary>
        public LocalNotesModel NotesHtml
        {
            get
            {
                if (_notesHtml == null && this.NotesHtmlId != null)
                    _notesHtml = this.Provider.Common.Notes.FetchById(this.NotesHtmlId);
                if (_notesHtml == null)
                    _notesHtml = this.Provider.Common.Notes.Create();
                
                return _notesHtml;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_NOTES_HTML" field.
        /// </summary>
        public String NotesHtmlId
        {
            get { return this.ModifiedData.NotesHtml; }
            set
            {
                if (this.ModifiedData.NotesHtml != value)
                     _notesHtml = null;
                this.ModifiedData.NotesHtml = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_IS_DYNAMIC" field.
        /// </summary>
        public Boolean IsDynamic
        {
            get { return this.ModifiedData.IsDynamic; }
            set { this.ModifiedData.IsDynamic = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="MailingListModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueueModel, ISaqQueueModel> SaqQueueMailingList
        {
            get
            {
                if (_saqQueueMailingList == null)
                    _saqQueueMailingList = new LocalCollection<LocalSaqQueueModel, ISaqQueueModel>(this.Provider.Marketing.SaqQueue.FetchAllByMailingListId(this.Id));
                
                return _saqQueueMailingList;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MailingListMemberModel" /> instances that reference this <see cref="MailingListModel" />.
        /// </summary>
        public LocalCollection<LocalMailingListMemberModel, IMailingListMemberModel> MailingListMemberList
        {
            get
            {
                if (_mailingListMemberList == null)
                    _mailingListMemberList = new LocalCollection<LocalMailingListMemberModel, IMailingListMemberModel>(this.Provider.Marketing.MailingListMember.FetchAllByMailingListId(this.Id));
                
                return _mailingListMemberList;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalMailingListModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalMailingListModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalMailingListModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalMailingListModel(LocalProvider provider, ListRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status = _status.Value1;
            }
            if (_owner != null)
            {
                _owner.Save();
                this.ModifiedData.UserId = _owner.Id == null && this.ModifiedData.UserId != null ? "" : _owner.Id;
            }
            if (_notesHtml != null)
            {
                _notesHtml.Save();
                this.ModifiedData.NotesHtml = _notesHtml.Id == null && this.ModifiedData.NotesHtml != null ? "" : _notesHtml.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_saqQueueMailingList != null)
                _saqQueueMailingList.Execute(obj => obj.MailingListId = this.Id).Execute(obj => obj.Save());
            if (_mailingListMemberList != null)
                _mailingListMemberList.Execute(obj => obj.MailingListId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Count of members that are people.
        /// </summary>
        System.Int32 IMailingListModel.TotalPersonCount
        {
            get { return this.TotalPersonCount; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_RCV_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMailingListModel.RcvDate
        {
            get { return this.RcvDate; }
            set { this.RcvDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_RCV_FROM" field.
        /// </summary>
        System.String IMailingListModel.RcvFrom
        {
            get { return this.RcvFrom; }
            set { this.RcvFrom = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_TITLE" field.
        /// </summary>
        System.String IMailingListModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IMailingListModel.Date
        {
            get { return this.Date; }
            set { this.Date = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_USER_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IMailingListModel.Owner
        {
            get { return this.Owner; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_USER_ID" field.
        /// </summary>
        System.String IMailingListModel.OwnerId
        {
            get { return this.OwnerId; }
            set { this.OwnerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IMailingListModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_STATUS" field.
        /// </summary>
        System.String IMailingListModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_NOTES" field.
        /// </summary>
        System.String IMailingListModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_LIMIT" field.
        /// </summary>
        System.Nullable<System.Double> IMailingListModel.Limit
        {
            get { return this.Limit; }
            set { this.Limit = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_WEB_ENABLED" field.
        /// </summary>
        System.Byte IMailingListModel.WebEnabled
        {
            get { return this.WebEnabled; }
            set { this.WebEnabled = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_NOTES_HTML" field.
        /// </summary>
        Consensus.Common.INotesModel IMailingListModel.NotesHtml
        {
            get { return this.NotesHtml; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_NOTES_HTML" field.
        /// </summary>
        System.String IMailingListModel.NotesHtmlId
        {
            get { return this.NotesHtmlId; }
            set { this.NotesHtmlId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_IS_DYNAMIC" field.
        /// </summary>
        System.Boolean IMailingListModel.IsDynamic
        {
            get { return this.IsDynamic; }
            set { this.IsDynamic = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:MailingListModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> IMailingListModel.SaqQueueMailingList
        {
            get { return this.SaqQueueMailingList; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListMemberModel" /> instances that reference this <see cref="!:MailingListModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IMailingListMemberModel> IMailingListModel.MailingListMemberList
        {
            get { return this.MailingListMemberList; }
        }

        #endregion
    }
}
