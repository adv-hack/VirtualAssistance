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
    public class GeneratedEncapsulatorClass : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The xml documentation for the runtime types.
        /// </summary>
        private XmlDocument _runtimeDocument;

        /// <summary>
        ///     The runtime model that is injected into the consumer class.
        /// </summary>
        private Type _runtimeModel;

        /// <summary>
        ///     The runtime factory that is injected into the consumer class.
        /// </summary>
        private Type _runtimeFactory;

        /// <summary>
        ///     The generated proxy that is encapsulated by this injector
        /// </summary>
        private GeneratedClass _wrappedType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the runtime model that is injected into the consumer class.
        /// </summary>
        public Type RuntimeModel
        {
            get { return _runtimeModel; }
        }

        /// <summary>
        ///     Gets the runtime factory that is injected into the consumer class.
        /// </summary>
        public Type RuntimeFactory
        {
            get { return _runtimeFactory; }
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

                    String assemblyFile = this.RuntimeModel.Assembly.Location;
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
        ///     Gets the generated proxy that is encapsulated by this injector
        /// </summary>
        public GeneratedClass WrappedType
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
        public override Boolean TypeIsPartial
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
        ///     Extends the members from the encapsulated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                List<CSharpMember> members = this.WrappedType.TypeMembers.ToList();
                members.AddRange(this.GetProperties());
                members.AddRange(this.GetModelMethods());
                members.AddRange(this.GetFactoryMethods());
                return members;
            }
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

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new build injector for an interface
        /// </summary>
        public GeneratedEncapsulatorClass(GeneratedClass wrappedType, Type runtimeModel, Type runtimeFactory)
            : base(wrappedType.Project)
        {
            _wrappedType = wrappedType;
            _runtimeModel = runtimeModel;
            _runtimeFactory = runtimeFactory;
        }

        #endregion

        #region methods

        private IEnumerable<CSharpMember> GetProperties()
        {
            PropertyInfo[] properties = this.RuntimeModel.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(property => !property.DeclaringType.IsAbstract || this.RuntimeModel.GetInterfaces().Any(i => property.DeclaringType == i)).ToArray();
            foreach (PropertyInfo property in properties)
            {
                Type returnType = GeneratedRuntimeType.MapType(this.RuntimeModel, property.PropertyType);
                String returnTypeName = GeneratedRuntimeType.GetTypeName(returnType, false);
                String usableTypeName = GeneratedRuntimeType.GetTypeName(returnType, true);
                String fieldName = "_" + property.Name.Substring(0, 1).ToLower() + property.Name.Substring(1);

                // Encapsulate model instance properties
                if (returnType.GetInterfaces().Any(iface => String.Equals(iface.Name, "IModel", StringComparison.Ordinal)))
                {
                    yield return new CSharpField(this)
                    {
                        XmlSummary = "The client-consumable proxy instance for the <see cref=\"" + property.Name + "\" /> member.",
                        FieldType = usableTypeName,
                        FieldModifier = CSharpModifiers.Private,
                        Name = fieldName
                    };
                    yield return new CSharpProperty(this)
                    {
                        Name = property.Name,
                        Attributes = property.GetCustomAttributes().Select(attr => attr.GetType().Name).ToArray(),
                        PropertyGetter = !property.CanRead ? null : new CSharpAccessor()
                        {
                            AccessorCode = new String[]
                            {
                                "if ("+ fieldName + " == null && this.Model." + property.Name + " != null)",
                                "    " + fieldName + " = new " + usableTypeName + "(this.Model." + property.Name + ");",
                                "if ("+ fieldName + " == null)",
                                "    " + fieldName + " = " + usableTypeName + ".Create();",
                                "return " + fieldName + ";"
                            }
                        },
                        PropertySetter = !property.CanWrite ? null : new CSharpAccessor()
                        {
                            AccessorCode = new String[]
                            { 
                                fieldName + " = value;",
                                "this.Model." + property.Name + " = value.Model;"
                            }
                        },
                        PropertyType = usableTypeName,
                        XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, property, "summary"),
                        XmlRemarks = this.GenerateDocumentation(this.RuntimeDocument, property, "remarks")
                    };
                }

                // Encapsulate model collection properties
                else if (returnType.IsGenericType && String.Equals(returnType.FullName.Split('`')[0], "Consensus.Collection", StringComparison.Ordinal))
                {
                    returnTypeName = GeneratedRuntimeType.GetTypeName(GeneratedRuntimeType.MapType(this.RuntimeModel, returnType.GetGenericArguments().First()), false);
                    usableTypeName = GeneratedRuntimeType.GetTypeName(GeneratedRuntimeType.MapType(this.RuntimeModel, returnType.GetGenericArguments().First()), true);
                    yield return new CSharpField(this)
                    {
                        XmlSummary = "The client-consumable proxy collection for the <see cref=\"" + property.Name + "\" /> member.",
                        FieldType = "ProxyCollection<" + usableTypeName + ", " + returnTypeName + ">",
                        FieldModifier = CSharpModifiers.Private,
                        Name = fieldName
                    };
                    yield return new CSharpProperty(this)
                    {
                        Name = property.Name,
                        Attributes = property.GetCustomAttributes().Select(attr => attr.GetType().Name).ToArray(),
                        PropertyGetter = !property.CanRead ? null : new CSharpAccessor()
                        {
                            AccessorCode = new String[]
                            {
                                "if ("+ fieldName + " == null)",
                                "    " + fieldName + " = new ProxyCollection<" + usableTypeName + ", " + returnTypeName + ">(this.Model." + property.Name + ", model => new " + usableTypeName + "(model));",
                                "return " + fieldName + ";"
                            }
                        },
                        PropertyType = "Collection<" + usableTypeName + ">",
                        XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, property, "summary"),
                        XmlRemarks = this.GenerateDocumentation(this.RuntimeDocument, property, "remarks")
                    };
                }

                // Encapsulate other properties
                else
                {
                    yield return new CSharpProperty(this)
                    {
                        Name = property.Name,
                        Attributes = property.GetCustomAttributes().Select(attr => attr.GetType().Name).ToArray(),
                        PropertyGetter = !property.CanRead ? null : new CSharpAccessor() { AccessorCode = new String[] { "return this.Model." + property.Name + ";" } },
                        PropertySetter = !property.CanWrite ? null : new CSharpAccessor() { AccessorCode = new String[] { "this.Model." + property.Name + " = value;" } },
                        PropertyType = returnTypeName,
                        XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, property, "summary"),
                        XmlRemarks = this.GenerateDocumentation(this.RuntimeDocument, property, "remarks")
                    };
                }
            }
        }

        private IEnumerable<CSharpMember> GetModelMethods()
        {
            MethodInfo[] methods = this.RuntimeModel.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(method => (method.DeclaringType == this.RuntimeModel || this.RuntimeModel.GetInterfaces().Any(i => method.DeclaringType == i)) && !method.IsSpecialName).ToArray();
            foreach (MethodInfo method in methods)
            {
                Boolean isHasPermissionMethod = method.Name == "HasPermission";

                String methodType = null;
                String[] methodCode = null;
                Type returnType = method.ReturnType == typeof(void) ? null : GeneratedRuntimeType.MapType(this.RuntimeModel, method.ReturnType);
                if (returnType == null)
                {
                    methodCode = new String[] 
                    {
                        "this.Model." + method.Name +
                        (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") +
                        "(" + String.Join(",", method.GetParameters().Select(param => param.Name)) + ");"
                    };
                }
                else if (returnType.GetInterfaces().Any(iface => String.Equals(iface.Name, "IModel", StringComparison.Ordinal)))
                {
                    String returnTypeName = GeneratedRuntimeType.GetTypeName(returnType, false);
                    String usableTypeName = GeneratedRuntimeType.GetTypeName(returnType, true);
                    methodType = usableTypeName;
                    methodCode = new String[] 
                    {
                        returnTypeName + " model = this.Model." + method.Name +
                            (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") +
                            "(" + String.Join(",", method.GetParameters().Select(param => param.Name)) + ")" + ");",
                        "return model == null ? null : new " + methodType + "(model);"                        
                    };
                }
                else if (returnType.IsGenericType && String.Equals(returnType.FullName.Split('`')[0], "System.Collections.Generic.IEnumerable", StringComparison.Ordinal) && returnType.GetGenericArguments()[0].GetInterfaces().Any(iface => String.Equals(iface.Name, "IModel", StringComparison.Ordinal)))
                {
                    String returnTypeName = GeneratedRuntimeType.GetTypeName(returnType, false);
                    String usableTypeName = GeneratedRuntimeType.GetTypeName(returnType, true);
                    returnTypeName = GeneratedRuntimeType.GetTypeName(GeneratedRuntimeType.MapType(this.RuntimeModel, returnType.GetGenericArguments().First()), false);
                    methodType = "IEnumerable<" + usableTypeName + ">";
                    methodCode = new String[]
                    {
                        "return this.Model." + method.Name +
                        (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") +
                        "(" + String.Join(",", method.GetParameters().Select(param => param.Name)) + ")" + 
                        ".Select(model => new " + methodType + "(model));"
                    };
                }
                else
                {
                    methodType = GeneratedRuntimeType.GetTypeName(returnType, false);
                    methodCode = new String[] 
                    {
                        "return this.Model." + method.Name +
                        (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") +
                        "(" + String.Join(",", method.GetParameters().Select(param => param.Name)) + ");"
                    };
                }

                yield return new CSharpMethod(this)
                {
                    Name = method.Name,
                    Attributes = method.GetCustomAttributes().Select(attr => attr.GetType().Name).ToArray(),
                    MethodType = methodType,
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
                    MethodCode = methodCode
                };
            }
        }

        private IEnumerable<CSharpMember> GetFactoryMethods()
        {
            MethodInfo[] methods = this.RuntimeFactory.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(method => (method.DeclaringType == this.RuntimeFactory || this.RuntimeFactory.GetInterfaces().Any(i => method.DeclaringType == i)) && !method.IsSpecialName).ToArray();
            foreach (MethodInfo method in methods)
            {
                String methodType;
                String[] methodCode;
                CSharpParameter[] methodParams = method.GetParameters().Select(param => new CSharpParameter()
                {
                    ParameterName = param.Name,
                    ParameterType = GeneratedRuntimeType.MapTypeName(this, param.ParameterType),
                    ParameterReference = param.IsOut ? CSharpReference.Out : param.IsRetval ? CSharpReference.Ref : Attribute.IsDefined(param, typeof(ParamArrayAttribute)) ? CSharpReference.Params : CSharpReference.None,
                    XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, param, "summary")
                }).ToArray();
                IHaveEntity iHaveEntity = this.WrappedType as IHaveEntity;
                
                // Generate the site-less factory method
                Type returnType = method.ReturnType == typeof(void) ? null : GeneratedRuntimeType.MapType(this.RuntimeModel, method.ReturnType);
                if (returnType == null)
                {
                    methodType = null;
                    methodCode = new String[] 
                    {
                        "ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];",
                        this.WrappedType.DeclarationName + "." + method.Name + 
                        (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") +
                        "(" + String.Join(",", new String[] { "site" }.Concat(method.GetParameters().Select(param => param.Name))) + ");"
                    };
                }
                else if (returnType.GetInterfaces().Any(iface => String.Equals(iface.Name, "IModel", StringComparison.Ordinal)))
                {
                    String returnTypeName = GeneratedRuntimeType.GetTypeName(returnType, false);
                    String usableTypeName = GeneratedRuntimeType.GetTypeName(returnType, true);
                    methodType = usableTypeName;
                    methodCode = new String[] 
                    {
                        "ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];",
                        "return " + this.WrappedType.DeclarationName + "." + method.Name + 
                        (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") +
                        "(" + String.Join(",", new String[] { "site" }.Concat(method.GetParameters().Select(param => param.Name))) + ");"
                    };
                }
                else if (returnType.IsGenericType && String.Equals(returnType.FullName.Split('`')[0], "System.Collections.Generic.IEnumerable", StringComparison.Ordinal) && returnType.GetGenericArguments()[0].GetInterfaces().Any(iface => String.Equals(iface.Name, "IModel", StringComparison.Ordinal)))
                {
                    String returnTypeName = GeneratedRuntimeType.GetTypeName(GeneratedRuntimeType.MapType(this.RuntimeModel, returnType.GetGenericArguments().First()), false);
                    String usableTypeName = GeneratedRuntimeType.GetTypeName(GeneratedRuntimeType.MapType(this.RuntimeModel, returnType.GetGenericArguments().First()), true);
                    methodType = "IEnumerable<" + usableTypeName + ">";
                    methodCode = new String[] 
                    {
                        "ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];",
                        "return " + this.WrappedType.DeclarationName + "." + method.Name + 
                        (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") +
                        "(" + String.Join(",", new String[] { "site" }.Concat(method.GetParameters().Select(param => param.Name))) + ");"
                    };
                }
                else
                {
                    methodType = GeneratedRuntimeType.GetTypeName(returnType, false);
                    methodCode = new String[] 
                    {
                        "ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];",
                        "return " + this.WrappedType.DeclarationName + "." + method.Name + 
                        (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") +
                        "(" + String.Join(",", new String[] { "site" }.Concat(method.GetParameters().Select(param => param.Name))) + ");"
                    };
                }
                yield return GetFactoryMethod(method, methodType, methodParams, methodCode);

                // Generate the sited factory method
                methodParams = new CSharpParameter[] { new CSharpParameter() { ParameterName = "site", ParameterType = "ConsensusSite" } }.Concat(methodParams).ToArray();
                if (returnType == null)
                {
                    methodType = null;
                    methodCode = new String[] 
                    {
                        "IBusinessProvider provider = site.GetService<IBusinessProvider>();",
                        "provider." + iHaveEntity.Entity.Container.ContainerName + "." + iHaveEntity.Entity.EntityName + "." + method.Name + (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") + "(" + String.Join(",", method.GetParameters().Select(param => param.Name)) + ");"
                    };
                }
                else if (returnType.GetInterfaces().Any(iface => String.Equals(iface.Name, "IModel", StringComparison.Ordinal)))
                {
                    String returnTypeName = GeneratedRuntimeType.GetTypeName(returnType, false);
                    String usableTypeName = GeneratedRuntimeType.GetTypeName(returnType, true);
                    methodType = usableTypeName;
                    methodCode = new String[] 
                    {
                        "IBusinessProvider provider = site.GetService<IBusinessProvider>();",
                        returnTypeName + " model = provider." + iHaveEntity.Entity.Container.ContainerName + "." + iHaveEntity.Entity.EntityName + "." + method.Name + (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") + "(" + String.Join(",", method.GetParameters().Select(param => param.Name)) + ");",
                        "return model == null ? null : new " + methodType + "(model);"
                    };
                }
                else if (returnType.IsGenericType && String.Equals(returnType.FullName.Split('`')[0], "System.Collections.Generic.IEnumerable", StringComparison.Ordinal) && returnType.GetGenericArguments()[0].GetInterfaces().Any(iface => String.Equals(iface.Name, "IModel", StringComparison.Ordinal)))
                {
                    String returnTypeName = GeneratedRuntimeType.GetTypeName(GeneratedRuntimeType.MapType(this.RuntimeModel, returnType.GetGenericArguments().First()), false);
                    String usableTypeName = GeneratedRuntimeType.GetTypeName(GeneratedRuntimeType.MapType(this.RuntimeModel, returnType.GetGenericArguments().First()), true);
                    methodType = "IEnumerable<" + usableTypeName + ">";
                    methodCode = new String[] 
                    {
                        "IBusinessProvider provider = site.GetService<IBusinessProvider>();",
                        "IEnumerable<" + returnTypeName + "> collection = provider." + iHaveEntity.Entity.Container.ContainerName + "." + iHaveEntity.Entity.EntityName + "." + method.Name + (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") + "(" + String.Join(",", method.GetParameters().Select(param => param.Name)) + ");",
                        "return collection.Select(model => new " + usableTypeName + "(model));"
                    };
                }
                else
                {
                    methodType = GeneratedRuntimeType.GetTypeName(returnType, false);
                    methodCode = new String[] 
                    {
                        "IBusinessProvider provider = site.GetService<IBusinessProvider>();",
                        "return provider." + iHaveEntity.Entity.Container.ContainerName + "." + iHaveEntity.Entity.EntityName + "." + method.Name + (method.GetGenericArguments().Length == 0 ? "" : "<" + String.Join(", ", method.GetGenericArguments().Select(gen => GeneratedRuntimeType.GetTypeName(gen, false))) + ">") + "(" + String.Join(",", method.GetParameters().Select(param => param.Name)) + ");"
                    };
                }
                yield return GetFactoryMethod(method, methodType, methodParams, methodCode);

            }
        }

        private CSharpMethod GetFactoryMethod(MethodInfo method, String methodType, CSharpParameter[] methodParams, String[] methodCode)
        {
            return new CSharpMethod(this)
            {
                Name = method.Name,
                Attributes = method.GetCustomAttributes().Select(attr => attr.GetType().Name).ToArray(),
                MethodType = methodType,
                MethodAbstraction = CSharpAbstractions.Static,
                MethodGenerics = method.GetGenericArguments().Select(generic => new CSharpGeneric()
                {
                    GenericName = generic.Name,
                    XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, generic, "summary"),
                    GenericConstraints = generic.GetGenericParameterConstraints().Select(con => con.Name).ToArray()
                }).ToArray(),
                MethodParameters = methodParams,
                MethodCode = methodCode,
                XmlSummary = this.GenerateDocumentation(this.RuntimeDocument, method, "summary"),
                XmlRemarks = this.GenerateDocumentation(this.RuntimeDocument, method, "remarks"),
                XmlReturns = this.GenerateDocumentation(this.RuntimeDocument, method, "returns")
            };
        }

        #endregion
    }

    public interface IHaveEntity
    {
        DomainEntity Entity
        {
            get;
        }
    }
}