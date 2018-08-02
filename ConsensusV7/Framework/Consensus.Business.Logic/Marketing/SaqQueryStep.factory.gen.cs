using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqQueryStepModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqQueryStepFactory : LocalFactory<LocalSaqQueryStepModel, SaqQueryStepsRecord, Int32>, ISaqQueryStepFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SaqQueryStepModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SaqQueryStepModel' /> instance.
        /// </returns>
        public LocalSaqQueryStepModel Create()
        {
            return new LocalSaqQueryStepModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SaqQueryStepModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SaqQueryStepModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSaqQueryStepModel> FetchAll()
        {
            IEnumerable<SaqQueryStepsRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueryStep.FetchAll();
            foreach (SaqQueryStepsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueryStepModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SaqQueryStepModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SaqQueryStepModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueryStepModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSaqQueryStepModel FetchById(Int32 id)
        {
            SaqQueryStepsRecord record = this.Provider.DataProvider.Marketing.SaqQueryStep.FetchById(id);
            if (record == null)
                return null;
            return new LocalSaqQueryStepModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SaqQueryStep/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.SaqQueryStep.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueryStepModel' /> instances.
        /// </summary>
        /// <param name="stepQueryId">
        ///     The value which identifies the <see cref='SaqQueryStepModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueryStepModel' /> instances that match the specified <paramref name='stepQueryId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueryStepModel> FetchAllByStepQueryId(Int64 stepQueryId)
        {
            IEnumerable<SaqQueryStepsRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueryStep.FetchAllByQryId(stepQueryId);
            foreach (SaqQueryStepsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueryStepModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueryStepModel' /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref='SaqQueryStepModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueryStepModel' /> instances that match the specified <paramref name='stepId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueryStepModel> FetchAllByStepId(Int64 stepId)
        {
            IEnumerable<SaqQueryStepsRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueryStep.FetchAllByStepId(stepId);
            foreach (SaqQueryStepsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueryStepModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueryStepModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueryStepModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqQueryStepModel ISaqQueryStepFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueryStepModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryStepModel> ISaqQueryStepFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueryStepModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueryStepModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqQueryStepModel ISaqQueryStepFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISaqQueryStepFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </summary>
        /// <param name="stepQueryId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instances that match the specified <paramref name="stepQueryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryStepModel> ISaqQueryStepFactory.FetchAllByStepQueryId(System.Int64 stepQueryId)
        {
            return this.FetchAllByStepQueryId(stepQueryId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryStepModel> ISaqQueryStepFactory.FetchAllByStepId(System.Int64 stepId)
        {
            return this.FetchAllByStepId(stepId);
        }

        #endregion
    }
}
