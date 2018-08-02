using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business.Logic
{
    /// <summary>
    ///     Generates the factory implementation class
    /// </summary>
    public class GeneratedFactoryX : TypeClass
    {
        /// <summary>
        ///     The collection of types which are compiled from the interfacing library
        /// </summary>
        public System.Type[] InterfaceLibrary
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the underlying data source for this class
        /// </summary>
        public DataEntity Entity
        {
            get { return base.DataSource as DataEntity; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "The locally-executed factory which instantiates the <see cref='" + this.Entity.CodeName + "Model' /> business model class."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Linq";
            }
        }

        /// <summary>
        ///     Gets the name of the file.
        /// </summary>
        public override String FileName
        {
            get
            {
                String fileName = Path.GetFileNameWithoutExtension(base.FileName);
                String fileExtn = Path.GetExtension(base.FileName);
                return fileName + ".gen.cs";
            }
        }

        /// <summary>
        ///     Gets the name of the file that this file is nested under.
        /// </summary>
        public override String FileNesting
        {
            get { return base.FileName; }
        }

        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Entity.CodeDomain.Name; }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets whether the class definition is spread over multiple files.
        /// </summary>
        public override Boolean TypePartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return String.Format("Local{0}Factory", this.Entity.CodeName); }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return String.Format("LocalFactory<Local{0}Model, {1}>", this.Entity.CodeName, this.Entity.KeyField.CodeTypeName); }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return String.Format("{0}Factory", this.Entity.CodeName); }
        }
               
        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Retrieves a specific <see cref='" + this.Entity.CodeName + "Model' /> instance.",
                    XmlReturns = "The <see cref='" + this.Entity.CodeName + "Model' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.",
                    MemberModifier = CSharpModifier.Public,
                    MemberType = "Local" + this.Entity.CodeName + "Model",
                    MemberName = "GetById",
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter()
                        { 
                            XmlSummary = "The unique value which distinctly identifies the <see cref='" + this.Entity.CodeName + "Model' /> instance to be returned.", 
                            MemberType = this.Entity.KeyField.CodeTypeName,
                            MemberName = "id"
                        }
                    },
                    Code = new String[] 
                    {
                        this.Entity.CodeName + "Record record = this.Provider.DataProvider." + this.Entity.CodeDomain.Name + "." + this.Entity.CodeName + ".SelectById(id);",
                        "Local" + this.Entity.CodeName + "Model model = Local" + this.Entity.CodeName + "Model.Create<Local" + this.Entity.CodeName + "Model>(this.Provider, record);",
                        "return model;"
                    }
                };

                if (this.Entity.CanCreate)
                {
                    yield return new MemberMethod(this)
                    {
                        XmlSummary = "Creates and initialises a new <see cref='" + this.Entity.CodeName + "Model' /> instance.",
                        XmlReturns = "A new <see cref='" + this.Entity.CodeName + "Model' /> instance.",
                        MemberModifier = CSharpModifier.Public,
                        MemberType = "Local" + this.Entity.CodeName + "Model",
                        MemberName = "Create",
                        Code = new String[] 
                        {
                            "Local" + this.Entity.CodeName + "Model model = Local" + this.Entity.CodeName + "Model.Create<Local" + this.Entity.CodeName + "Model>(this.Provider);",
                            "return model;"
                        }
                    };
                }

                if (this.InterfaceLibrary != null)
                {
                    System.Type interfaceType = this.InterfaceLibrary.FirstOrDefault(type => type.Name == String.Format("{0}Factory", this.Entity.CodeName));
                    if (interfaceType != null)
                    {
                        foreach (PropertyInfo property in interfaceType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                            yield return new MemberImplementor(this, property, this.GetDocumentation(property));
                        foreach (MethodInfo method in interfaceType.GetMethods(BindingFlags.Public | BindingFlags.Instance))
                            if (!method.IsSpecialName)
                                yield return new MemberImplementor(this, method, this.GetDocumentation(method));
                    }
                }
            }
        }
    }
}