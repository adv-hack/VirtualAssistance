using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CodeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerCodeRepository
    {
        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public CodeRecord FetchByTypeAndCode(String type, String code)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch, "Type", "Code");
            this.MapParameterIn(command, "@PA_CODE_TYPE", type);
            this.MapParameterIn(command, "@PA_CODE_VALUE1", code);
            return this.Execute(command).FirstOrDefault();
        }

        /// <summary>
        ///     Retrieves a single <see cref="CodeRecord" /> instance from the data store.
        /// </summary>
        /// <param name="type">
        ///     The type code which distinctly identifies the type of <see cref="CodeRecord" /> instance to be returned.
        /// </param>
        /// <param name="codeValue3">
        ///     The unique value which distinctly identifies the <see cref="CodeRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="CodeRecord" /> instance that matches the specified <paramref name="codeValue3" />; or null, if no matching instance can be found.
        /// </returns>
        public CodeRecord FetchByTypeAndCodeValue3(String type, String codeValue3)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch, "Type", "CodeValue3");
            this.MapParameterIn(command, "@PA_CODE_TYPE", type);
            this.MapParameterIn(command, "@PA_CODE_VALUE3", codeValue3);
            return this.Execute(command).FirstOrDefault();
        }

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<CodeRecord> FetchAllByType(String type)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Type");
            this.MapParameterIn(command, "@PA_CODE_TYPE", type);
            return this.Execute(command);
        }

        public override void RemoveById(CodeRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spRemoveSystemCode");
            //this.MapParameterIn(command, "@PA_CODE_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
            
        }

        
    }
}
