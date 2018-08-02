using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MailingListModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMailingListFactory : LocalFactory<LocalMailingListModel, ListRecord, String>, IMailingListFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='MailingListModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='MailingListModel' /> instance.
        /// </returns>
        public LocalMailingListModel Create()
        {
            return new LocalMailingListModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='MailingListModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='MailingListModel' /> instances.
        /// </returns>
        public IEnumerable<LocalMailingListModel> FetchAll()
        {
            IEnumerable<ListRecord> recordCollection = this.Provider.DataProvider.Marketing.MailingList.FetchAll();
            foreach (ListRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMailingListModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='MailingListModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='MailingListModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MailingListModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalMailingListModel FetchById(String id)
        {
            ListRecord record = this.Provider.DataProvider.Marketing.MailingList.FetchById(id);
            if (record == null)
                return null;
            return new LocalMailingListModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='MailingList/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.MailingList.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MailingListModel' /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref='MailingListModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MailingListModel' /> instances that match the specified <paramref name='ownerId' />.
        /// </returns>
        public IEnumerable<LocalMailingListModel> FetchAllByOwnerId(String ownerId)
        {
            IEnumerable<ListRecord> recordCollection = this.Provider.DataProvider.Marketing.MailingList.FetchAllByUserId(ownerId);
            foreach (ListRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMailingListModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MailingListModel' /> instances.
        /// </summary>
        /// <param name="notesHtmlId">
        ///     The value which identifies the <see cref='MailingListModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MailingListModel' /> instances that match the specified <paramref name='notesHtmlId' />.
        /// </returns>
        public IEnumerable<LocalMailingListModel> FetchAllByNotesHtmlId(String notesHtmlId)
        {
            IEnumerable<ListRecord> recordCollection = this.Provider.DataProvider.Marketing.MailingList.FetchAllByNotesHtml(notesHtmlId);
            foreach (ListRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMailingListModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:MailingListModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MailingListModel" /> instance.
        /// </returns>
        Consensus.Marketing.IMailingListModel IMailingListFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MailingListModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MailingListModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListModel> IMailingListFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Marketing.IMailingListModel IMailingListFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IMailingListFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListModel> IMailingListFactory.FetchAllByOwnerId(System.String ownerId)
        {
            return this.FetchAllByOwnerId(ownerId);
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
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListModel> IMailingListFactory.FetchAllByNotesHtmlId(System.String notesHtmlId)
        {
            return this.FetchAllByNotesHtmlId(notesHtmlId);
        }

        #endregion
    }
}
