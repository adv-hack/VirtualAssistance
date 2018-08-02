using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ProfileRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileCoursesModel : IProfileModel
    {
        /// <summary>
        ///     Gets the The value of the "PROF_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IProductCourseModel Courses
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_COURSE_ID" field.
        /// </summary>
        System.String CoursesId
        {
            get;
            set;
        }
    }
}
