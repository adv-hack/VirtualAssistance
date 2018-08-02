using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="HistoryLinkModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IHistoryLinkFactory : IFactory<IHistoryLinkModel, Int32>
    {
        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IHistoryLinkModel FetchByUserIDAndURL(System.Int32 userId, System.String URL);

        /// <summary>
        ///     Creates a new <see cref="!:HistoryLinkModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:HistoryLinkModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IHistoryLinkModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:HistoryLinkModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:HistoryLinkModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IHistoryLinkModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:HistoryLinkModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:HistoryLinkModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HistoryLinkModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IHistoryLinkModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HistoryLinkModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:HistoryLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HistoryLinkModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IHistoryLinkModel> FetchAllByUserId(System.Int32 userId);
    }
}
