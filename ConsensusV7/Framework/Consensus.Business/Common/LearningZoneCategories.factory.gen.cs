using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LearningZoneCategoriesModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILearningZoneCategoriesFactory : IFactory<ILearningZoneCategoriesModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </returns>
        Consensus.Common.ILearningZoneCategoriesModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LearningZoneCategoriesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LearningZoneCategoriesModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ILearningZoneCategoriesModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LearningZoneCategoriesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearningZoneCategoriesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ILearningZoneCategoriesModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
