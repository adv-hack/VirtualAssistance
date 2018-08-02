using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LicenseLimitModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLicenseLimitFactory : LocalFactory<LocalLicenseLimitModel, LicenseLimitRecord, Int32>, ILicenseLimitFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LicenseLimitModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LicenseLimitModel' /> instance.
        /// </returns>
        public LocalLicenseLimitModel Create()
        {
            return new LocalLicenseLimitModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LicenseLimitModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LicenseLimitModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLicenseLimitModel> FetchAll()
        {
            IEnumerable<LicenseLimitRecord> recordCollection = this.Provider.DataProvider.Security.LicenseLimit.FetchAll();
            foreach (LicenseLimitRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLicenseLimitModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LicenseLimitModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LicenseLimitModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LicenseLimitModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLicenseLimitModel FetchById(Int32 id)
        {
            LicenseLimitRecord record = this.Provider.DataProvider.Security.LicenseLimit.FetchById(id);
            if (record == null)
                return null;
            return new LocalLicenseLimitModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='LicenseLimit/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.LicenseLimit.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LicenseLimitModel' /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref='LicenseLimitModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LicenseLimitModel' /> instances that match the specified <paramref name='licenseId' />.
        /// </returns>
        public IEnumerable<LocalLicenseLimitModel> FetchAllByLicenseId(Guid licenseId)
        {
            IEnumerable<LicenseLimitRecord> recordCollection = this.Provider.DataProvider.Security.LicenseLimit.FetchAllByLicId(licenseId);
            foreach (LicenseLimitRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLicenseLimitModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:LicenseLimitModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseLimitModel" /> instance.
        /// </returns>
        Consensus.Security.ILicenseLimitModel ILicenseLimitFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseLimitModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseLimitModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseLimitModel> ILicenseLimitFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseLimitModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseLimitModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseLimitModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.ILicenseLimitModel ILicenseLimitFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ILicenseLimitFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseLimitModel" /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref="!:LicenseLimitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseLimitModel" /> instances that match the specified <paramref name="licenseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseLimitModel> ILicenseLimitFactory.FetchAllByLicenseId(System.Guid licenseId)
        {
            return this.FetchAllByLicenseId(licenseId);
        }

        #endregion
    }
}
