using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    public class StoredProcProject : GeneratedProject
    {
        #region fields

        /// <summary>
        ///     The business domain from which the project is generated.
        /// </summary>
        private Domain _domain;
        
        #endregion

        #region properties

        /// <summary>
        ///     Gets the business domain from which the project is generated.
        /// </summary>
        public override Domain Domain
        {
            get { return _domain; }
        }
        

        /// <summary>
        ///     Gets the name of the generation project.
        /// </summary>
        public override String Name
        {
            get { return "Generating: " + this.FileName; }
        }

        /// <summary>
        ///     Gets the name of the generated project file.
        /// </summary>
        public override String FileName
        {
            get { return "Consensus.Entity"; }
        }

        /// <summary>
        ///     Gets the extension of the generated file
        /// </summary>
        public override String FileExtension
        {
            get { return "sqlproj"; }
        }

        /// <summary>
        ///     Gets the root namespace for the project
        /// </summary>
        public override String ProjectNamespace
        {
            get { return ""; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="StoredProcProject" /> instance.
        /// </summary>
        /// <param name="domain">
        ///     Sets the business domain from which the project is generated.
        /// </param>
        public StoredProcProject(String workingDirectory, Domain domain) : base(workingDirectory)
        {
            _domain = domain;
        }

        #endregion

        #region methods

        protected override void ExecuteTask()
        {
            base.ExecuteTask();

            // Load the project document
            XmlDocument document = new XmlDocument();
            document.Load(this.FilePath);
            XmlNamespaceManager manager = new XmlNamespaceManager(document.NameTable);
            manager.AddNamespace("vs", GeneratedProjectItem.VisualStudioNamespace);
            
            // Identify all SQL scripts included in the project
            XmlNodeList scriptNodes = document.SelectNodes("vs:Project/vs:ItemGroup/vs:*[@Include]", manager);
            String[] scriptFiles = scriptNodes.OfType<XmlNode>().Select(node => node.Attributes["Include"].Value).Where(file => String.Equals(Path.GetExtension(file), ".sql", StringComparison.OrdinalIgnoreCase)).OrderBy(file => file).ToArray();
            foreach (DomainDataSource dataSource in this.Domain.DataSources)
            {
                this.Message("Executing procedures against " + dataSource.Name);
                foreach (String scriptFile in scriptFiles)
                {
                    String filePath = Path.Combine(this.FileFolder, scriptFile);
                    String fileText = File.ReadAllText(filePath);
                    this.Message("  Running " + scriptFile);
                    dataSource.Execute(fileText);
                }
            }
        }

        protected override IEnumerable<Task> GetSubTasks()
        {
            // Identify the objects requiring generation.
            DomainContainer[] containers;
            DomainEntity[] entities;
            switch (this.Domain.GenerationMode)
            {
                default:
                    containers = this.Domain.Containers.Where(container => container.Exists).ToArray();
                    entities = this.Domain.Containers.SelectMany(container => container.ContainerEntities)
                        .Where(entity => entity.Exists && entity.GetType() == typeof(DomainEntity))
                        .OrderBy(entity => entity.Container.ContainerName)
                        .ThenBy(entity => entity.EntityName)
                        .ToArray();
                    break;
            }

            // Generate the "FetchById" procedures
            foreach (DomainEntity entity in entities)
            {
                yield return new StoredProcCreate(this, entity);
                yield return new StoredProcFetchAll(this, entity);
                yield return new StoredProcFetchById(this, entity);
                yield return new StoredProcModify(this, entity); 
                yield return new StoredProcRemoveById(this, entity);
                foreach (DomainEntityAttribute attribute in entity.Container.Domain.Containers.SelectMany(container => container.ContainerEntities).Where(ent => ent.ReferencedTable == entity.ReferencedTable && ent.Exists).SelectMany(ent => ent.EntityAttributes).Where(attr => attr.Exists && attr.ReferencedEntity != null))
                    yield return new StoredProcFetchAllByColumn(this, entity, attribute.Column); 
            }

        }

        #endregion
    }
}
