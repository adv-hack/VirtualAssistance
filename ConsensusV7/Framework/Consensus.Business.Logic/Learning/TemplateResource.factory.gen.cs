using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TemplateResourceModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTemplateResourceFactory : LocalFactory<LocalTemplateResourceModel, TemplateXrefRecord, String>, ITemplateResourceFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='TemplateResourceModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='TemplateResourceModel' /> instance.
        /// </returns>
        public LocalTemplateResourceModel Create()
        {
            return new LocalTemplateResourceModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='TemplateResourceModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='TemplateResourceModel' /> instances.
        /// </returns>
        public IEnumerable<LocalTemplateResourceModel> FetchAll()
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAll();
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null && record.Type == 0)
                {
                    yield return new LocalTemplateResourceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='TemplateResourceModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='TemplateResourceModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateResourceModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalTemplateResourceModel FetchById(String id)
        {
            TemplateXrefRecord record = this.Provider.DataProvider.Learning.Template.FetchById(id);
            if (record == null)
                return null;
            return new LocalTemplateResourceModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='TemplateResource/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Template.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TemplateResourceModel' /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref='TemplateResourceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateResourceModel' /> instances that match the specified <paramref name='billOfMaterialId' />.
        /// </returns>
        public IEnumerable<LocalTemplateResourceModel> FetchAllByBillOfMaterialId(String billOfMaterialId)
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAllByBomId(billOfMaterialId);
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null && record.Type == 0)
                {
                    yield return new LocalTemplateResourceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TemplateResourceModel' /> instances.
        /// </summary>
        /// <param name="resourceId">
        ///     The value which identifies the <see cref='TemplateResourceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateResourceModel' /> instances that match the specified <paramref name='resourceId' />.
        /// </returns>
        public IEnumerable<LocalTemplateResourceModel> FetchAllByResourceId(String resourceId)
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAllByProdId(resourceId);
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null && record.Type == 0)
                {
                    yield return new LocalTemplateResourceModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:TemplateResourceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateResourceModel" /> instance.
        /// </returns>
        Consensus.Learning.ITemplateResourceModel ITemplateResourceFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateResourceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateResourceModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateResourceModel> ITemplateResourceFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateResourceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateResourceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateResourceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ITemplateResourceModel ITemplateResourceFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ITemplateResourceFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateResourceModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateResourceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateResourceModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateResourceModel> ITemplateResourceFactory.FetchAllByBillOfMaterialId(System.String billOfMaterialId)
        {
            return this.FetchAllByBillOfMaterialId(billOfMaterialId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateResourceModel" /> instances.
        /// </summary>
        /// <param name="resourceId">
        ///     The value which identifies the <see cref="!:TemplateResourceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateResourceModel" /> instances that match the specified <paramref name="resourceId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateResourceModel> ITemplateResourceFactory.FetchAllByResourceId(System.String resourceId)
        {
            return this.FetchAllByResourceId(resourceId);
        }

        #endregion
    }
}
