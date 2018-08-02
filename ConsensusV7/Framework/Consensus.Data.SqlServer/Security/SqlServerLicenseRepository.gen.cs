using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LicenseRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLicenseRepository : SqlServerRepository<LicenseRecord, Guid>, ILicenseRepository
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
            get { return "License"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="LicenseRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LIC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "License"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="LicenseRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LicenseRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, LicenseRecord record)
        {
            record.Id = dataRecord["LIC_ID"].ConvertTo<Guid>();
            record.Active = dataRecord["LIC_ACTIVE"].ConvertTo<DateTime>();
            record.Expiry = dataRecord["LIC_EXPIRY"].ConvertTo<DateTime?>();
            record.Owner = dataRecord["LIC_OWNER"].ConvertTo<String>();
            record.Signature = dataRecord["LIC_SIGNATURE"].ConvertTo<Byte[]>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LicenseRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, LicenseRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LIC_ID", record.Id);
            this.MapParameterIn(command, "@PA_LIC_ACTIVE", record.Active == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Active);
            this.MapParameterIn(command, "@PA_LIC_EXPIRY", record.Expiry == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Expiry);
            this.MapParameterIn(command, "@PA_LIC_OWNER", record.Owner);
            this.MapParameterIn(command, "@PA_LIC_SIGNATURE", record.Signature);
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
        ///     The <see cref="LicenseRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, LicenseRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LIC_ID", record.Id);
            record.Active = this.MapParameterOut(command, "@PA_LIC_ACTIVE", record.Active);
            record.Expiry = this.MapParameterOut(command, "@PA_LIC_EXPIRY", record.Expiry);
            record.Owner = this.MapParameterOut(command, "@PA_LIC_OWNER", record.Owner);
            record.Signature = this.MapParameterOut(command, "@PA_LIC_SIGNATURE", record.Signature);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LicenseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="owner">
        ///     The value which identifies the <see cref='LicenseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LicenseRecord" /> instances that match the specified <paramref name='owner' />.
        /// </returns>
        public IEnumerable<LicenseRecord> FetchAllByOwner(String owner)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Owner");
            this.MapParameterIn(command, "@PA_LIC_OWNER", owner);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ILicenseRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.LicenseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="owner">
        ///     The value which identifies the <see cref="!:LicenseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.LicenseRecord" /> instances that match the specified <paramref name="owner" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.LicenseRecord> ILicenseRepository.FetchAllByOwner(System.String owner)
        {
            return this.FetchAllByOwner(owner);
        }

        #endregion
    }
}
