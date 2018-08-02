using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProfileRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerProfileRepository : SqlServerRepository<ProfileRecord, String>, IProfileRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Common"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Profile"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ProfileRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PROF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Profile"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ProfileRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProfileRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ProfileRecord record)
        {
            record.Id = dataRecord["PROF_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["PROF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PROF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PROF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PROF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PROF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PROF_RCV_FROM"].ConvertTo<String>();
            record.OrgId = dataRecord["PROF_ORG_ID"].ConvertTo<String>();
            record.PersonId = dataRecord["PROF_PERSON_ID"].ConvertTo<String>();
            record.RoleId = dataRecord["PROF_ROLE_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["PROF_PROD_ID"].ConvertTo<String>();
            record.Key = dataRecord["PROF_KEY"].ConvertTo<String>();
            record.Value = dataRecord["PROF_VALUE"].ConvertTo<String>();
            record.Notes = dataRecord["PROF_NOTES"].ConvertTo<String>();
            record.Date = dataRecord["PROF_DATE"].ConvertTo<DateTime?>();
            record.MrTop = dataRecord["PROF_MR_TOP"].ConvertTo<String>();
            record.MrId = dataRecord["PROF_MR_ID"].ConvertTo<String>();
            record.MrQuestPar = dataRecord["PROF_MR_QUEST_PAR"].ConvertTo<String>();
            record.MrQuestKey = dataRecord["PROF_MR_QUEST_KEY"].ConvertTo<Int32?>();
            record.MrAnswType = dataRecord["PROF_MR_ANSW_TYPE"].ConvertTo<Byte?>();
            record.MrNum = dataRecord["PROF_MR_NUM"].ConvertTo<Double?>();
            record.MrAlpha = dataRecord["PROF_MR_ALPHA"].ConvertTo<String>();
            record.MrChk1 = dataRecord["PROF_MR_CHK1"].ConvertTo<Byte?>();
            record.MrChk2 = dataRecord["PROF_MR_CHK2"].ConvertTo<Byte?>();
            record.MrChk3 = dataRecord["PROF_MR_CHK3"].ConvertTo<Byte?>();
            record.MrChk4 = dataRecord["PROF_MR_CHK4"].ConvertTo<Byte?>();
            record.MrChk5 = dataRecord["PROF_MR_CHK5"].ConvertTo<Byte?>();
            record.MrOpt = dataRecord["PROF_MR_OPT"].ConvertTo<Byte?>();
            record.MrChild = dataRecord["PROF_MR_CHILD"].ConvertTo<String>();
            record.Lock = dataRecord["PROF_LOCK"].ConvertTo<String>();
            record.OppId = dataRecord["PROF_OPP_ID"].ConvertTo<String>();
            record.MrLinkType = dataRecord["PROF_MR_LINK_TYPE"].ConvertTo<Byte?>();
            record.Value3 = dataRecord["PROF_VALUE3"].ConvertTo<String>();
            record.Userchar1 = dataRecord["PROF_USERCHAR_1"].ConvertTo<String>();
            record.Usernum1 = dataRecord["PROF_USERNUM_1"].ConvertTo<Double?>();
            record.Userchar2 = dataRecord["PROF_USERCHAR_2"].ConvertTo<String>();
            record.CourseId = dataRecord["PROF_COURSE_ID"].ConvertTo<String>();
            record.SelectDte = dataRecord["PROF_SELECT_DTE"].ConvertTo<DateTime?>();
            record.MailDate = dataRecord["PROF_MAIL_DATE"].ConvertTo<DateTime?>();
            record.DtePassed = dataRecord["PROF_DTE_PASSED"].ConvertTo<DateTime?>();
            record.PhoneDte = dataRecord["PROF_PHONE_DTE"].ConvertTo<DateTime?>();
            record.Userdate1 = dataRecord["PROF_USERDATE_1"].ConvertTo<DateTime?>();
            record.Userdate2 = dataRecord["PROF_USERDATE_2"].ConvertTo<DateTime?>();
            record.Userdate3 = dataRecord["PROF_USERDATE_3"].ConvertTo<DateTime?>();
            record.Userchar3 = dataRecord["PROF_USERCHAR_3"].ConvertTo<String>();
            record.Usernum2 = dataRecord["PROF_USERNUM_2"].ConvertTo<Double?>();
            record.Usernum3 = dataRecord["PROF_USERNUM_3"].ConvertTo<Double?>();
            record.Status = dataRecord["PROF_STATUS"].ConvertTo<String>();
            record.SpouseNam = dataRecord["PROF_SPOUSE_NAM"].ConvertTo<String>();
            record.Diet1 = dataRecord["PROF_DIET1"].ConvertTo<String>();
            record.Diet2 = dataRecord["PROF_DIET2"].ConvertTo<String>();
            record.AccptDte = dataRecord["PROF_ACCPT_DTE"].ConvertTo<DateTime?>();
            record.PgpId = dataRecord["PROF_PGP_ID"].ConvertTo<String>();
            record.Value2 = dataRecord["PROF_VALUE2"].ConvertTo<String>();
            record.LinkId = dataRecord["PROF_LINK_ID"].ConvertTo<String>();
            record.LinkType = dataRecord["PROF_LINK_TYPE"].ConvertTo<Byte?>();
            record.ProjId = dataRecord["PROF_PROJ_ID"].ConvertTo<String>();
            record.Cost = dataRecord["PROF_COST"].ConvertTo<Decimal?>();
            record.QualId = dataRecord["PROF_QUAL_ID"].ConvertTo<String>();
            record.LocId = dataRecord["PROF_LOC_ID"].ConvertTo<String>();
            record.AttribTint01 = dataRecord["PROF_ATTRIB_TINT_01"].ConvertTo<Byte?>();
            record.PdsId = dataRecord["PROF_PDS_ID"].ConvertTo<String>();
            record.TrainId = dataRecord["PROF_TRAIN_ID"].ConvertTo<String>();
            record.MemId = dataRecord["PROF_MEM_ID"].ConvertTo<String>();
            record.DelId = dataRecord["PROF_DEL_ID"].ConvertTo<String>();
            record.CertId = dataRecord["PROF_CERT_ID"].ConvertTo<String>();
            record.VolId = dataRecord["PROF_VOL_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProfileRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ProfileRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PROF_ID", record.Id);
            this.MapParameterIn(command, "@PA_PROF_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_PROF_PERSON_ID", record.PersonId);
            this.MapParameterIn(command, "@PA_PROF_ROLE_ID", record.RoleId);
            this.MapParameterIn(command, "@PA_PROF_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_PROF_KEY", record.Key);
            this.MapParameterIn(command, "@PA_PROF_VALUE", record.Value);
            this.MapParameterIn(command, "@PA_PROF_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_PROF_DATE", record.Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date);
            this.MapParameterIn(command, "@PA_PROF_MR_TOP", record.MrTop);
            this.MapParameterIn(command, "@PA_PROF_MR_ID", record.MrId);
            this.MapParameterIn(command, "@PA_PROF_MR_QUEST_PAR", record.MrQuestPar);
            this.MapParameterIn(command, "@PA_PROF_MR_QUEST_KEY", record.MrQuestKey == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MrQuestKey);
            this.MapParameterIn(command, "@PA_PROF_MR_ANSW_TYPE", record.MrAnswType);
            this.MapParameterIn(command, "@PA_PROF_MR_NUM", record.MrNum == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MrNum);
            this.MapParameterIn(command, "@PA_PROF_MR_ALPHA", record.MrAlpha);
            this.MapParameterIn(command, "@PA_PROF_MR_CHK1", record.MrChk1);
            this.MapParameterIn(command, "@PA_PROF_MR_CHK2", record.MrChk2);
            this.MapParameterIn(command, "@PA_PROF_MR_CHK3", record.MrChk3);
            this.MapParameterIn(command, "@PA_PROF_MR_CHK4", record.MrChk4);
            this.MapParameterIn(command, "@PA_PROF_MR_CHK5", record.MrChk5);
            this.MapParameterIn(command, "@PA_PROF_MR_OPT", record.MrOpt);
            this.MapParameterIn(command, "@PA_PROF_MR_CHILD", record.MrChild);
            this.MapParameterIn(command, "@PA_PROF_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PROF_OPP_ID", record.OppId);
            this.MapParameterIn(command, "@PA_PROF_MR_LINK_TYPE", record.MrLinkType);
            this.MapParameterIn(command, "@PA_PROF_VALUE3", record.Value3);
            this.MapParameterIn(command, "@PA_PROF_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_PROF_USERNUM_1", record.Usernum1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_PROF_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_PROF_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_PROF_SELECT_DTE", record.SelectDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SelectDte);
            this.MapParameterIn(command, "@PA_PROF_MAIL_DATE", record.MailDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.MailDate);
            this.MapParameterIn(command, "@PA_PROF_DTE_PASSED", record.DtePassed == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DtePassed);
            this.MapParameterIn(command, "@PA_PROF_PHONE_DTE", record.PhoneDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PhoneDte);
            this.MapParameterIn(command, "@PA_PROF_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_PROF_USERDATE_2", record.Userdate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate2);
            this.MapParameterIn(command, "@PA_PROF_USERDATE_3", record.Userdate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate3);
            this.MapParameterIn(command, "@PA_PROF_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_PROF_USERNUM_2", record.Usernum2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_PROF_USERNUM_3", record.Usernum3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_PROF_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_PROF_SPOUSE_NAM", record.SpouseNam);
            this.MapParameterIn(command, "@PA_PROF_DIET1", record.Diet1);
            this.MapParameterIn(command, "@PA_PROF_DIET2", record.Diet2);
            this.MapParameterIn(command, "@PA_PROF_ACCPT_DTE", record.AccptDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AccptDte);
            this.MapParameterIn(command, "@PA_PROF_PGP_ID", record.PgpId);
            this.MapParameterIn(command, "@PA_PROF_VALUE2", record.Value2);
            this.MapParameterIn(command, "@PA_PROF_LINK_ID", record.LinkId);
            this.MapParameterIn(command, "@PA_PROF_LINK_TYPE", record.LinkType);
            this.MapParameterIn(command, "@PA_PROF_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_PROF_COST", record.Cost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Cost);
            this.MapParameterIn(command, "@PA_PROF_QUAL_ID", record.QualId);
            this.MapParameterIn(command, "@PA_PROF_LOC_ID", record.LocId);
            this.MapParameterIn(command, "@PA_PROF_ATTRIB_TINT_01", record.AttribTint01);
            this.MapParameterIn(command, "@PA_PROF_PDS_ID", record.PdsId);
            this.MapParameterIn(command, "@PA_PROF_TRAIN_ID", record.TrainId);
            this.MapParameterIn(command, "@PA_PROF_MEM_ID", record.MemId);
            this.MapParameterIn(command, "@PA_PROF_DEL_ID", record.DelId);
            this.MapParameterIn(command, "@PA_PROF_CERT_ID", record.CertId);
            this.MapParameterIn(command, "@PA_PROF_VOL_ID", record.VolId);
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
        ///     The <see cref="ProfileRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ProfileRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PROF_ID", record.Id);
            record.OrgId = this.MapParameterOut(command, "@PA_PROF_ORG_ID", record.OrgId);
            record.PersonId = this.MapParameterOut(command, "@PA_PROF_PERSON_ID", record.PersonId);
            record.RoleId = this.MapParameterOut(command, "@PA_PROF_ROLE_ID", record.RoleId);
            record.ProdId = this.MapParameterOut(command, "@PA_PROF_PROD_ID", record.ProdId);
            record.Key = this.MapParameterOut(command, "@PA_PROF_KEY", record.Key);
            record.Value = this.MapParameterOut(command, "@PA_PROF_VALUE", record.Value);
            record.Notes = this.MapParameterOut(command, "@PA_PROF_NOTES", record.Notes);
            record.Date = this.MapParameterOut(command, "@PA_PROF_DATE", record.Date);
            record.MrTop = this.MapParameterOut(command, "@PA_PROF_MR_TOP", record.MrTop);
            record.MrId = this.MapParameterOut(command, "@PA_PROF_MR_ID", record.MrId);
            record.MrQuestPar = this.MapParameterOut(command, "@PA_PROF_MR_QUEST_PAR", record.MrQuestPar);
            record.MrQuestKey = this.MapParameterOut(command, "@PA_PROF_MR_QUEST_KEY", record.MrQuestKey);
            record.MrAnswType = this.MapParameterOut(command, "@PA_PROF_MR_ANSW_TYPE", record.MrAnswType);
            record.MrNum = this.MapParameterOut(command, "@PA_PROF_MR_NUM", record.MrNum);
            record.MrAlpha = this.MapParameterOut(command, "@PA_PROF_MR_ALPHA", record.MrAlpha);
            record.MrChk1 = this.MapParameterOut(command, "@PA_PROF_MR_CHK1", record.MrChk1);
            record.MrChk2 = this.MapParameterOut(command, "@PA_PROF_MR_CHK2", record.MrChk2);
            record.MrChk3 = this.MapParameterOut(command, "@PA_PROF_MR_CHK3", record.MrChk3);
            record.MrChk4 = this.MapParameterOut(command, "@PA_PROF_MR_CHK4", record.MrChk4);
            record.MrChk5 = this.MapParameterOut(command, "@PA_PROF_MR_CHK5", record.MrChk5);
            record.MrOpt = this.MapParameterOut(command, "@PA_PROF_MR_OPT", record.MrOpt);
            record.MrChild = this.MapParameterOut(command, "@PA_PROF_MR_CHILD", record.MrChild);
            record.Lock = this.MapParameterOut(command, "@PA_PROF_LOCK", record.Lock);
            record.OppId = this.MapParameterOut(command, "@PA_PROF_OPP_ID", record.OppId);
            record.MrLinkType = this.MapParameterOut(command, "@PA_PROF_MR_LINK_TYPE", record.MrLinkType);
            record.Value3 = this.MapParameterOut(command, "@PA_PROF_VALUE3", record.Value3);
            record.Userchar1 = this.MapParameterOut(command, "@PA_PROF_USERCHAR_1", record.Userchar1);
            record.Usernum1 = this.MapParameterOut(command, "@PA_PROF_USERNUM_1", record.Usernum1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_PROF_USERCHAR_2", record.Userchar2);
            record.CourseId = this.MapParameterOut(command, "@PA_PROF_COURSE_ID", record.CourseId);
            record.SelectDte = this.MapParameterOut(command, "@PA_PROF_SELECT_DTE", record.SelectDte);
            record.MailDate = this.MapParameterOut(command, "@PA_PROF_MAIL_DATE", record.MailDate);
            record.DtePassed = this.MapParameterOut(command, "@PA_PROF_DTE_PASSED", record.DtePassed);
            record.PhoneDte = this.MapParameterOut(command, "@PA_PROF_PHONE_DTE", record.PhoneDte);
            record.Userdate1 = this.MapParameterOut(command, "@PA_PROF_USERDATE_1", record.Userdate1);
            record.Userdate2 = this.MapParameterOut(command, "@PA_PROF_USERDATE_2", record.Userdate2);
            record.Userdate3 = this.MapParameterOut(command, "@PA_PROF_USERDATE_3", record.Userdate3);
            record.Userchar3 = this.MapParameterOut(command, "@PA_PROF_USERCHAR_3", record.Userchar3);
            record.Usernum2 = this.MapParameterOut(command, "@PA_PROF_USERNUM_2", record.Usernum2);
            record.Usernum3 = this.MapParameterOut(command, "@PA_PROF_USERNUM_3", record.Usernum3);
            record.Status = this.MapParameterOut(command, "@PA_PROF_STATUS", record.Status);
            record.SpouseNam = this.MapParameterOut(command, "@PA_PROF_SPOUSE_NAM", record.SpouseNam);
            record.Diet1 = this.MapParameterOut(command, "@PA_PROF_DIET1", record.Diet1);
            record.Diet2 = this.MapParameterOut(command, "@PA_PROF_DIET2", record.Diet2);
            record.AccptDte = this.MapParameterOut(command, "@PA_PROF_ACCPT_DTE", record.AccptDte);
            record.PgpId = this.MapParameterOut(command, "@PA_PROF_PGP_ID", record.PgpId);
            record.Value2 = this.MapParameterOut(command, "@PA_PROF_VALUE2", record.Value2);
            record.LinkId = this.MapParameterOut(command, "@PA_PROF_LINK_ID", record.LinkId);
            record.LinkType = this.MapParameterOut(command, "@PA_PROF_LINK_TYPE", record.LinkType);
            record.ProjId = this.MapParameterOut(command, "@PA_PROF_PROJ_ID", record.ProjId);
            record.Cost = this.MapParameterOut(command, "@PA_PROF_COST", record.Cost);
            record.QualId = this.MapParameterOut(command, "@PA_PROF_QUAL_ID", record.QualId);
            record.LocId = this.MapParameterOut(command, "@PA_PROF_LOC_ID", record.LocId);
            record.AttribTint01 = this.MapParameterOut(command, "@PA_PROF_ATTRIB_TINT_01", record.AttribTint01);
            record.PdsId = this.MapParameterOut(command, "@PA_PROF_PDS_ID", record.PdsId);
            record.TrainId = this.MapParameterOut(command, "@PA_PROF_TRAIN_ID", record.TrainId);
            record.MemId = this.MapParameterOut(command, "@PA_PROF_MEM_ID", record.MemId);
            record.DelId = this.MapParameterOut(command, "@PA_PROF_DEL_ID", record.DelId);
            record.CertId = this.MapParameterOut(command, "@PA_PROF_CERT_ID", record.CertId);
            record.VolId = this.MapParameterOut(command, "@PA_PROF_VOL_ID", record.VolId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainId">
        ///     The value which identifies the <see cref='ProfileModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProfileRecord" /> instances that match the specified <paramref name='trainId' />.
        /// </returns>
        public IEnumerable<ProfileRecord> FetchAllByTrainId(String trainId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "TrainId");
            this.MapParameterIn(command, "@PA_PROF_TRAIN_ID", trainId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="volId">
        ///     The value which identifies the <see cref='ProfileModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProfileRecord" /> instances that match the specified <paramref name='volId' />.
        /// </returns>
        public IEnumerable<ProfileRecord> FetchAllByVolId(String volId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "VolId");
            this.MapParameterIn(command, "@PA_PROF_VOL_ID", volId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='ProfileModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProfileRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<ProfileRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_PROF_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='ProfileModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProfileRecord" /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<ProfileRecord> FetchAllByPersonId(String personId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PersonId");
            this.MapParameterIn(command, "@PA_PROF_PERSON_ID", personId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='ProfileModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProfileRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<ProfileRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_PROF_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref='ProfileModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProfileRecord" /> instances that match the specified <paramref name='courseId' />.
        /// </returns>
        public IEnumerable<ProfileRecord> FetchAllByCourseId(String courseId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseId");
            this.MapParameterIn(command, "@PA_PROF_COURSE_ID", courseId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IProfileRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="trainId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> IProfileRepository.FetchAllByTrainId(System.String trainId)
        {
            return this.FetchAllByTrainId(trainId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="volId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="volId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> IProfileRepository.FetchAllByVolId(System.String volId)
        {
            return this.FetchAllByVolId(volId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> IProfileRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> IProfileRepository.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> IProfileRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> IProfileRepository.FetchAllByCourseId(System.String courseId)
        {
            return this.FetchAllByCourseId(courseId);
        }

        #endregion
    }
}
