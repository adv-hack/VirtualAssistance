using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="C4textModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalC4textFactory : LocalFactory<LocalC4textModel, C4textRecord, String>, IC4textFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='C4textModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='C4textModel' /> instance.
        /// </returns>
        public LocalC4textModel Create()
        {
            return new LocalC4textModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='C4textModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='C4textModel' /> instances.
        /// </returns>
        public IEnumerable<LocalC4textModel> FetchAll()
        {
            IEnumerable<C4textRecord> recordCollection = this.Provider.DataProvider.Activities.C4text.FetchAll();
            foreach (C4textRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalC4textModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='C4textModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='C4textModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='C4textModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalC4textModel FetchById(String id)
        {
            C4textRecord record = this.Provider.DataProvider.Activities.C4text.FetchById(id);
            if (record == null)
                return null;
            return new LocalC4textModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='C4text/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Activities.C4text.TableName;
        }

        #endregion

        #region implementations

        System.Collections.Generic.IEnumerable<Consensus.Activities.IC4textModel> IC4textFactory.FetchAllByOwnerUrlAndOwnerId(System.String ownerUrl, System.String ownerId)
        {
            return this.FetchAllByOwnerUrlAndOwnerId(ownerUrl, ownerId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:C4textModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:C4textModel" /> instance.
        /// </returns>
        Consensus.Activities.IC4textModel IC4textFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:C4textModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:C4textModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IC4textModel> IC4textFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:C4textModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:C4textModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:C4textModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IC4textModel IC4textFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IC4textFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
