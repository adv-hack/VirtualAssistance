using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AttachLearningZoneCategoriesModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAttachLearningZoneCategoriesFactory : IFactory<IAttachLearningZoneCategoriesModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </returns>
        Consensus.Common.IAttachLearningZoneCategoriesModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachLearningZoneCategoriesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IAttachLearningZoneCategoriesModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instances that match the specified <paramref name="attIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> FetchAllByAttIdId(System.String attIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </summary>
        /// <param name="lzcIdId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instances that match the specified <paramref name="lzcIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> FetchAllByLzcIdId(System.Int32 lzcIdId);
    }
}
