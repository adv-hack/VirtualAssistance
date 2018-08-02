using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    public abstract class DomainDataSource
    {
        #region fields

        /// <summary>
        ///     The domain instance in which the data source is defined.
        /// </summary>
        private Domain _domain;

        /// <summary>
        ///     The globally unique identifier for the data source.
        /// </summary>
        private Guid _guid;

        /// <summary>
        ///     The name of the data source
        /// </summary>
        private String _name;

        /// <summary>
        ///     The description for the data source.
        /// </summary>
        private String _description;

        /// <summary>
        ///     The connection string, which specifies the location and credentials of the development database.
        /// </summary>
        private String _connectionString;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain instance in which the database is defined.
        /// </summary>
        public Domain Domain
        {
            get { return _domain; }
        }

        /// <summary>
        ///     Gets the globally unique identifier for the data source.
        /// </summary>
        public Guid Guid
        {
            get { return _guid; }
            private set { _guid = value; }
        }

        /// <summary>
        ///     Gets or sets the name of the data source
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     Gets or sets the description for the data source
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     Gets or sets the connection string, which specifies the location and credentials of the development database.
        /// </summary>
        public String ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = String.IsNullOrEmpty(value) ? null : this.FormatConnection(value); }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="DomainDataSource" /> instance.
        /// </summary>
        internal DomainDataSource(Domain domain)
        {
            _guid = Guid.NewGuid();
            _domain = domain;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the list of tables that have been defined in the database.
        /// </summary>
        public abstract String[] GetTables();

        /// <summary>
        ///     Imports a table into the domain.
        /// </summary>
        /// <param name="tableName">
        ///     The name of the table.
        /// </param>
        /// <returns>
        ///     The imported table.
        /// </returns>
        public abstract DomainTable ImportTable(String tableName);
        
        /// <summary>
        ///     Parses the specified connection string through a platform-specific connection builder to apply platform-specific formatting.
        /// </summary>
        /// <param name="connectionString">
        ///     The pre-formatted connection string.
        /// </param>
        /// <returns>
        ///     The formatted connection string.
        /// </returns>
        public abstract String FormatConnection(String connectionString);
        
        /// <summary>
        ///     Executes a simple command which obtains the current date and time from the data-source server.
        /// </summary>
        /// <returns>
        ///     The exception which prevented the command from executing, or null if the command executed successfully.
        /// </returns>
        public abstract Exception TestConnection();

        /// <summary>
        ///     Executes a sql statement against the database.
        /// </summary>
        public abstract void Execute(String sqlStatement);

        /// <summary>
        ///     Serialises this <see cref="Database" /> instance into an xml element.
        /// </summary>
        /// <param name="parentNode">
        ///     The xml element, into which the instance is serialised.
        /// </param>
        internal void Serialise(XmlNode parentNode)
        {
            XmlNode node = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("dataSource"));
            node.Attributes.Append(node.OwnerDocument.CreateAttribute("guid")).Value = this.Guid.ToString();
            node.AppendChild(node.OwnerDocument.CreateElement("type")).InnerText = this.GetType().FullName;
            node.AppendChild(node.OwnerDocument.CreateElement("name")).InnerText = this.Name;
            node.AppendChild(node.OwnerDocument.CreateElement("description")).InnerText = this.Description;
            node.AppendChild(node.OwnerDocument.CreateElement("connection")).InnerText = this.ConnectionString;
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal static void Deserialise(Domain domain, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("dataSource"))
            {
                DomainDataSource result = domain.CreateDataSource(Type.GetType(xmlNode.SelectSingleNode("type").InnerText));
                result.Guid = xmlNode.Attributes["guid"].Value.ConvertTo<Guid>();
                result.Name = xmlNode.SelectSingleNode("name").InnerText;
                result.Description = xmlNode.SelectSingleNode("description").InnerText;
                result.ConnectionString = xmlNode.SelectSingleNode("connection").InnerText;
            }
        }

        #endregion
    }
}
