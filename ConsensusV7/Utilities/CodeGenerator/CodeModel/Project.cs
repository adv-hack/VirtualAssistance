using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a Microsoft Visual Studio project.
    /// </summary>
    [Serializable]
    public abstract class Project
    {
        #region fields

        /// <summary>
        ///     The namespace used within the visual studio project files
        /// </summary>
        private const String VsNamespace = @"http://schemas.microsoft.com/developer/msbuild/2003";

        /// <summary>
        ///     The targeted framework version
        /// </summary>
        private const String DotNetVersion = "4.5";

        /// <summary>
        ///     The instance of the xml document for the project
        /// </summary>
        private XmlDocument _xmlDocument;  

        /// <summary>
        ///     The instance of the xml namespace manager for the project
        /// </summary>
        private XmlNamespaceManager _xmlManager;

        /// <summary>
        ///     The types to be included within the project.
        /// </summary>
        private List<ProjectItem> _projectTypes;

        /// <summary>
        ///     The parent solution within which, the project is location.
        /// </summary>
        private ProjectSolution _solution;
        
        #endregion

        #region properties

        /// <summary>
        ///     Gets the parent solution within which, the project is location.
        /// </summary>
        public ProjectSolution Solution
        {
            get { return _solution; }
        }

        /// <summary>
        ///     Gets the name of the project.
        /// </summary>
        public abstract String ProjectName { get; }

        /// <summary>
        ///     Gets the namespace for the project
        /// </summary>
        public abstract String ProjectNamespace
        {
            get;
        }

        /// <summary>
        ///     Gets the full path of the project folder.
        /// </summary>
        public virtual String ProjectFolder
        {
            get { return Path.Combine(this.Solution.SolutionPath, this.ProjectName); }
        }

        /// <summary>
        ///     Gets the xml document for the project.
        /// </summary>
        protected XmlDocument ProjectFile
        {
            get { return _xmlDocument; }
        }

        /// <summary>
        ///     Gets the collection of project references.
        /// </summary>
        public virtual IEnumerable<String> ProjectReferences
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the types defined within the project.
        /// </summary>
        public List<ProjectItem> ProjectTypes
        {
            get
            {
                if (_projectTypes == null)
                    _projectTypes = new List<ProjectItem>();

                return _projectTypes;
            }
        }

        /// <summary>
        ///     Gets the name of the project file.
        /// </summary>
        public String FileName
        {
            get { return this.ProjectName + "." + this.FileExtension; }
        }

        /// <summary>
        ///     Gets the full path of the project file.
        /// </summary>
        public String FilePath
        {
            get { return Path.Combine(this.ProjectFolder, this.FileName); }
        }

        /// <summary>
        ///     Gets the extension used for the project file.
        /// </summary>
        public abstract String FileExtension { get; }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="Project" /> instance.
        /// </summary>
        public Project(ProjectSolution solution)
        {
            // Link the project and the solution
            _solution = solution;
            if (!_solution.Projects.Contains(this))
                _solution.Projects.Add(this);

            // Ensure the project file exists
            if (!Directory.Exists(this.ProjectFolder))
                Directory.CreateDirectory(this.ProjectFolder);
            if (!File.Exists(this.FilePath))
                this.Initialise();

            // Load the project document
            _xmlDocument = new XmlDocument();
            _xmlDocument.Load(this.FilePath);
            
            // Initialise the project document namespace
            _xmlManager = new XmlNamespaceManager(_xmlDocument.NameTable);
            _xmlManager.AddNamespace("vs", Project.VsNamespace);
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates the initial project file.
        /// </summary>
        private void Initialise()
        {
            XmlDocument document = new XmlDocument();
            document.AppendChild(document.CreateXmlDeclaration("1.0", "utf-8", null));

            XmlNode projectNode = document.AppendChild(document.CreateElement("Project"));
            projectNode.Attributes.Append(document.CreateAttribute("DefaultTargets")).Value = "Build";
            projectNode.Attributes.Append(document.CreateAttribute("xmlns")).Value = "http://schemas.microsoft.com/developer/msbuild/2003";
            projectNode.Attributes.Append(document.CreateAttribute("ToolsVersion")).Value = "12.0";

            XmlNode importBuild = projectNode.AppendChild(document.CreateElement("Import"));
            importBuild.Attributes.Append(document.CreateAttribute("Project")).Value = "$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props";
            importBuild.Attributes.Append(document.CreateAttribute("Condition")).Value = "Exists('$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props')";

            XmlNode mainPropertyGroup = projectNode.AppendChild(document.CreateElement("PropertyGroup"));
            mainPropertyGroup.AppendChild(document.CreateElement("ProjectGuid")).InnerText = Guid.NewGuid().ToString();
            mainPropertyGroup.AppendChild(document.CreateElement("OutputType")).InnerText = "Library";
            mainPropertyGroup.AppendChild(document.CreateElement("RootNamespace")).InnerText = (this is ProjectCSharp ? (this as ProjectCSharp).ProjectNamespace : this.Solution.SolutionName);
            mainPropertyGroup.AppendChild(document.CreateElement("AssemblyName")).InnerText = this.ProjectName;
            mainPropertyGroup.AppendChild(document.CreateElement("TargetFrameworkVersion")).InnerText = "v4.5";

            XmlNode mainConfiguration = mainPropertyGroup.AppendChild(document.CreateElement("Configuration"));
            mainConfiguration.Attributes.Append(document.CreateAttribute("Condition")).Value = " '$(Configuration)' == '' ";
            mainConfiguration.InnerText = "Debug";

            XmlNode mainPlatform = mainPropertyGroup.AppendChild(document.CreateElement("Platform"));
            mainPlatform.Attributes.Append(document.CreateAttribute("Condition")).Value = " '$(Platform)' == '' ";
            mainPlatform.InnerText = "AnyCPU";

            XmlNode debugPropertyGroup = projectNode.AppendChild(document.CreateElement("PropertyGroup"));
            debugPropertyGroup.Attributes.Append(document.CreateAttribute("Condition")).Value = " '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ";
            debugPropertyGroup.AppendChild(document.CreateElement("DebugSymbols")).InnerText = "true";
            debugPropertyGroup.AppendChild(document.CreateElement("DebugType")).InnerText = "full";
            debugPropertyGroup.AppendChild(document.CreateElement("Optimize")).InnerText = "false";
            debugPropertyGroup.AppendChild(document.CreateElement("OutputPath")).InnerText = "bin\\debug\\";
            debugPropertyGroup.AppendChild(document.CreateElement("DefineConstants")).InnerText = "DEBUG;TRACE";
            debugPropertyGroup.AppendChild(document.CreateElement("ErrorReport")).InnerText = "prompt";
            debugPropertyGroup.AppendChild(document.CreateElement("WarningLevel")).InnerText = "4";
            debugPropertyGroup.AppendChild(document.CreateElement("DocumentationFile")).InnerText = "..\\..\\documentation\\" + this.ProjectName.ToLower() + ".xml";

            XmlNode releasePropertyGroup = projectNode.AppendChild(document.CreateElement("PropertyGroup"));
            releasePropertyGroup.Attributes.Append(document.CreateAttribute("Condition")).Value = " '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ";
            releasePropertyGroup.AppendChild(document.CreateElement("DebugSymbols")).InnerText = "false";
            releasePropertyGroup.AppendChild(document.CreateElement("DebugType")).InnerText = "none";
            releasePropertyGroup.AppendChild(document.CreateElement("Optimize")).InnerText = "true";
            releasePropertyGroup.AppendChild(document.CreateElement("OutputPath")).InnerText = "bin\\release\\";
            releasePropertyGroup.AppendChild(document.CreateElement("DefineConstants")).InnerText = "TRACE";
            releasePropertyGroup.AppendChild(document.CreateElement("ErrorReport")).InnerText = "prompt";
            releasePropertyGroup.AppendChild(document.CreateElement("WarningLevel")).InnerText = "4";
            releasePropertyGroup.AppendChild(document.CreateElement("DocumentationFile")).InnerText = "..\\..\\documentation\\" + this.ProjectName.ToLower() + ".xml";

            XmlNode importNode2 = projectNode.AppendChild(document.CreateElement("Import"));
            importNode2.Attributes.Append(document.CreateAttribute("Project")).Value = "$(MSBuildToolsPath)\\Microsoft.CSharp.targets";
            importNode2.Attributes.Append(document.CreateAttribute("Condition")).Value = "Exists('$(MSBuildToolsPath)\\Microsoft.CSharp.targets')";

            XmlNode itemGroup = projectNode.AppendChild(document.CreateElement("ItemGroup"));
            itemGroup.AppendChild(document.CreateElement("Reference")).Attributes.Append(document.CreateAttribute("Include")).Value = "System";
            itemGroup.AppendChild(document.CreateElement("Reference")).Attributes.Append(document.CreateAttribute("Include")).Value = "System.Core";
            itemGroup.AppendChild(document.CreateElement("Reference")).Attributes.Append(document.CreateAttribute("Include")).Value = "System.Data";
            itemGroup.AppendChild(document.CreateElement("Reference")).Attributes.Append(document.CreateAttribute("Include")).Value = "System.Xml";
            itemGroup.AppendChild(document.CreateElement("Reference")).Attributes.Append(document.CreateAttribute("Include")).Value = "System.Xml.Linq";

            if (this.ProjectReferences != null)
                foreach (String reference in this.ProjectReferences)
                    this.AddReference(itemGroup, reference);
            
            document.Save(this.FilePath);
        }

        /// <summary>
        ///     Adds a programmatic reference to the project.
        /// </summary>
        /// <param name="parentNode">
        ///     The xml node to which the reference will be added.
        /// </param>
        /// <param name="reference">
        ///     The name of the Microsoft.NET framework library that is referenced, or the relative path to a DLL or project file.
        /// </param>
        private void AddReference(XmlNode parentNode, String reference)
        {
            if (String.Equals(Path.GetExtension(reference), ".dll", StringComparison.OrdinalIgnoreCase))
            {
                // Load the referenced assembly
                String absolutePath = new FileInfo(Path.Combine(this.ProjectFolder, reference)).FullName;
                String assemblyName = AssemblyName.GetAssemblyName(absolutePath).FullName;

                // Add the reference node
                XmlNode referenceNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("Reference"));
                referenceNode.Attributes.Append(parentNode.OwnerDocument.CreateAttribute("Include")).Value = assemblyName;
                referenceNode.AppendChild(parentNode.OwnerDocument.CreateElement("HintPath")).InnerText = reference;
            }
            else if (!reference.StartsWith("."))
            {
                // Add the reference node
                XmlNode referenceNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("Reference"));
                referenceNode.Attributes.Append(parentNode.OwnerDocument.CreateAttribute("Include")).Value = reference;
            }
            else
            {
                // Add the reference node
                XmlNode referenceNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("ProjectReference"));
                referenceNode.Attributes.Append(parentNode.OwnerDocument.CreateAttribute("Include")).Value = reference;

                // Load the referenced project
                XmlDocument referenceDocument = new XmlDocument();
                referenceDocument.Load(Path.Combine(this.ProjectFolder, reference));

                // Initialise the Visual Studio namespace
                XmlNamespaceManager referenceManager = new XmlNamespaceManager(referenceDocument.NameTable);
                referenceManager.AddNamespace("vs", Project.VsNamespace);

                // Get the project identifiers and add to the project reference node
                referenceNode.AppendChild(parentNode.OwnerDocument.CreateElement("Project")).InnerText = referenceDocument.SelectSingleNode("vs:Project/vs:PropertyGroup/vs:ProjectGuid", referenceManager).InnerText;
                referenceNode.AppendChild(parentNode.OwnerDocument.CreateElement("Name")).InnerText = referenceDocument.SelectSingleNode("vs:Project/vs:PropertyGroup/vs:AssemblyName", referenceManager).InnerText;
            }
        }

        /// <summary>
        ///     Generates the content for all types included within the project and adds each generated type to the project file.
        /// </summary>
        public void Save()
        {
            XmlNode groupNode = this.ProjectFile.SelectSingleNode("vs:Project/vs:ItemGroup", _xmlManager);
            foreach (ProjectItem projectType in this.ProjectTypes)
            {
                String typePath = Path.Combine(projectType.FileFolder, projectType.FileName);

                // Ensure the generated type is included within the project file
                String itemXPath = String.Format("vs:*[@Include='{0}']", typePath);
                XmlNode itemNode = groupNode.SelectSingleNode(itemXPath, _xmlManager);
                if (itemNode != null && !String.Equals(itemNode.Name, projectType.BuildAction.ToString()))
                    itemNode.ParentNode.RemoveChild(itemNode);
                if (itemNode == null || !String.Equals(itemNode.Name, projectType.BuildAction.ToString()))
                {
                    itemNode = groupNode.AppendChild(this.ProjectFile.CreateElement(projectType.BuildAction.ToString(), Project.VsNamespace));
                    itemNode.Attributes.Append(this.ProjectFile.CreateAttribute("Include")).Value = typePath;
                }                

                // Ensure the generated type is nested or un-nested, as required
                XmlNode nestNode = itemNode.SelectSingleNode("vs:DependentUpon", _xmlManager);
                if (!String.IsNullOrEmpty(projectType.FileNesting) && nestNode == null)
                    itemNode.AppendChild(this.ProjectFile.CreateElement("DependentUpon", Project.VsNamespace)).InnerText = projectType.FileNesting;
                else if (String.IsNullOrEmpty(projectType.FileNesting) && nestNode != null)
                    itemNode.RemoveChild(nestNode);
            }

            // Save the project file.
            this.ProjectFile.Save(this.FilePath);
        }

        #endregion
    }
}
