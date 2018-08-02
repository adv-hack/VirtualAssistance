using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MailingListMemberModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMailingListMemberFactory : IFactory<IMailingListMemberModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:MailingListMemberModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MailingListMemberModel" /> instance.
        /// </returns>
        Consensus.Marketing.IMailingListMemberModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MailingListMemberModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListMemberModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:MailingListMemberModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MailingListMemberModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.IMailingListMemberModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instances that match the specified <paramref name="mailingListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListMemberModel> FetchAllByMailingListId(System.String mailingListId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MailingListMemberModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MailingListMemberModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IMailingListMemberModel> FetchAllByPersonId(System.String personId);
    }
}
