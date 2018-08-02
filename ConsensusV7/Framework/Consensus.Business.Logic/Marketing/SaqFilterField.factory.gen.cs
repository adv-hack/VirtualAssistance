using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqFilterFieldModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqFilterFieldFactory : LocalFactory<LocalSaqFilterFieldModel, SaqFilterRecord, Int64>, ISaqFilterFieldFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SaqFilterFieldModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SaqFilterFieldModel' /> instance.
        /// </returns>
        public LocalSaqFilterFieldModel Create()
        {
            return new LocalSaqFilterFieldModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SaqFilterFieldModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SaqFilterFieldModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSaqFilterFieldModel> FetchAll()
        {
            IEnumerable<SaqFilterRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqFilterField.FetchAll();
            foreach (SaqFilterRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqFilterFieldModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SaqFilterFieldModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SaqFilterFieldModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqFilterFieldModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSaqFilterFieldModel FetchById(Int64 id)
        {
            SaqFilterRecord record = this.Provider.DataProvider.Marketing.SaqFilterField.FetchById(id);
            if (record == null)
                return null;
            return new LocalSaqFilterFieldModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SaqFilterField/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.SaqFilterField.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SaqFilterFieldModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqFilterFieldModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqFilterFieldModel ISaqFilterFieldFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqFilterFieldModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqFilterFieldModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqFilterFieldModel> ISaqFilterFieldFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqFilterFieldModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqFilterFieldModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqFilterFieldModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqFilterFieldModel ISaqFilterFieldFactory.FetchById(System.Int64 id)
        {
            return this.FetchById(id);
        }

        System.String ISaqFilterFieldFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
