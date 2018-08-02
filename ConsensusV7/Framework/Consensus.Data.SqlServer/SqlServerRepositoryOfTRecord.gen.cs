using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for repositories which persist and retrieve the <typeparamref name="TRecord" /> data structure, in a Microsoft SQL Server database.
    /// </summary>
    /// <typeparam name="TRecord">
    ///     The type of data structure which is persisted within the repository.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class SqlServerRepository<TRecord> : SqlServerRepository, IRepository<TRecord> where TRecord : Record, new()
    {
        #region methods

        /// <summary>
        ///     Executes the specified database command and maps the resultset to an enumerable collection of <typeparamref name="TRecord" /> instances.
        /// </summary>
        /// <param name="command">
        ///     The database command to be executed.
        /// </param>
        /// <returns>
        ///     An enumerable collection of <typeparamref name="TRecord" /> instances mapped from the command result.
        /// </returns>
        protected IEnumerable<TRecord> Execute(DbCommand command)
        {
            TRecord[] result;
            using (IDataReader reader = this.Provider.Database.ExecuteReader(command))
                result = this.MapRecords(reader).ToArray();
            
            return result;
        }

        /// <summary>
        ///     Maps the result set returned by an <see cref="IDataReader" /> to an enumerable collection of <typeparamref name="TRecord" /> instances.
        /// </summary>
        /// <param name="dataReader">
        ///     The <see cref="IDataReader" /> which iterates through the <see cref="IDataRecord" /> instances to be mapped.
        /// </param>
        /// <returns>
        ///     An enumerable collection of <typeparamref name="TRecord" /> instances mapped from the records obtained from the specified <paramref name="dataReader" />.
        /// </returns>
        private IEnumerable<TRecord> MapRecords(IDataReader dataReader)
        {
            while (dataReader != null & !dataReader.IsClosed && dataReader.Read())
                yield return this.MapRecord(dataReader);
        }

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to a new instance of the <typeparamref name="TRecord" /> class.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <returns>
        ///     A new <typeparamref name="TRecord" /> instance pre-initialised with values obtained from the specified <paramref name="dataRecord" />.
        /// </returns>
        private TRecord MapRecord(IDataRecord dataRecord)
        {
            TRecord record = new TRecord();
            this.MapRecord(dataRecord, record);
            return record;
        }

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <paramref name="dataRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <typeparamref name="TRecord" /> instance to be mapped to.
        /// </param>
        protected abstract void MapRecord(IDataRecord dataRecord, TRecord record);

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The instance of the <typeparamref name="TRecord" /> containing the values to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected abstract void MapParametersIn(IDbCommand command, TRecord record, bool useV6Logic);

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The instance of the <typeparamref name="TRecord" /> to be updated.
        /// </param>
        protected abstract void MapParametersOut(IDbCommand command, TRecord record);

        /// <summary>
        ///     Sets the parameter for the specified <paramref name="command" /> to the specified <paramref name="value" />.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="name">
        ///     The name of the parameter to be set.
        /// </param>
        /// <param name="value">
        ///     The value of the parameter to be set.
        /// </param>
        protected void MapParameterIn(IDbCommand command, String name, Object value)
        {
            IDataParameter parameter = command.Parameters.Contains(name) ? command.Parameters[name] as IDataParameter : null;
            if (parameter != null && (parameter.Direction == ParameterDirection.Input || parameter.Direction == ParameterDirection.InputOutput))
                parameter.Value = value;
        }

        /// <summary>
        ///     Adds the standard error handling parameters for older procedures to the specified <paramref name="command" />.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        protected void MapErrorParams(IDbCommand command)
        {
            MapParameterIn(command, "@PA_ERRORCODE", null);
            MapParameterIn(command, "@PA_ERRORDESC", null);
        }

        /// <summary>
        ///     Reads standard error handling parameters for older procedures and throws an ApplicationException if an error has been returned.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        protected virtual void CheckErrorParams(IDbCommand command)
        {
            int errCode = 0;
            string errMsg = "";
            errCode = this.MapParameterOut(command, "@PA_ERRORCODE", errCode);
            errMsg = this.MapParameterOut(command, "@PA_ERRORDESC", errMsg);
            
            if (!string.IsNullOrEmpty(errMsg))
            {
                throw new ApplicationException(errMsg);
            }
        }

        /// <summary>
        ///     Extracts the parameter value from the specified <paramref name="command" />.
        /// </summary>
        /// <typeparam name="TValue">
        ///     The data type of the value to be extracted.
        /// </typeparam>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be extracted.
        /// </param>
        /// <param name="name">
        ///     The name of the parameter to be extracted.
        /// </param>
        /// <param name="value">
        ///     The value of the parameter to be returned if the parameter is not found, or is not an output parameter.
        /// </param>
        protected TValue MapParameterOut<TValue>(IDbCommand command, String name, TValue value)
        {
            IDataParameter parameter = command.Parameters.Contains(name) ? command.Parameters[name] as IDataParameter : null;
            if (parameter != null && (parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.InputOutput))
                value = parameter.Value.ConvertTo<TValue>();
            
            return value;
        }

        /// <summary>
        ///     Retrieves all existing <typeparamref name="TRecord" /> instances from the data store.
        /// </summary>
        /// <returns>
        ///     The enumerable collection of <typeparamref name="TRecord" /> instances that are persisted within the data store.
        /// </returns>
        public virtual IEnumerable<TRecord> FetchAll()
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll);
            return this.Execute(command);
        }

        /// <summary>
        ///     Creates a new <typeparamref name="TRecord" /> instance within the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be created within the data store.
        /// </param>
        public virtual void Create(TRecord record)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Create);
            this.MapParametersIn(command, record, false);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        /// <summary>
        ///     Modifies an existing <typeparamref name="TRecord" /> instance within the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be modified within the data store.
        /// </param>
        public virtual void Modify(TRecord record)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Modify);
            this.MapParametersIn(command, record, false);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        /// <summary>
        ///     Removes an existing <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be removed from the data store.
        /// </param>
        public virtual void RemoveById(TRecord record)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Remove, "Id");
            this.MapParametersIn(command, record, false);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves all existing <typeparamref name="TRecord" /> instances from the data store.
        /// </summary>
        /// <returns>
        ///     The enumerable collection of <typeparamref name="TRecord" /> instances that are persisted within the data store.
        /// </returns>
        System.Collections.Generic.IEnumerable<TRecord> IRepository<TRecord>.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Creates a new <typeparamref name="TRecord" /> instance within the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be created within the data store.
        /// </param>
        void IRepository<TRecord>.Create(TRecord record)
        {
            this.Create(record);
        }

        /// <summary>
        ///     Modifies an existing <typeparamref name="TRecord" /> instance within the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be modified within the data store.
        /// </param>
        void IRepository<TRecord>.Modify(TRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Removes an existing <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be removed from the data store.
        /// </param>
        void IRepository<TRecord>.RemoveById(TRecord record)
        {
            this.RemoveById(record);
        }

        #endregion
    }
}
