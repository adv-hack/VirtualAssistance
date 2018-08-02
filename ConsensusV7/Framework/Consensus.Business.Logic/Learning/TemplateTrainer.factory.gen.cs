using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TemplateTrainerModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTemplateTrainerFactory : LocalFactory<LocalTemplateTrainerModel, TemplateXrefRecord, String>, ITemplateTrainerFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='TemplateTrainerModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='TemplateTrainerModel' /> instance.
        /// </returns>
        public LocalTemplateTrainerModel Create()
        {
            return new LocalTemplateTrainerModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='TemplateTrainerModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='TemplateTrainerModel' /> instances.
        /// </returns>
        public IEnumerable<LocalTemplateTrainerModel> FetchAll()
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAll();
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null && record.Type == 1)
                {
                    yield return new LocalTemplateTrainerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='TemplateTrainerModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='TemplateTrainerModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateTrainerModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalTemplateTrainerModel FetchById(String id)
        {
            TemplateXrefRecord record = this.Provider.DataProvider.Learning.Template.FetchById(id);
            if (record == null)
                return null;
            return new LocalTemplateTrainerModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='TemplateTrainer/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Template.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TemplateTrainerModel' /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref='TemplateTrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateTrainerModel' /> instances that match the specified <paramref name='billOfMaterialId' />.
        /// </returns>
        public IEnumerable<LocalTemplateTrainerModel> FetchAllByBillOfMaterialId(String billOfMaterialId)
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAllByBomId(billOfMaterialId);
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null && record.Type == 1)
                {
                    yield return new LocalTemplateTrainerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TemplateTrainerModel' /> instances.
        /// </summary>
        /// <param name="trainerRoleId">
        ///     The value which identifies the <see cref='TemplateTrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateTrainerModel' /> instances that match the specified <paramref name='trainerRoleId' />.
        /// </returns>
        public IEnumerable<LocalTemplateTrainerModel> FetchAllByTrainerRoleId(String trainerRoleId)
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAllByTrainProleId(trainerRoleId);
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null && record.Type == 1)
                {
                    yield return new LocalTemplateTrainerModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:TemplateTrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateTrainerModel" /> instance.
        /// </returns>
        Consensus.Learning.ITemplateTrainerModel ITemplateTrainerFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateTrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateTrainerModel> ITemplateTrainerFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateTrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateTrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ITemplateTrainerModel ITemplateTrainerFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ITemplateTrainerFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateTrainerModel> ITemplateTrainerFactory.FetchAllByBillOfMaterialId(System.String billOfMaterialId)
        {
            return this.FetchAllByBillOfMaterialId(billOfMaterialId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </summary>
        /// <param name="trainerRoleId">
        ///     The value which identifies the <see cref="!:TemplateTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instances that match the specified <paramref name="trainerRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateTrainerModel> ITemplateTrainerFactory.FetchAllByTrainerRoleId(System.String trainerRoleId)
        {
            return this.FetchAllByTrainerRoleId(trainerRoleId);
        }

        #endregion
    }
}
