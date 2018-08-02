using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessProviderDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain containers whose factory collections are exposed by the generated provider.
        /// </summary>
        private DomainContainer[] _containers;

        #endregion

        #region properties

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
        ///     Gets the domain containers whose factory collections are exposed by the generated provider.
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
            get { return "Provides the programmatic access to the locally-executable factory collections."; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlRemarks
        {
            get { return "THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.\r\nDO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION."; }
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
            get { return "LocalProvider"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "ConsensusProvider";
            }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "IBusinessProvider";
            }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                yield return new CSharpField(this)
                {
                    XmlSummary = "The data provider which exposes programmatic access to the repositories within the persistence mechanism.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "IDataProvider",
                    Name = "_dataProvider"
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the data provider which exposes programmatic access to the repositories within the persistence mechanism.",
                    PropertyType = "IDataProvider",
                    Name = "DataProvider",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Internal,
                        AccessorCode = new String[] 
                        { 
                            "if (_dataProvider == null)",
                            "    _dataProvider = this.Site.GetService<IDataProvider>();",
                            "",
                            "return _dataProvider;" 
                        }
                    }
                };
                foreach (DomainContainer container in this.Containers)
                {
                    yield return new CSharpField(this)
                    {
                        XmlSummary = "The collection of locally-executable factories which pertain to " + (String.IsNullOrEmpty(container.ContainerDescription) ? "the " + container.ContainerName + " namespace" : container.ContainerDescription),
                        FieldModifier = CSharpModifiers.Private,
                        FieldType = "Local" + container.ContainerName + "FactoryCollection",
                        Name = "_" + container.ContainerName.Substring(0, 1).ToLower() + container.ContainerName.Substring(1)
                    };
                    yield return new CSharpProperty(this)
                    {
                        XmlSummary = "Gets the collection of locally-executable factories which pertain to " + (String.IsNullOrEmpty(container.ContainerDescription) ? "the " + container.ContainerName + " namespace" : container.ContainerDescription),
                        PropertyType = "Local" + container.ContainerName + "FactoryCollection",
                        Name = container.ContainerName,
                        PropertyGetter = new CSharpAccessor() { AccessorCode = new String[] { "return LocalFactoryCollection.Create(this, ref _" + container.ContainerName.Substring(0, 1).ToLower() + container.ContainerName.Substring(1) + ");", } }
                    };
                }
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerProviderDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain containers whose repository collections are exposed by the generated provider.
        /// </param>
        public LocalBusinessProviderDynamic(GeneratedProject project, DomainContainer[] containers) : base(project)
        {
            _containers = containers;
        }

        #endregion
    }
}
