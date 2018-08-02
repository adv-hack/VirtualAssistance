using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Type = System.Type;
using CodeType = CodeGenerator.CodeModel.Type;

namespace CodeGenerator.Consensus.Business
{
    public class GeneratedProxyX : TypeClass
    {
        /// <summary>
        ///     Gets the underlying runtime type (for the provider) that is used to generate this interface
        /// </summary>
        public Type ProviderType
        {
            get { return this.FactoryType.Assembly.GetTypes().FirstOrDefault(type => type.GetInterfaces().Any(iface => iface.Name == "BusinessProvider")); }
        }

        /// <summary>
        ///     Gets the underlying runtime type (for the factory) that is used to generate this interface
        /// </summary>
        public Type FactoryType
        {
            get { return base.DataSource as Type; }
        }

        /// <summary>
        ///     Gets the underlying runtime type (for the model) that is used to generate this interface
        /// </summary>
        public Type ModelType
        {
            get { return this.FactoryType.BaseType.GetGenericArguments().FirstOrDefault(); }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                // Get the namespaces for all values returned by the properties and methods
                List<String> references = new List<String>();
                references.AddRange(this.ModelType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Select(prop => prop.PropertyType.Namespace));
                references.AddRange(this.ModelType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(method => !method.IsSpecialName).Select(method => method.ReturnType.Namespace));
                references.Add("System.ComponentModel");

                // Exclude the system namespace (this is always included) and the current namespace
                return references
                    .Where(reference => reference != this.TypeNamespace)
                    .Where(reference => reference != "System")
                    .OrderBy(reference => reference)
                    .Distinct();
            }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get
            {
                XmlNode xmlDocumentation = this.GetDocumentation(this.ModelType);
                return xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n');
            }
        }

        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.FactoryType.Namespace.Substring(this.ParentProject.ProjectNamespace.Length + 1); }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return this.ModelType.GetInterfaces().Where(iface => iface.Implements("Model") && iface.GetGenericArguments().Length == 0).Select(iface => iface.Name.EndsWith("Model") ? iface.Name.Substring(0, iface.Name.Length - 5) : iface.Name).FirstOrDefault(); }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get
            {
                Type modelType = this.ModelType.GetInterfaces().First(iface => iface.Implements("Model") && iface.GetGenericArguments().Length == 0);
                Type keyType = this.ModelType.GetInterfaces().First(iface => iface.Name == "Model`1").GetGenericArguments()[0];
                return String.Format("Proxy<{0}, {1}>", CodeType.GetTypeName(modelType), CodeType.GetTypeName(keyType));
            }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return this.ModelType.GetInterfaces().First(iface => iface.Implements("Model") && iface.GetGenericArguments().Length == 0).Name; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                PropertyInfo providerProperty = this.ProviderType.GetProperties(BindingFlags.Public | BindingFlags.Instance).FirstOrDefault(prop => prop.PropertyType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Any(subprop => subprop.PropertyType == this.FactoryType));
                PropertyInfo factoryProperty = providerProperty.PropertyType.GetProperties(BindingFlags.Public | BindingFlags.Instance).FirstOrDefault(prop => prop.PropertyType == this.FactoryType);
                
                // Return proxy properties for each property defined on the Model
                PropertyInfo[] properties = this.ModelType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (PropertyInfo property in properties)
                {
                    XmlNode xmlDocumentation = this.GetDocumentation(property);
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        MemberType = CodeType.GetTypeName(property.PropertyType),
                        MemberName = property.Name,
                        GetAccessor = property.CanRead ? new MemberAccessor() { Code = new String[] { "return this.Model." + property.Name + ";" } } : null,
                        SetAccessor = property.CanWrite ? new MemberAccessor() { Code = new String[] { "this.Model." + property.Name + " = value;" } } : null
                    };
                }

                // Return proxy methods for each method defined on the Model
                MethodInfo[] modelMethods = this.ModelType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (MethodInfo method in modelMethods.Where(m => !m.IsSpecialName))
                {
                    // Get the xml node for the method
                    XmlNode xmlDocumentation = this.GetDocumentation(method);

                    // Get the parameters for the method
                    List<MemberParameter> parameters = new List<MemberParameter>();
                    foreach (ParameterInfo parameter in method.GetParameters())
                    {
                        MemberParameter memberParameter = new MemberParameter();
                        if (Attribute.IsDefined(parameter, typeof(ParamArrayAttribute)))
                            memberParameter.MemberKeyword = CSharpKeyword.Params;
                        else if (parameter.ParameterType.IsByRef && parameter.IsOut)
                            memberParameter.MemberKeyword = CSharpKeyword.Out;
                        else if (parameter.ParameterType.IsByRef)
                            memberParameter.MemberKeyword = CSharpKeyword.Ref;
                        memberParameter.MemberType = CodeType.GetTypeName(parameter.ParameterType);
                        memberParameter.MemberName = parameter.Name;
                        memberParameter.XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("param[@name='" + parameter.Name + "']") == null ? null : xmlDocumentation.SelectSingleNode("param[@name='" + parameter.Name + "']").InnerXml.Trim().Trim('\r', '\n');
                        parameters.Add(memberParameter);
                    }

                    // Return the proxy method 
                    String returnType = CodeType.GetTypeName(method.ReturnType);
                    yield return new MemberMethod(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        XmlReturns = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("returns") == null ? null : xmlDocumentation.SelectSingleNode("returns").InnerXml.Trim().Trim('\r', '\n'),
                        MemberAbstraction = CSharpAbstraction.Static,
                        MemberType = CodeType.GetTypeName(method.ReturnType),
                        MemberName = method.Name,
                        MemberParameters = parameters.ToArray(),
                        Code = new String[]
                        {
                            (returnType == "Void" ? "" : "return ") + "this." + method.Name + "(" + String.Join(", ", parameters.Select(p => p.MemberName)) + ");"
                        }
                    };
                }

                // Return static methods for method defined on the factory
                MethodInfo[] factoryMethods = this.FactoryType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (MethodInfo method in factoryMethods.Where(m => !m.IsSpecialName))
                {
                    // Get the xml node for the method
                    XmlNode xmlDocumentation = this.GetDocumentation(method);

                    // Get the parameters for the method
                    List<MemberParameter> parameters = new List<MemberParameter>();
                    foreach (ParameterInfo parameter in method.GetParameters())
                    {
                        MemberParameter memberParameter = new MemberParameter();
                        if (Attribute.IsDefined(parameter, typeof(ParamArrayAttribute)))
                            memberParameter.MemberKeyword = CSharpKeyword.Params;
                        else if (parameter.ParameterType.IsByRef && parameter.IsOut)
                            memberParameter.MemberKeyword = CSharpKeyword.Out;
                        else if (parameter.ParameterType.IsByRef)
                            memberParameter.MemberKeyword = CSharpKeyword.Ref;
                        memberParameter.MemberType = CodeType.GetTypeName(parameter.ParameterType);
                        memberParameter.MemberName = parameter.Name;
                        memberParameter.XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("param[@name='" + parameter.Name + "']") == null ? null : xmlDocumentation.SelectSingleNode("param[@name='" + parameter.Name + "']").InnerXml.Trim().Trim('\r', '\n');
                        parameters.Add(memberParameter);
                    }

                    // Return the overloaded method for site-independent calls
                    String returnType = CodeType.GetTypeName(method.ReturnType);
                    yield return new MemberMethod(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        XmlReturns = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("returns") == null ? null : xmlDocumentation.SelectSingleNode("returns").InnerXml.Trim().Trim('\r', '\n'),
                        MemberAbstraction = CSharpAbstraction.Static,
                        MemberType = returnType == CodeType.GetTypeName(this.ModelType) ? this.TypeName : returnType,
                        MemberName = method.Name,
                        MemberParameters = parameters.ToArray(),
                        Code = new String[]
                        {
                            "ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];",
                            (returnType == "Void" ? "" : "return ") + this.TypeName + "." + method.Name + "(site" + (parameters.Count == 0 ? "" : ", " + String.Join(", ", parameters.Select(p => p.MemberName))) + ");"
                        }
                    };

                    // Return the overloaded method for site-specific calls
                    yield return new MemberMethod(this)
                    {
                        XmlSummary = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("summary") == null ? null : xmlDocumentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n'),
                        XmlReturns = xmlDocumentation == null || xmlDocumentation.SelectSingleNode("returns") == null ? null : xmlDocumentation.SelectSingleNode("returns").InnerXml.Trim().Trim('\r', '\n'),
                        MemberAbstraction = CSharpAbstraction.Static,
                        MemberType = returnType == CodeType.GetTypeName(this.ModelType) ? this.TypeName : returnType,
                        MemberName = method.Name,
                        MemberParameters = new MemberParameter[] { new MemberParameter() { MemberType = "ConsensusSite", MemberName = "site", XmlSummary = "The Consensus instance in which, this operation is performed" } }.Concat(parameters).ToArray(),
                        Code = new String[]
                        {
                            "BusinessProvider provider = site.GetService<BusinessProvider>();",
                            (returnType == "Void" ? "" : returnType + " result = ") + "provider." + providerProperty.Name  + "." + factoryProperty.Name + "." + method.Name + "(" + String.Join(", ", parameters.Select(p => p.MemberName)) + ");",
                            "return" + (returnType == "Void" ? "" : returnType == CodeType.GetTypeName(this.ModelType) ? " new " + this.TypeName + "(result)" : " result") + ";"
                        }
                    };
                }

                // Return the required constructor
                yield return new MemberConstructor(this)
                {
                    XmlSummary = "Initialises a new instance of the client-consumable class.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter() 
                        { 
                            XmlSummary = "Sets underlying business model which is encapsulated by this consumable client class.",
                            MemberType = this.ModelType.GetInterfaces().First(iface => iface.Implements("Model") && iface.GetGenericArguments().Length == 0).Name,
                            MemberName = "model",
                        }
                    },
                    MemberInvocation = "model"
                };
            }
        }
    }
}
