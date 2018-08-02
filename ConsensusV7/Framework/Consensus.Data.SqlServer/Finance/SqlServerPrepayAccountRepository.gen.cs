using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MasterClubRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPrepayAccountRepository : SqlServerRepository<MasterClubRecord, String>, IPrepayAccountRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Finance"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "MasterClub"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="MasterClubRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_MSTC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Master_Club"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="MasterClubRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MasterClubRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, MasterClubRecord record)
        {
            record.Id = dataRecord["MSTC_ID"].ConvertTo<String>();
            record.Lock = dataRecord["MSTC_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["MSTC_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["MSTC_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["MSTC_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["MSTC_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["MSTC_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["MSTC_RCV_FROM"].ConvertTo<String>();
            record.OrgId = dataRecord["MSTC_ORG_ID"].ConvertTo<String>();
            record.DaysNo = dataRecord["MSTC_DAYS_NO"].ConvertTo<Byte?>();
            record.Period = dataRecord["MSTC_PERIOD"].ConvertTo<Double?>();
            record.MembVal = dataRecord["MSTC_MEMB_VAL"].ConvertTo<Decimal>();
            record.ExpDate = dataRecord["MSTC_EXP_DATE"].ConvertTo<DateTime?>();
            record.Contact = dataRecord["MSTC_CONTACT"].ConvertTo<String>();
            record.MembNo = dataRecord["MSTC_MEMB_NO"].ConvertTo<String>();
            record.StartDate = dataRecord["MSTC_START_DATE"].ConvertTo<DateTime?>();
            record.FinishDate = dataRecord["MSTC_FINISH_DATE"].ConvertTo<DateTime?>();
            record.PayDate = dataRecord["MSTC_PAY_DATE"].ConvertTo<DateTime?>();
            record.TotPoints = dataRecord["MSTC_TOT_POINTS"].ConvertTo<Decimal>();
            record.RemainPts = dataRecord["MSTC_REMAIN_PTS"].ConvertTo<Decimal>();
            record.Status = dataRecord["MSTC_STATUS"].ConvertTo<String>();
            record.Notes = dataRecord["MSTC_NOTES"].ConvertTo<String>();
            record.Type = dataRecord["MSTC_TYPE"].ConvertTo<String>();
            record.UsedValue = dataRecord["MSTC_USED_VALUE"].ConvertTo<Double?>();
            record.Restrict = dataRecord["MSTC_RESTRICT"].ConvertTo<Byte?>();
            record.Delegate = dataRecord["MSTC_DELEGATE"].ConvertTo<String>();
            record.PlId = dataRecord["MSTC_PL_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["MSTC_PROD_ID"].ConvertTo<String>();
            record.ProdType = dataRecord["MSTC_PROD_TYPE"].ConvertTo<String>();
            record.StopFlag = dataRecord["MSTC_STOP_FLAG"].ConvertTo<Byte?>();
            record.NamedUsers = dataRecord["MSTC_NAMED_USERS"].ConvertTo<Byte?>();
            record.CurrencyType = dataRecord["MSTC_CURRENCY_TYPE"].ConvertTo<String>();
            record.CenId = dataRecord["MSTC_CEN_ID"].ConvertTo<String>();
            record.MepId = dataRecord["MSTC_MEP_ID"].ConvertTo<String>();
            record.NamedBookers = dataRecord["MSTC_NAMED_BOOKERS"].ConvertTo<Byte?>();
            record.Name = dataRecord["MSTC_NAME"].ConvertTo<String>();
            record.UniqueRef = dataRecord["MSTC_UNIQUE_REF"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MasterClubRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, MasterClubRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_MSTC_ID", record.Id);
            this.MapParameterIn(command, "@PA_MSTC_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_MSTC_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_MSTC_DAYS_NO", record.DaysNo);
            this.MapParameterIn(command, "@PA_MSTC_PERIOD", record.Period == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Period);
            this.MapParameterIn(command, "@PA_MSTC_MEMB_VAL", record.MembVal == Decimal.MinValue ? 0M : record.MembVal);
            this.MapParameterIn(command, "@PA_MSTC_EXP_DATE", record.ExpDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ExpDate);
            this.MapParameterIn(command, "@PA_MSTC_CONTACT", record.Contact);
            this.MapParameterIn(command, "@PA_MSTC_MEMB_NO", record.MembNo);
            this.MapParameterIn(command, "@PA_MSTC_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_MSTC_FINISH_DATE", record.FinishDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.FinishDate);
            this.MapParameterIn(command, "@PA_MSTC_PAY_DATE", record.PayDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PayDate);
            this.MapParameterIn(command, "@PA_MSTC_TOT_POINTS", record.TotPoints == Decimal.MinValue ? 0M : record.TotPoints);
            this.MapParameterIn(command, "@PA_MSTC_REMAIN_PTS", record.RemainPts == Decimal.MinValue ? 0M : record.RemainPts);
            this.MapParameterIn(command, "@PA_MSTC_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_MSTC_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_MSTC_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_MSTC_USED_VALUE", record.UsedValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UsedValue);
            this.MapParameterIn(command, "@PA_MSTC_RESTRICT", record.Restrict);
            this.MapParameterIn(command, "@PA_MSTC_DELEGATE", record.Delegate);
            this.MapParameterIn(command, "@PA_MSTC_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_MSTC_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_MSTC_PROD_TYPE", record.ProdType);
            this.MapParameterIn(command, "@PA_MSTC_STOP_FLAG", record.StopFlag);
            this.MapParameterIn(command, "@PA_MSTC_NAMED_USERS", record.NamedUsers);
            this.MapParameterIn(command, "@PA_MSTC_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_MSTC_CEN_ID", record.CenId);
            this.MapParameterIn(command, "@PA_MSTC_MEP_ID", record.MepId);
            this.MapParameterIn(command, "@PA_MSTC_NAMED_BOOKERS", record.NamedBookers);
            this.MapParameterIn(command, "@PA_MSTC_NAME", record.Name);
            this.MapParameterIn(command, "@PA_MSTC_UNIQUE_REF", record.UniqueRef);
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
        ///     The <see cref="MasterClubRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, MasterClubRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_MSTC_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_MSTC_LOCK", record.Lock);
            record.OrgId = this.MapParameterOut(command, "@PA_MSTC_ORG_ID", record.OrgId);
            record.DaysNo = this.MapParameterOut(command, "@PA_MSTC_DAYS_NO", record.DaysNo);
            record.Period = this.MapParameterOut(command, "@PA_MSTC_PERIOD", record.Period);
            record.MembVal = this.MapParameterOut(command, "@PA_MSTC_MEMB_VAL", record.MembVal);
            record.ExpDate = this.MapParameterOut(command, "@PA_MSTC_EXP_DATE", record.ExpDate);
            record.Contact = this.MapParameterOut(command, "@PA_MSTC_CONTACT", record.Contact);
            record.MembNo = this.MapParameterOut(command, "@PA_MSTC_MEMB_NO", record.MembNo);
            record.StartDate = this.MapParameterOut(command, "@PA_MSTC_START_DATE", record.StartDate);
            record.FinishDate = this.MapParameterOut(command, "@PA_MSTC_FINISH_DATE", record.FinishDate);
            record.PayDate = this.MapParameterOut(command, "@PA_MSTC_PAY_DATE", record.PayDate);
            record.TotPoints = this.MapParameterOut(command, "@PA_MSTC_TOT_POINTS", record.TotPoints);
            record.RemainPts = this.MapParameterOut(command, "@PA_MSTC_REMAIN_PTS", record.RemainPts);
            record.Status = this.MapParameterOut(command, "@PA_MSTC_STATUS", record.Status);
            record.Notes = this.MapParameterOut(command, "@PA_MSTC_NOTES", record.Notes);
            record.Type = this.MapParameterOut(command, "@PA_MSTC_TYPE", record.Type);
            record.UsedValue = this.MapParameterOut(command, "@PA_MSTC_USED_VALUE", record.UsedValue);
            record.Restrict = this.MapParameterOut(command, "@PA_MSTC_RESTRICT", record.Restrict);
            record.Delegate = this.MapParameterOut(command, "@PA_MSTC_DELEGATE", record.Delegate);
            record.PlId = this.MapParameterOut(command, "@PA_MSTC_PL_ID", record.PlId);
            record.ProdId = this.MapParameterOut(command, "@PA_MSTC_PROD_ID", record.ProdId);
            record.ProdType = this.MapParameterOut(command, "@PA_MSTC_PROD_TYPE", record.ProdType);
            record.StopFlag = this.MapParameterOut(command, "@PA_MSTC_STOP_FLAG", record.StopFlag);
            record.NamedUsers = this.MapParameterOut(command, "@PA_MSTC_NAMED_USERS", record.NamedUsers);
            record.CurrencyType = this.MapParameterOut(command, "@PA_MSTC_CURRENCY_TYPE", record.CurrencyType);
            record.CenId = this.MapParameterOut(command, "@PA_MSTC_CEN_ID", record.CenId);
            record.MepId = this.MapParameterOut(command, "@PA_MSTC_MEP_ID", record.MepId);
            record.NamedBookers = this.MapParameterOut(command, "@PA_MSTC_NAMED_BOOKERS", record.NamedBookers);
            record.Name = this.MapParameterOut(command, "@PA_MSTC_NAME", record.Name);
            record.UniqueRef = this.MapParameterOut(command, "@PA_MSTC_UNIQUE_REF", record.UniqueRef);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MasterClubRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='PrepayAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MasterClubRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<MasterClubRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_MSTC_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MasterClubRecord" /> instances from the data store.
        /// </summary>
        /// <param name="contact">
        ///     The value which identifies the <see cref='PrepayAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MasterClubRecord" /> instances that match the specified <paramref name='contact' />.
        /// </returns>
        public IEnumerable<MasterClubRecord> FetchAllByContact(String contact)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Contact");
            this.MapParameterIn(command, "@PA_MSTC_CONTACT", contact);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MasterClubRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='PrepayAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MasterClubRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<MasterClubRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_MSTC_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MasterClubRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref='PrepayAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MasterClubRecord" /> instances that match the specified <paramref name='mepId' />.
        /// </returns>
        public IEnumerable<MasterClubRecord> FetchAllByMepId(String mepId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MepId");
            this.MapParameterIn(command, "@PA_MSTC_MEP_ID", mepId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPrepayAccountRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.MasterClubRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.MasterClubRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.MasterClubRecord> IPrepayAccountRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.MasterClubRecord" /> instances from the data store.
        /// </summary>
        /// <param name="contact">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.MasterClubRecord" /> instances that match the specified <paramref name="contact" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.MasterClubRecord> IPrepayAccountRepository.FetchAllByContact(System.String contact)
        {
            return this.FetchAllByContact(contact);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.MasterClubRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.MasterClubRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.MasterClubRecord> IPrepayAccountRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.MasterClubRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.MasterClubRecord" /> instances that match the specified <paramref name="mepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.MasterClubRecord> IPrepayAccountRepository.FetchAllByMepId(System.String mepId)
        {
            return this.FetchAllByMepId(mepId);
        }

        #endregion
    }
}
