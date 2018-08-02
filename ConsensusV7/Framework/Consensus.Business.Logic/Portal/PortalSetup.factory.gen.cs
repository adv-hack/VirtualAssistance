using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalSetupModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalSetupFactory : LocalFactory<LocalPortalSetupModel, PortalSetupRecord, Int32>, IPortalSetupFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PortalSetupModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PortalSetupModel' /> instance.
        /// </returns>
        public LocalPortalSetupModel Create()
        {
            return new LocalPortalSetupModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PortalSetupModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PortalSetupModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPortalSetupModel> FetchAll()
        {
            IEnumerable<PortalSetupRecord> recordCollection = this.Provider.DataProvider.Portal.PortalSetup.FetchAll();
            foreach (PortalSetupRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalSetupModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PortalSetupModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PortalSetupModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalSetupModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPortalSetupModel FetchById(Int32 id)
        {
            PortalSetupRecord record = this.Provider.DataProvider.Portal.PortalSetup.FetchById(id);
            if (record == null)
                return null;
            return new LocalPortalSetupModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PortalSetup/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Portal.PortalSetup.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PortalSetupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalSetupModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalSetupModel IPortalSetupFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalSetupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalSetupModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalSetupModel> IPortalSetupFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalSetupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalSetupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalSetupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalSetupModel IPortalSetupFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IPortalSetupFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
