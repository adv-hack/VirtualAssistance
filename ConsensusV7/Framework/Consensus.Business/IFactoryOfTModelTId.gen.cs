using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Supports the instantiation of the <typeparamref name='TModel' /> business model.
    /// </summary>
    /// <typeparam name="TModel">
    ///     The type of business model which is instantiated by the factory.
    /// </typeparam>
    /// <typeparam name="TId">
    ///     The data type of the unique id which distinctly identifies the instance of the business model.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IFactory<TModel, TId> : IFactory<TModel> where TModel : IModel<TId> where TId : IComparable<TId>, IEquatable<TId>
    {
    }
}
