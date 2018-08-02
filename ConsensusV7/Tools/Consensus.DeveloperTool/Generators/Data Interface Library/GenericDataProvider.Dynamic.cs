using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the dynamic-code file for the dependency-injectable provider interface.
    /// </summary>
    public class GenericDataProviderDynamic : GeneratedInterface
    {
        #region fields

        /// <summary>
        ///     The domain containers whose repository collections are exposed by the generated provider.
        /// </summary>
        private DomainContainer[] _containers;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain containers whose repository collections are exposed by the generated provider.
        /// </summary>
        public DomainContainer[] Containers
        {
            get { return _containers; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the programmatic access to the repository collections."; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlRemarks
        {
            get { return "THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.\r\nDO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION."; }
        }

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return base.FileName + ".gen"; }
        }

        /// <summary>
        ///     Gets the name of the project item that this item is nested beneath.
        /// </summary>
        public override String FileNesting
        {
            get { return base.FileName + "." + base.FileExtension; }
        }  

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Collections.Generic";
                yield return "System.Data";
                yield return "System.Data.Common";
                yield return "System.Linq";
                foreach (DomainContainer container in this.Containers)
                    yield return this.Project.ProjectNamespace + "." + container.ContainerName;
            }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "IDataProvider"; }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="GenericDataProviderDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public GenericDataProviderDynamic(GeneratedProject project, DomainContainer[] containers) : base(project)
        {
            _containers = containers;
        }

        #endregion
    }
}
