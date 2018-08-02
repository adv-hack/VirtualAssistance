using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="NotesModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface INotesFactory : IFactory<INotesModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:NotesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:NotesModel" /> instance.
        /// </returns>
        Consensus.Common.INotesModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:NotesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:NotesModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.INotesModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:NotesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:NotesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:NotesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.INotesModel FetchById(System.String id);

        System.String GetTableName();
    }
}
