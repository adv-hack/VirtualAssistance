using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LetterTemplateTypeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLetterTemplateTypeFactory : LocalFactory<LocalLetterTemplateTypeModel, LettmplttypeRecord, String>, ILetterTemplateTypeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LetterTemplateTypeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LetterTemplateTypeModel' /> instance.
        /// </returns>
        public LocalLetterTemplateTypeModel Create()
        {
            return new LocalLetterTemplateTypeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LetterTemplateTypeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LetterTemplateTypeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLetterTemplateTypeModel> FetchAll()
        {
            IEnumerable<LettmplttypeRecord> recordCollection = this.Provider.DataProvider.Document.LetterTemplateType.FetchAll();
            foreach (LettmplttypeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLetterTemplateTypeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LetterTemplateTypeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LetterTemplateTypeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LetterTemplateTypeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLetterTemplateTypeModel FetchById(String id)
        {
            LettmplttypeRecord record = this.Provider.DataProvider.Document.LetterTemplateType.FetchById(id);
            if (record == null)
                return null;
            return new LocalLetterTemplateTypeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='LetterTemplateType/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.LetterTemplateType.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </returns>
        Consensus.Document.ILetterTemplateTypeModel ILetterTemplateTypeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LetterTemplateTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LetterTemplateTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateTypeModel> ILetterTemplateTypeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LetterTemplateTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ILetterTemplateTypeModel ILetterTemplateTypeFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ILetterTemplateTypeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
