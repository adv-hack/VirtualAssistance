using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "Attachment" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class AttachmentRecord : Record<String>, Cloneable<AttachmentRecord>, IEquatable<AttachmentRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ATT_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "ATT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ATT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ATT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ATT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ATT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ATT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ATT_TABLE_ID" field.
        /// </summary>
        private Int32? _tableId;

        /// <summary>
        ///     the value of the "ATT_RECORD_ID" field.
        /// </summary>
        private String _recordId;

        /// <summary>
        ///     the value of the "ATT_FILE_NAME" field.
        /// </summary>
        private String _fileName;

        /// <summary>
        ///     the value of the "ATT_FILE_DESC" field.
        /// </summary>
        private String _fileDesc;

        /// <summary>
        ///     the value of the "ATT_DATE_ETD" field.
        /// </summary>
        private DateTime? _dateEtd;

        /// <summary>
        ///     the value of the "ATT_CHKD_BY" field.
        /// </summary>
        private String _chkdBy;

        /// <summary>
        ///     the value of the "ATT_CHKD_DATE" field.
        /// </summary>
        private DateTime? _chkdDate;

        /// <summary>
        ///     the value of the "ATT_ORDER_NUM" field.
        /// </summary>
        private Byte? _orderNum;

        /// <summary>
        ///     the value of the "ATT_ORGL_NAME" field.
        /// </summary>
        private String _orglName;

        /// <summary>
        ///     the value of the "ATT_VERSION_NO" field.
        /// </summary>
        private Double? _versionNo;

        /// <summary>
        ///     the value of the "ATT_TEMPLATE" field.
        /// </summary>
        private String _template;

        /// <summary>
        ///     the value of the "ATT_SOURCE_DATA" field.
        /// </summary>
        private String _sourceData;

        /// <summary>
        ///     the value of the "ATT_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "ATT_CHKD_OUT_DATE" field.
        /// </summary>
        private DateTime? _chkdOutDate;

        /// <summary>
        ///     the value of the "ATT_CHKD_OUT_BY" field.
        /// </summary>
        private String _chkdOutBy;

        /// <summary>
        ///     the value of the "ATT_CHKD_IN_DATE" field.
        /// </summary>
        private DateTime? _chkdInDate;

        /// <summary>
        ///     the value of the "ATT_CHKD_IN_BY" field.
        /// </summary>
        private String _chkdInBy;

        /// <summary>
        ///     the value of the "ATT_PIC_ID" field.
        /// </summary>
        private String _picId;

        /// <summary>
        ///     the value of the "ATT_TEXT" field.
        /// </summary>
        private String _text;

        /// <summary>
        ///     the value of the "ATT_URL_PATH" field.
        /// </summary>
        private String _urlPath;

        /// <summary>
        ///     the value of the "ATT_PAGESETUP" field.
        /// </summary>
        private String _pagesetup;

        /// <summary>
        ///     the value of the "ATT_COMPRESS" field.
        /// </summary>
        private Byte? _compress;

        /// <summary>
        ///     the value of the "ATT_EXTENSION" field.
        /// </summary>
        private String _extension;

        /// <summary>
        ///     the value of the "ATT_ATTRIB01" field.
        /// </summary>
        private String _attrib01;

        /// <summary>
        ///     the value of the "ATT_WEB" field.
        /// </summary>
        private Byte _web;

        /// <summary>
        ///     the value of the "ATT_PRINT_ONLY" field.
        /// </summary>
        private Byte _printOnly;

        /// <summary>
        ///     the value of the "ATT_EMAIL_ONLY" field.
        /// </summary>
        private Byte _emailOnly;

        /// <summary>
        ///     the value of the "ATT_UG_NAME" field.
        /// </summary>
        private String _ugName;

        /// <summary>
        ///     the value of the "ATT_CATEGORY" field.
        /// </summary>
        private String _category;

        /// <summary>
        ///     the value of the "ATT_START_OFFSET" field.
        /// </summary>
        private Int32 _startOffset;

        /// <summary>
        ///     the value of the "ATT_END_OFFSET" field.
        /// </summary>
        private Int32 _endOffset;

        /// <summary>
        ///     the value of the "ATT_MIME" field.
        /// </summary>
        private String _mime;

        /// <summary>
        ///     the value of the "ATT_SIZE" field.
        /// </summary>
        private Int64? _size;

        /// <summary>
        ///     the value of the "ATT_VISIBILITY" field.
        /// </summary>
        private Byte _visibility;

        /// <summary>
        ///     the value of the "ATT_ARCHIVED" field.
        /// </summary>
        private Byte _archived;

        /// <summary>
        ///     the value of the "ATT_ARCHIVE_FILE" field.
        /// </summary>
        private String _archiveFile;

        /// <summary>
        ///     the value of the "ATT_ARCHIVE_BAT_ID" field.
        /// </summary>
        private String _archiveBatId;

        /// <summary>
        ///     the value of the "ATT_TABLE_URL" field.
        /// </summary>
        private String _tableUrl;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ATT_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "ATT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ATT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ATT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ATT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ATT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ATT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ATT_TABLE_ID" field.
        /// </summary>
        public Int32? TableId
        {
            get { return _tableId; }
            set { _tableId = value; }
        }

        /// <summary>
        ///     the value of the "ATT_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        ///     the value of the "ATT_FILE_NAME" field.
        /// </summary>
        public String FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        /// <summary>
        ///     the value of the "ATT_FILE_DESC" field.
        /// </summary>
        public String FileDesc
        {
            get { return _fileDesc; }
            set { _fileDesc = value; }
        }

        /// <summary>
        ///     the value of the "ATT_DATE_ETD" field.
        /// </summary>
        public DateTime? DateEtd
        {
            get { return _dateEtd; }
            set { _dateEtd = value; }
        }

        /// <summary>
        ///     the value of the "ATT_CHKD_BY" field.
        /// </summary>
        public String ChkdBy
        {
            get { return _chkdBy; }
            set { _chkdBy = value; }
        }

        /// <summary>
        ///     the value of the "ATT_CHKD_DATE" field.
        /// </summary>
        public DateTime? ChkdDate
        {
            get { return _chkdDate; }
            set { _chkdDate = value; }
        }

        /// <summary>
        ///     the value of the "ATT_ORDER_NUM" field.
        /// </summary>
        public Byte? OrderNum
        {
            get { return _orderNum; }
            set { _orderNum = value; }
        }

        /// <summary>
        ///     the value of the "ATT_ORGL_NAME" field.
        /// </summary>
        public String OrglName
        {
            get { return _orglName; }
            set { _orglName = value; }
        }

        /// <summary>
        ///     the value of the "ATT_VERSION_NO" field.
        /// </summary>
        public Double? VersionNo
        {
            get { return _versionNo; }
            set { _versionNo = value; }
        }

        /// <summary>
        ///     the value of the "ATT_TEMPLATE" field.
        /// </summary>
        public String Template
        {
            get { return _template; }
            set { _template = value; }
        }

        /// <summary>
        ///     the value of the "ATT_SOURCE_DATA" field.
        /// </summary>
        public String SourceData
        {
            get { return _sourceData; }
            set { _sourceData = value; }
        }

        /// <summary>
        ///     the value of the "ATT_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ATT_CHKD_OUT_DATE" field.
        /// </summary>
        public DateTime? ChkdOutDate
        {
            get { return _chkdOutDate; }
            set { _chkdOutDate = value; }
        }

        /// <summary>
        ///     the value of the "ATT_CHKD_OUT_BY" field.
        /// </summary>
        public String ChkdOutBy
        {
            get { return _chkdOutBy; }
            set { _chkdOutBy = value; }
        }

        /// <summary>
        ///     the value of the "ATT_CHKD_IN_DATE" field.
        /// </summary>
        public DateTime? ChkdInDate
        {
            get { return _chkdInDate; }
            set { _chkdInDate = value; }
        }

        /// <summary>
        ///     the value of the "ATT_CHKD_IN_BY" field.
        /// </summary>
        public String ChkdInBy
        {
            get { return _chkdInBy; }
            set { _chkdInBy = value; }
        }

        /// <summary>
        ///     the value of the "ATT_PIC_ID" field.
        /// </summary>
        public String PicId
        {
            get { return _picId; }
            set { _picId = value; }
        }

        /// <summary>
        ///     the value of the "ATT_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        ///     the value of the "ATT_URL_PATH" field.
        /// </summary>
        public String UrlPath
        {
            get { return _urlPath; }
            set { _urlPath = value; }
        }

        /// <summary>
        ///     the value of the "ATT_PAGESETUP" field.
        /// </summary>
        public String Pagesetup
        {
            get { return _pagesetup; }
            set { _pagesetup = value; }
        }

        /// <summary>
        ///     the value of the "ATT_COMPRESS" field.
        /// </summary>
        public Byte? Compress
        {
            get { return _compress; }
            set { _compress = value; }
        }

        /// <summary>
        ///     the value of the "ATT_EXTENSION" field.
        /// </summary>
        public String Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        /// <summary>
        ///     the value of the "ATT_ATTRIB01" field.
        /// </summary>
        public String Attrib01
        {
            get { return _attrib01; }
            set { _attrib01 = value; }
        }

        /// <summary>
        ///     the value of the "ATT_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return _web; }
            set { _web = value; }
        }

        /// <summary>
        ///     the value of the "ATT_PRINT_ONLY" field.
        /// </summary>
        public Byte PrintOnly
        {
            get { return _printOnly; }
            set { _printOnly = value; }
        }

        /// <summary>
        ///     the value of the "ATT_EMAIL_ONLY" field.
        /// </summary>
        public Byte EmailOnly
        {
            get { return _emailOnly; }
            set { _emailOnly = value; }
        }

        /// <summary>
        ///     the value of the "ATT_UG_NAME" field.
        /// </summary>
        public String UgName
        {
            get { return _ugName; }
            set { _ugName = value; }
        }

        /// <summary>
        ///     the value of the "ATT_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        ///     the value of the "ATT_START_OFFSET" field.
        /// </summary>
        public Int32 StartOffset
        {
            get { return _startOffset; }
            set { _startOffset = value; }
        }

        /// <summary>
        ///     the value of the "ATT_END_OFFSET" field.
        /// </summary>
        public Int32 EndOffset
        {
            get { return _endOffset; }
            set { _endOffset = value; }
        }

        /// <summary>
        ///     the value of the "ATT_MIME" field.
        /// </summary>
        public String Mime
        {
            get { return _mime; }
            set { _mime = value; }
        }

        /// <summary>
        ///     the value of the "ATT_SIZE" field.
        /// </summary>
        public Int64? Size
        {
            get { return _size; }
            set { _size = value; }
        }

        /// <summary>
        ///     the value of the "ATT_VISIBILITY" field.
        /// </summary>
        public Byte Visibility
        {
            get { return _visibility; }
            set { _visibility = value; }
        }

        /// <summary>
        ///     the value of the "ATT_ARCHIVED" field.
        /// </summary>
        public Byte Archived
        {
            get { return _archived; }
            set { _archived = value; }
        }

        /// <summary>
        ///     the value of the "ATT_ARCHIVE_FILE" field.
        /// </summary>
        public String ArchiveFile
        {
            get { return _archiveFile; }
            set { _archiveFile = value; }
        }

        /// <summary>
        ///     the value of the "ATT_ARCHIVE_BAT_ID" field.
        /// </summary>
        public String ArchiveBatId
        {
            get { return _archiveBatId; }
            set { _archiveBatId = value; }
        }

        /// <summary>
        ///     the value of the "ATT_TABLE_URL" field.
        /// </summary>
        public String TableUrl
        {
            get { return _tableUrl; }
            set { _tableUrl = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="AttachmentRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="AttachmentRecord" /> object instance.
        /// </returns>
        public AttachmentRecord Clone()
        {
            AttachmentRecord record = new AttachmentRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.TableId = this.TableId;
            record.RecordId = this.RecordId;
            record.FileName = this.FileName;
            record.FileDesc = this.FileDesc;
            record.DateEtd = this.DateEtd;
            record.ChkdBy = this.ChkdBy;
            record.ChkdDate = this.ChkdDate;
            record.OrderNum = this.OrderNum;
            record.OrglName = this.OrglName;
            record.VersionNo = this.VersionNo;
            record.Template = this.Template;
            record.SourceData = this.SourceData;
            record.Type = this.Type;
            record.ChkdOutDate = this.ChkdOutDate;
            record.ChkdOutBy = this.ChkdOutBy;
            record.ChkdInDate = this.ChkdInDate;
            record.ChkdInBy = this.ChkdInBy;
            record.PicId = this.PicId;
            record.Text = this.Text;
            record.UrlPath = this.UrlPath;
            record.Pagesetup = this.Pagesetup;
            record.Compress = this.Compress;
            record.Extension = this.Extension;
            record.Attrib01 = this.Attrib01;
            record.Web = this.Web;
            record.PrintOnly = this.PrintOnly;
            record.EmailOnly = this.EmailOnly;
            record.UgName = this.UgName;
            record.Category = this.Category;
            record.StartOffset = this.StartOffset;
            record.EndOffset = this.EndOffset;
            record.Mime = this.Mime;
            record.Size = this.Size;
            record.Visibility = this.Visibility;
            record.Archived = this.Archived;
            record.ArchiveFile = this.ArchiveFile;
            record.ArchiveBatId = this.ArchiveBatId;
            record.TableUrl = this.TableUrl;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="AttachmentRecord" /> instance is equal to another <see cref="AttachmentRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="AttachmentRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(AttachmentRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.TableId == that.TableId);
            result = result && (this.RecordId.TrimOrNullify() == that.RecordId.TrimOrNullify());
            result = result && (this.FileName.TrimOrNullify() == that.FileName.TrimOrNullify());
            result = result && (this.FileDesc.TrimOrNullify() == that.FileDesc.TrimOrNullify());
            result = result && (this.DateEtd == that.DateEtd);
            result = result && (this.ChkdBy.TrimOrNullify() == that.ChkdBy.TrimOrNullify());
            result = result && (this.ChkdDate == that.ChkdDate);
            result = result && (this.OrderNum == that.OrderNum);
            result = result && (this.OrglName.TrimOrNullify() == that.OrglName.TrimOrNullify());
            result = result && (this.VersionNo == that.VersionNo);
            result = result && (this.Template.TrimOrNullify() == that.Template.TrimOrNullify());
            result = result && (this.SourceData.TrimOrNullify() == that.SourceData.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.ChkdOutDate == that.ChkdOutDate);
            result = result && (this.ChkdOutBy.TrimOrNullify() == that.ChkdOutBy.TrimOrNullify());
            result = result && (this.ChkdInDate == that.ChkdInDate);
            result = result && (this.ChkdInBy.TrimOrNullify() == that.ChkdInBy.TrimOrNullify());
            result = result && (this.PicId.TrimOrNullify() == that.PicId.TrimOrNullify());
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            result = result && (this.UrlPath.TrimOrNullify() == that.UrlPath.TrimOrNullify());
            result = result && (this.Pagesetup.TrimOrNullify() == that.Pagesetup.TrimOrNullify());
            result = result && (this.Compress == that.Compress);
            result = result && (this.Extension.TrimOrNullify() == that.Extension.TrimOrNullify());
            result = result && (this.Attrib01.TrimOrNullify() == that.Attrib01.TrimOrNullify());
            result = result && (this.Web == that.Web);
            result = result && (this.PrintOnly == that.PrintOnly);
            result = result && (this.EmailOnly == that.EmailOnly);
            result = result && (this.UgName.TrimOrNullify() == that.UgName.TrimOrNullify());
            result = result && (this.Category.TrimOrNullify() == that.Category.TrimOrNullify());
            result = result && (this.StartOffset == that.StartOffset);
            result = result && (this.EndOffset == that.EndOffset);
            result = result && (this.Mime.TrimOrNullify() == that.Mime.TrimOrNullify());
            result = result && (this.Size == that.Size);
            result = result && (this.Visibility == that.Visibility);
            result = result && (this.Archived == that.Archived);
            result = result && (this.ArchiveFile.TrimOrNullify() == that.ArchiveFile.TrimOrNullify());
            result = result && (this.ArchiveBatId.TrimOrNullify() == that.ArchiveBatId.TrimOrNullify());
            result = result && (this.TableUrl.TrimOrNullify() == that.TableUrl.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
