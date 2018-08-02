using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LettmplttypeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLetterTemplateTypeRepository : SqlServerRepository<LettmplttypeRecord, String>, ILetterTemplateTypeRepository
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
            get { return "Lettmplttype"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="LettmplttypeRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LTT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "LetTmpltType"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="LettmplttypeRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LettmplttypeRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, LettmplttypeRecord record)
        {
            record.Id = dataRecord["LTT_ID"].ConvertTo<String>();
            record.Lock = dataRecord["LTT_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["LTT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["LTT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["LTT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["LTT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["LTT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["LTT_RCV_FROM"].ConvertTo<String>();
            record.Name = dataRecord["LTT_NAME"].ConvertTo<String>();
            record.Desc = dataRecord["LTT_DESC"].ConvertTo<String>();
            record.Levels = dataRecord["LTT_LEVELS"].ConvertTo<Int32?>();
            record.Type = dataRecord["LTT_TYPE"].ConvertTo<Byte?>();
            record.ProcName = dataRecord["LTT_PROC_NAME"].ConvertTo<String>();
            record.Equivalent = dataRecord["LTT_EQUIVALENT"].ConvertTo<String>();
            record.DefaultPrType = dataRecord["LTT_DEFAULT_PR_TYPE"].ConvertTo<String>();
            record.Url = dataRecord["LTT_URL"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LettmplttypeRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, LettmplttypeRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LTT_ID", record.Id);
            this.MapParameterIn(command, "@PA_LTT_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_LTT_NAME", record.Name);
            this.MapParameterIn(command, "@PA_LTT_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_LTT_LEVELS", record.Levels == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Levels);
            this.MapParameterIn(command, "@PA_LTT_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_LTT_PROC_NAME", record.ProcName);
            this.MapParameterIn(command, "@PA_LTT_EQUIVALENT", record.Equivalent);
            this.MapParameterIn(command, "@PA_LTT_DEFAULT_PR_TYPE", record.DefaultPrType);
            this.MapParameterIn(command, "@PA_LTT_URL", record.Url);
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
        ///     The <see cref="LettmplttypeRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, LettmplttypeRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LTT_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_LTT_LOCK", record.Lock);
            record.Name = this.MapParameterOut(command, "@PA_LTT_NAME", record.Name);
            record.Desc = this.MapParameterOut(command, "@PA_LTT_DESC", record.Desc);
            record.Levels = this.MapParameterOut(command, "@PA_LTT_LEVELS", record.Levels);
            record.Type = this.MapParameterOut(command, "@PA_LTT_TYPE", record.Type);
            record.ProcName = this.MapParameterOut(command, "@PA_LTT_PROC_NAME", record.ProcName);
            record.Equivalent = this.MapParameterOut(command, "@PA_LTT_EQUIVALENT", record.Equivalent);
            record.DefaultPrType = this.MapParameterOut(command, "@PA_LTT_DEFAULT_PR_TYPE", record.DefaultPrType);
            record.Url = this.MapParameterOut(command, "@PA_LTT_URL", record.Url);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ILetterTemplateTypeRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
