using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AttachmentRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerAttachmentRepository : SqlServerRepository<AttachmentRecord, String>, IAttachmentRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Common"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Attachment"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AttachmentRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ATT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Attachment"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AttachmentRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AttachmentRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AttachmentRecord record)
        {
            record.Id = dataRecord["ATT_ID"].ConvertTo<String>();
            record.Lock = dataRecord["ATT_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["ATT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ATT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ATT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ATT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ATT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ATT_RCV_FROM"].ConvertTo<String>();
            record.TableId = dataRecord["ATT_TABLE_ID"].ConvertTo<Int32?>();
            record.RecordId = dataRecord["ATT_RECORD_ID"].ConvertTo<String>();
            record.FileName = dataRecord["ATT_FILE_NAME"].ConvertTo<String>();
            record.FileDesc = dataRecord["ATT_FILE_DESC"].ConvertTo<String>();
            record.DateEtd = dataRecord["ATT_DATE_ETD"].ConvertTo<DateTime?>();
            record.ChkdBy = dataRecord["ATT_CHKD_BY"].ConvertTo<String>();
            record.ChkdDate = dataRecord["ATT_CHKD_DATE"].ConvertTo<DateTime?>();
            record.OrderNum = dataRecord["ATT_ORDER_NUM"].ConvertTo<Byte?>();
            record.OrglName = dataRecord["ATT_ORGL_NAME"].ConvertTo<String>();
            record.VersionNo = dataRecord["ATT_VERSION_NO"].ConvertTo<Double?>();
            record.Template = dataRecord["ATT_TEMPLATE"].ConvertTo<String>();
            record.SourceData = dataRecord["ATT_SOURCE_DATA"].ConvertTo<String>();
            record.Type = dataRecord["ATT_TYPE"].ConvertTo<Byte?>();
            record.ChkdOutDate = dataRecord["ATT_CHKD_OUT_DATE"].ConvertTo<DateTime?>();
            record.ChkdOutBy = dataRecord["ATT_CHKD_OUT_BY"].ConvertTo<String>();
            record.ChkdInDate = dataRecord["ATT_CHKD_IN_DATE"].ConvertTo<DateTime?>();
            record.ChkdInBy = dataRecord["ATT_CHKD_IN_BY"].ConvertTo<String>();
            record.PicId = dataRecord["ATT_PIC_ID"].ConvertTo<String>();
            record.Text = dataRecord["ATT_TEXT"].ConvertTo<String>();
            record.UrlPath = dataRecord["ATT_URL_PATH"].ConvertTo<String>();
            record.Pagesetup = dataRecord["ATT_PAGESETUP"].ConvertTo<String>();
            record.Compress = dataRecord["ATT_COMPRESS"].ConvertTo<Byte?>();
            record.Extension = dataRecord["ATT_EXTENSION"].ConvertTo<String>();
            record.Attrib01 = dataRecord["ATT_ATTRIB01"].ConvertTo<String>();
            record.Web = dataRecord["ATT_WEB"].ConvertTo<Byte>();
            record.PrintOnly = dataRecord["ATT_PRINT_ONLY"].ConvertTo<Byte>();
            record.EmailOnly = dataRecord["ATT_EMAIL_ONLY"].ConvertTo<Byte>();
            record.UgName = dataRecord["ATT_UG_NAME"].ConvertTo<String>();
            record.Category = dataRecord["ATT_CATEGORY"].ConvertTo<String>();
            record.StartOffset = dataRecord["ATT_START_OFFSET"].ConvertTo<Int32>();
            record.EndOffset = dataRecord["ATT_END_OFFSET"].ConvertTo<Int32>();
            record.Mime = dataRecord["ATT_MIME"].ConvertTo<String>();
            record.Size = dataRecord["ATT_SIZE"].ConvertTo<Int64?>();
            record.Visibility = dataRecord["ATT_VISIBILITY"].ConvertTo<Byte>();
            record.Archived = dataRecord["ATT_ARCHIVED"].ConvertTo<Byte>();
            record.ArchiveFile = dataRecord["ATT_ARCHIVE_FILE"].ConvertTo<String>();
            record.ArchiveBatId = dataRecord["ATT_ARCHIVE_BAT_ID"].ConvertTo<String>();
            record.TableUrl = dataRecord["ATT_TABLE_URL"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AttachmentRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AttachmentRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ATT_ID", record.Id);
            this.MapParameterIn(command, "@PA_ATT_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_ATT_TABLE_ID", record.TableId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TableId);
            this.MapParameterIn(command, "@PA_ATT_RECORD_ID", record.RecordId);
            this.MapParameterIn(command, "@PA_ATT_FILE_NAME", record.FileName);
            this.MapParameterIn(command, "@PA_ATT_FILE_DESC", record.FileDesc);
            this.MapParameterIn(command, "@PA_ATT_DATE_ETD", record.DateEtd == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateEtd);
            this.MapParameterIn(command, "@PA_ATT_CHKD_BY", record.ChkdBy);
            this.MapParameterIn(command, "@PA_ATT_CHKD_DATE", record.ChkdDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ChkdDate);
            this.MapParameterIn(command, "@PA_ATT_ORDER_NUM", record.OrderNum);
            this.MapParameterIn(command, "@PA_ATT_ORGL_NAME", record.OrglName);
            this.MapParameterIn(command, "@PA_ATT_VERSION_NO", record.VersionNo == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.VersionNo);
            this.MapParameterIn(command, "@PA_ATT_TEMPLATE", record.Template);
            this.MapParameterIn(command, "@PA_ATT_SOURCE_DATA", record.SourceData);
            this.MapParameterIn(command, "@PA_ATT_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ATT_CHKD_OUT_DATE", record.ChkdOutDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ChkdOutDate);
            this.MapParameterIn(command, "@PA_ATT_CHKD_OUT_BY", record.ChkdOutBy);
            this.MapParameterIn(command, "@PA_ATT_CHKD_IN_DATE", record.ChkdInDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ChkdInDate);
            this.MapParameterIn(command, "@PA_ATT_CHKD_IN_BY", record.ChkdInBy);
            this.MapParameterIn(command, "@PA_ATT_PIC_ID", record.PicId);
            this.MapParameterIn(command, "@PA_ATT_TEXT", record.Text);
            this.MapParameterIn(command, "@PA_ATT_URL_PATH", record.UrlPath);
            this.MapParameterIn(command, "@PA_ATT_PAGESETUP", record.Pagesetup);
            this.MapParameterIn(command, "@PA_ATT_COMPRESS", record.Compress);
            this.MapParameterIn(command, "@PA_ATT_EXTENSION", record.Extension);
            this.MapParameterIn(command, "@PA_ATT_ATTRIB01", record.Attrib01);
            this.MapParameterIn(command, "@PA_ATT_WEB", record.Web);
            this.MapParameterIn(command, "@PA_ATT_PRINT_ONLY", record.PrintOnly);
            this.MapParameterIn(command, "@PA_ATT_EMAIL_ONLY", record.EmailOnly);
            this.MapParameterIn(command, "@PA_ATT_UG_NAME", record.UgName);
            this.MapParameterIn(command, "@PA_ATT_CATEGORY", record.Category);
            this.MapParameterIn(command, "@PA_ATT_START_OFFSET", record.StartOffset == Int32.MinValue ? 0 : record.StartOffset);
            this.MapParameterIn(command, "@PA_ATT_END_OFFSET", record.EndOffset == Int32.MinValue ? 0 : record.EndOffset);
            this.MapParameterIn(command, "@PA_ATT_MIME", record.Mime);
            this.MapParameterIn(command, "@PA_ATT_SIZE", record.Size == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.Size);
            this.MapParameterIn(command, "@PA_ATT_VISIBILITY", record.Visibility);
            this.MapParameterIn(command, "@PA_ATT_ARCHIVED", record.Archived);
            this.MapParameterIn(command, "@PA_ATT_ARCHIVE_FILE", record.ArchiveFile);
            this.MapParameterIn(command, "@PA_ATT_ARCHIVE_BAT_ID", record.ArchiveBatId);
            this.MapParameterIn(command, "@PA_ATT_TABLE_URL", record.TableUrl);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AttachmentRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AttachmentRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ATT_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_ATT_LOCK", record.Lock);
            record.TableId = this.MapParameterOut(command, "@PA_ATT_TABLE_ID", record.TableId);
            record.RecordId = this.MapParameterOut(command, "@PA_ATT_RECORD_ID", record.RecordId);
            record.FileName = this.MapParameterOut(command, "@PA_ATT_FILE_NAME", record.FileName);
            record.FileDesc = this.MapParameterOut(command, "@PA_ATT_FILE_DESC", record.FileDesc);
            record.DateEtd = this.MapParameterOut(command, "@PA_ATT_DATE_ETD", record.DateEtd);
            record.ChkdBy = this.MapParameterOut(command, "@PA_ATT_CHKD_BY", record.ChkdBy);
            record.ChkdDate = this.MapParameterOut(command, "@PA_ATT_CHKD_DATE", record.ChkdDate);
            record.OrderNum = this.MapParameterOut(command, "@PA_ATT_ORDER_NUM", record.OrderNum);
            record.OrglName = this.MapParameterOut(command, "@PA_ATT_ORGL_NAME", record.OrglName);
            record.VersionNo = this.MapParameterOut(command, "@PA_ATT_VERSION_NO", record.VersionNo);
            record.Template = this.MapParameterOut(command, "@PA_ATT_TEMPLATE", record.Template);
            record.SourceData = this.MapParameterOut(command, "@PA_ATT_SOURCE_DATA", record.SourceData);
            record.Type = this.MapParameterOut(command, "@PA_ATT_TYPE", record.Type);
            record.ChkdOutDate = this.MapParameterOut(command, "@PA_ATT_CHKD_OUT_DATE", record.ChkdOutDate);
            record.ChkdOutBy = this.MapParameterOut(command, "@PA_ATT_CHKD_OUT_BY", record.ChkdOutBy);
            record.ChkdInDate = this.MapParameterOut(command, "@PA_ATT_CHKD_IN_DATE", record.ChkdInDate);
            record.ChkdInBy = this.MapParameterOut(command, "@PA_ATT_CHKD_IN_BY", record.ChkdInBy);
            record.PicId = this.MapParameterOut(command, "@PA_ATT_PIC_ID", record.PicId);
            record.Text = this.MapParameterOut(command, "@PA_ATT_TEXT", record.Text);
            record.UrlPath = this.MapParameterOut(command, "@PA_ATT_URL_PATH", record.UrlPath);
            record.Pagesetup = this.MapParameterOut(command, "@PA_ATT_PAGESETUP", record.Pagesetup);
            record.Compress = this.MapParameterOut(command, "@PA_ATT_COMPRESS", record.Compress);
            record.Extension = this.MapParameterOut(command, "@PA_ATT_EXTENSION", record.Extension);
            record.Attrib01 = this.MapParameterOut(command, "@PA_ATT_ATTRIB01", record.Attrib01);
            record.Web = this.MapParameterOut(command, "@PA_ATT_WEB", record.Web);
            record.PrintOnly = this.MapParameterOut(command, "@PA_ATT_PRINT_ONLY", record.PrintOnly);
            record.EmailOnly = this.MapParameterOut(command, "@PA_ATT_EMAIL_ONLY", record.EmailOnly);
            record.UgName = this.MapParameterOut(command, "@PA_ATT_UG_NAME", record.UgName);
            record.Category = this.MapParameterOut(command, "@PA_ATT_CATEGORY", record.Category);
            record.StartOffset = this.MapParameterOut(command, "@PA_ATT_START_OFFSET", record.StartOffset);
            record.EndOffset = this.MapParameterOut(command, "@PA_ATT_END_OFFSET", record.EndOffset);
            record.Mime = this.MapParameterOut(command, "@PA_ATT_MIME", record.Mime);
            record.Size = this.MapParameterOut(command, "@PA_ATT_SIZE", record.Size);
            record.Visibility = this.MapParameterOut(command, "@PA_ATT_VISIBILITY", record.Visibility);
            record.Archived = this.MapParameterOut(command, "@PA_ATT_ARCHIVED", record.Archived);
            record.ArchiveFile = this.MapParameterOut(command, "@PA_ATT_ARCHIVE_FILE", record.ArchiveFile);
            record.ArchiveBatId = this.MapParameterOut(command, "@PA_ATT_ARCHIVE_BAT_ID", record.ArchiveBatId);
            record.TableUrl = this.MapParameterOut(command, "@PA_ATT_TABLE_URL", record.TableUrl);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IAttachmentRepository.TableName
        {
            get { return this.TableName; }
        }

        void IAttachmentRepository.Create(Consensus.Common.AttachmentRecord record)
        {
            this.Create(record);
        }

        void IAttachmentRepository.Modify(Consensus.Common.AttachmentRecord record)
        {
            this.Modify(record);
        }

        System.Collections.Generic.IEnumerable<Consensus.Common.AttachmentRecord> IAttachmentRepository.FetchAllByUrlAndRecordId(System.String Url, System.String recordId)
        {
            return this.FetchAllByUrlAndRecordId(Url, recordId);
        }

        #endregion
    }
}
