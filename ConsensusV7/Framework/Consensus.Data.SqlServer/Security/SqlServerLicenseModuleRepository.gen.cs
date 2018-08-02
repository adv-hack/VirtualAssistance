using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LicenseModuleRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLicenseModuleRepository : SqlServerRepository<LicenseModuleRecord, Int32>, ILicenseModuleRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Security"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "LicenseModule"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="LicenseModuleRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "License_Module"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="LicenseModuleRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LicenseModuleRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, LicenseModuleRecord record)
        {
            record.Id = dataRecord["LM_ID"].ConvertTo<Int32>();
            record.LicId = dataRecord["LM_LIC_ID"].ConvertTo<Guid>();
            record.ModId = dataRecord["LM_MOD_ID"].ConvertTo<Guid>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LicenseModuleRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, LicenseModuleRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LM_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_LM_LIC_ID", record.LicId);
            this.MapParameterIn(command, "@PA_LM_MOD_ID", record.ModId);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LicenseModuleRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, LicenseModuleRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LM_ID", record.Id);
            record.LicId = this.MapParameterOut(command, "@PA_LM_LIC_ID", record.LicId);
            record.ModId = this.MapParameterOut(command, "@PA_LM_MOD_ID", record.ModId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ILicenseModuleRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.LicenseModuleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="licId">
        ///     The value which identifies the <see cref="!:LicenseModuleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.LicenseModuleRecord" /> instances that match the specified <paramref name="licId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.LicenseModuleRecord> ILicenseModuleRepository.FetchAllByLicId(System.Guid licId)
        {
            return this.FetchAllByLicId(licId);
        }

        #endregion
    }
}
