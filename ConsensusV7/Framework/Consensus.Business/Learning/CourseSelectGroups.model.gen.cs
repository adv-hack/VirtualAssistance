using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="CourseselectgroupsRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICourseSelectGroupsModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "CSG_PSG_ID" field.
        /// </summary>
        Consensus.Learning.IProdSelectGroupModel ProdSelectionGroup
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CSG_PSG_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ProdSelectionGroupId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CSG_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel Event
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CSG_COURSE_ID" field.
        /// </summary>
        System.String EventId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_TYPE" field.
        /// </summary>
        System.Byte Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_MIN" field.
        /// </summary>
        System.Byte Min
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_MAX" field.
        /// </summary>
        System.Byte Max
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_ORDER" field.
        /// </summary>
        System.Byte Order
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_ERROR_MESSAGE" field.
        /// </summary>
        System.String ErrorMessage
        {
            get;
            set;
        }
    }
}
