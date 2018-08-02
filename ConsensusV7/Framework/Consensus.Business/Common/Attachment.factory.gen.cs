using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AttachmentModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAttachmentFactory : IFactory<IAttachmentModel, String>
    {
        /// <summary>
        ///     Fetch the attachments for a particular instance of a model entity.
        /// </summary>
        /// <param name="Url">
        ///     The entity, e.g. "Contact/Person".
        /// </param>
        /// <param name="recordId">
        ///     The Id of the record in the entity.
        /// </param>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachmentModel> FetchAllByUrlAndRecordId(System.String Url, System.String recordId);

        /// <summary>
        ///     Creates a new <see cref="!:AttachmentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachmentModel" /> instance.
        /// </returns>
        Consensus.Common.IAttachmentModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachmentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachmentModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachmentModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachmentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachmentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IAttachmentModel FetchById(System.String id);

        System.String GetTableName();
    }
}
