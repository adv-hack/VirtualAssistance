using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the programmatic access to the repository collections for Microsoft SQL Server data access.
    /// </summary>
    public partial class SqlServerProvider
    {
        public Dictionary<String, Object>[] ExecuteQuery(String query)
        {
            return this.ExecuteQuery(query, null);
        }

        public Dictionary<String, Object>[] ExecuteQuery(String query, Dictionary<String, Object> parameters)
        {
            DbCommand command = this.Database.GetSqlStringCommand(query);
            if (parameters != null)
            {
                foreach (String parameterName in parameters.Keys)
                {
                    DbParameter parameter = command.CreateParameter();
                    parameter.ParameterName = parameterName;
                    parameter.Value = parameters[parameterName] == null ? DBNull.Value : parameters[parameterName];
                    command.Parameters.Add(parameter);
                }
            }
            return this.ExecuteCommand(command).ToArray();
        }

        public Dictionary<String, Object>[] ExecuteProcedure(String procedureName, Dictionary<String, Object> parameters)
        {
            DbCommand command = this.GetStoredProcedure(procedureName);
            foreach (String parameterName in parameters.Keys)
                if (command.Parameters.Contains(parameterName))
                    command.Parameters[parameterName].Value = parameters[parameterName];
            return this.ExecuteCommand(command).ToArray();
        }

        private IEnumerable<Dictionary<String, Object>> ExecuteCommand(DbCommand command)
        {
            using (IDataReader reader = this.Database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    Dictionary<String, Object> record = new Dictionary<String, Object>();
                    Enumerable.Range(0, reader.FieldCount).Execute(i => record[reader.GetName(i)] = reader[i]);
                    yield return record;
                }
            }
        }
    }
}
