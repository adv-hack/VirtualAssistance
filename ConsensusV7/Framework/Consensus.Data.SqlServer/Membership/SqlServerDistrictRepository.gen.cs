using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="DistrictRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerDistrictRepository : SqlServerRepository<DistrictRecord, String>, IDistrictRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Membership"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "District"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="DistrictRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_DIS_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "District"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="DistrictRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DistrictRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, DistrictRecord record)
        {
            record.Id = dataRecord["DIS_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["DIS_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["DIS_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["DIS_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["DIS_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["DIS_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["DIS_RCV_DATE"].ConvertTo<DateTime?>();
            record.Name = dataRecord["DIS_NAME"].ConvertTo<String>();
            record.Status = dataRecord["DIS_STATUS"].ConvertTo<String>();
            record.Type = dataRecord["DIS_TYPE"].ConvertTo<String>();
            record.Category = dataRecord["DIS_CATEGORY"].ConvertTo<String>();
            record.Group = dataRecord["DIS_GROUP"].ConvertTo<String>();
            record.Region = dataRecord["DIS_REGION"].ConvertTo<String>();
            record.Web = dataRecord["DIS_WEB"].ConvertTo<Byte>();
            record.ExtUrl = dataRecord["DIS_EXT_URL"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DistrictRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, DistrictRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_DIS_ID", record.Id);
            this.MapParameterIn(command, "@PA_DIS_NAME", record.Name);
            this.MapParameterIn(command, "@PA_DIS_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_DIS_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_DIS_CATEGORY", record.Category);
            this.MapParameterIn(command, "@PA_DIS_GROUP", record.Group);
            this.MapParameterIn(command, "@PA_DIS_REGION", record.Region);
            this.MapParameterIn(command, "@PA_DIS_WEB", record.Web);
            this.MapParameterIn(command, "@PA_DIS_EXT_URL", record.ExtUrl);
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
        ///     The <see cref="DistrictRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, DistrictRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_DIS_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_DIS_NAME", record.Name);
            record.Status = this.MapParameterOut(command, "@PA_DIS_STATUS", record.Status);
            record.Type = this.MapParameterOut(command, "@PA_DIS_TYPE", record.Type);
            record.Category = this.MapParameterOut(command, "@PA_DIS_CATEGORY", record.Category);
            record.Group = this.MapParameterOut(command, "@PA_DIS_GROUP", record.Group);
            record.Region = this.MapParameterOut(command, "@PA_DIS_REGION", record.Region);
            record.Web = this.MapParameterOut(command, "@PA_DIS_WEB", record.Web);
            record.ExtUrl = this.MapParameterOut(command, "@PA_DIS_EXT_URL", record.ExtUrl);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IDistrictRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
