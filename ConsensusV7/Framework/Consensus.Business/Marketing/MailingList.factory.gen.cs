using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MailingListModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMailingListFactory : IFactory<IMailingListModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:MailingListModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MailingListModel" /> instance.
        /// </returns>
        Consensus.Marketing.IMailingListModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MailingListModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MailingListModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:MailingListModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MailingListModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.IMailingListModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListModel" /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instances that match the specified <paramref name="ownerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListModel> FetchAllByOwnerId(System.String ownerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListModel" /> instances.
        /// </summary>
        /// <param name="notesHtmlId">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListModel" /> instances that match the specified <paramref name="notesHtmlId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListModel> FetchAllByNotesHtmlId(System.String notesHtmlId);
    }
}
