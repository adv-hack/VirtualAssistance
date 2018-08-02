using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TimeSpentModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTimeSpentFactory : LocalFactory<LocalTimeSpentModel, TimeSpentRecord, String>, ITimeSpentFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='TimeSpentModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='TimeSpentModel' /> instance.
        /// </returns>
        public LocalTimeSpentModel Create()
        {
            return new LocalTimeSpentModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='TimeSpentModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='TimeSpentModel' /> instances.
        /// </returns>
        public IEnumerable<LocalTimeSpentModel> FetchAll()
        {
            IEnumerable<TimeSpentRecord> recordCollection = this.Provider.DataProvider.Contact.TimeSpent.FetchAll();
            foreach (TimeSpentRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTimeSpentModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='TimeSpentModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='TimeSpentModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TimeSpentModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalTimeSpentModel FetchById(String id)
        {
            TimeSpentRecord record = this.Provider.DataProvider.Contact.TimeSpent.FetchById(id);
            if (record == null)
                return null;
            return new LocalTimeSpentModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='TimeSpent/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.TimeSpent.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:TimeSpentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TimeSpentModel" /> instance.
        /// </returns>
        Consensus.Contact.ITimeSpentModel ITimeSpentFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TimeSpentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TimeSpentModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITimeSpentModel> ITimeSpentFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TimeSpentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TimeSpentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TimeSpentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ITimeSpentModel ITimeSpentFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ITimeSpentFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
