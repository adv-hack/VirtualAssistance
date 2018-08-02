using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PayscheduleheaderModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPayscheduleheaderFactory : LocalFactory<LocalPayscheduleheaderModel, PayscheduleheaderRecord, Int32>, IPayscheduleheaderFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PayscheduleheaderModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PayscheduleheaderModel' /> instance.
        /// </returns>
        public LocalPayscheduleheaderModel Create()
        {
            return new LocalPayscheduleheaderModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PayscheduleheaderModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PayscheduleheaderModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPayscheduleheaderModel> FetchAll()
        {
            IEnumerable<PayscheduleheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Payscheduleheader.FetchAll();
            foreach (PayscheduleheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPayscheduleheaderModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PayscheduleheaderModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PayscheduleheaderModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PayscheduleheaderModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPayscheduleheaderModel FetchById(Int32 id)
        {
            PayscheduleheaderRecord record = this.Provider.DataProvider.Finance.Payscheduleheader.FetchById(id);
            if (record == null)
                return null;
            return new LocalPayscheduleheaderModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Payscheduleheader/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.Payscheduleheader.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PayscheduleheaderModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PayscheduleheaderModel" /> instance.
        /// </returns>
        Consensus.Finance.IPayscheduleheaderModel IPayscheduleheaderFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PayscheduleheaderModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PayscheduleheaderModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayscheduleheaderModel> IPayscheduleheaderFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PayscheduleheaderModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PayscheduleheaderModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayscheduleheaderModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPayscheduleheaderModel IPayscheduleheaderFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IPayscheduleheaderFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
