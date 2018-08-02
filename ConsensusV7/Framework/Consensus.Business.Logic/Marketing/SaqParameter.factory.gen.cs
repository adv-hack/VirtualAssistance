using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqParameterModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqParameterFactory : LocalFactory<LocalSaqParameterModel, SaqStepParamsRecord, Int64>, ISaqParameterFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SaqParameterModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SaqParameterModel' /> instance.
        /// </returns>
        public LocalSaqParameterModel Create()
        {
            return new LocalSaqParameterModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SaqParameterModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SaqParameterModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSaqParameterModel> FetchAll()
        {
            IEnumerable<SaqStepParamsRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqParameter.FetchAll();
            foreach (SaqStepParamsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqParameterModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SaqParameterModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SaqParameterModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqParameterModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSaqParameterModel FetchById(Int64 id)
        {
            SaqStepParamsRecord record = this.Provider.DataProvider.Marketing.SaqParameter.FetchById(id);
            if (record == null)
                return null;
            return new LocalSaqParameterModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SaqParameter/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.SaqParameter.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqParameterModel' /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref='SaqParameterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqParameterModel' /> instances that match the specified <paramref name='stepId' />.
        /// </returns>
        public IEnumerable<LocalSaqParameterModel> FetchAllByStepId(Int64 stepId)
        {
            IEnumerable<SaqStepParamsRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqParameter.FetchAllByStepId(stepId);
            foreach (SaqStepParamsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqParameterModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqParameterModel' /> instances.
        /// </summary>
        /// <param name="filterFieldId">
        ///     The value which identifies the <see cref='SaqParameterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqParameterModel' /> instances that match the specified <paramref name='filterFieldId' />.
        /// </returns>
        public IEnumerable<LocalSaqParameterModel> FetchAllByFilterFieldId(Int64 filterFieldId)
        {
            IEnumerable<SaqStepParamsRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqParameter.FetchAllByFId(filterFieldId);
            foreach (SaqStepParamsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqParameterModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SaqParameterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqParameterModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqParameterModel ISaqParameterFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqParameterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqParameterModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqParameterModel> ISaqParameterFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqParameterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqParameterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqParameterModel ISaqParameterFactory.FetchById(System.Int64 id)
        {
            return this.FetchById(id);
        }

        System.String ISaqParameterFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqParameterModel" /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqParameterModel> ISaqParameterFactory.FetchAllByStepId(System.Int64 stepId)
        {
            return this.FetchAllByStepId(stepId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqParameterModel" /> instances.
        /// </summary>
        /// <param name="filterFieldId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instances that match the specified <paramref name="filterFieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqParameterModel> ISaqParameterFactory.FetchAllByFilterFieldId(System.Int64 filterFieldId)
        {
            return this.FetchAllByFilterFieldId(filterFieldId);
        }

        #endregion
    }
}
