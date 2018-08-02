using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ArticleRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerArticleRepository : SqlServerRepository<ArticleRecord, Int32>, IArticleRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Document"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Article"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ArticleRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ARTI_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Article"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ArticleRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ArticleRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ArticleRecord record)
        {
            record.Id = dataRecord["ARTI_ID"].ConvertTo<Int32>();
            record.Type = dataRecord["ARTI_TYPE"].ConvertTo<Byte>();
            record.State = dataRecord["ARTI_STATE"].ConvertTo<Byte>();
            record.AddDate = dataRecord["ARTI_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModDate = dataRecord["ARTI_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvDate = dataRecord["ARTI_RCV_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ARTI_ADD_BY"].ConvertTo<String>();
            record.ModBy = dataRecord["ARTI_MOD_BY"].ConvertTo<String>();
            record.RcvFrom = dataRecord["ARTI_RCV_FROM"].ConvertTo<String>();
            record.Name = dataRecord["ARTI_NAME"].ConvertTo<String>();
            record.Notes = dataRecord["ARTI_NOTES"].ConvertTo<String>();
            record.NotesHtml = dataRecord["ARTI_NOTES_HTML"].ConvertTo<String>();
            record.Group = dataRecord["ARTI_GROUP"].ConvertTo<String>();
            record.Keywords = dataRecord["ARTI_KEYWORDS"].ConvertTo<String>();
            record.Category = dataRecord["ARTI_CATEGORY"].ConvertTo<String>();
            record.Summary = dataRecord["ARTI_SUMMARY"].ConvertTo<String>();
            record.SummaryHtml = dataRecord["ARTI_SUMMARY_HTML"].ConvertTo<String>();
            record.Web = dataRecord["ARTI_WEB"].ConvertTo<Byte>();
            record.Image = dataRecord["ARTI_IMAGE"].ConvertTo<String>();
            record.Featured = dataRecord["ARTI_FEATURED"].ConvertTo<Byte>();
            record.PublishDate = dataRecord["ARTI_PUBLISH_DATE"].ConvertTo<DateTime?>();
            record.PublishProleId = dataRecord["ARTI_PUBLISH_PROLE_ID"].ConvertTo<String>();
            record.PsId = dataRecord["ARTI_PS_ID"].ConvertTo<Int32?>();
            record.Area = dataRecord["ARTI_AREA"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ArticleRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ArticleRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ARTI_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_ARTI_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ARTI_STATE", record.State);
            this.MapParameterIn(command, "@PA_ARTI_NAME", record.Name);
            this.MapParameterIn(command, "@PA_ARTI_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_ARTI_NOTES_HTML", record.NotesHtml);
            this.MapParameterIn(command, "@PA_ARTI_GROUP", record.Group);
            this.MapParameterIn(command, "@PA_ARTI_KEYWORDS", record.Keywords);
            this.MapParameterIn(command, "@PA_ARTI_CATEGORY", record.Category);
            this.MapParameterIn(command, "@PA_ARTI_SUMMARY", record.Summary);
            this.MapParameterIn(command, "@PA_ARTI_SUMMARY_HTML", record.SummaryHtml);
            this.MapParameterIn(command, "@PA_ARTI_WEB", record.Web);
            this.MapParameterIn(command, "@PA_ARTI_IMAGE", record.Image);
            this.MapParameterIn(command, "@PA_ARTI_FEATURED", record.Featured);
            this.MapParameterIn(command, "@PA_ARTI_PUBLISH_DATE", record.PublishDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PublishDate);
            this.MapParameterIn(command, "@PA_ARTI_PUBLISH_PROLE_ID", record.PublishProleId);
            this.MapParameterIn(command, "@PA_ARTI_PS_ID", record.PsId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PsId);
            this.MapParameterIn(command, "@PA_ARTI_AREA", record.Area);
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
        ///     The <see cref="ArticleRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ArticleRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ARTI_ID", record.Id);
            record.Type = this.MapParameterOut(command, "@PA_ARTI_TYPE", record.Type);
            record.State = this.MapParameterOut(command, "@PA_ARTI_STATE", record.State);
            record.Name = this.MapParameterOut(command, "@PA_ARTI_NAME", record.Name);
            record.Notes = this.MapParameterOut(command, "@PA_ARTI_NOTES", record.Notes);
            record.NotesHtml = this.MapParameterOut(command, "@PA_ARTI_NOTES_HTML", record.NotesHtml);
            record.Group = this.MapParameterOut(command, "@PA_ARTI_GROUP", record.Group);
            record.Keywords = this.MapParameterOut(command, "@PA_ARTI_KEYWORDS", record.Keywords);
            record.Category = this.MapParameterOut(command, "@PA_ARTI_CATEGORY", record.Category);
            record.Summary = this.MapParameterOut(command, "@PA_ARTI_SUMMARY", record.Summary);
            record.SummaryHtml = this.MapParameterOut(command, "@PA_ARTI_SUMMARY_HTML", record.SummaryHtml);
            record.Web = this.MapParameterOut(command, "@PA_ARTI_WEB", record.Web);
            record.Image = this.MapParameterOut(command, "@PA_ARTI_IMAGE", record.Image);
            record.Featured = this.MapParameterOut(command, "@PA_ARTI_FEATURED", record.Featured);
            record.PublishDate = this.MapParameterOut(command, "@PA_ARTI_PUBLISH_DATE", record.PublishDate);
            record.PublishProleId = this.MapParameterOut(command, "@PA_ARTI_PUBLISH_PROLE_ID", record.PublishProleId);
            record.PsId = this.MapParameterOut(command, "@PA_ARTI_PS_ID", record.PsId);
            record.Area = this.MapParameterOut(command, "@PA_ARTI_AREA", record.Area);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IArticleRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
