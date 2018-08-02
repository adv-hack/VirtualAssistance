using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TemplateModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTemplateFactory : LocalFactory<LocalTemplateModel, TemplateXrefRecord, String>, ITemplateFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='TemplateModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='TemplateModel' /> instance.
        /// </returns>
        public LocalTemplateModel Create()
        {
            return new LocalTemplateModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='TemplateModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='TemplateModel' /> instances.
        /// </returns>
        public IEnumerable<LocalTemplateModel> FetchAll()
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAll();
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.Type == 0)
                        yield return new LocalTemplateResourceModel(this.Provider, record);
                    else if (record.Type == 2)
                        yield return new LocalTemplateRoomModel(this.Provider, record);
                    else if (record.Type == 1)
                        yield return new LocalTemplateTrainerModel(this.Provider, record);
                    else
                        yield return new LocalTemplateModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='TemplateModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='TemplateModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalTemplateModel FetchById(String id)
        {
            TemplateXrefRecord record = this.Provider.DataProvider.Learning.Template.FetchById(id);
            if (record == null)
                return null;
            if (record.Type == 0)
                return new LocalTemplateResourceModel(this.Provider, record);
            if (record.Type == 2)
                return new LocalTemplateRoomModel(this.Provider, record);
            if (record.Type == 1)
                return new LocalTemplateTrainerModel(this.Provider, record);
            return new LocalTemplateModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Template/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Template.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TemplateModel' /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref='TemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateModel' /> instances that match the specified <paramref name='billOfMaterialId' />.
        /// </returns>
        public IEnumerable<LocalTemplateModel> FetchAllByBillOfMaterialId(String billOfMaterialId)
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAllByBomId(billOfMaterialId);
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.Type == 0)
                        yield return new LocalTemplateResourceModel(this.Provider, record);
                    else if (record.Type == 2)
                        yield return new LocalTemplateRoomModel(this.Provider, record);
                    else if (record.Type == 1)
                        yield return new LocalTemplateTrainerModel(this.Provider, record);
                    else
                        yield return new LocalTemplateModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:TemplateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateModel" /> instance.
        /// </returns>
        Consensus.Learning.ITemplateModel ITemplateFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateModel> ITemplateFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ITemplateModel ITemplateFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ITemplateFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateModel> ITemplateFactory.FetchAllByBillOfMaterialId(System.String billOfMaterialId)
        {
            return this.FetchAllByBillOfMaterialId(billOfMaterialId);
        }

        #endregion
    }
}
