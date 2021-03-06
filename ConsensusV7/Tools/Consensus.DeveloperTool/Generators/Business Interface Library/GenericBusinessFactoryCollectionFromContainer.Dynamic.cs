﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class GenericBusinessFactoryCollectionFromContainerDynamic : GeneratedInterface
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
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Represents a collection of factory instances which are responsible for the instantiation of the business models " + (String.IsNullOrEmpty(this.Container.ContainerDescription) ? "in the " + this.Container.ContainerName + " namespace" : "pertaining to " + this.Container.ContainerDescription.ToLower()); }
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
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "IFactoryCollection";
            }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "I" + this.Container.ContainerName + "FactoryCollection"; }
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
        public GenericBusinessFactoryCollectionFromContainerDynamic(GeneratedProject project, DomainContainer container) : base(project)
        {
            _container = container;
        }

        #endregion
    }
}
