using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class MailingListMember : Proxy<IMailingListMemberModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MailingList" /> member.
        /// </summary>
        private Consensus.Marketing.MailingList _mailingList;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Person" /> member.
        /// </summary>
        private Consensus.Contact.Person _person;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "LM_LIST_ID" field.
        /// </summary>
        public Consensus.Marketing.MailingList MailingList
        {
            get
            {
                if (_mailingList == null && this.Model.MailingList != null)
                    _mailingList = new Consensus.Marketing.MailingList(this.Model.MailingList);
                if (_mailingList == null)
                    _mailingList = Consensus.Marketing.MailingList.Create();
                return _mailingList;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LM_LIST_ID" field.
        /// </summary>
        public System.String MailingListId
        {
            get { return this.Model.MailingListId; }
            set { this.Model.MailingListId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LM_PN_ID" field.
        /// </summary>
        public Consensus.Contact.Person Person
        {
            get
            {
                if (_person == null && this.Model.Person != null)
                    _person = new Consensus.Contact.Person(this.Model.Person);
                if (_person == null)
                    _person = Consensus.Contact.Person.Create();
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LM_PN_ID" field.
        /// </summary>
        public System.String PersonId
        {
            get { return this.Model.PersonId; }
            set { this.Model.PersonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_TABLE_NAME" field.
        /// </summary>
        public System.String TableName
        {
            get { return this.Model.TableName; }
            set { this.Model.TableName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_RECORD_ID" field.
        /// </summary>
        public System.String RecordId
        {
            get { return this.Model.RecordId; }
            set { this.Model.RecordId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal MailingListMember(IMailingListMemberModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:MailingListMemberModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MailingListMemberModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.MailingListMember Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingListMember.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MailingListMemberModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MailingListMemberModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.MailingListMember Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.IMailingListMemberModel model = provider.Marketing.MailingListMember.Create();
            return model == null ? null : new Consensus.Marketing.MailingListMember(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MailingListMemberModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingListMember> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingListMember.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MailingListMemberModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingListMember> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IMailingListMemberModel> collection = provider.Marketing.MailingListMember.FetchAll();
            return collection.Select(model => new Consensus.Marketing.MailingListMember(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MailingListMemberModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MailingListMemberModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.MailingListMember FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingListMember.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MailingListMemberModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MailingListMemberModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.MailingListMember FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.IMailingListMemberModel model = provider.Marketing.MailingListMember.FetchById(id);
            return model == null ? null : new Consensus.Marketing.MailingListMember(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingListMember.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.MailingListMember.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instances that match the specified <paramref name="mailingListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingListMember> FetchAllByMailingListId(System.String mailingListId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingListMember.FetchAllByMailingListId(site,mailingListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instances that match the specified <paramref name="mailingListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingListMember> FetchAllByMailingListId(ConsensusSite site, System.String mailingListId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IMailingListMemberModel> collection = provider.Marketing.MailingListMember.FetchAllByMailingListId(mailingListId);
            return collection.Select(model => new Consensus.Marketing.MailingListMember(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingListMember> FetchAllByPersonId(System.String personId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return MailingListMember.FetchAllByPersonId(site,personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.MailingListMember> FetchAllByPersonId(ConsensusSite site, System.String personId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IMailingListMemberModel> collection = provider.Marketing.MailingListMember.FetchAllByPersonId(personId);
            return collection.Select(model => new Consensus.Marketing.MailingListMember(model));
        }

        #endregion
    }
}
