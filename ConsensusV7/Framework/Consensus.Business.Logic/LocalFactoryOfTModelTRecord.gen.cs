using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for locally-executable business factories which support business model instantiation.
    /// </summary>
    /// <typeparam name="TModel">
    ///     The type of business model which is instantiated by the factory.
    /// </typeparam>
    /// <typeparam name="TRecord">
    ///     The data type of the record that is encapsulated by the business model.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class LocalFactory<TModel, TRecord> : LocalFactory<TModel> where TModel : LocalModel<TRecord> where TRecord : Record, Cloneable<TRecord>, IEquatable<TRecord>, new()
    {
    }
}
