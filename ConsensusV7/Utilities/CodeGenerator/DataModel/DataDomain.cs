using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.DataModel
{
    /// <summary>
    ///     Represents a domain or namespace
    /// </summary>
    [Serializable]
    public class DataDomain
    {
        #region fields

        /// <summary>
        ///     The collection of entities which belong to this domain.
        /// </summary>
        private DataEntity[] _entities;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the database in which the domain is defined.
        /// </summary>
        internal Database Parent { get; private set; }

        /// <summary>
        ///     Gets or sets the unique identifier for the domain
        /// </summary>
        public String Identifier { get; set; }

        /// <summary>
        ///     Gets or sets the name of the domain
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        ///     Gets or sets the name of the domain
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        ///     Gets the collection of entities which belong to this domain.
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

        /// <summary>
        ///     Initialises a new domain within the data model.
        /// </summary>
        /// <param name="parent">
        ///     The database in which the domain is configured.
        /// </param>
        public DataDomain(Database parent)
        {
            this.Parent = parent;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Saves changes to the domain
        /// </summary>
        public void Save()
        {
            this.Parent.Execute("SaveDomain", this.Identifier, this.Name, this.Description);
        }

        /// <summary>
        ///     Constructs a new <see cref="DataDomain"/> instance from an <see cref="IDataRecord"/>.
        /// </summary>
        /// <param name="record">
        ///     The data record which holds the information that describes this domain.
        /// </param>
        /// <param name="database">
        ///     The parent database, in which the domain is defined.
        /// </param>
        /// <returns>
        ///     An initialised <see cref="DataDomain"/> instance.
        /// </returns>
        private static DataDomain Parse(IDataRecord record, Database database)
        {
            return new DataDomain(database)
            {
                Identifier = record["Identifier"].ConvertTo<String>(),
                Name = record["Name"].ConvertTo<String>(),
                Description = record["Description"].ConvertTo<String>()
            };
        }

        /// <summary>
        ///     Gets all domains from the database.
        /// </summary>
        /// <param name="database">
        ///     The database in which the domains are defined.
        /// </param>
        /// <returns>
        ///     An enumerable collection of <see cref="DataDomain"/> instances.
        /// </returns>
        public static IEnumerable<DataDomain> GetAll(Database database)
        {
            return database.Execute(DataDomain.Parse, database, "GetDomain");
        }

        #endregion
    }
}
