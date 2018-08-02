using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the dynamic-code file for the <see cref="DomainContainer"/>-driven repository collection class.
    /// </summary>
    public class SqlServerRepositoryCollectionFromContainerDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain container from which the repository collection is generated.
        /// </summary>
        private DomainContainer _container;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain container from which the repository collection is generated.
        /// </summary>
        public DomainContainer Container
        {
            get { return _container; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return true; }
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
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Microsoft SQL Server repository collection which pertains to " + (String.IsNullOrEmpty(this.Container.ContainerDescription) ? "the " + this.Container.ContainerName + " namespace" : this.Container.ContainerDescription); }
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
                yield return "System.Data.Common";
                yield return "System.Linq";
            }
        }

        /// <summary>
        ///     Gets the scoping namespace of the runtime type.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Container.ContainerName; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "SqlServer" + this.Container.ContainerName + "RepositoryCollection"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "SqlServerRepositoryCollection";
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
                yield return "I" + this.Container.ContainerName + "RepositoryCollection";
            }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                DomainEntity[] entities = this.Container.ContainerEntities.Where(entity => entity.Exists && entity.GetType() == typeof(DomainEntity)).ToArray();
                foreach (DomainEntity entity in entities)
                {
                    yield return new CSharpField(this)
                    {
                        XmlSummary = "The Microsoft SQL Server repository which persists and retrieves instances of the <see cref=\"" + entity.ReferencedTable.ProgrammaticName + "Record\" /> data structure.",
                        FieldModifier = CSharpModifiers.Private,
                        FieldType = "SqlServer" + entity.EntityName + "Repository",
                        Name = "_" + entity.EntityName.Substring(0, 1).ToLower() + entity.EntityName.Substring(1)
                    };
                    yield return new CSharpProperty(this)
                    {
                        XmlSummary = "Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref=\"" + entity.ReferencedTable.ProgrammaticName + "Record\" /> data structure.",
                        PropertyType = "SqlServer" + entity.EntityName + "Repository",
                        Name = entity.EntityName,
                        //PropertyGetter = new CSharpAccessor() { AccessorCode = new String[] { "return SqlServerRepository.Create(this.Provider, ref _" + entity.EntityName.Substring(0, 1).ToLower() + entity.EntityName.Substring(1) + ");", } }
                        PropertyGetter = new CSharpAccessor()
                            {
                                AccessorCode = new String[] {
                                    "SqlServerProvider provider = this.Provider;",
                                    "OverrideProvider(typeof(SqlServer" + entity.EntityName + "Repository), ref provider);",
                                    "return SqlServerRepository.Create(provider, ref _" + entity.EntityName.Substring(0, 1).ToLower() + entity.EntityName.Substring(1) + ");"
                                }
                            }
                        /*
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCodeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _code);
                         */
                    };
                }

                // partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance",
                    MethodModifier = CSharpModifiers.Partial,
                    MethodType = "void",
                    Name = "OverrideProvider",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The type of the SqlServerDataRepository instance being created",
                            ParameterType = "Type",
                            ParameterName = "SqlServerDataRepositoryType"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The default provider. A new provider may be assigned to this parameter in an implementation, if required.",
                            ParameterType = "SqlServerProvider",
                            ParameterName = "provider",
                            ParameterReference = CSharpReference.Ref
                        }
                    },
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepositoryFromEntityUser" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="container">
        ///     Sets the domain container from which the repository collection is generated.
        /// </param>
        public SqlServerRepositoryCollectionFromContainerDynamic(GeneratedProject project, DomainContainer container) : base(project)
        {
            _container = container;
        }

        #endregion
    }
}
