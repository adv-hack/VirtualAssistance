using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class MailingList : Proxy<IMailingListModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Owner" /> member.
        /// </summary>
        private Consensus.Contact.Role _owner;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="NotesHtml" /> member.
        /// </summary>
        private Consensus.Common.Notes _notesHtml;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueueMailingList" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel> _saqQueueMailingList;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MailingListMemberList" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.MailingListMember, Consensus.Marketing.IMailingListMemberModel> _mailingListMemberList;

        #endregion

        #region properties

        /// <summary>
        ///     Count of members that are people.
        /// </summary>
        public System.Int32 TotalPersonCount
        {
            get { return this.Model.TotalPersonCount; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_RCV_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> RcvDate
        {
            get { return this.Model.RcvDate; }
            set { this.Model.RcvDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_RCV_FROM" field.
        /// </summary>
        public System.String RcvFrom
        {
            get { return this.Model.RcvFrom; }
            set { this.Model.RcvFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_USER_ID" field.
        /// </summary>
        public Consensus.Contact.Role Owner
        {
            get
            {
                if (_owner == null && this.Model.Owner != null)
                    _owner = new Consensus.Contact.Role(this.Model.Owner);
                if (_owner == null)
                    _owner = Consensus.Contact.Role.Create();
                return _owner;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_USER_ID" field.
        /// </summary>
        public System.String OwnerId
        {
            get { return this.Model.OwnerId; }
            set { this.Model.OwnerId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_LIMIT" field.
        /// </summary>
        public System.Nullable<System.Double> Limit
        {
            get { return this.Model.Limit; }
            set { this.Model.Limit = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_WEB_ENABLED" field.
        /// </summary>
        public System.Byte WebEnabled
        {
            get { return this.Model.WebEnabled; }
            set { this.Model.WebEnabled = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIST_NOTES_HTML" field.
        /// </summary>
        public Consensus.Common.Notes NotesHtml
        {
            get
            {
                if (_notesHtml == null && this.Model.NotesHtml != null)
                    _notesHtml = new Consensus.Common.Notes(this.Model.NotesHtml);
                if (_notesHtml == null)
                    _notesHtml = Consensus.Common.Notes.Create();
                return _notesHtml;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_NOTES_HTML" field.
        /// </summary>
        public System.String NotesHtmlId
        {
            get { return this.Model.NotesHtmlId; }
            set { this.Model.NotesHtmlId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_IS_DYNAMIC" field.
        /// </summary>
        public System.Boolean IsDynamic
        {
            get { return this.Model.IsDynamic; }
            set { this.Model.IsDynamic = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:MailingListModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQueue> SaqQueueMailingList
        {
            get
            {
                if (_saqQueueMailingList == null)
                    _saqQueueMailingList = new ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel>(this.Model.SaqQueueMailingList, model => new Consensus.Marketing.SaqQueue(model));
                return _saqQueueMailingList;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListMemberModel" /> instances that reference this <see cref="!:MailingListModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.MailingListMember> MailingListMemberList
        {
            get
            {
                if (_mailingListMemberList == null)
                    _mailingListMemberList = new ProxyCollection<Consensus.Marketing.MailingListMember, Consensus.Marketing.IMailingListMemberModel>(this.Model.MailingListMemberList, model => new Consensus.Marketing.MailingListMember(model));
                return _mailingListMemberList;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal MailingList(IMailingListModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:MailingListModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MailingListModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.MailingList Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingList.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MailingListModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MailingListModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.MailingList Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.IMailingListModel model = provider.Marketing.MailingList.Create();
            return model == null ? null : new Consensus.Marketing.MailingList(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MailingListModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MailingListModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingList> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingList.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MailingListModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MailingListModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingList> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IMailingListModel> collection = provider.Marketing.MailingList.FetchAll();
            return collection.Select(model => new Consensus.Marketing.MailingList(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MailingListModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MailingListModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.MailingList FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingList.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MailingListModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MailingListModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.MailingList FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.IMailingListModel model = provider.Marketing.MailingList.FetchById(id);
            return model == null ? null : new Consensus.Marketing.MailingList(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingList.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.MailingList.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListModel" /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instances that match the specified <paramref name="ownerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingList> FetchAllByOwnerId(System.String ownerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingList.FetchAllByOwnerId(site,ownerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListModel" /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instances that match the specified <paramref name="ownerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingList> FetchAllByOwnerId(ConsensusSite site, System.String ownerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IMailingListModel> collection = provider.Marketing.MailingList.FetchAllByOwnerId(ownerId);
            return collection.Select(model => new Consensus.Marketing.MailingList(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListModel" /> instances.
        /// </summary>
        /// <param name="notesHtmlId">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instances that match the specified <paramref name="notesHtmlId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingList> FetchAllByNotesHtmlId(System.String notesHtmlId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingList.FetchAllByNotesHtmlId(site,notesHtmlId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListModel" /> instances.
        /// </summary>
        /// <param name="notesHtmlId">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instances that match the specified <paramref name="notesHtmlId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingList> FetchAllByNotesHtmlId(ConsensusSite site, System.String notesHtmlId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IMailingListModel> collection = provider.Marketing.MailingList.FetchAllByNotesHtmlId(notesHtmlId);
            return collection.Select(model => new Consensus.Marketing.MailingList(model));
        }

        #endregion
    }
}
