using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents an item within a generated project.
    /// </summary>
    public abstract class GeneratedProjectItem : GeneratedFile
    {
        #region fields

        /// <summary>
        ///     The namespace for the visual studio project file.
        /// </summary>
        public const String VisualStudioNamespace = "http://schemas.microsoft.com/developer/msbuild/2003";

        /// <summary>
        ///     The generated project in which the project item is included.
        /// </summary>
        private GeneratedProject _project;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the generated project in which the project item is included.
        /// </summary>
        public GeneratedProject Project
        {
            get { return _project; }
        }

        /// <summary>
        ///     Gets the build action for the project item.
        /// </summary>
        public virtual GeneratedProjectAction TaskAction
        {
            get { return GeneratedProjectAction.Compile;  }
        }

        /// <summary>
        ///     Gets the folder in which the file is generated.
        /// </summary>
        public override String FileFolder
        {
            get { return this.Project.FileFolder; }
        }

        /// <summary>
        ///     Gets the name of the project item that this item is nested beneath.
        /// </summary>
        public virtual String FileNesting
        {
            get { return null; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratedProjectItem" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the task list, in which this task is included.
        /// </param>
        public GeneratedProjectItem(GeneratedProject project)
        {
            _project = project;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Executes the task.
        /// </summary>
        protected override void ExecuteTask()
        {
            if (MainForm.Runtime != null && MainForm.Runtime.CancelToken != null)
                MainForm.Runtime.CancelToken.ThrowIfCancellationRequested();

            // Generate the file content.
            base.ExecuteTask();
            if (this.Project != null)
                this.AddToProjectFile();
        }

        /// <summary>
        ///     Adds the generated project item to the project file.
        /// </summary>
        private void AddToProjectFile()
        {
            String relativePath = this.FileFolder.Substring(this.Project.FileFolder.Length);
            String relativeFile = Path.Combine((String.IsNullOrEmpty(relativePath) || !relativePath.StartsWith("\\")) ? "" : relativePath.Substring(1), this.FileName + "." + this.FileExtension);
            
            // Load the project document
            XmlDocument document = new XmlDocument();
            document.Load(this.Project.FilePath);

            // Load the visual studio namespace
            XmlNamespaceManager manager = new XmlNamespaceManager(document.NameTable);
            manager.AddNamespace("vs", GeneratedProjectItem.VisualStudioNamespace);

            // Get the group and the item node for the generated file
            XmlNode groupNode = document.SelectSingleNode("vs:Project/vs:ItemGroup", manager);
            XmlNode itemNode = groupNode.SelectSingleNode("vs:*[@Include='" + relativeFile + "']", manager);
            if (itemNode != null && !String.Equals(itemNode.Name, this.TaskAction.ToString()))
            {
                itemNode.ParentNode.RemoveChild(itemNode);
                document.Save(this.Project.FilePath);
            }

            // Add the item node, if missing
            if (itemNode == null || !String.Equals(itemNode.Name, this.TaskAction.ToString()))
            {
                itemNode = groupNode.AppendChild(document.CreateElement(this.TaskAction.ToString(), GeneratedProjectItem.VisualStudioNamespace));
                itemNode.Attributes.Append(document.CreateAttribute("Include")).Value = relativeFile;
                document.Save(this.Project.FilePath);
            }

            // Add or remove the nesting
            XmlNode nestingNode = itemNode.SelectSingleNode("vs:DependentUpon", manager);
            if (!String.IsNullOrEmpty(this.FileNesting) && nestingNode == null)
            {
                itemNode.AppendChild(document.CreateElement("DependentUpon", GeneratedProjectItem.VisualStudioNamespace)).InnerText = this.FileNesting;
                document.Save(this.Project.FilePath);
            }
            else if (!String.IsNullOrEmpty(this.FileNesting) && !String.Equals(nestingNode.InnerText, this.FileNesting))
            {
                nestingNode.InnerText = this.FileNesting;
                document.Save(this.Project.FilePath);
            }
            else if (String.IsNullOrEmpty(this.FileNesting) && nestingNode != null)
            {
                itemNode.RemoveChild(nestingNode);
                document.Save(this.Project.FilePath);
            }
        }

        #endregion
    }
}
