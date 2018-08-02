using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class GenericBusinessFactoryDynamic : GeneratedInterface
    {
        #region fields

        /// <summary>
        ///     The domain within which the interface is defined.
        /// </summary>
        private Domain _domain;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the domain within which the interface is defined.
        /// </summary>
        public Domain Domain
        {
            get { return _domain; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the instantiation of a business model."; }
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
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "IFactory"; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="GenericDataRepositoryDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public GenericBusinessFactoryDynamic(GeneratedProject project, Domain domain) : base(project)
        {
            _domain = domain;
        }

        #endregion
    }
}
