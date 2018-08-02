using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MailingListMemberModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMailingListMemberFactory : LocalFactory<LocalMailingListMemberModel, ListMemberRecord, String>, IMailingListMemberFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='MailingListMemberModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='MailingListMemberModel' /> instance.
        /// </returns>
        public LocalMailingListMemberModel Create()
        {
            return new LocalMailingListMemberModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='MailingListMemberModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='MailingListMemberModel' /> instances.
        /// </returns>
        public IEnumerable<LocalMailingListMemberModel> FetchAll()
        {
            IEnumerable<ListMemberRecord> recordCollection = this.Provider.DataProvider.Marketing.MailingListMember.FetchAll();
            foreach (ListMemberRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMailingListMemberModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='MailingListMemberModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='MailingListMemberModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MailingListMemberModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalMailingListMemberModel FetchById(String id)
        {
            ListMemberRecord record = this.Provider.DataProvider.Marketing.MailingListMember.FetchById(id);
            if (record == null)
                return null;
            return new LocalMailingListMemberModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='MailingListMember/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.MailingListMember.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MailingListMemberModel' /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref='MailingListMemberModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MailingListMemberModel' /> instances that match the specified <paramref name='mailingListId' />.
        /// </returns>
        public IEnumerable<LocalMailingListMemberModel> FetchAllByMailingListId(String mailingListId)
        {
            IEnumerable<ListMemberRecord> recordCollection = this.Provider.DataProvider.Marketing.MailingListMember.FetchAllByListId(mailingListId);
            foreach (ListMemberRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMailingListMemberModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MailingListMemberModel' /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='MailingListMemberModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MailingListMemberModel' /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<LocalMailingListMemberModel> FetchAllByPersonId(String personId)
        {
            IEnumerable<ListMemberRecord> recordCollection = this.Provider.DataProvider.Marketing.MailingListMember.FetchAllByPnId(personId);
            foreach (ListMemberRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMailingListMemberModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:MailingListMemberModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MailingListMemberModel" /> instance.
        /// </returns>
        Consensus.Marketing.IMailingListMemberModel IMailingListMemberFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MailingListMemberModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListMemberModel> IMailingListMemberFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Marketing.IMailingListMemberModel IMailingListMemberFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IMailingListMemberFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListMemberModel> IMailingListMemberFactory.FetchAllByMailingListId(System.String mailingListId)
        {
            return this.FetchAllByMailingListId(mailingListId);
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
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListMemberModel> IMailingListMemberFactory.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        #endregion
    }
}
