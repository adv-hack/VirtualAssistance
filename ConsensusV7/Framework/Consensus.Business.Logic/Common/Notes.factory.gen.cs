using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="NotesModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalNotesFactory : LocalFactory<LocalNotesModel, C4textRecord, String>, INotesFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='NotesModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='NotesModel' /> instance.
        /// </returns>
        public LocalNotesModel Create()
        {
            return new LocalNotesModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='NotesModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='NotesModel' /> instances.
        /// </returns>
        public IEnumerable<LocalNotesModel> FetchAll()
        {
            IEnumerable<C4textRecord> recordCollection = this.Provider.DataProvider.Common.Notes.FetchAll();
            foreach (C4textRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalNotesModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='NotesModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='NotesModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='NotesModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalNotesModel FetchById(String id)
        {
            C4textRecord record = this.Provider.DataProvider.Common.Notes.FetchById(id);
            if (record == null)
                return null;
            return new LocalNotesModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Notes/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.Notes.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:NotesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:NotesModel" /> instance.
        /// </returns>
        Consensus.Common.INotesModel INotesFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:NotesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:NotesModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.INotesModel> INotesFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:NotesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:NotesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:NotesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.INotesModel INotesFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String INotesFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
