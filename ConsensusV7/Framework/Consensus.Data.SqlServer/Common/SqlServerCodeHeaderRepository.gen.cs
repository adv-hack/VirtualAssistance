using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CodeHeaderRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCodeHeaderRepository : SqlServerRepository<CodeHeaderRecord, String>, ICodeHeaderRepository
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
            get { return "CodeHeader"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CodeHeaderRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CDHDR_CODE_TYPE"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Code_Header"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CodeHeaderRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CodeHeaderRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CodeHeaderRecord record)
        {
            record.Id = dataRecord["CDHDR_CODE_TYPE"].ConvertTo<String>();
            record.Name = dataRecord["CDHDR_NAME"].ConvertTo<String>();
            record.Length = dataRecord["CDHDR_LENGTH"].ConvertTo<Byte?>();
            record.Type = dataRecord["CDHDR_TYPE"].ConvertTo<Byte?>();
            record.Tv1 = dataRecord["CDHDR_TV1"].ConvertTo<Byte?>();
            record.Tv2 = dataRecord["CDHDR_TV2"].ConvertTo<Byte?>();
            record.Tv3 = dataRecord["CDHDR_TV3"].ConvertTo<Byte?>();
            record.Tv4 = dataRecord["CDHDR_TV4"].ConvertTo<Byte?>();
            record.Tv1Len = dataRecord["CDHDR_TV1_LEN"].ConvertTo<Byte?>();
            record.ColName = dataRecord["CDHDR_COL_NAME"].ConvertTo<String>();
            record.TabName = dataRecord["CDHDR_TAB_NAME"].ConvertTo<String>();
            record.ReadOnly = dataRecord["CDHDR_READ_ONLY"].ConvertTo<Byte?>();
            record.CodeValue3List = dataRecord["CDHDR_CODE_VALUE3_LIST"].ConvertTo<String>();
            record.Immutable = dataRecord["CDHDR_IMMUTABLE"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CodeHeaderRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CodeHeaderRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CDHDR_CODE_TYPE", record.Id);
            this.MapParameterIn(command, "@PA_CDHDR_NAME", record.Name);
            this.MapParameterIn(command, "@PA_CDHDR_LENGTH", record.Length);
            this.MapParameterIn(command, "@PA_CDHDR_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_CDHDR_TV1", record.Tv1);
            this.MapParameterIn(command, "@PA_CDHDR_TV2", record.Tv2);
            this.MapParameterIn(command, "@PA_CDHDR_TV3", record.Tv3);
            this.MapParameterIn(command, "@PA_CDHDR_TV4", record.Tv4);
            this.MapParameterIn(command, "@PA_CDHDR_TV1_LEN", record.Tv1Len);
            this.MapParameterIn(command, "@PA_CDHDR_COL_NAME", record.ColName);
            this.MapParameterIn(command, "@PA_CDHDR_TAB_NAME", record.TabName);
            this.MapParameterIn(command, "@PA_CDHDR_READ_ONLY", record.ReadOnly);
            this.MapParameterIn(command, "@PA_CDHDR_CODE_VALUE3_LIST", record.CodeValue3List);
            this.MapParameterIn(command, "@PA_CDHDR_IMMUTABLE", record.Immutable);
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
        ///     The <see cref="CodeHeaderRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CodeHeaderRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CDHDR_CODE_TYPE", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_CDHDR_NAME", record.Name);
            record.Length = this.MapParameterOut(command, "@PA_CDHDR_LENGTH", record.Length);
            record.Type = this.MapParameterOut(command, "@PA_CDHDR_TYPE", record.Type);
            record.Tv1 = this.MapParameterOut(command, "@PA_CDHDR_TV1", record.Tv1);
            record.Tv2 = this.MapParameterOut(command, "@PA_CDHDR_TV2", record.Tv2);
            record.Tv3 = this.MapParameterOut(command, "@PA_CDHDR_TV3", record.Tv3);
            record.Tv4 = this.MapParameterOut(command, "@PA_CDHDR_TV4", record.Tv4);
            record.Tv1Len = this.MapParameterOut(command, "@PA_CDHDR_TV1_LEN", record.Tv1Len);
            record.ColName = this.MapParameterOut(command, "@PA_CDHDR_COL_NAME", record.ColName);
            record.TabName = this.MapParameterOut(command, "@PA_CDHDR_TAB_NAME", record.TabName);
            record.ReadOnly = this.MapParameterOut(command, "@PA_CDHDR_READ_ONLY", record.ReadOnly);
            record.CodeValue3List = this.MapParameterOut(command, "@PA_CDHDR_CODE_VALUE3_LIST", record.CodeValue3List);
            record.Immutable = this.MapParameterOut(command, "@PA_CDHDR_IMMUTABLE", record.Immutable);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICodeHeaderRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
