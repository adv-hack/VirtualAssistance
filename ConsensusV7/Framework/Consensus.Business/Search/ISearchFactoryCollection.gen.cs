using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Search namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SearchTypeModel" /> objects.
        /// </summary>
        Consensus.Search.ISearchTypeFactory SearchType
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SearchColumnModel" /> objects.
        /// </summary>
        Consensus.Search.ISearchColumnFactory SearchColumn
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SearchParameterModel" /> objects.
        /// </summary>
        Consensus.Search.ISearchParameterFactory SearchParameter
        {
            get;
        }
    }
}
