using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AttachmentDataModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAttachmentDataFactory : IFactory<IAttachmentDataModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:AttachmentDataModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachmentDataModel" /> instance.
        /// </returns>
        Consensus.Common.IAttachmentDataModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachmentDataModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachmentDataModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachmentDataModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachmentDataModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachmentDataModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentDataModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IAttachmentDataModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachmentDataModel" /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref="!:AttachmentDataModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentDataModel" /> instances that match the specified <paramref name="attIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachmentDataModel> FetchAllByAttIdId(System.String attIdId);
    }
}
