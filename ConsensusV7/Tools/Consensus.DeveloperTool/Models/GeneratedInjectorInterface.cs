using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;
using System.IO;

namespace Consensus.CodeGenerator
{
    public class GeneratedInjectorInterface : GeneratedInterface
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
        private GeneratedInterface _wrappedType;

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
        public GeneratedInterface WrappedType
        {
            get { return _wrappedType; }
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
	        get {  return this.WrappedType.DeclarationType; }
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
        ///     Returns the property from the encapsulated type.
        /// </summary>
        public override GeneratedProjectAction TaskAction
        {
            get { return this.WrappedType.TaskAction; }
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
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override bool TypeIsPartial
        {
            get { return this.WrappedType.TypeIsPartial; }
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
                        members.Add(new CSharpProperty(this)
                        {
                            Name = property.Name,
                            Attributes = property.GetCustomAttributes().Select(attr => attr.GetType().Name).ToArray(),
                            PropertyGetter = property.CanRead ? new CSharpAccessor() : null,
                            PropertySetter = property.CanWrite ? new CSharpAccessor() : null,
                            PropertyType = GeneratedRuntimeType.MapTypeName(this, property.PropertyType),
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
                        members.Add(new CSharpMethod(this)
                        {
                            Name = method.Name,
                            Attributes = method.GetCustomAttributes().Any(attr => attr is NonSerializedAttribute) ? new String[] { "NonSerialized" } : null,
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
        public GeneratedInjectorInterface(GeneratedInterface wrappedType, Type runtimeType) : base(wrappedType.Project)
        {
            _wrappedType = wrappedType;
            _runtimeType = runtimeType;
        }

        #endregion
    }
}