using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="ListMemberRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMailingListMemberModel : LocalModel<ListMemberRecord, String>, IMailingListMemberModel
    {
        #region fields

        /// <summary>
        ///     The value of the "LM_LIST_ID" field.
        /// </summary>
        private LocalMailingListModel _mailingList;

        /// <summary>
        ///     The value of the "LM_PN_ID" field.
        /// </summary>
        private LocalPersonModel _person;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ListMemberRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.MailingListMember.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ListMemberRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.MailingListMember.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ListMemberRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.MailingListMember.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "LM_LIST_ID" field.
        /// </summary>
        public LocalMailingListModel MailingList
        {
            get
            {
                if (_mailingList == null && this.MailingListId != null)
                    _mailingList = this.Provider.Marketing.MailingList.FetchById(this.MailingListId);
                if (_mailingList == null)
                    _mailingList = this.Provider.Marketing.MailingList.Create();
                
                return _mailingList;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LM_LIST_ID" field.
        /// </summary>
        public String MailingListId
        {
            get { return this.ModifiedData.ListId; }
            set
            {
                if (this.ModifiedData.ListId != value)
                     _mailingList = null;
                this.ModifiedData.ListId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "LM_PN_ID" field.
        /// </summary>
        public LocalPersonModel Person
        {
            get
            {
                if (_person == null && this.PersonId != null)
                    _person = this.Provider.Contact.Person.FetchById(this.PersonId);
                if (_person == null)
                    _person = this.Provider.Contact.Person.Create();
                
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LM_PN_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return this.ModifiedData.PnId; }
            set
            {
                if (this.ModifiedData.PnId != value)
                     _person = null;
                this.ModifiedData.PnId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return this.ModifiedData.TableName; }
            set { this.ModifiedData.TableName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return this.ModifiedData.RecordId; }
            set { this.ModifiedData.RecordId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalMailingListMemberModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalMailingListMemberModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalMailingListMemberModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalMailingListMemberModel(LocalProvider provider, ListMemberRecord record) : base(provider, record)
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
            if (_mailingList != null)
            {
                _mailingList.Save();
                this.ModifiedData.ListId = _mailingList.Id == null && this.ModifiedData.ListId != null ? "" : _mailingList.Id;
            }
            if (_person != null)
            {
                _person.Save();
                this.ModifiedData.PnId = _person.Id == null && this.ModifiedData.PnId != null ? "" : _person.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "LM_LIST_ID" field.
        /// </summary>
        Consensus.Marketing.IMailingListModel IMailingListMemberModel.MailingList
        {
            get { return this.MailingList; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LM_LIST_ID" field.
        /// </summary>
        System.String IMailingListMemberModel.MailingListId
        {
            get { return this.MailingListId; }
            set { this.MailingListId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LM_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IMailingListMemberModel.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LM_PN_ID" field.
        /// </summary>
        System.String IMailingListMemberModel.PersonId
        {
            get { return this.PersonId; }
            set { this.PersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_TABLE_NAME" field.
        /// </summary>
        System.String IMailingListMemberModel.TableName
        {
            get { return this.TableName; }
            set { this.TableName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_RECORD_ID" field.
        /// </summary>
        System.String IMailingListMemberModel.RecordId
        {
            get { return this.RecordId; }
            set { this.RecordId = (System.String)value; }
        }

        #endregion
    }
}
