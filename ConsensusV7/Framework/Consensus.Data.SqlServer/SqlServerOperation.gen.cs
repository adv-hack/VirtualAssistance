using System;

namespace Consensus
{
    /// <summary>
    ///     Enumerates the standard data access operations that can be executed against the Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public enum SqlServerOperation
    {
        /// <summary>
        ///     Creates a new record within the repository.
        /// </summary>
        Create = 0,

        /// <summary>
        ///     Modifies an existing record within the repository.
        /// </summary>
        Modify = 1,

        /// <summary>
        ///     Removes an existing record from the repository.
        /// </summary>
        Remove = 2,

        /// <summary>
        ///     Retrieves a single record from the repository.
        /// </summary>
        Fetch = 3,

        /// <summary>
        ///     Retrieves multiple records from the repository.
        /// </summary>
        FetchAll = 4
    }
}
