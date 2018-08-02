using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.DataModel
{
    /// <summary>
    ///     Represents a database.
    /// </summary>
    [Serializable]
    public class Database
    {
        #region fields

        /// <summary>
        ///     The collection of domains that have been defined within the database.
        /// </summary>
        private DataDomain[] _domains;

        /// <summary>
        ///     The collection of entities which do not yet belong to a domain.
        /// </summary>
        private DataEntity[] _entities;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the name of the database
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        ///     Gets or sets the connection string for the database
        /// </summary>
        public String Connection { private get; set; }

        /// <summary>
        ///     Gets the collection of domains that have been defined within the database.
        /// </summary>
        public DataDomain[] Domains
        {
            get
            {
                if (_domains == null)
                    _domains = DataDomain.GetAll(this).ToArray();

                return _domains;
            }
        }

        /// <summary>
        ///     Gets the collection of domains that have been defined within the database.
        /// </summary>
        public DataEntity[] Entities
        {
            get
            {
                if (_entities == null)
                    _entities = DataEntity.GetAll(this).ToArray();

                return _entities;
            }
        }

        #endregion

        #region constructors

        private Database()
        {
        }

        #endregion

        #region methods

        public void RunScript(String path)
        {
            String text = File.ReadAllText(path);
            String[] batches = text.Split(new String[] { "\r\ngo\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (String batch in batches)
            {
                using (SqlConnection connection = new SqlConnection(this.Connection))
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = batch;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        ///     Loads the collection of domains and entities that have been defined within the database.
        /// </summary>
        public void Refresh()
        {
            _domains = null;
            _entities = null;
        }
        
        /// <summary>
        ///     Gets all of the database connections that have been configured for the referencing application.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Database> GetAll()
        {
            foreach (ConnectionStringSettings settings in ConfigurationManager.ConnectionStrings)
                yield return new Database() { Name = settings.Name, Connection = settings.ConnectionString };
        }
        
        internal void Execute(String script, params Object[] parameters)
        {
            // Connect to the database
            using (SqlConnection connection = new SqlConnection(this.Connection))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = Database.GetScript(script, parameters);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
        }

        internal IEnumerable<TObject> Execute<TObject, TParent>(Func<IDataRecord, TParent, TObject> parser, TParent parent, String script, params Object[] parameters)
        {
            // Connect to the database
            using (SqlConnection connection = new SqlConnection(this.Connection))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = Database.GetScript(script, parameters);
                command.CommandType = CommandType.Text;
                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader != null && !reader.IsClosed && reader.Read())
                        yield return parser.Invoke(reader, parent);
            }
        }

        internal static String GetScript(String script, Object[] parameters)
        {
            // Get the sql query from the resources that have been embedded into the assembly
            String resourceText;
            String resourceName = String.Format("CodeGenerator.DataModel.Scripts.{0}.sql", script);
            using (Stream stream = typeof(Database).Assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
                resourceText = reader.ReadToEnd();

            return String.Format(resourceText, parameters);
        }

        #endregion
    }
}
