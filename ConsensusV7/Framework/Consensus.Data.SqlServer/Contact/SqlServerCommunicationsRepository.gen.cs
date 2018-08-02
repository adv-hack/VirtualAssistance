using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CommunicationsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCommunicationsRepository : SqlServerRepository<CommunicationsRecord, Int64>, ICommunicationsRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Contact"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Communications"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CommunicationsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_COMM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Communications"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CommunicationsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CommunicationsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CommunicationsRecord record)
        {
            record.Id = dataRecord["COMM_ID"].ConvertTo<Int64>();
            record.AddDate = dataRecord["COMM_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["COMM_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["COMM_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["COMM_MOD_BY"].ConvertTo<String>();
            record.DeviceCode = dataRecord["COMM_DEVICE_CODE"].ConvertTo<String>();
            record.DiallingCode = dataRecord["COMM_DIALLING_CODE"].ConvertTo<String>();
            record.StdCode = dataRecord["COMM_STD_CODE"].ConvertTo<String>();
            record.Extension = dataRecord["COMM_EXTENSION"].ConvertTo<String>();
            record.ExDirectory = dataRecord["COMM_EX_DIRECTORY"].ConvertTo<Int32?>();
            record.Notes = dataRecord["COMM_NOTES"].ConvertTo<String>();
            record.ValidFrom = dataRecord["COMM_VALID_FROM"].ConvertTo<DateTime?>();
            record.Active = dataRecord["COMM_ACTIVE"].ConvertTo<Int32?>();
            record.Default = dataRecord["COMM_DEFAULT"].ConvertTo<Int32?>();
            record.Preferred = dataRecord["COMM_PREFERRED"].ConvertTo<Int32?>();
            record.DeviceValue = dataRecord["COMM_DEVICE_VALUE"].ConvertTo<String>();
            record.DeviceFullValue = dataRecord["COMM_DEVICE_FULL_VALUE"].ConvertTo<String>();
            record.AddId = dataRecord["COMM_ADD_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CommunicationsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CommunicationsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_COMM_ID", record.Id == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_COMM_DEVICE_CODE", record.DeviceCode);
            this.MapParameterIn(command, "@PA_COMM_DIALLING_CODE", record.DiallingCode);
            this.MapParameterIn(command, "@PA_COMM_STD_CODE", record.StdCode);
            this.MapParameterIn(command, "@PA_COMM_EXTENSION", record.Extension);
            this.MapParameterIn(command, "@PA_COMM_EX_DIRECTORY", record.ExDirectory == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ExDirectory);
            this.MapParameterIn(command, "@PA_COMM_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_COMM_VALID_FROM", record.ValidFrom == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidFrom);
            this.MapParameterIn(command, "@PA_COMM_ACTIVE", record.Active == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Active);
            this.MapParameterIn(command, "@PA_COMM_DEFAULT", record.Default == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Default);
            this.MapParameterIn(command, "@PA_COMM_PREFERRED", record.Preferred == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Preferred);
            this.MapParameterIn(command, "@PA_COMM_DEVICE_VALUE", record.DeviceValue);
            this.MapParameterIn(command, "@PA_COMM_DEVICE_FULL_VALUE", record.DeviceFullValue);
            this.MapParameterIn(command, "@PA_COMM_ADD_ID", record.AddId);
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
        ///     The <see cref="CommunicationsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CommunicationsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_COMM_ID", record.Id);
            record.DeviceCode = this.MapParameterOut(command, "@PA_COMM_DEVICE_CODE", record.DeviceCode);
            record.DiallingCode = this.MapParameterOut(command, "@PA_COMM_DIALLING_CODE", record.DiallingCode);
            record.StdCode = this.MapParameterOut(command, "@PA_COMM_STD_CODE", record.StdCode);
            record.Extension = this.MapParameterOut(command, "@PA_COMM_EXTENSION", record.Extension);
            record.ExDirectory = this.MapParameterOut(command, "@PA_COMM_EX_DIRECTORY", record.ExDirectory);
            record.Notes = this.MapParameterOut(command, "@PA_COMM_NOTES", record.Notes);
            record.ValidFrom = this.MapParameterOut(command, "@PA_COMM_VALID_FROM", record.ValidFrom);
            record.Active = this.MapParameterOut(command, "@PA_COMM_ACTIVE", record.Active);
            record.Default = this.MapParameterOut(command, "@PA_COMM_DEFAULT", record.Default);
            record.Preferred = this.MapParameterOut(command, "@PA_COMM_PREFERRED", record.Preferred);
            record.DeviceValue = this.MapParameterOut(command, "@PA_COMM_DEVICE_VALUE", record.DeviceValue);
            record.DeviceFullValue = this.MapParameterOut(command, "@PA_COMM_DEVICE_FULL_VALUE", record.DeviceFullValue);
            record.AddId = this.MapParameterOut(command, "@PA_COMM_ADD_ID", record.AddId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICommunicationsRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
