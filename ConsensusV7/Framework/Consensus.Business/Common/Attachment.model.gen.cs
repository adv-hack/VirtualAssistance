using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="AttachmentRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAttachmentModel : IModel<String>
    {
        /// <summary>
        ///     Flatten out the many-to-many linked LearningZoneCategories into a one-to-many link.
        /// </summary>
        Consensus.Common.IAttachLearningZoneCategoriesModel LearningZoneCategoryLink
        {
            get;
        }

        /// <summary>
        ///     The Flattened out linked LearningZoneCategory.
        /// </summary>
        Consensus.Common.ILearningZoneCategoriesModel LearningZoneCategory
        {
            get;
        }

        /// <summary>
        ///     The Id of the Flattened out linked LearningZoneCategory.
        /// </summary>
        System.Int32 LearningZoneCategoryId
        {
            get;
            set;
        }

        /// <summary>
        ///     Resolves the description of the Visibility option (hard coded). Set has no effect.
        /// </summary>
        System.String VisibilityDesc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> AddDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ADD_BY" field.
        /// </summary>
        System.String AddBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TABLE_ID" field.
        /// </summary>
        System.Nullable<System.Int32> TableId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_RECORD_ID" field.
        /// </summary>
        System.String RecordId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_FILE_NAME" field.
        /// </summary>
        System.String FileName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_FILE_DESC" field.
        /// </summary>
        System.String FileDesc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ORDER_NUM" field.
        /// </summary>
        System.Nullable<System.Byte> OrderNum
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ORGL_NAME" field.
        /// </summary>
        System.String OrglName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_VERSION_NO" field.
        /// </summary>
        System.Nullable<System.Double> VersionNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_OUT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ChkdOutDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_OUT_BY" field.
        /// </summary>
        System.String ChkdOutBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_IN_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ChkdInDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_IN_BY" field.
        /// </summary>
        System.String ChkdInBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TEXT" field.
        /// </summary>
        System.String Text
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_URL_PATH" field.
        /// </summary>
        System.String UrlPath
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ATT_ATTRIB01" field.
        /// </summary>
        Consensus.Common.ICodeModel Attrib01Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATT_ATTRIB01" field.
        /// </summary>
        System.String Attrib01TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_WEB" field.
        /// </summary>
        System.Byte Web
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_UG_NAME" field.
        /// </summary>
        System.String UgName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ATT_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel Category
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATT_CATEGORY" field.
        /// </summary>
        System.String CategoryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_MIME" field.
        /// </summary>
        System.String Mime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_VISIBILITY" field.
        /// </summary>
        System.Byte Visibility
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ARCHIVED" field.
        /// </summary>
        System.Byte Archived
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ARCHIVE_FILE" field.
        /// </summary>
        System.String ArchiveFile
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TABLE_URL" field.
        /// </summary>
        System.String TableUrl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachmentDataModel" /> instances that reference this <see cref="!:AttachmentModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IAttachmentDataModel> DataAttachments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="!:AttachmentModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IAttachLearningZoneCategoriesModel> LearningZoneCategoriesLinkAttachments
        {
            get;
        }
    }
}
