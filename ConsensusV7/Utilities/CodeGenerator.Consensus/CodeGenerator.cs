using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using Microsoft.Build.Execution;
using Microsoft.Build.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Type = System.Type;
using CodeType = CodeGenerator.CodeModel.Type;
using Microsoft.Build.Framework;
using System.Data.SqlClient;
using System.Data;

namespace CodeGenerator
{
    [Serializable]
    public class CodeGenerator
    {
        #region delegates

        /// <summary>
        ///     The delegate for code generator events
        /// </summary>
        public delegate void CodeGeneratorEvent(String message);

        #endregion

        #region properties

        /// <summary>
        ///     The database that the code is generated for
        /// </summary>
        public readonly Database CurrentDatabase;

        /// <summary>
        ///     The solution that the code is generator for
        /// </summary>
        public readonly ProjectSolution CurrentSolution;

        /// <summary>
        ///     Specifies if the static base types are also generated.
        /// </summary>
        public readonly Boolean GenerateBaseTypes;

        public Boolean ExecuteEntity;

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new code generator
        /// </summary>
        public CodeGenerator(Database database, ProjectSolution solution, Boolean generateBaseTypes)
        {
            this.CurrentDatabase = database;
            this.CurrentSolution = solution;
            this.GenerateBaseTypes = generateBaseTypes;
        }

        #endregion

        #region generation methods

        public void GenerateConsensusEntity()
        {
            IEnumerable<DataEntity> entityCollection = this.CurrentDatabase.Domains.SelectMany(domain => domain.Entities);
            Project project = this.GenerateProject<Consensus.Entity.GeneratedProject>();
            this.GenerateType<Consensus.Entity.GeneratedSelectAll, DataEntity>(project, entityCollection);
            this.GenerateType<Consensus.Entity.GeneratedSelectById, DataEntity>(project, entityCollection);
            this.GenerateType(project);

            if (this.ExecuteEntity)
                foreach (ProjectItem item in project.ProjectTypes)
                    this.CurrentDatabase.RunScript(item.FilePath);
        }

        public void GenerateConsensusData()
        {
            IEnumerable<DataDomain> domainCollection = this.CurrentDatabase.Domains;
            IEnumerable<DataEntity> entityCollection = this.CurrentDatabase.Domains.SelectMany(domain => domain.Entities);

            // Get the Consensus.Data Project
            Project project = this.GenerateProject<Consensus.Data.GeneratedProject>();

            // Generate the base types
            if (this.GenerateBaseTypes)
            {
                this.GenerateType<Consensus.Data.GeneratedDataOperation>(project);
                this.GenerateType<Consensus.Data.GeneratedRepositoryCollection>(project);
                this.GenerateType<Consensus.Data.GeneratedRepository>(project);
                this.GenerateType<Consensus.Data.GeneratedRepositoryOfTRecord>(project);
                this.GenerateType<Consensus.Data.GeneratedRepositoryOfTRecordTKey>(project);
                this.GenerateType<Consensus.Data.GeneratedRecord>(project);
                this.GenerateType<Consensus.Data.GeneratedRecordOfTKey>(project);
            }

            // Generate the entity-driven types
            this.GenerateType<Consensus.Data.GeneratedDataProvider>(project, domainCollection);
            this.GenerateType<Consensus.Data.GeneratedRepositoryCollectionX, DataDomain>(project, domainCollection);
            this.GenerateType<Consensus.Data.GeneratedRecordX, DataEntity>(project, entityCollection);
            this.GenerateType<Consensus.Data.BlankRepository, DataEntity>(project, entityCollection);

            // Execute the generation process
            this.GenerateType(project);
        }

        public void GenerateConsensusDataSqlServer()
        {
            IEnumerable<DataDomain> domainCollection = this.CurrentDatabase.Domains;
            IEnumerable<DataEntity> entityCollection = this.CurrentDatabase.Domains.SelectMany(domain => domain.Entities);

            // Get the Consensus.Data.SqlServer Project
            Project project = this.GenerateProject<Consensus.Data.SqlServer.GeneratedProject>();

            // Generate the base types
            if (this.GenerateBaseTypes)
            {
                this.GenerateType<Consensus.Data.SqlServer.GeneratedRepositoryCollection>(project);
                this.GenerateType<Consensus.Data.SqlServer.GeneratedRepository>(project);
                this.GenerateType<Consensus.Data.SqlServer.GeneratedRepositoryOfTRecord>(project);
                this.GenerateType<Consensus.Data.SqlServer.GeneratedRepositoryOfTRecordTKey>(project);
            }

            // Generate the entity-driven types
            this.GenerateType<Consensus.Data.SqlServer.GeneratedDataProvider>(project, domainCollection);
            this.GenerateType<Consensus.Data.SqlServer.GeneratedRepositoryCollectionX, DataDomain>(project, domainCollection);
            this.GenerateType<Consensus.Data.SqlServer.GeneratedRepositoryX, DataEntity>(project, entityCollection);
            this.GenerateType<Consensus.Data.SqlServer.BlankRepository, DataEntity>(project, entityCollection);

            // Execute the generation process
            this.GenerateType(project);
        }

        public void GenerateConsensusDataInterfaces()
        {
            // Compile the Consensus.Data.SqlServer Project to drive the generation of the Consensus.Data project
            Project project1 = this.GenerateProject<Consensus.Data.GeneratedProject>();
            Project project2 = this.GenerateProject<Consensus.Data.SqlServer.GeneratedProject>();
            Type[] runtimeTypes = this.CompileProject(project2);
            
            // Get the data sources for the type generation
            IEnumerable<DataEntity> entityCollection = this.CurrentDatabase.Domains.SelectMany(domain => domain.Entities);
            IEnumerable<Tuple<DataEntity, Type>> tupleCollection = entityCollection.Join(runtimeTypes, entity => "SqlServer" + entity.CodeName + "Repository", type => type.Name, (entity, type) => new Tuple<DataEntity, Type>(entity, type));

            // Generate the entity/runtime-type driven types
            this.GenerateType<Consensus.Data.GeneratedRepositoryX, Tuple<DataEntity, Type>>(project1, tupleCollection);
            this.GenerateType(project1);
        }

        public void GenerateConsensusBusiness()
        {
            IEnumerable<DataDomain> domainCollection = this.CurrentDatabase.Domains;
            IEnumerable<DataEntity> entityCollection = this.CurrentDatabase.Domains.SelectMany(domain => domain.Entities);

            // Get the Consensus.Business Project
            Project project = this.GenerateProject<Consensus.Business.GeneratedProject>();

            // Generate the base types
            if (this.GenerateBaseTypes)
            {
                this.GenerateType<Consensus.Business.GeneratedModel>(project);
                this.GenerateType<Consensus.Business.GeneratedModelEditable>(project);
                this.GenerateType<Consensus.Business.GeneratedModelRemovable>(project);
                this.GenerateType<Consensus.Business.GeneratedModelOfTKey>(project);
                this.GenerateType<Consensus.Business.GeneratedFactory>(project);
                this.GenerateType<Consensus.Business.GeneratedFactoryOfTModel>(project);
                this.GenerateType<Consensus.Business.GeneratedFactoryOfTModelTKey>(project);
                this.GenerateType<Consensus.Business.GeneratedFactoryCollection>(project);
                this.GenerateType<Consensus.Business.GeneratedProxy>(project);
                this.GenerateType<Consensus.Business.GeneratedProxyOfTModel>(project);
                this.GenerateType<Consensus.Business.GeneratedProxyOfTModelTKey>(project);
            }

            // Generate blank interfaces (these will be populated later)
            this.GenerateType<Consensus.Business.BlankBusinessProvider>(project, domainCollection);
            this.GenerateType<Consensus.Business.BlankBusinessFactoryCollection, DataDomain>(project, domainCollection);
            this.GenerateType<Consensus.Business.BlankFactory, DataEntity>(project, entityCollection);
            this.GenerateType<Consensus.Business.BlankModel, DataEntity>(project, entityCollection);
            this.GenerateType<Consensus.Business.BlankProxy, DataEntity>(project, entityCollection);

            // Execute the generation process
            this.GenerateType(project);
        }

        public void GenerateConsensusBusinessLogic()
        {
            IEnumerable<DataDomain> domainCollection = this.CurrentDatabase.Domains;
            IEnumerable<DataEntity> entityCollection = this.CurrentDatabase.Domains.SelectMany(domain => domain.Entities);

            // Get the Consensus.Business.Logic Project
            Project project = this.GenerateProject<Consensus.Business.Logic.GeneratedProject>();

            // Generate the base types
            if (this.GenerateBaseTypes)
            {
                this.GenerateType<Consensus.Business.Logic.GeneratedModel>(project);
                this.GenerateType<Consensus.Business.Logic.GeneratedModelOfTRecord>(project);
                this.GenerateType<Consensus.Business.Logic.GeneratedModelOfTRecordTKey>(project);
                this.GenerateType<Consensus.Business.Logic.GeneratedFactory>(project);
                this.GenerateType<Consensus.Business.Logic.GeneratedFactoryOfTModel>(project);
                this.GenerateType<Consensus.Business.Logic.GeneratedFactoryOfTModelTKey>(project);
                this.GenerateType<Consensus.Business.Logic.GeneratedFactoryCollection>(project);
            }

            // Generate the entity-driven types
            this.GenerateType<Consensus.Business.Logic.GeneratedBusinessProvider>(project, domainCollection);
            this.GenerateType<Consensus.Business.Logic.GeneratedFactoryCollectionX, DataDomain>(project, domainCollection);
            this.GenerateType<Consensus.Business.Logic.GeneratedFactoryX, DataEntity>(project, entityCollection);
            this.GenerateType<Consensus.Business.Logic.GeneratedModelX, DataEntity>(project, entityCollection);
            this.GenerateType<Consensus.Business.Logic.BlankFactory, DataEntity>(project, entityCollection);
            this.GenerateType<Consensus.Business.Logic.BlankModel, DataEntity>(project, entityCollection);

            // Execute the generation process
            this.GenerateType(project);
        }

        public void GenerateConsensusBusinessInterfaces()
        {
            // Compile the Consensus.Business.Logic Project to drive the generation of the Consensus.Business project
            Project project1 = this.GenerateProject<Consensus.Business.GeneratedProject>();
            Project project2 = this.GenerateProject<Consensus.Business.Logic.GeneratedProject>();
            Type[] runtimeTypes = this.CompileProject(project2);
            if (runtimeTypes == null)
                throw new InvalidOperationException(project2.ProjectName + " did not compile");

            // Populate the blank interfaces
            this.GenerateType<Consensus.Business.GeneratedBusinessProvider>(project1, runtimeTypes.FirstOrDefault(type => !type.IsAbstract && type.Implements("BusinessProvider")));
            this.GenerateType<Consensus.Business.GeneratedFactoryCollectionX, Type>(project1, runtimeTypes.Where(type => !type.IsAbstract && type.Implements("FactoryCollection")));
            this.GenerateType<Consensus.Business.GeneratedFactoryX, Type>(project1, runtimeTypes.Where(type => !type.IsAbstract && type.Implements("Factory")));
            this.GenerateType<Consensus.Business.GeneratedModelX, Type>(project1, runtimeTypes.Where(type => !type.IsAbstract && type.Implements("Model")));
            this.GenerateType<Consensus.Business.GeneratedProxyX, Type>(project1, runtimeTypes.Where(type => !type.IsAbstract && type.Implements("Factory")));
            this.GenerateType(project1);
        }

        public void GenerateConsensusBusinessImplementors()
        {
            // Regenerate the business logic layer
            IEnumerable<DataDomain> domainCollection = this.CurrentDatabase.Domains;
            IEnumerable<DataEntity> entityCollection = this.CurrentDatabase.Domains.SelectMany(domain => domain.Entities);
            Project project2 = this.GenerateProject<Consensus.Business.Logic.GeneratedProject>();
            if (this.GenerateBaseTypes)
            {
                this.GenerateType<Consensus.Business.Logic.GeneratedModel>(project2);
                this.GenerateType<Consensus.Business.Logic.GeneratedModelOfTRecord>(project2);
                this.GenerateType<Consensus.Business.Logic.GeneratedModelOfTRecordTKey>(project2);
                this.GenerateType<Consensus.Business.Logic.GeneratedFactory>(project2);
                this.GenerateType<Consensus.Business.Logic.GeneratedFactoryOfTModel>(project2);
                this.GenerateType<Consensus.Business.Logic.GeneratedFactoryOfTModelTKey>(project2);
                this.GenerateType<Consensus.Business.Logic.GeneratedFactoryCollection>(project2);
            }
            this.GenerateType<Consensus.Business.Logic.GeneratedBusinessProvider>(project2, domainCollection);
            this.GenerateType<Consensus.Business.Logic.GeneratedFactoryCollectionX, DataDomain>(project2, domainCollection);
            this.GenerateType<Consensus.Business.Logic.GeneratedFactoryX, DataEntity>(project2, entityCollection);
            this.GenerateType<Consensus.Business.Logic.GeneratedModelX, DataEntity>(project2, entityCollection);
            this.GenerateType<Consensus.Business.Logic.BlankFactory, DataEntity>(project2, entityCollection);
            this.GenerateType<Consensus.Business.Logic.BlankModel, DataEntity>(project2, entityCollection);

            // Compile the interface library for the business logic layer
            Project project1 = this.GenerateProject<Consensus.Business.GeneratedProject>();
            Type[] runtimeTypes = this.CompileProject(project1);           
            project2.ProjectTypes.OfType<Consensus.Business.Logic.GeneratedBusinessProvider>().ToList().ForEach(type => type.InterfaceLibrary = runtimeTypes);
            project2.ProjectTypes.OfType<Consensus.Business.Logic.GeneratedFactoryCollectionX>().ToList().ForEach(type => type.InterfaceLibrary = runtimeTypes);
            project2.ProjectTypes.OfType<Consensus.Business.Logic.GeneratedFactoryX>().ToList().ForEach(type => type.InterfaceLibrary = runtimeTypes);
            project2.ProjectTypes.OfType<Consensus.Business.Logic.GeneratedModelX>().ToList().ForEach(type => type.InterfaceLibrary = runtimeTypes);
            this.GenerateType(project2);
        }

        #endregion

        #region helper methods

        private void GenerateType<TType>(Project project) where TType : ProjectItem, new()
        {
            this.GenerateType<TType>(project, null);
        }

        private void GenerateType<TType>(Project project, Object dataSource) where TType : ProjectItem, new()
        {
            // Create the new type
            TType type = new TType();
            type.ParentProject = project;
            type.DataSource = dataSource;

            // Remove any existing type that may be replaced with the current type
            ProjectItem[] redundantTypes = project.ProjectTypes.Where(existing => existing.FilePath == type.FilePath).ToArray();
            foreach (ProjectItem redundantType in redundantTypes)
                project.ProjectTypes.Remove(redundantType);

            // Add the type to the project
            project.ProjectTypes.Add(type);
        }

        private void GenerateType<TType, TData>(Project project, IEnumerable<TData> dataSource) where TType : ProjectItem, new()
        {
            if (dataSource != null)
                foreach (TData dataItem in dataSource)
                    if (!project.ProjectTypes.OfType<TType>().Any(type => type.DataSource == dataSource))
                        this.GenerateType<TType>(project, dataItem);
        }

        private void GenerateType(Project project)
        {
            // Loop through each type and generate
            ProjectItem[] types = project.ProjectTypes.OrderBy(type => type.FileFolder).ThenBy(type => type.FileName).ToArray();
            foreach (ProjectItem type in types)
            {
                this.LogGeneratorMessage(type.FilePath.Substring(this.CurrentSolution.SolutionPath.Length));
                type.Generate();
            }

            // Save the project
            project.Save();
        }

        private TProject GenerateProject<TProject>() where TProject : Project
        {
            // Get the existing project from the solution
            TProject project = this.CurrentSolution.Projects.OfType<TProject>().FirstOrDefault();

            // If the project does not exist yet, add a new project to the solution
            if (project == null)
                project = Activator.CreateInstance(typeof(TProject), new Object[] { this.CurrentSolution }) as TProject;

            return project;
        }

        private Type[] CompileProject(Project project)
        {
            Type[] result = null;
            
            IDictionary<String, String> buildProperties = new Dictionary<String, String>();
            buildProperties.Add("Configuration", "Generate");
            
            // Execute MSBuild to compile the project 
            ConsoleLogger buildLogger = new ConsoleLogger(LoggerVerbosity.Normal, new WriteHandler(this.LogCompilerMessage), null, null);
            BuildRequestData buildRequest = new BuildRequestData(project.FilePath, buildProperties, null, new String[] { "Clean", "Build" }, null);
            BuildParameters buildParameters = new BuildParameters() { DetailedSummary = false, OnlyLogCriticalEvents = false, Loggers = new List<ILogger>() { buildLogger } };
            TargetResult buildResult = BuildManager.DefaultBuildManager.Build(buildParameters, buildRequest).ResultsByTarget["Build"];
            if (buildResult.ResultCode == TargetResultCode.Success)
            {
                String outputFile = buildResult.Items[0].GetMetadata("FullPath");
                String outputPath = Path.GetDirectoryName(outputFile);
                String outputName = AssemblyName.GetAssemblyName(outputFile).FullName;

                // Copy the output libraries to the current working directory
                String[] files = Directory.GetFiles(outputPath, "*.dll");
                foreach (String file in files)
                {
                    String fileName = Path.GetFileName(file);
                    String filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                    File.Copy(file, filePath, true);

                    this.LogTemporaryFile(filePath);
                }

                // Load the types from the assembly
                result = Assembly.Load(outputName).GetTypes();
            }

            return result;
        }

        private void LogGeneratorMessage(String message)
        {
            if (this.LogGenerator != null)
                this.LogGenerator.Invoke(message);
        }

        private void LogCompilerMessage(String message)
        {
            if (this.LogCompiler != null)
                this.LogCompiler.Invoke(message);
        }

        private void LogTemporaryFile(String path)
        {
            if (this.LogFile != null)
                this.LogFile.Invoke(path);
        }

        #endregion

        #region events

        /// <summary>
        ///     Fires for each output message that is broadcasted by the code generator
        /// </summary>
        public event CodeGeneratorEvent LogGenerator;

        /// <summary>
        ///     Fires for each output message that is broadcasted by the code compiler
        /// </summary>
        public event CodeGeneratorEvent LogCompiler;

        /// <summary>
        ///     Fires for each temporary file that is created
        /// </summary>
        public event CodeGeneratorEvent LogFile;

        #endregion
    }
}
