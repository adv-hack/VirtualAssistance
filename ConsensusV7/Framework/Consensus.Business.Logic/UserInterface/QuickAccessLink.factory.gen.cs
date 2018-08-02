using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="QuickAccessLinkModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalQuickAccessLinkFactory : LocalFactory<LocalQuickAccessLinkModel, QuickaccesslinkRecord, Int32>, IQuickAccessLinkFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='QuickAccessLinkModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='QuickAccessLinkModel' /> instance.
        /// </returns>
        public LocalQuickAccessLinkModel Create()
        {
            return new LocalQuickAccessLinkModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='QuickAccessLinkModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='QuickAccessLinkModel' /> instances.
        /// </returns>
        public IEnumerable<LocalQuickAccessLinkModel> FetchAll()
        {
            IEnumerable<QuickaccesslinkRecord> recordCollection = this.Provider.DataProvider.UserInterface.QuickAccessLink.FetchAll();
            foreach (QuickaccesslinkRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalQuickAccessLinkModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='QuickAccessLinkModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='QuickAccessLinkModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='QuickAccessLinkModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalQuickAccessLinkModel FetchById(Int32 id)
        {
            QuickaccesslinkRecord record = this.Provider.DataProvider.UserInterface.QuickAccessLink.FetchById(id);
            if (record == null)
                return null;
            return new LocalQuickAccessLinkModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='QuickAccessLink/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.QuickAccessLink.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='QuickAccessLinkModel' /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref='QuickAccessLinkModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='QuickAccessLinkModel' /> instances that match the specified <paramref name='userId' />.
        /// </returns>
        public IEnumerable<LocalQuickAccessLinkModel> FetchAllByUserId(Int32 userId)
        {
            IEnumerable<QuickaccesslinkRecord> recordCollection = this.Provider.DataProvider.UserInterface.QuickAccessLink.FetchAllByUserId(userId);
            foreach (QuickaccesslinkRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalQuickAccessLinkModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:QuickAccessLinkModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:QuickAccessLinkModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IQuickAccessLinkModel IQuickAccessLinkFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:QuickAccessLinkModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:QuickAccessLinkModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IQuickAccessLinkModel> IQuickAccessLinkFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:QuickAccessLinkModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:QuickAccessLinkModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:QuickAccessLinkModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IQuickAccessLinkModel IQuickAccessLinkFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IQuickAccessLinkFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:QuickAccessLinkModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:QuickAccessLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:QuickAccessLinkModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IQuickAccessLinkModel> IQuickAccessLinkFactory.FetchAllByUserId(System.Int32 userId)
        {
            return this.FetchAllByUserId(userId);
        }

        #endregion
    }
}
