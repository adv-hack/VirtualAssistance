using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CodeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCodeFactory : LocalFactory<LocalCodeModel, CodeRecord, String>, ICodeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CodeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CodeModel' /> instance.
        /// </returns>
        public LocalCodeModel Create()
        {
            return new LocalCodeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CodeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CodeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCodeModel> FetchAll()
        {
            IEnumerable<CodeRecord> recordCollection = this.Provider.DataProvider.Common.Code.FetchAll();
            foreach (CodeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCodeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CodeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CodeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CodeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCodeModel FetchById(String id)
        {
            CodeRecord record = this.Provider.DataProvider.Common.Code.FetchById(id);
            if (record == null)
                return null;
            return new LocalCodeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Code/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.Code.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <param name="codeType">
        ///     The type of the code.
        /// </param>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeModel" /> instance.
        /// </returns>
        Consensus.Common.ICodeModel ICodeFactory.Create(System.String codeType)
        {
            return this.Create(codeType);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ICodeModel ICodeFactory.FetchByTypeAndCode(System.String codeType, System.String codeValue)
        {
            return this.FetchByTypeAndCode(codeType, codeValue);
        }

        /// <summary>
        ///     Retrieves a single <see cref="!:CodeModel" /> instance from the data store.
        /// </summary>
        /// <param name="codeValue3">
        ///     The unique value which distinctly identifies the <see cref="!:CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="codeValue3" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ICodeModel ICodeFactory.FetchByTypeAndCodeValue3(System.String codeType, System.String codeValue3)
        {
            return this.FetchByTypeAndCodeValue3(codeType, codeValue3);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ICodeModel> ICodeFactory.FetchAllByType(System.String codeType)
        {
            return this.FetchAllByType(codeType);
        }

        System.Collections.Generic.IEnumerable<System.Object> ICodeFactory.FetchAllInTree(System.String codeType)
        {
            return this.FetchAllInTree(codeType);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeModel" /> instance.
        /// </returns>
        Consensus.Common.ICodeModel ICodeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CodeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CodeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ICodeModel> ICodeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ICodeModel ICodeFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ICodeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
