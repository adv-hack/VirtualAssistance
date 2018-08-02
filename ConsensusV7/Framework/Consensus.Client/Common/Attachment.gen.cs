using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Attachment : Proxy<IAttachmentModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LearningZoneCategoryLink" /> member.
        /// </summary>
        private Consensus.Common.AttachLearningZoneCategories _learningZoneCategoryLink;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LearningZoneCategory" /> member.
        /// </summary>
        private Consensus.Common.LearningZoneCategories _learningZoneCategory;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Attrib01Type" /> member.
        /// </summary>
        private Consensus.Common.Code _attrib01Type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Category" /> member.
        /// </summary>
        private Consensus.Common.Code _category;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="DataAttachments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.AttachmentData, Consensus.Common.IAttachmentDataModel> _dataAttachments;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="LearningZoneCategoriesLinkAttachments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.AttachLearningZoneCategories, Consensus.Common.IAttachLearningZoneCategoriesModel> _learningZoneCategoriesLinkAttachments;

        #endregion

        #region properties

        /// <summary>
        ///     Flatten out the many-to-many linked LearningZoneCategories into a one-to-many link.
        /// </summary>
        public Consensus.Common.AttachLearningZoneCategories LearningZoneCategoryLink
        {
            get
            {
                if (_learningZoneCategoryLink == null && this.Model.LearningZoneCategoryLink != null)
                    _learningZoneCategoryLink = new Consensus.Common.AttachLearningZoneCategories(this.Model.LearningZoneCategoryLink);
                if (_learningZoneCategoryLink == null)
                    _learningZoneCategoryLink = Consensus.Common.AttachLearningZoneCategories.Create();
                return _learningZoneCategoryLink;
            }
        }

        /// <summary>
        ///     The Flattened out linked LearningZoneCategory.
        /// </summary>
        public Consensus.Common.LearningZoneCategories LearningZoneCategory
        {
            get
            {
                if (_learningZoneCategory == null && this.Model.LearningZoneCategory != null)
                    _learningZoneCategory = new Consensus.Common.LearningZoneCategories(this.Model.LearningZoneCategory);
                if (_learningZoneCategory == null)
                    _learningZoneCategory = Consensus.Common.LearningZoneCategories.Create();
                return _learningZoneCategory;
            }
        }

        /// <summary>
        ///     The Id of the Flattened out linked LearningZoneCategory.
        /// </summary>
        public System.Int32 LearningZoneCategoryId
        {
            get { return this.Model.LearningZoneCategoryId; }
            set { this.Model.LearningZoneCategoryId = value; }
        }

        /// <summary>
        ///     Resolves the description of the Visibility option (hard coded). Set has no effect.
        /// </summary>
        public System.String VisibilityDesc
        {
            get { return this.Model.VisibilityDesc; }
            set { this.Model.VisibilityDesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ADD_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> AddDate
        {
            get { return this.Model.AddDate; }
            set { this.Model.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ADD_BY" field.
        /// </summary>
        public System.String AddBy
        {
            get { return this.Model.AddBy; }
            set { this.Model.AddBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TABLE_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> TableId
        {
            get { return this.Model.TableId; }
            set { this.Model.TableId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_RECORD_ID" field.
        /// </summary>
        public System.String RecordId
        {
            get { return this.Model.RecordId; }
            set { this.Model.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_FILE_NAME" field.
        /// </summary>
        public System.String FileName
        {
            get { return this.Model.FileName; }
            set { this.Model.FileName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_FILE_DESC" field.
        /// </summary>
        public System.String FileDesc
        {
            get { return this.Model.FileDesc; }
            set { this.Model.FileDesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ORDER_NUM" field.
        /// </summary>
        public System.Nullable<System.Byte> OrderNum
        {
            get { return this.Model.OrderNum; }
            set { this.Model.OrderNum = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ORGL_NAME" field.
        /// </summary>
        public System.String OrglName
        {
            get { return this.Model.OrglName; }
            set { this.Model.OrglName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_VERSION_NO" field.
        /// </summary>
        public System.Nullable<System.Double> VersionNo
        {
            get { return this.Model.VersionNo; }
            set { this.Model.VersionNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_OUT_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ChkdOutDate
        {
            get { return this.Model.ChkdOutDate; }
            set { this.Model.ChkdOutDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_OUT_BY" field.
        /// </summary>
        public System.String ChkdOutBy
        {
            get { return this.Model.ChkdOutBy; }
            set { this.Model.ChkdOutBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_IN_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ChkdInDate
        {
            get { return this.Model.ChkdInDate; }
            set { this.Model.ChkdInDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_CHKD_IN_BY" field.
        /// </summary>
        public System.String ChkdInBy
        {
            get { return this.Model.ChkdInBy; }
            set { this.Model.ChkdInBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TEXT" field.
        /// </summary>
        public System.String Text
        {
            get { return this.Model.Text; }
            set { this.Model.Text = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_URL_PATH" field.
        /// </summary>
        public System.String UrlPath
        {
            get { return this.Model.UrlPath; }
            set { this.Model.UrlPath = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ATT_ATTRIB01" field.
        /// </summary>
        public Consensus.Common.Code Attrib01Type
        {
            get
            {
                if (_attrib01Type == null && this.Model.Attrib01Type != null)
                    _attrib01Type = new Consensus.Common.Code(this.Model.Attrib01Type);
                if (_attrib01Type == null)
                    _attrib01Type = Consensus.Common.Code.Create();
                return _attrib01Type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATT_ATTRIB01" field.
        /// </summary>
        public System.String Attrib01TypeCode
        {
            get { return this.Model.Attrib01TypeCode; }
            set { this.Model.Attrib01TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_WEB" field.
        /// </summary>
        public System.Byte Web
        {
            get { return this.Model.Web; }
            set { this.Model.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_UG_NAME" field.
        /// </summary>
        public System.String UgName
        {
            get { return this.Model.UgName; }
            set { this.Model.UgName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ATT_CATEGORY" field.
        /// </summary>
        public Consensus.Common.Code Category
        {
            get
            {
                if (_category == null && this.Model.Category != null)
                    _category = new Consensus.Common.Code(this.Model.Category);
                if (_category == null)
                    _category = Consensus.Common.Code.Create();
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATT_CATEGORY" field.
        /// </summary>
        public System.String CategoryCode
        {
            get { return this.Model.CategoryCode; }
            set { this.Model.CategoryCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_MIME" field.
        /// </summary>
        public System.String Mime
        {
            get { return this.Model.Mime; }
            set { this.Model.Mime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_VISIBILITY" field.
        /// </summary>
        public System.Byte Visibility
        {
            get { return this.Model.Visibility; }
            set { this.Model.Visibility = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ARCHIVED" field.
        /// </summary>
        public System.Byte Archived
        {
            get { return this.Model.Archived; }
            set { this.Model.Archived = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_ARCHIVE_FILE" field.
        /// </summary>
        public System.String ArchiveFile
        {
            get { return this.Model.ArchiveFile; }
            set { this.Model.ArchiveFile = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATT_TABLE_URL" field.
        /// </summary>
        public System.String TableUrl
        {
            get { return this.Model.TableUrl; }
            set { this.Model.TableUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachmentDataModel" /> instances that reference this <see cref="!:AttachmentModel" />.
        /// </summary>
        public Collection<Consensus.Common.AttachmentData> DataAttachments
        {
            get
            {
                if (_dataAttachments == null)
                    _dataAttachments = new ProxyCollection<Consensus.Common.AttachmentData, Consensus.Common.IAttachmentDataModel>(this.Model.DataAttachments, model => new Consensus.Common.AttachmentData(model));
                return _dataAttachments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="!:AttachmentModel" />.
        /// </summary>
        public Collection<Consensus.Common.AttachLearningZoneCategories> LearningZoneCategoriesLinkAttachments
        {
            get
            {
                if (_learningZoneCategoriesLinkAttachments == null)
                    _learningZoneCategoriesLinkAttachments = new ProxyCollection<Consensus.Common.AttachLearningZoneCategories, Consensus.Common.IAttachLearningZoneCategoriesModel>(this.Model.LearningZoneCategoriesLinkAttachments, model => new Consensus.Common.AttachLearningZoneCategories(model));
                return _learningZoneCategoriesLinkAttachments;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Attachment(IAttachmentModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Fetch the attachments for a particular instance of a model entity.
        /// </summary>
        /// <param name="Url">
        ///     The entity, e.g. "Contact/Person".
        /// </param>
        /// <param name="recordId">
        ///     The Id of the record in the entity.
        /// </param>
        public static IEnumerable<Consensus.Common.Attachment> FetchAllByUrlAndRecordId(System.String Url, System.String recordId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Attachment.FetchAllByUrlAndRecordId(site,Url,recordId);
        }

        /// <summary>
        ///     Fetch the attachments for a particular instance of a model entity.
        /// </summary>
        /// <param name="Url">
        ///     The entity, e.g. "Contact/Person".
        /// </param>
        /// <param name="recordId">
        ///     The Id of the record in the entity.
        /// </param>
        public static IEnumerable<Consensus.Common.Attachment> FetchAllByUrlAndRecordId(ConsensusSite site, System.String Url, System.String recordId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IAttachmentModel> collection = provider.Common.Attachment.FetchAllByUrlAndRecordId(Url,recordId);
            return collection.Select(model => new Consensus.Common.Attachment(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:AttachmentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachmentModel" /> instance.
        /// </returns>
        public static Consensus.Common.Attachment Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Attachment.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AttachmentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachmentModel" /> instance.
        /// </returns>
        public static Consensus.Common.Attachment Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IAttachmentModel model = provider.Common.Attachment.Create();
            return model == null ? null : new Consensus.Common.Attachment(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachmentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachmentModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.Attachment> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Attachment.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachmentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachmentModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.Attachment> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IAttachmentModel> collection = provider.Common.Attachment.FetchAll();
            return collection.Select(model => new Consensus.Common.Attachment(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachmentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachmentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Attachment FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Attachment.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachmentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachmentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Attachment FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IAttachmentModel model = provider.Common.Attachment.FetchById(id);
            return model == null ? null : new Consensus.Common.Attachment(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Attachment.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.Attachment.GetTableName();
        }

        #endregion
    }
}
