using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CodeHeaderModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCodeHeaderFactory : LocalFactory<LocalCodeHeaderModel, CodeHeaderRecord, String>, ICodeHeaderFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CodeHeaderModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CodeHeaderModel' /> instance.
        /// </returns>
        public LocalCodeHeaderModel Create()
        {
            return new LocalCodeHeaderModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CodeHeaderModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CodeHeaderModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCodeHeaderModel> FetchAll()
        {
            IEnumerable<CodeHeaderRecord> recordCollection = this.Provider.DataProvider.Common.CodeHeader.FetchAll();
            foreach (CodeHeaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCodeHeaderModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CodeHeaderModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CodeHeaderModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CodeHeaderModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCodeHeaderModel FetchById(String id)
        {
            CodeHeaderRecord record = this.Provider.DataProvider.Common.CodeHeader.FetchById(id);
            if (record == null)
                return null;
            return new LocalCodeHeaderModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='CodeHeader/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.CodeHeader.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:CodeHeaderModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeHeaderModel" /> instance.
        /// </returns>
        Consensus.Common.ICodeHeaderModel ICodeHeaderFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CodeHeaderModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CodeHeaderModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ICodeHeaderModel> ICodeHeaderFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeHeaderModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CodeHeaderModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeHeaderModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ICodeHeaderModel ICodeHeaderFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ICodeHeaderFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
