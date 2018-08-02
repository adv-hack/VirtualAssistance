using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileCoursesModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileCoursesFactory : IFactory<IProfileCoursesModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProfileCoursesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileCoursesModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileCoursesModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileCoursesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileCoursesModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileCoursesModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileCoursesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileCoursesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileCoursesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileCoursesModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileCoursesModel" /> instances.
        /// </summary>
        /// <param name="coursesId">
        ///     The value which identifies the <see cref="!:ProfileCoursesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileCoursesModel" /> instances that match the specified <paramref name="coursesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileCoursesModel> FetchAllByCoursesId(System.String coursesId);
    }
}
