using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ArticlexrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerArticlexrefRepository : SqlServerRepository<ArticlexrefRecord, Int32>, IArticlexrefRepository
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
            get { return "Articlexref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ArticlexrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ARTIXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "ArticleXref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ArticlexrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ArticlexrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ArticlexrefRecord record)
        {
            record.Id = dataRecord["ARTIXREF_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["ARTIXREF_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["ARTIXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ARTIXREF_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["ARTIXREF_MOD_BY"].ConvertTo<String>();
            record.ArtiId = dataRecord["ARTIXREF_ARTI_ID"].ConvertTo<String>();
            record.RelArtiId = dataRecord["ARTIXREF_REL_ARTI_ID"].ConvertTo<Int32>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ArticlexrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ArticlexrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ARTIXREF_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_ARTIXREF_ARTI_ID", record.ArtiId);
            this.MapParameterIn(command, "@PA_ARTIXREF_REL_ARTI_ID", record.RelArtiId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RelArtiId);
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
        ///     The <see cref="ArticlexrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ArticlexrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ARTIXREF_ID", record.Id);
            record.ArtiId = this.MapParameterOut(command, "@PA_ARTIXREF_ARTI_ID", record.ArtiId);
            record.RelArtiId = this.MapParameterOut(command, "@PA_ARTIXREF_REL_ARTI_ID", record.RelArtiId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ArticlexrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="relArtiId">
        ///     The value which identifies the <see cref='ArticlexrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ArticlexrefRecord" /> instances that match the specified <paramref name='relArtiId' />.
        /// </returns>
        public IEnumerable<ArticlexrefRecord> FetchAllByRelArtiId(Int32 relArtiId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "RelArtiId");
            this.MapParameterIn(command, "@PA_ARTIXREF_REL_ARTI_ID", relArtiId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IArticlexrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.ArticlexrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="relArtiId">
        ///     The value which identifies the <see cref="!:ArticlexrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.ArticlexrefRecord" /> instances that match the specified <paramref name="relArtiId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ArticlexrefRecord> IArticlexrefRepository.FetchAllByRelArtiId(System.Int32 relArtiId)
        {
            return this.FetchAllByRelArtiId(relArtiId);
        }

        #endregion
    }
}
