using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqStepModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqStepFactory : LocalFactory<LocalSaqStepModel, SaqStepRecord, Int64>, ISaqStepFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SaqStepModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SaqStepModel' /> instance.
        /// </returns>
        public LocalSaqStepModel Create()
        {
            return new LocalSaqStepModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SaqStepModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SaqStepModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSaqStepModel> FetchAll()
        {
            IEnumerable<SaqStepRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqStep.FetchAll();
            foreach (SaqStepRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqStepModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SaqStepModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SaqStepModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqStepModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSaqStepModel FetchById(Int64 id)
        {
            SaqStepRecord record = this.Provider.DataProvider.Marketing.SaqStep.FetchById(id);
            if (record == null)
                return null;
            return new LocalSaqStepModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SaqStep/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.SaqStep.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqStepModel' /> instances.
        /// </summary>
        /// <param name="ownerRoleId">
        ///     The value which identifies the <see cref='SaqStepModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqStepModel' /> instances that match the specified <paramref name='ownerRoleId' />.
        /// </returns>
        public IEnumerable<LocalSaqStepModel> FetchAllByOwnerRoleId(String ownerRoleId)
        {
            IEnumerable<SaqStepRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqStep.FetchAllByProleId(ownerRoleId);
            foreach (SaqStepRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqStepModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SaqStepModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqStepModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqStepModel ISaqStepFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqStepModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqStepModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqStepModel> ISaqStepFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqStepModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqStepModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqStepModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqStepModel ISaqStepFactory.FetchById(System.Int64 id)
        {
            return this.FetchById(id);
        }

        System.String ISaqStepFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqStepModel" /> instances.
        /// </summary>
        /// <param name="ownerRoleId">
        ///     The value which identifies the <see cref="!:SaqStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqStepModel" /> instances that match the specified <paramref name="ownerRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqStepModel> ISaqStepFactory.FetchAllByOwnerRoleId(System.String ownerRoleId)
        {
            return this.FetchAllByOwnerRoleId(ownerRoleId);
        }

        #endregion
    }
}
