using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="AttachmentRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAttachmentModel : LocalModel<AttachmentRecord, String>, IAttachmentModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ATT_ATTRIB01" field.
        /// </summary>
        private LocalCodeModel _attrib01Type;

        /// <summary>
        ///     The value of the "ATT_CATEGORY" field.
        /// </summary>
        private LocalCodeModel _category;

        /// <summary>
        ///     The collection of <see cref="AttachmentDataModel" /> instances that reference this <see cref="AttachmentModel" />.
        /// </summary>
        private LocalCollection<LocalAttachmentDataModel, IAttachmentDataModel> _dataAttachments;

        /// <summary>
        ///     The collection of <see cref="AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="AttachmentModel" />.
        /// </summary>
        private LocalCollection<LocalAttachLearningZoneCategoriesModel, IAttachLearningZoneCategoriesModel> _learningZoneCategoriesLinkAttachments;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachmentRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.Attachment.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachmentRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.Attachment.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AttachmentRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.Attachment.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return this.ModifiedData.AddDate; }
            set { this.ModifiedData.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return this.ModifiedData.AddBy; }
            set { this.ModifiedData.AddBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TABLE_ID" field.
        /// </summary>
        public Int32? TableId
        {
            get { return this.ModifiedData.TableId; }
            set { this.ModifiedData.TableId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return this.ModifiedData.RecordId; }
            set { this.ModifiedData.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_FILE_NAME" field.
        /// </summary>
        public String FileName
        {
            get { return this.ModifiedData.FileName; }
            set { this.ModifiedData.FileName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_FILE_DESC" field.
        /// </summary>
        public String FileDesc
        {
            get { return this.ModifiedData.FileDesc; }
            set { this.ModifiedData.FileDesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ORDER_NUM" field.
        /// </summary>
        public Byte? OrderNum
        {
            get { return this.ModifiedData.OrderNum; }
            set { this.ModifiedData.OrderNum = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ORGL_NAME" field.
        /// </summary>
        public String OrglName
        {
            get { return this.ModifiedData.OrglName; }
            set { this.ModifiedData.OrglName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_VERSION_NO" field.
        /// </summary>
        public Double? VersionNo
        {
            get { return this.ModifiedData.VersionNo; }
            set { this.ModifiedData.VersionNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_OUT_DATE" field.
        /// </summary>
        public DateTime? ChkdOutDate
        {
            get { return this.ModifiedData.ChkdOutDate; }
            set { this.ModifiedData.ChkdOutDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_OUT_BY" field.
        /// </summary>
        public String ChkdOutBy
        {
            get { return this.ModifiedData.ChkdOutBy; }
            set { this.ModifiedData.ChkdOutBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_IN_DATE" field.
        /// </summary>
        public DateTime? ChkdInDate
        {
            get { return this.ModifiedData.ChkdInDate; }
            set { this.ModifiedData.ChkdInDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_IN_BY" field.
        /// </summary>
        public String ChkdInBy
        {
            get { return this.ModifiedData.ChkdInBy; }
            set { this.ModifiedData.ChkdInBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return this.ModifiedData.Text; }
            set { this.ModifiedData.Text = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_URL_PATH" field.
        /// </summary>
        public String UrlPath
        {
            get { return this.ModifiedData.UrlPath; }
            set { this.ModifiedData.UrlPath = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ATT_ATTRIB01" field.
        /// </summary>
        public LocalCodeModel Attrib01Type
        {
            get
            {
                if (_attrib01Type == null && !String.IsNullOrEmpty(this.Attrib01TypeCode))
                    _attrib01Type = this.Provider.Common.Code.FetchByTypeAndCode("ATTYP", this.Attrib01TypeCode);
                if (_attrib01Type == null)
                    _attrib01Type = this.Provider.Common.Code.Create("ATTYP");
                return _attrib01Type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATT_ATTRIB01" field.
        /// </summary>
        public String Attrib01TypeCode
        {
            get { return this.ModifiedData.Attrib01; }
            set
            {
                if (this.ModifiedData.Attrib01 != value)
                     _attrib01Type = null;
                this.ModifiedData.Attrib01 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return this.ModifiedData.Web; }
            set { this.ModifiedData.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_UG_NAME" field.
        /// </summary>
        public String UgName
        {
            get { return this.ModifiedData.UgName; }
            set { this.ModifiedData.UgName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ATT_CATEGORY" field.
        /// </summary>
        public LocalCodeModel Category
        {
            get
            {
                if (_category == null && !String.IsNullOrEmpty(this.CategoryCode))
                    _category = this.Provider.Common.Code.FetchByTypeAndCode("ATCAT", this.CategoryCode);
                if (_category == null)
                    _category = this.Provider.Common.Code.Create("ATCAT");
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATT_CATEGORY" field.
        /// </summary>
        public String CategoryCode
        {
            get { return this.ModifiedData.Category; }
            set
            {
                if (this.ModifiedData.Category != value)
                     _category = null;
                this.ModifiedData.Category = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_MIME" field.
        /// </summary>
        public String Mime
        {
            get { return this.ModifiedData.Mime; }
            set { this.ModifiedData.Mime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_VISIBILITY" field.
        /// </summary>
        public Byte Visibility
        {
            get { return this.ModifiedData.Visibility; }
            set { this.ModifiedData.Visibility = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ARCHIVED" field.
        /// </summary>
        public Byte Archived
        {
            get { return this.ModifiedData.Archived; }
            set { this.ModifiedData.Archived = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ARCHIVE_FILE" field.
        /// </summary>
        public String ArchiveFile
        {
            get { return this.ModifiedData.ArchiveFile; }
            set { this.ModifiedData.ArchiveFile = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TABLE_URL" field.
        /// </summary>
        public String TableUrl
        {
            get { return this.ModifiedData.TableUrl; }
            set { this.ModifiedData.TableUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AttachmentDataModel" /> instances that reference this <see cref="AttachmentModel" />.
        /// </summary>
        public LocalCollection<LocalAttachmentDataModel, IAttachmentDataModel> DataAttachments
        {
            get
            {
                if (_dataAttachments == null)
                    _dataAttachments = new LocalCollection<LocalAttachmentDataModel, IAttachmentDataModel>(this.Provider.Common.AttachmentData.FetchAllByAttIdId(this.Id));
                
                return _dataAttachments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="AttachmentModel" />.
        /// </summary>
        public LocalCollection<LocalAttachLearningZoneCategoriesModel, IAttachLearningZoneCategoriesModel> LearningZoneCategoriesLinkAttachments
        {
            get
            {
                if (_learningZoneCategoriesLinkAttachments == null)
                    _learningZoneCategoriesLinkAttachments = new LocalCollection<LocalAttachLearningZoneCategoriesModel, IAttachLearningZoneCategoriesModel>(this.Provider.Common.AttachLearningZoneCategories.FetchAllByAttIdId(this.Id));
                
                return _learningZoneCategoriesLinkAttachments;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalAttachmentModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalAttachmentModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalAttachmentModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalAttachmentModel(LocalProvider provider, AttachmentRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_attrib01Type != null)
            {
                _attrib01Type.Save();
                this.ModifiedData.Attrib01 = _attrib01Type.Value1;
            }
            if (_category != null)
            {
                _category.Save();
                this.ModifiedData.Category = _category.Value1;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_dataAttachments != null)
                _dataAttachments.Execute(obj => obj.AttIdId = this.Id).Execute(obj => obj.Save());
            if (_learningZoneCategoriesLinkAttachments != null)
                _learningZoneCategoriesLinkAttachments.Execute(obj => obj.AttIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Flatten out the many-to-many linked LearningZoneCategories into a one-to-many link.
        /// </summary>
        Consensus.Common.IAttachLearningZoneCategoriesModel IAttachmentModel.LearningZoneCategoryLink
        {
            get { return this.LearningZoneCategoryLink; }
        }

        /// <summary>
        ///     The Flattened out linked LearningZoneCategory.
        /// </summary>
        Consensus.Common.ILearningZoneCategoriesModel IAttachmentModel.LearningZoneCategory
        {
            get { return this.LearningZoneCategory; }
        }

        /// <summary>
        ///     The Id of the Flattened out linked LearningZoneCategory.
        /// </summary>
        System.Int32 IAttachmentModel.LearningZoneCategoryId
        {
            get { return this.LearningZoneCategoryId; }
            set { this.LearningZoneCategoryId = (System.Int32)value; }
        }

        /// <summary>
        ///     Resolves the description of the Visibility option (hard coded). Set has no effect.
        /// </summary>
        System.String IAttachmentModel.VisibilityDesc
        {
            get { return this.VisibilityDesc; }
            set { this.VisibilityDesc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IAttachmentModel.AddDate
        {
            get { return this.AddDate; }
            set { this.AddDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ADD_BY" field.
        /// </summary>
        System.String IAttachmentModel.AddBy
        {
            get { return this.AddBy; }
            set { this.AddBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TABLE_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IAttachmentModel.TableId
        {
            get { return this.TableId; }
            set { this.TableId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_RECORD_ID" field.
        /// </summary>
        System.String IAttachmentModel.RecordId
        {
            get { return this.RecordId; }
            set { this.RecordId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_FILE_NAME" field.
        /// </summary>
        System.String IAttachmentModel.FileName
        {
            get { return this.FileName; }
            set { this.FileName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_FILE_DESC" field.
        /// </summary>
        System.String IAttachmentModel.FileDesc
        {
            get { return this.FileDesc; }
            set { this.FileDesc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ORDER_NUM" field.
        /// </summary>
        System.Nullable<System.Byte> IAttachmentModel.OrderNum
        {
            get { return this.OrderNum; }
            set { this.OrderNum = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ORGL_NAME" field.
        /// </summary>
        System.String IAttachmentModel.OrglName
        {
            get { return this.OrglName; }
            set { this.OrglName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_VERSION_NO" field.
        /// </summary>
        System.Nullable<System.Double> IAttachmentModel.VersionNo
        {
            get { return this.VersionNo; }
            set { this.VersionNo = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IAttachmentModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_OUT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IAttachmentModel.ChkdOutDate
        {
            get { return this.ChkdOutDate; }
            set { this.ChkdOutDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_OUT_BY" field.
        /// </summary>
        System.String IAttachmentModel.ChkdOutBy
        {
            get { return this.ChkdOutBy; }
            set { this.ChkdOutBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_IN_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IAttachmentModel.ChkdInDate
        {
            get { return this.ChkdInDate; }
            set { this.ChkdInDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_IN_BY" field.
        /// </summary>
        System.String IAttachmentModel.ChkdInBy
        {
            get { return this.ChkdInBy; }
            set { this.ChkdInBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TEXT" field.
        /// </summary>
        System.String IAttachmentModel.Text
        {
            get { return this.Text; }
            set { this.Text = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_URL_PATH" field.
        /// </summary>
        System.String IAttachmentModel.UrlPath
        {
            get { return this.UrlPath; }
            set { this.UrlPath = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ATT_ATTRIB01" field.
        /// </summary>
        Consensus.Common.ICodeModel IAttachmentModel.Attrib01Type
        {
            get { return this.Attrib01Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATT_ATTRIB01" field.
        /// </summary>
        System.String IAttachmentModel.Attrib01TypeCode
        {
            get { return this.Attrib01TypeCode; }
            set { this.Attrib01TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_WEB" field.
        /// </summary>
        System.Byte IAttachmentModel.Web
        {
            get { return this.Web; }
            set { this.Web = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_UG_NAME" field.
        /// </summary>
        System.String IAttachmentModel.UgName
        {
            get { return this.UgName; }
            set { this.UgName = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ATT_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel IAttachmentModel.Category
        {
            get { return this.Category; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATT_CATEGORY" field.
        /// </summary>
        System.String IAttachmentModel.CategoryCode
        {
            get { return this.CategoryCode; }
            set { this.CategoryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_MIME" field.
        /// </summary>
        System.String IAttachmentModel.Mime
        {
            get { return this.Mime; }
            set { this.Mime = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_VISIBILITY" field.
        /// </summary>
        System.Byte IAttachmentModel.Visibility
        {
            get { return this.Visibility; }
            set { this.Visibility = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ARCHIVED" field.
        /// </summary>
        System.Byte IAttachmentModel.Archived
        {
            get { return this.Archived; }
            set { this.Archived = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ARCHIVE_FILE" field.
        /// </summary>
        System.String IAttachmentModel.ArchiveFile
        {
            get { return this.ArchiveFile; }
            set { this.ArchiveFile = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TABLE_URL" field.
        /// </summary>
        System.String IAttachmentModel.TableUrl
        {
            get { return this.TableUrl; }
            set { this.TableUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachmentDataModel" /> instances that reference this <see cref="!:AttachmentModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IAttachmentDataModel> IAttachmentModel.DataAttachments
        {
            get { return this.DataAttachments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="!:AttachmentModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IAttachLearningZoneCategoriesModel> IAttachmentModel.LearningZoneCategoriesLinkAttachments
        {
            get { return this.LearningZoneCategoriesLinkAttachments; }
        }

        #endregion
    }
}
