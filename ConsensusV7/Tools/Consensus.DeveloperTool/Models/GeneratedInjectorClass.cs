using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    public class GeneratedInjectorClass : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The runtime type that is injected into the generated type
        /// </summary>
        private Type _runtimeType;

        /// <summary>
        ///     The xml documentation for the runtime type.
        /// </summary>
        private XmlDocument _runtimeDocument;

        /// <summary>
        ///     The generated type that is encapsulated by this injector
        /// </summary>
        private GeneratedClass _wrappedType;

        /// <summary>
        ///     The name of the interface being implemented.
        /// </summary>
        private String _interfaceName;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the runtime type that is injected into the generated type
        /// </summary>
        public Type RuntimeType
        {
            get { return _runtimeType; }
        }

        /// <summary>
        ///     Gets the xml documentation for the runtime type.
        /// </summary>
        public XmlDocument RuntimeDocument
        {
            get
            {
                if (_runtimeDocument == null)
                {
                    _runtimeDocument = new XmlDocument();

                    String assemblyFile = this.RuntimeType.Assembly.Location;
                    String assemblyPath = Path.GetDirectoryName(assemblyFile);
                    String documentFile = Path.GetFileNameWithoutExtension(assemblyFile) + ".xml";
                    String documentPath = Path.Combine(assemblyPath, documentFile);
                    if (File.Exists(documentPath))
                        _runtimeDocument.Load(documentPath);
                }
                return _runtimeDocument;
            }
        }

        /// <summary>
        ///     Gets the generated type that is encapsulated by this injector.
        /// </summary>
        public GeneratedClass WrappedType
        {
            get { return _wrappedType; }
        }

        /// <summary>
        ///     Gets the name of the interface being implemented.
        /// </summary>
        public String InterfaceName
        {
            get { return _interfaceName; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override Boolean Enabled
        {
            get { return this.WrappedType.Enabled; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String Name
        {
            get { return this.WrappedType.Name; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String DeclarationName
        {
            get { return this.WrappedType.DeclarationName; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override CSharpTypes DeclarationType
        {
            get { return this.WrappedType.DeclarationType; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String FileExtension
        {
            get { return this.WrappedType.FileExtension; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String FileFolder
        {
            get { return this.WrappedType.FileFolder; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return true; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String FileName
        {
            get { return this.WrappedType.FileName; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String FileNesting
        {
            get { return this.WrappedType.FileNesting; }
        }
        
        /// <summary>
        ///     Gets the abstraction of the generated runtime type.
        /// </summary>
        public override CSharpAbstractions TypeAbstraction
        {
            get { return this.WrappedType.TypeAbstraction; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override GeneratedProjectAction TaskAction
        {
            get { return this.WrappedType.TaskAction; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get { return this.WrappedType.TypeBase; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override IEnumerable<CSharpGeneric> TypeGenerics
        {
            get { return this.WrappedType.TypeGenerics; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { return this.WrappedType.TypeInterfaces; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override CSharpModifiers TypeModifier
        {
            get { return this.WrappedType.TypeModifier; }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override bool TypeIsPartial
        {
            get { return this.WrappedType.TypeIsPartial; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String TypeName
        {
            get { return this.WrappedType.TypeName; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.WrappedType.TypeNamespace; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get { return this.WrappedType.TypeReferences; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String XmlRemarks
        {
            get { return this.WrappedType.XmlRemarks; }
        }

        /// <summary>
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override String XmlSummary
        {
            get { return this.WrappedType.XmlSummary; }
        }

        /// <summary>
        ///     Extends the members from the encapsulated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                List<CSharpMember> members = this.WrappedType.TypeMembers.ToList();
                foreach (PropertyInfo property in this.RuntimeType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if (property.DeclaringType == this.RuntimeType || this.RuntimeType.GetInterfaces().Any(i => property.DeclaringType == i))
                    {
                        members.Add(new CSharpImplementationProperty(this)
                        {
                            Attributes = property.GetCustomAttributes().Select(attr => attr.GetType().Name).ToArray(),
                            Name = property.Name,
                            PropertyGetter = property.CanRead,
                            PropertySetter = property.CanWrite,
                            OriginalType = GeneratedRuntimeType.GetTypeName(property.PropertyType),
                            PropertyType = GeneratedRuntimeType.MapTypeName(this, property.PropertyType),
                            PropertyInterface = this.InterfaceName,
                            XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, property, "summary"),
                            XmlRemarks = this.GenerateDocumentation(this.RuntimeDocument, property, "remarks")
                        });
                    }
                }
                foreach (MethodInfo method in this.RuntimeType.GetMethods(BindingFlags.Public | BindingFlags.Instance))
                {
                    Boolean isHasPermissionMethod = method.Name == "HasPermission";

                    if ((method.DeclaringType == this.RuntimeType || this.RuntimeType.GetInterfaces().Any(i => method.DeclaringType == i)) && !method.IsSpecialName)
                    {
                        members.Add(new CSharpImplementationMethod(this)
                        {
                            Attributes = method.GetCustomAttributes().Select(attr => attr.GetType().Name).ToArray(),
                            Name = method.Name,
                            MethodInterface = this.InterfaceName,
                            MethodType = method.ReturnType == typeof(void) ? null : GeneratedRuntimeType.MapTypeName(this, method.ReturnType),
                            MethodGenerics = method.GetGenericArguments().Select(generic => new CSharpGeneric()
                            {
                                GenericName = generic.Name,
                                XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, generic, "summary"),
                                GenericConstraints = generic.GetGenericParameterConstraints().Select(con => con.Name).ToArray()
                            }).ToArray(),
                            MethodParameters = method.GetParameters().Select(param => new CSharpParameter()
                            {
                                ParameterName = param.Name,
                                ParameterType = GeneratedRuntimeType.MapTypeName(this, param.ParameterType),
                                ParameterReference = param.IsOut ? CSharpReference.Out : param.IsRetval ? CSharpReference.Ref : Attribute.IsDefined(param, typeof(ParamArrayAttribute)) ? CSharpReference.Params : CSharpReference.None,
                                XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, param, "summary")
                            }).ToArray(),
                            XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, method, "summary"),
                            XmlRemarks = this.GenerateDocumentation(this.RuntimeDocument, method, "remarks"),
                            XmlReturns = this.GenerateDocumentation(this.RuntimeDocument, method, "returns")
                        });
                    }
                }
                return members;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new build injector for an interface
        /// </summary>
        public GeneratedInjectorClass(GeneratedClass wrappedType, Type runtimeType, String interfaceName) : base(wrappedType.Project)
        {
            _wrappedType = wrappedType;
            _runtimeType = runtimeType;
            _interfaceName = interfaceName;
        }

        #endregion
    }
}
