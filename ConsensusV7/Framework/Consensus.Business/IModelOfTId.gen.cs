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
    /// <typeparam name="TId">
    ///     The data type of the unique id which distinctly identifies the instance of the business model.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IModel<TId> : IModel where TId : IComparable<TId>, IEquatable<TId>
    {
        /// <summary>
        ///     Gets the unique id which distinctly identifies the instance of the business model.
        /// </summary>
        TId Id
        {
            get;
        }
    }
}
