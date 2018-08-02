using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for repositories which persist and retrieve data structures, in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class SqlServerRepository : IRepository
    {
        #region fields

        /// <summary>
        ///     The naming convention applied to the standard stored procedures.
        /// </summary>
        protected const String StoredProcedureNamingConvention = "spConsensus{typeNamespace}{typeName}{operation}{parameters}";

        /// <summary>
        ///     The <see cref="SqlServerProvider" /> instance which exposes this repository.
        /// </summary>
        private SqlServerProvider _provider;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected abstract String TypeNamespace
        {
            get;
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected abstract String TypeName
        {
            get;
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public abstract String TableName
        {
            get;
        }

        /// <summary>
        ///     Gets <see cref="SqlServerProvider" /> instance which exposes this repository.
        /// </summary>
        protected SqlServerProvider Provider
        {
            get { return _provider; }
            private set { _provider = value; }
        }

        /// <summary>
        ///     Gets the Role Id for the currently logged on user.
        /// </summary>
        protected String UserId
        {
            get
            {
                if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session == null)
                {
                    return "-";
                }
                else
                {
                   object oUser = System.Web.HttpContext.Current.Session["current_user"];
                   if (oUser != null)
                   {
                       Type localUserType = oUser.GetType();
                       System.Reflection.PropertyInfo IdProp = localUserType.GetProperty("UserId");
                       if (IdProp != null)
                       {
                           return IdProp.GetValue(oUser).ToString();
                       }
                       else
                       {
                           return "-";
                       }
                   }
                   else
                   {
                       return "-";
                   }
                }
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepository" /> instance.
        /// </summary>
        /// <remarks>
        ///     The use of an internal static instantiation method, combined with a protected constructor, allows common initialisation code to be centralised
        ///     within an abstract class without creating a requirement for constructor implementation within the derived classes.
        /// </remarks>
        protected SqlServerRepository()
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <typeparamref name="TRepository" /> instance and stores the instance within the specified <paramref name="reference" />, unless the reference has already been initialised with a <typeparamref name="TRepository" /> instance.
        /// </summary>
        /// <typeparam name="TRepository">
        ///     The type of repository to be checked and if required, instantiated and initialised.
        /// </typeparam>
        /// <param name="provider">
        ///     The data provider which programmatically exposes this repository.
        /// </param>
        /// <param name="reference">
        ///     The reference to the field which persists the instance of the repository within memory.
        /// </param>
        /// <returns>
        ///     The newly initialised instance, or the pre-existing instance, of the <typeparamref name="TRepository" /> class.
        /// </returns>
        /// <remarks>
        ///     The use of an internal static instantiation method, combined with a protected constructor, allows common initialisation code to be centralised
        ///     within an abstract class without creating a requirement for constructor implementation within the derived classes.
        /// </remarks>
        internal static TRepository Create<TRepository>(SqlServerProvider provider, ref TRepository reference) where TRepository : SqlServerRepository, new()
        {
            if (reference == null)
                reference = new TRepository() { Provider = provider };
            
            return reference;
        }

        /// <summary>
        ///     Gets a <see cref="DbCommand" /> instance for executing a sql statement.
        /// </summary>
        /// <param name="statement">
        ///     The sql statement to be executed by the <see cref="DbCommand" />.
        /// </param>
        /// <returns>
        ///     A new <see cref="DbCommand" /> instance, pre-initialised for executing the specified <paramref name="statement" />.
        /// </returns>
        protected DbCommand GetSqlStatement(String statement)
        {
            DbCommand command = this.Provider.Database.GetSqlStringCommand(statement);
            command.Connection = this.Provider.Database.CreateConnection();
            return command;
        }

        /// <summary>
        ///     Gets a <see cref="DbCommand" /> instance for executing a stored procedure.
        /// </summary>
        /// <param name="operation">
        ///     The operation that is performed by the stored procedure.
        /// </param>
        /// <param name="parameters">
        ///     The name of the parameters that are required by the stored procedure.
        /// </param>
        /// <returns>
        ///     A new <see cref="DbCommand" /> instance, pre-initialised for executing a stored procedure that performs the specified <paramref name="operation" />.
        /// </returns>
        protected DbCommand GetStoredProcedure(SqlServerOperation operation, params String[] parameters)
        {
            String procedureNameSuffix = (parameters.Length == 0 ? String.Empty : "By" + String.Join("And", parameters));
            String procedureNameFormat = SqlServerRepository.StoredProcedureNamingConvention.Replace("{typeNamespace}", "{0}").Replace("{typeName}", "{1}").Replace("{operation}", "{2}").Replace("{parameters}", "{3}");
            String procedureName = String.Format(procedureNameFormat, this.TypeNamespace, this.TypeName, operation, procedureNameSuffix);
            return this.Provider.GetStoredProcedure(procedureName);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
