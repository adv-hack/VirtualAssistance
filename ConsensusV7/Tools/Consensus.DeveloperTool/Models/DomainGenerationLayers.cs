using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Enumerates the different generation layers.
    /// </summary>
    public enum DomainGenerationLayers
    {
        /// <summary>
        ///     All layers will be generated.
        /// </summary>
        All,

        /// <summary>
        ///     The data access layer will be generated.
        /// </summary>
        DataAccessLayer,

        /// <summary>
        ///     The business logic layer will be generated.
        /// </summary>
        BusinessLogicLayer,

        /// <summary>
        ///     The client-consumable classes will be generated.
        /// </summary>
        ClientConsumerLayer,

        /// <summary>
        ///     The stored procedure logic will be generated.
        /// </summary>
        StoredProcedures

    }
}
