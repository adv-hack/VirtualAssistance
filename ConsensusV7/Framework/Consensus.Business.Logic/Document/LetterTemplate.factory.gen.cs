using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LetterTemplateModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLetterTemplateFactory : LocalFactory<LocalLetterTemplateModel, LettertmpltRecord, String>, ILetterTemplateFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LetterTemplateModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LetterTemplateModel' /> instance.
        /// </returns>
        public LocalLetterTemplateModel Create()
        {
            return new LocalLetterTemplateModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LetterTemplateModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LetterTemplateModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLetterTemplateModel> FetchAll()
        {
            IEnumerable<LettertmpltRecord> recordCollection = this.Provider.DataProvider.Document.LetterTemplate.FetchAll();
            foreach (LettertmpltRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLetterTemplateModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LetterTemplateModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LetterTemplateModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LetterTemplateModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLetterTemplateModel FetchById(String id)
        {
            LettertmpltRecord record = this.Provider.DataProvider.Document.LetterTemplate.FetchById(id);
            if (record == null)
                return null;
            return new LocalLetterTemplateModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='LetterTemplate/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.LetterTemplate.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LetterTemplateModel' /> instances.
        /// </summary>
        /// <param name="typeId">
        ///     The value which identifies the <see cref='LetterTemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LetterTemplateModel' /> instances that match the specified <paramref name='typeId' />.
        /// </returns>
        public IEnumerable<LocalLetterTemplateModel> FetchAllByTypeId(String typeId)
        {
            IEnumerable<LettertmpltRecord> recordCollection = this.Provider.DataProvider.Document.LetterTemplate.FetchAllByType(typeId);
            foreach (LettertmpltRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLetterTemplateModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LetterTemplateModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='LetterTemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LetterTemplateModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalLetterTemplateModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<LettertmpltRecord> recordCollection = this.Provider.DataProvider.Document.LetterTemplate.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (LettertmpltRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLetterTemplateModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LetterTemplateModel' /> instances.
        /// </summary>
        /// <param name="sendFromId">
        ///     The value which identifies the <see cref='LetterTemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LetterTemplateModel' /> instances that match the specified <paramref name='sendFromId' />.
        /// </returns>
        public IEnumerable<LocalLetterTemplateModel> FetchAllBySendFromId(String sendFromId)
        {
            IEnumerable<LettertmpltRecord> recordCollection = this.Provider.DataProvider.Document.LetterTemplate.FetchAllBySendProleId(sendFromId);
            foreach (LettertmpltRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLetterTemplateModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:LetterTemplateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LetterTemplateModel" /> instance.
        /// </returns>
        Consensus.Document.ILetterTemplateModel ILetterTemplateFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LetterTemplateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateModel> ILetterTemplateFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LetterTemplateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LetterTemplateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ILetterTemplateModel ILetterTemplateFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ILetterTemplateFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="typeId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="typeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateModel> ILetterTemplateFactory.FetchAllByTypeId(System.String typeId)
        {
            return this.FetchAllByTypeId(typeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateModel> ILetterTemplateFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="sendFromId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="sendFromId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateModel> ILetterTemplateFactory.FetchAllBySendFromId(System.String sendFromId)
        {
            return this.FetchAllBySendFromId(sendFromId);
        }

        #endregion
    }
}
