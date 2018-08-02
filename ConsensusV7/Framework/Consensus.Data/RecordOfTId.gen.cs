using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Represents a data structure within the persistence mechanism, which is distinctly identifiable by a unique value.
    /// </summary>
    /// <typeparam name="TId">
    ///     The data type of the unique value which distinctly identifies the instance of the data structure.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class Record<TId> : Record where TId : IComparable<TId>, IEquatable<TId>
    {
        /// <summary>
        ///     The unique value which distinctly identifies the instance of the data structure.
        /// </summary>
        public TId Id;
    }
}
