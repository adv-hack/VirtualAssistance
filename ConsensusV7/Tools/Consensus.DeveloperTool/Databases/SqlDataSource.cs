using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a Microsoft SQL Server development database which reflects the structure of a business domain.
    /// </summary>
    [Description("Microsoft SQL Server")]
    public class SqlDataSource : DomainDataSource
    {
        #region constructor

        /// <summary>
        ///     Creates a new <see cref="SqlDataSource" /> instance.
        /// </summary>
        /// <param name="domain">
        ///     Sets the <see cref="Domain" /> instance in which the data source is defined.
        /// </param>
        internal SqlDataSource(Domain domain) : base(domain)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the list of tables that have been defined in the database.
        /// </summary>
        public override String[] GetTables()
        {
            return this.Execute(rec => rec["name"].ConvertTo<String>(), @"
              select objects.name
              from sys.schemas
              join sys.objects on objects.schema_id = schemas.schema_id
              where schemas.name = 'dbo' and objects.type = 'u'
              order by objects.name").ToArray();
        }

        /// <summary>
        ///     Imports the specified database table into the current domain.
        /// </summary>
        /// <param name="tableName">
        ///     The name of the table to be imported.
        /// </param>
        public override DomainTable ImportTable(String tableName)
        {
            // Import the table information
            DomainTable table = this.Execute(record => this.ParseTable(this.Domain, record), @"
              select objects.name 
              from sys.schemas
              join sys.objects on objects.schema_id = schemas.schema_id
              where schemas.name = 'dbo' and objects.type = 'u' and objects.name = @param1", tableName).FirstOrDefault();

            return table;
        }

        /// <summary>
        ///     Parses the specified connection string through a platform-specific connection builder to apply platform-specific formatting.
        /// </summary>
        /// <param name="connectionString">
        ///     The pre-formatted connection string.
        /// </param>
        /// <returns>
        ///     The formatted connection string.
        /// </returns>
        public override String FormatConnection(String connectionString)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = connectionString;
            return builder.ToString();
        }

        /// <summary>
        ///     Executes a simple command which obtains the current date and time from the data-source server.
        /// </summary>
        /// <returns>
        ///     The exception which prevented the command from executing, or null if the command executed successfully.
        /// </returns>
        public override Exception TestConnection()
        {
            Exception error = null;
            DateTime? value = null;
            try
            {
                value = this.Execute(rec => rec["currentDateTime"].ConvertTo<DateTime>(), "select getDate() as currentDateTime").FirstOrDefault();
            }
            catch (Exception exception)
            {
                error = exception;
            }
            return error;
        }

        /// <summary>
        ///     Executes a sql statement against the database.
        /// </summary>
        public override void Execute(String sqlStatement)
        {
            String[] sqlBatches = sqlStatement.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
            for (Int32 i = 0; i < sqlBatches.Length; i++)
                sqlBatches[i] = String.Equals(sqlBatches[i], "go", StringComparison.OrdinalIgnoreCase) ? "※" : sqlBatches[i];

            sqlBatches = String.Join(Environment.NewLine, sqlBatches).Split(new String[] { "※" }, StringSplitOptions.RemoveEmptyEntries);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                connection.Open();
                foreach (String sqlBatch in sqlBatches)
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = sqlBatch;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        ///     Parses a data record into a <see cref="DatabaseTable" /> instance.
        /// </summary>
        private DomainTable ParseTable(Domain domain, IDataRecord record)
        {
            DomainTable table = domain.CreateTable();
            table.TableName = record["name"].ConvertTo<String>();

            // Import the column information
            this.Execute(rec2 => this.ParseColumn(table, rec2), @"
              select column_index = columns.column_id, column_name = columns.name, column_type = case types.name when 'bigint' then 'Int64' when 'binary' then 'Binary' when 'bit' then 'Boolean' when 'char' then 'Char' when 'date' then 'DateTime' when 'datetime' then 'DateTime' when 'decimal' then 'Decimal' when 'float' then 'Double' when 'int' then 'Int32' when 'money' then 'Decimal' when 'nchar' then 'NChar' when 'nvarchar' then 'NVarchar' when 'smallint' then 'Int16' when 'tinyint' then 'Byte' when 'real' then 'Single' when 'uniqueidentifier' then 'Guid' when 'varbinary' then 'Binary' when 'varchar' then 'Varchar' else types.name end, column_length = case when types.name in ('nchar', 'nvarchar') then columns.max_length / 2 when types.name in ('char', 'varchar') then columns.max_length else columns.precision end, column_scale = columns.scale, column_nullable = case when columns.is_nullable = 0 then 'False' else 'True' end, column_default = case when len(default_constraints.definition) < 4 then substring(default_constraints.definition, 2, len(default_constraints.definition) - 2) when isnumeric(substring(default_constraints.definition, 3, len(default_constraints.definition) - 4)) = 0 then substring(default_constraints.definition, 2, len(default_constraints.definition) - 2) else substring(default_constraints.definition, 3, len(default_constraints.definition) - 4) end
              from sys.schemas
              join sys.objects on objects.schema_id = schemas.schema_id 
              join sys.columns on columns.object_id = objects.object_id
              join sys.types on types.user_type_id = columns.user_type_id
              left join sys.default_constraints on default_constraints.parent_object_id = columns.object_id and default_constraints.parent_column_id = columns.column_id
              where schemas.name = 'dbo' and objects.type = 'u' and objects.name = @param1
			  order by columns.column_id", table.TableName).ToArray();

            // Import the index information
            this.Execute(rec2 => this.ParseIndex(table, rec2), @"
              select index_id = indexes.index_id, index_name = indexes.name, index_unique = indexes.is_unique
              from sys.schemas
              join sys.objects on objects.schema_id = schemas.schema_id 
              join sys.indexes on indexes.object_id = objects.object_id
              where schemas.name = 'dbo' and objects.type = 'u' and objects.name = @param1
              order by indexes.type, indexes.index_id", table.TableName).ToArray();

            // Import the constraint information
            this.Execute(rec2 => this.ParseConstraint(table, rec2), @"
              select key_id = foreign_keys.object_id, key_name = foreign_keys.name, key_object = referenced_object.name
              from sys.schemas
              join sys.objects on objects.schema_id = schemas.schema_id 
              join sys.foreign_keys on foreign_keys.parent_object_id = objects.object_id
              join sys.objects as referenced_object on referenced_object.object_id = foreign_keys.referenced_object_id
              where schemas.name = 'dbo' and objects.type = 'u' and objects.name = @param1
              order by foreign_keys.key_index_id", table.TableName).ToArray();

            return table;
        }

        /// <summary>
        ///     Parses a data record into a <see cref="DatabaseTableColumn" /> instance.
        /// </summary>
        private DomainTableColumn ParseColumn(DomainTable table, IDataRecord record)
        {
            DomainTableColumn column = table.CreateColumn();
            column.ColumnOrdinal = record["column_index"].ConvertTo<Int32>();
            column.ColumnName = record["column_name"].ConvertTo<String>();
            column.ColumnType = record["column_type"].ConvertTo<DomainDataType>();
            column.ColumnLength = record["column_length"].ConvertTo<Int32>();
            column.ColumnScale = record["column_scale"].ConvertTo<Int32>();
            column.ColumnNullable = record["column_nullable"].ConvertTo<Boolean>();
            column.ColumnDefaultValue = record["column_default"].ConvertTo<String>();
            return column;
        }

        /// <summary>
        ///     Parses a data record into a <see cref="DatabaseIndex" /> instance.
        /// </summary>
        private DomainTableIndex ParseIndex(DomainTable table, IDataRecord record)
        {
            DomainTableIndex index = table.CreateIndex();
            index.IndexName = record["index_name"].ConvertTo<String>();
            index.IndexIsUnique = record["index_unique"].ConvertTo<Boolean>();

            // Import the column information
            this.Execute(rec2 => this.ParseIndexColumn(index, rec2), @"
              select columns.name
              from sys.schemas
              join sys.objects on objects.schema_id = schemas.schema_id 
              join sys.columns on columns.object_id = objects.object_id 
              join sys.indexes on indexes.object_id = objects.object_id
              join sys.index_columns on index_columns.object_id = objects.object_id and index_columns.index_id = indexes.index_id and index_columns.column_id = columns.column_id
              where schemas.name = 'dbo' and objects.type = 'u' and objects.name = @param1 and indexes.index_id = @param2
              order by indexes.type, indexes.index_id", table.TableName, record["index_id"]).ToArray();

            return index;
        }

        /// <summary>
        ///     Parses a data record into a <see cref="DatabaseIndexColumn" /> instance.
        /// </summary>
        private DomainTableIndexColumn ParseIndexColumn(DomainTableIndex index, IDataRecord record)
        {
            DomainTableIndexColumn indexColumn = index.CreateColumn();
            indexColumn.ReferencedColumn = index.Table.TableColumns.FirstOrDefault(column => column.ColumnName == record["name"].ConvertTo<String>());
            return indexColumn;
        }

        /// <summary>
        ///     Parses a data record into a <see cref="DatabaseConstraint" /> instance.
        /// </summary>
        private DomainTableConstraint ParseConstraint(DomainTable table, IDataRecord record)
        {
            DomainTableConstraint constraint = table.CreateConstraint();
            constraint.ConstraintName = record["key_name"].ConvertTo<String>();
            constraint.ReferencedTable = table.Domain.Tables.FirstOrDefault(t => t.TableName == record["key_object"].ConvertTo<String>());

            // Import the column information
            this.Execute(rec2 => this.ParseConstraintColumn(constraint, rec2), @"
              select column_name = columns.name, column_reference = referenced_column.name
              from sys.schemas
              join sys.objects on objects.schema_id = schemas.schema_id 
              join sys.columns on columns.object_id = objects.object_id 
              join sys.foreign_keys on foreign_keys.parent_object_id = objects.object_id
              join sys.foreign_key_columns on foreign_key_columns.constraint_object_id = foreign_keys.object_id and foreign_key_columns.parent_object_id = foreign_keys.parent_object_id and foreign_key_columns.parent_column_id = columns.column_id
              join sys.columns as referenced_column on referenced_column.object_id = foreign_key_columns.referenced_object_id and referenced_column.column_id = foreign_key_columns.referenced_column_id
              where schemas.name = 'dbo' and objects.type = 'u' and objects.name = @param1 and foreign_keys.object_id = @param2", table.TableName, record["key_id"]).ToArray();
            return constraint;
        }

        /// <summary>
        ///     Parses a data record into a <see cref="DatabaseConstraintColumn" /> instance.
        /// </summary>
        private DomainTableConstraintColumn ParseConstraintColumn(DomainTableConstraint constraint, IDataRecord record)
        {
            DomainTableConstraintColumn constraintColumn = constraint.CreateColumn();
            constraintColumn.ConstraintColumn = constraint.Table.TableColumns.FirstOrDefault(column => column.ColumnName == record["column_name"].ConvertTo<String>());
            constraintColumn.ReferencedColumn = constraint.ReferencedTable.TableColumns.FirstOrDefault(column => column.ColumnName == record["column_reference"].ConvertTo<String>());
            return constraintColumn;
        }
        
        /// <summary>
        ///     Executes a sql statement against the database.
        /// </summary>
        /// <typeparam name="TResult">
        ///     The type of result to return.
        /// </typeparam>
        /// <param name="parser">
        ///     The delegated function for parsing each record into the required type.
        /// </param>
        /// <param name="commandText">
        ///     The sql statement to be executed.
        /// </param>
        /// <param name="parameters">
        ///     The paameters to be passed into the sql statement.
        /// </param>
        /// <returns>
        ///     An enumerable collection of objects, parsed from the records returned by the sql statement
        /// </returns>
        private IEnumerable<TResult> Execute<TResult>(Func<IDataRecord, TResult> parser, String commandText, params Object[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = commandText;
                    command.CommandType = CommandType.Text;
                    for (Int32 i = 0; i < parameters.Length; i++)
                        command.Parameters.AddWithValue("@param" + (i + 1).ToString(), parameters[i]);

                    using (SqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                            yield return parser.Invoke(reader);
                }
            }
        }

        #endregion
    }
}
