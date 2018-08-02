using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TemplateRoomModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTemplateRoomFactory : LocalFactory<LocalTemplateRoomModel, TemplateXrefRecord, String>, ITemplateRoomFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='TemplateRoomModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='TemplateRoomModel' /> instance.
        /// </returns>
        public LocalTemplateRoomModel Create()
        {
            return new LocalTemplateRoomModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='TemplateRoomModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='TemplateRoomModel' /> instances.
        /// </returns>
        public IEnumerable<LocalTemplateRoomModel> FetchAll()
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAll();
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null && record.Type == 2)
                {
                    yield return new LocalTemplateRoomModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='TemplateRoomModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='TemplateRoomModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateRoomModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalTemplateRoomModel FetchById(String id)
        {
            TemplateXrefRecord record = this.Provider.DataProvider.Learning.Template.FetchById(id);
            if (record == null)
                return null;
            return new LocalTemplateRoomModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='TemplateRoom/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Template.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TemplateRoomModel' /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref='TemplateRoomModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TemplateRoomModel' /> instances that match the specified <paramref name='billOfMaterialId' />.
        /// </returns>
        public IEnumerable<LocalTemplateRoomModel> FetchAllByBillOfMaterialId(String billOfMaterialId)
        {
            IEnumerable<TemplateXrefRecord> recordCollection = this.Provider.DataProvider.Learning.Template.FetchAllByBomId(billOfMaterialId);
            foreach (TemplateXrefRecord record in recordCollection)
            {
                if (record != null && record.Type == 2)
                {
                    yield return new LocalTemplateRoomModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:TemplateRoomModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateRoomModel" /> instance.
        /// </returns>
        Consensus.Learning.ITemplateRoomModel ITemplateRoomFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateRoomModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateRoomModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateRoomModel> ITemplateRoomFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateRoomModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateRoomModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateRoomModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ITemplateRoomModel ITemplateRoomFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ITemplateRoomFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateRoomModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateRoomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateRoomModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateRoomModel> ITemplateRoomFactory.FetchAllByBillOfMaterialId(System.String billOfMaterialId)
        {
            return this.FetchAllByBillOfMaterialId(billOfMaterialId);
        }

        #endregion
    }
}
