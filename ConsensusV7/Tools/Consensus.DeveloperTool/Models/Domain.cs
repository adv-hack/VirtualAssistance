using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    public class Domain : VersionData
    {
        #region fields

        /// <summary>
        ///     The current version of the domain.
        /// </summary>
        private Version _version;

        /// <summary>
        ///     The collection of tables defined within the domain.
        /// </summary>
        private List<DomainTable> _tables;

        /// <summary>
        ///     The collection of containers defined within the domain.
        /// </summary>
        private List<DomainContainer> _containers;

        /// <summary>
        ///     The collection of data sources defined for the domain.
        /// </summary>
        private List<DomainDataSource> _dataSources;

        /// <summary>
        ///     The mode of code generation required for the domain.
        /// </summary>
        private DomainGenerationModes _generationMode;

        /// <summary>
        ///     The layer of generation required for the domain.
        /// </summary>
        private DomainGenerationLayers _generationLayer;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the name of the domain.
        /// </summary>
        public String DomainName
        {
            get { return base.GetValue<String>("name"); }
            set { base.SetValue<String>("name", value); }
        }

        /// <summary>
        ///     Gets or sets the description for the domain.
        /// </summary>
        public String DomainDescription
        {
            get { return base.GetValue<String>("description"); }
            set { base.SetValue<String>("description", value); }
        }

        /// <summary>
        ///    Gets the collection of tables defined within the domain.
        /// </summary>
        public DomainTable[] Tables
        {
            get { return _tables.ToArray(); }
        }

        /// <summary>
        ///    Gets the collection of containers defined within the domain.
        /// </summary>
        public DomainContainer[] Containers
        {
            get { return _containers.ToArray(); }
        }

        /// <summary>
        ///    Gets the collection of data sources defined for the domain.
        /// </summary>
        public DomainDataSource[] DataSources
        {
            get { return _dataSources.ToArray(); }
        }

        /// <summary>
        ///    Gets the current version of the domain.
        /// </summary>
        public override Version Version
        {
            get { return _version; }
        }

        /// <summary>
        ///    Gets or sets the of code generation required for the domain.
        /// </summary>
        public DomainGenerationModes GenerationMode
        {
            get { return _generationMode; }
            set { _generationMode = value; }
        }

        /// <summary>
        ///    Gets or sets the layer of generation required for the domain.
        /// </summary>
        public DomainGenerationLayers GenerationLayer
        {
            get { return _generationLayer; }
            set { _generationLayer = value; }
        }

        #endregion

        #region constructor

        public Domain() : base(new Version(1,0,0,0,0))
        {
            _tables = new List<DomainTable>();
            _containers = new List<DomainContainer>();
            _dataSources = new List<DomainDataSource>();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Deletes the specified data source from the domain.
        /// </summary>
        public void Delete(DomainDataSource dataSource)
        {
            _dataSources.Remove(dataSource);
        }

        /// <summary>
        ///     Creates a new database table within the domain.
        /// </summary>
        public DomainTable CreateTable()
        {
            DomainTable table = new DomainTable(this);
            _tables.Add(table);
            return table;
        }

        /// <summary>
        ///     Creates a new scoping container within the domain.
        /// </summary>
        public DomainContainer CreateContainer()
        {
            DomainContainer container = new DomainContainer(this);
            _containers.Add(container);
            return container;
        }

        /// <summary>
        ///     Creates a new data source for the domain.
        /// </summary>
        public DomainDataSource CreateDataSource(Type type)
        {
            DomainDataSource datasource = type.Construct(this) as DomainDataSource;
            _dataSources.Add(datasource);
            return datasource;
        }

        /// <summary>
        ///     Changes the version of the domain.
        /// </summary>
        /// <param name="major">
        ///     Sets the major version number.
        /// </param>
        /// <param name="minor">
        ///     Sets the minor version number.
        /// </param>
        /// <param name="month">
        ///     Sets the month number.
        /// </param>
        /// <param name="patch">
        ///     Sets the patch number.
        /// </param>
        /// <param name="build">
        ///     Sets the build number.
        /// </param>
        public void ChangeVersion(UInt16 major, UInt16 minor, UInt16 release, UInt16 patch, UInt64 build)
        {
            _version = new Version(major, minor, release, patch, build);
        }

        /// <summary>
        ///     Saves the domain to the specified document
        /// </summary>
        public void Save(String filePath)
        {
            XmlDocument document = new XmlDocument();
            document.AppendChild(document.CreateXmlDeclaration("1.0", "utf-8", null));
            document.AppendChild(document.CreateElement("domain"));
            document.DocumentElement.Attributes.Append(document.CreateAttribute("version")).Value = this.Version.ToString();
            this.Serialise(document.DocumentElement);
            this.Tables.Execute(item => item.Serialise(document.DocumentElement));
            this.Containers.Execute(item => item.Serialise(document.DocumentElement));
            this.DataSources.Execute(item => item.Serialise(document.DocumentElement));
            document.Save(filePath);
        }

        /// <summary>
        ///     Loads the domain from the specified document.
        /// </summary>
        public static Domain Load(String filePath)
        {
            Domain domain = new Domain();
            if (File.Exists(filePath))
            {
                XmlDocument document = new XmlDocument();
                document.Load(filePath);
                domain._version = new Version(document.DocumentElement.Attributes["version"].Value);
                
                domain.Deserialise(document.DocumentElement);
                DomainTable.Deserialise(domain, document.DocumentElement);
                DomainContainer.Deserialise(domain, document.DocumentElement);
                DomainContainer.DeserialiseExtenders(domain, document.DocumentElement);
                DomainDataSource.Deserialise(domain, document.DocumentElement);
            }
            else
            {
                domain.ChangeVersion(7, 0, 0, 0, 0);
                domain.DomainName = "Consensus";
            }
            return domain;
        }

        #endregion
    }
}
