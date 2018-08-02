using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CourseSelectGroupsModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICourseSelectGroupsFactory : IFactory<ICourseSelectGroupsModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </returns>
        Consensus.Learning.ICourseSelectGroupsModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CourseSelectGroupsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CourseSelectGroupsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CourseSelectGroupsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CourseSelectGroupsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ICourseSelectGroupsModel FetchById(System.Int32 id);

        System.String GetTableName();

        System.Collections.Generic.IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> FetchAllByProdSelectionGroupId(System.Nullable<System.Int32> prodSelectionGroupId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CourseSelectGroupsModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:CourseSelectGroupsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CourseSelectGroupsModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> FetchAllByEventId(System.String eventId);
    }
}
