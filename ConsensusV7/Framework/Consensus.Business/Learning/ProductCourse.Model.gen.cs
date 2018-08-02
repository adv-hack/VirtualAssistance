using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductCourseModel : IProductModel
    {
        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileCoursesModel" /> instances that reference this <see cref="!:ProductCourseModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileCoursesModel> ProfileProductCourse
        {
            get;
        }
    }
}
