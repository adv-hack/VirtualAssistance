using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MembershipRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerMembershipRepository : SqlServerRepository<MembershipRecord, String>, IMembershipRepository
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
            get { return "Membership"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="MembershipRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_MEM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Membership"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="MembershipRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MembershipRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, MembershipRecord record)
        {
            record.Id = dataRecord["MEM_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["MEM_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["MEM_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["MEM_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["MEM_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["MEM_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["MEM_RCV_DATE"].ConvertTo<DateTime?>();
            record.Ref = dataRecord["MEM_REF"].ConvertTo<String>();
            record.Notes = dataRecord["MEM_NOTES"].ConvertTo<String>();
            record.PmId = dataRecord["MEM_PM_ID"].ConvertTo<String>();
            record.Start = dataRecord["MEM_START"].ConvertTo<DateTime?>();
            record.CustOrderNo = dataRecord["MEM_CUST_ORDER_NO"].ConvertTo<String>();
            record.Username = dataRecord["MEM_USERNAME"].ConvertTo<String>();
            record.Password = dataRecord["MEM_PASSWORD"].ConvertTo<String>();
            record.RegStatus = dataRecord["MEM_REG_STATUS"].ConvertTo<String>();
            record.Type = dataRecord["MEM_TYPE"].ConvertTo<String>();
            record.Status = dataRecord["MEM_STATUS"].ConvertTo<String>();
            record.Grade = dataRecord["MEM_GRADE"].ConvertTo<String>();
            record.SubOnly = dataRecord["MEM_SUB_ONLY"].ConvertTo<Int32?>();
            record.BiogHtml = dataRecord["MEM_BIOG_HTML"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MembershipRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, MembershipRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_MEM_ID", record.Id);
            this.MapParameterIn(command, "@PA_MEM_REF", record.Ref);
            this.MapParameterIn(command, "@PA_MEM_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_MEM_PM_ID", record.PmId);
            this.MapParameterIn(command, "@PA_MEM_START", record.Start == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Start);
            this.MapParameterIn(command, "@PA_MEM_CUST_ORDER_NO", record.CustOrderNo);
            this.MapParameterIn(command, "@PA_MEM_USERNAME", record.Username);
            this.MapParameterIn(command, "@PA_MEM_PASSWORD", record.Password);
            this.MapParameterIn(command, "@PA_MEM_REG_STATUS", record.RegStatus);
            this.MapParameterIn(command, "@PA_MEM_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_MEM_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_MEM_GRADE", record.Grade);
            this.MapParameterIn(command, "@PA_MEM_SUB_ONLY", record.SubOnly == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SubOnly);
            this.MapParameterIn(command, "@PA_MEM_BIOG_HTML", record.BiogHtml);
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
        ///     The <see cref="MembershipRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, MembershipRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_MEM_ID", record.Id);
            record.Ref = this.MapParameterOut(command, "@PA_MEM_REF", record.Ref);
            record.Notes = this.MapParameterOut(command, "@PA_MEM_NOTES", record.Notes);
            record.PmId = this.MapParameterOut(command, "@PA_MEM_PM_ID", record.PmId);
            record.Start = this.MapParameterOut(command, "@PA_MEM_START", record.Start);
            record.CustOrderNo = this.MapParameterOut(command, "@PA_MEM_CUST_ORDER_NO", record.CustOrderNo);
            record.Username = this.MapParameterOut(command, "@PA_MEM_USERNAME", record.Username);
            record.Password = this.MapParameterOut(command, "@PA_MEM_PASSWORD", record.Password);
            record.RegStatus = this.MapParameterOut(command, "@PA_MEM_REG_STATUS", record.RegStatus);
            record.Type = this.MapParameterOut(command, "@PA_MEM_TYPE", record.Type);
            record.Status = this.MapParameterOut(command, "@PA_MEM_STATUS", record.Status);
            record.Grade = this.MapParameterOut(command, "@PA_MEM_GRADE", record.Grade);
            record.SubOnly = this.MapParameterOut(command, "@PA_MEM_SUB_ONLY", record.SubOnly);
            record.BiogHtml = this.MapParameterOut(command, "@PA_MEM_BIOG_HTML", record.BiogHtml);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IMembershipRepository.TableName
        {
            get { return this.TableName; }
        }

        void IMembershipRepository.Create(Consensus.Membership.MembershipRecord record)
        {
            this.Create(record);
        }

        void IMembershipRepository.Modify(Consensus.Membership.MembershipRecord record)
        {
            this.Modify(record);
        }

        #endregion
    }
}
