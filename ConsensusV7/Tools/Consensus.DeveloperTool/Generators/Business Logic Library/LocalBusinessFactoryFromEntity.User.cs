using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessFactoryFromEntityUser : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;

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
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return this.Entity.EntityName + ".factory"; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the instantiation of the <see cref=\"" + this.Entity.EntityName + "Model\" /> object."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Collections.Generic";
                yield return "System.Linq";
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
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return false; }
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
        public LocalBusinessFactoryFromEntityUser(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion
    }
}
