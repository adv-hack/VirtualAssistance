using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Logistics
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Logistics namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLogisticsFactoryCollection : LocalFactoryCollection, ILogisticsFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProjectModel" /> objects.
        /// </summary>
        private LocalProjectFactory _project;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProjectModel" /> objects.
        /// </summary>
        public LocalProjectFactory Project
        {
            get { return LocalFactory.Create(this.Provider, ref _project); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProjectModel" /> objects.
        /// </summary>
        Consensus.Logistics.IProjectFactory ILogisticsFactoryCollection.Project
        {
            get { return this.Project; }
        }

        #endregion
    }
}
