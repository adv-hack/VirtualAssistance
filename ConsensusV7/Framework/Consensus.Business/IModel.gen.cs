using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Defines the members that have been exposed by a business model instance, which implements the standardised rules for the Consensus solution.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IModel
    {
        #region properties

        /// <summary>
        ///     Gets whether the underlying data structure has been persisted within the the persistence mechanism.
        /// </summary>
        System.Boolean IsPersisted
        {
            get;
        }

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        System.Boolean IsModified
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Stores the underlying data within the persistence mechanism.
        /// </summary>
        void Save();

        /// <summary>
        ///     Removes the underlying data from the persistence mechanism.
        /// </summary>
        void Delete();

        #endregion
    }
}
