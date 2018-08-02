using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessFactoryFromEntityDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;
        
        /// <summary>
        ///     The lowest-level entity in the inheritence chain.
        /// </summary>
        private DomainEntity _baseEntity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        public DomainEntity Entity
        {
            get { return _entity; }
        }

        /// <summary>
        ///    Gets the lowest-level entity in the inheritence chain.
        /// </summary>
        public DomainEntity BaseEntity
        {
            get
            {
                if (_baseEntity == null)
                    _baseEntity = this.Entity;

                while (_baseEntity is DomainEntityExtender)
                    _baseEntity = (_baseEntity as DomainEntityExtender).ReferencedEntity;

                return _baseEntity;
            }
        }

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return this.Entity.EntityName + ".factory.gen"; }
        }

        /// <summary>
        ///     Gets the name of the project item that this item is nested beneath.
        /// </summary>
        public override String FileNesting
        {
            get { return this.Entity.EntityName + ".factory." + base.FileExtension; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the instantiation of the <see cref=\"" + this.Entity.EntityName + "Model\" /> object."; }
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
                List<String> references = new List<String>();
                references.Add("System.Collections.Generic");
                references.Add("System.Linq");

                DomainEntityExtender extender = this.Entity as DomainEntityExtender;
                if (extender != null && extender.Container != extender.ReferencedEntity.Container && !references.Contains(this.Project.ProjectNamespace + "." + extender.ReferencedEntity.Container.ContainerName))
                    references.Add(this.Project.ProjectNamespace + "." + extender.ReferencedEntity.Container.ContainerName);

                return references;
            }
        }

        /// <summary>
        ///     Gets the scoping namespace of the runtime type.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Entity.Container.ContainerName; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "Local" + this.Entity.EntityName + "Factory"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "LocalFactory<Local" + this.Entity.EntityName + "Model, " + this.Entity.ReferencedTable.ProgrammaticName + "Record, " + this.Entity.ReferencedTable.TableKey.ProgrammaticType + ">";
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
                yield return "I" + this.Entity.EntityName + "Factory";
            }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                DomainEntityAttribute[] referenceAttributes = this.Entity.EntityAttributes.Where(attr => attr.ReferencedEntity != null && attr.ReferencedEntity.Exists && !String.Equals(attr.ReferencedEntity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase)).ToArray();
                
                if (!this.Entity.EntityIsAbstract && this.Entity.EntityIsCreatable)
                    yield return this.GenerateCreate();
                yield return this.GenerateFetchAll();
                yield return this.GenerateFetchById();
                yield return this.GenerateGetTableName();
                foreach (DomainEntityAttribute attribute in referenceAttributes)
                    yield return this.GenerateFetchAllByAttribute(attribute);
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
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public LocalBusinessFactoryFromEntityDynamic(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion

        #region methods

        private CSharpMethod GenerateCreate()
        {
            CSharpMethod result = new CSharpMethod(this);
            result.XmlSummary = "Creates a new <see cref='" + this.Entity.EntityName + "Model' /> instance.";
            result.XmlReturns = "A newly instantiated <see cref='" + this.Entity.EntityName + "Model' /> instance.";
            result.MethodType = "Local" + this.Entity.EntityName + "Model";
            result.Name = "Create";
            result.MethodCode = new String[] { "return new Local" + this.Entity.EntityName + "Model(this.Provider);" };
            return result;
        }

        private CSharpMethod GenerateFetchById()
        {
            List<String> methodCode = new List<String>();
            DomainEntityExtender[] extenders = this.Entity.Container.Domain.Containers.SelectMany(c => c.ContainerEntities).OfType<DomainEntityExtender>().Where(e => e.ReferencedEntity == this.Entity && !String.IsNullOrEmpty(e.FilterCode)).ToArray();
            methodCode.Add(this.Entity.ReferencedTable.ProgrammaticName + "Record record = this.Provider.DataProvider." + this.BaseEntity.Container.ContainerName + "." + this.BaseEntity.EntityName + ".FetchById(id);");
            methodCode.Add("if (record == null)");
            methodCode.Add("    return null;");
            foreach (DomainEntityExtender extender in extenders)
            {
                methodCode.Add("if (" + extender.FilterCode + ")");
                methodCode.Add("    return new Local" + extender.EntityName + "Model(this.Provider, record);");
            }
            methodCode.Add("return new Local" + this.Entity.EntityName + "Model(this.Provider, record);");

            CSharpMethod result = new CSharpMethod(this);
            result.XmlSummary = "Retrieves a specific <see cref='" + this.Entity.EntityName + "Model' /> instance.";
            result.XmlReturns = "The <see cref='" + this.Entity.EntityName + "Model' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.";
            result.MethodType = "Local" + this.Entity.EntityName + "Model";
            result.Name = "FetchById";
            result.MethodParameters = new CSharpParameter[] { new CSharpParameter() { ParameterType = this.Entity.ReferencedTable.TableKey.ProgrammaticType, ParameterName = "id", XmlSummary = "The unique value which distinctly identifies the <see cref='" + this.Entity.EntityName + "Model' /> instance to be returned." }, };
            result.MethodCode = methodCode.ToArray();
            return result;
        }

        public CSharpMethod GenerateFetchAll()
        {
            List<String> methodCode = new List<String>();
            DomainEntityExtender[] extenders = this.Entity.Container.Domain.Containers.SelectMany(c => c.ContainerEntities).OfType<DomainEntityExtender>().Where(e => e.ReferencedEntity == this.Entity && !String.IsNullOrEmpty(e.FilterCode)).ToArray();
            methodCode.Add("IEnumerable<" + this.Entity.ReferencedTable.ProgrammaticName + "Record> recordCollection = this.Provider.DataProvider." + this.BaseEntity.Container.ContainerName + "." + this.BaseEntity.EntityName + ".FetchAll();");
            methodCode.Add("foreach (" + this.Entity.ReferencedTable.ProgrammaticName + "Record record in recordCollection)");
            methodCode.Add("{");
            methodCode.Add("    if (record != null" + (this.Entity.FilterCode != null ? " && " + this.Entity.FilterCode : "") + ")");
            methodCode.Add("    {");
            foreach (DomainEntityExtender extender in extenders)
            {
                methodCode.Add("        " + (extender == extenders[0] ? "if" : "else if") + " (" + extender.FilterCode + ")");
                methodCode.Add("            yield return new Local" + extender.EntityName + "Model(this.Provider, record);");
            }
            if (extenders.Length != 0)
                methodCode.Add("        else");
            methodCode.Add((extenders.Length == 0 ? "" : "    ") + "        yield return new Local" + this.Entity.EntityName + "Model(this.Provider, record);");
            methodCode.Add("    }");
            methodCode.Add("}");

            CSharpMethod result = new CSharpMethod(this);
            result.XmlSummary = "Retrieves all instances of the <see cref='" + this.Entity.EntityName + "Model' /> class.";
            result.XmlReturns = "An enumerable collection of <see cref='" + this.Entity.EntityName + "Model' /> instances.";
            result.MethodType = "IEnumerable<Local" + this.Entity.EntityName + "Model>";
            result.Name = "FetchAll";
            result.MethodCode = methodCode.ToArray();
            return result;
        }

        public CSharpMethod GenerateFetchAllByAttribute(DomainEntityAttribute attribute)
        {
            String parameterName = attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + "Id";
            
            List<String> methodCode = new List<String>();
            DomainEntityExtender[] extenders = this.Entity.Container.Domain.Containers.SelectMany(c => c.ContainerEntities).OfType<DomainEntityExtender>().Where(e => e.ReferencedEntity == this.Entity && !String.IsNullOrEmpty(e.FilterCode)).ToArray();
            methodCode.Add("IEnumerable<" + this.Entity.ReferencedTable.ProgrammaticName + "Record> recordCollection = this.Provider.DataProvider." + this.BaseEntity.Container.ContainerName + "." + this.BaseEntity.EntityName + ".FetchAllBy" + attribute.Column.ProgrammaticName + "(" + parameterName + ");");
            methodCode.Add("foreach (" + this.Entity.ReferencedTable.ProgrammaticName + "Record record in recordCollection)");
            methodCode.Add("{");
            methodCode.Add("    if (record != null" + (this.Entity.FilterCode != null ? " && " + this.Entity.FilterCode : "") + ")");
            methodCode.Add("    {");
            foreach (DomainEntityExtender extender in extenders)
            {
                methodCode.Add("        " + (extender == extenders[0] ? "if" : "else if") + " (" + extender.FilterCode + ")");
                methodCode.Add("            yield return new Local" + extender.EntityName + "Model(this.Provider, record);");
            }
            if (extenders.Length != 0)
                methodCode.Add("        else");
            methodCode.Add((extenders.Length == 0 ? "" : "    ") + "        yield return new Local" + this.Entity.EntityName + "Model(this.Provider, record);");
            methodCode.Add("    }");
            methodCode.Add("}");

            CSharpMethod result = new CSharpMethod(this);
            result.XmlSummary = "Retrieves a collection of <see cref='" + this.Entity.EntityName + "Model' /> instances.";
            result.XmlReturns = "The <see cref='" + this.Entity.EntityName + "Model' /> instances that match the specified <paramref name='" + parameterName + "' />.";
            result.MethodType = "IEnumerable<Local" + this.Entity.EntityName + "Model>";
            result.Name = "FetchAllBy" + attribute.AttributeName + "Id";
            result.MethodParameters = new CSharpParameter[]
            {
                new CSharpParameter()
                { 
                    XmlSummary = "The value which identifies the <see cref='" + this.Entity.EntityName + "Model' /> instances to be returned.", 
                    ParameterType = attribute.Column.ProgrammaticType,
                    ParameterName = parameterName 
                }
            };
            result.MethodCode = methodCode.ToArray();
            return result;
        }

        private CSharpMethod GenerateGetTableName()
        {
            CSharpMethod result = new CSharpMethod(this);
            result.XmlSummary = "Gets the underlying database table name for <see cref='" + this.Entity.EntityName + "/>.";
            result.XmlReturns = "The table name.";
            result.MethodType = "String";
            result.Name = "GetTableName";
            result.MethodCode = new String[] { "return this.Provider.DataProvider." + this.BaseEntity.Container.ContainerName + "." + this.BaseEntity.EntityName + ".TableName;" };
            return result;
        }

        #endregion
    }
}
