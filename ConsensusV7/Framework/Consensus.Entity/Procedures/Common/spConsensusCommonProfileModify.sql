if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonProfileModify')
  exec ('create procedure dbo.spConsensusCommonProfileModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonProfileModify(@PA_PROF_ID varchar(11) = null output, @PA_PROF_ORG_ID varchar(11) = null output, @PA_PROF_PERSON_ID varchar(11) = null output, @PA_PROF_ROLE_ID varchar(11) = null output, @PA_PROF_PROD_ID varchar(11) = null output, @PA_PROF_KEY varchar(50) = null output, @PA_PROF_VALUE varchar(40) = null output, @PA_PROF_NOTES varchar(250) = null output, @PA_PROF_DATE datetime = null output, @PA_PROF_MR_TOP varchar(11) = null output, @PA_PROF_MR_ID varchar(11) = null output, @PA_PROF_MR_QUEST_PAR varchar(11) = null output, @PA_PROF_MR_QUEST_KEY integer = null output, @PA_PROF_MR_ANSW_TYPE tinyint = null output, @PA_PROF_MR_NUM float = null output, @PA_PROF_MR_ALPHA varchar(max) = null output, @PA_PROF_MR_CHK1 tinyint = null output, @PA_PROF_MR_CHK2 tinyint = null output, @PA_PROF_MR_CHK3 tinyint = null output, @PA_PROF_MR_CHK4 tinyint = null output, @PA_PROF_MR_CHK5 tinyint = null output, @PA_PROF_MR_OPT tinyint = null output, @PA_PROF_MR_CHILD varchar(11) = null output, @PA_PROF_LOCK varchar(10) = null output, @PA_PROF_OPP_ID varchar(11) = null output, @PA_PROF_MR_LINK_TYPE tinyint = null output, @PA_PROF_VALUE3 varchar(20) = null output, @PA_PROF_USERCHAR_1 varchar(100) = null output, @PA_PROF_USERNUM_1 float = null output, @PA_PROF_USERCHAR_2 varchar(100) = null output, @PA_PROF_COURSE_ID varchar(11) = null output, @PA_PROF_SELECT_DTE datetime = null output, @PA_PROF_MAIL_DATE datetime = null output, @PA_PROF_DTE_PASSED datetime = null output, @PA_PROF_PHONE_DTE datetime = null output, @PA_PROF_USERDATE_1 datetime = null output, @PA_PROF_USERDATE_2 datetime = null output, @PA_PROF_USERDATE_3 datetime = null output, @PA_PROF_USERCHAR_3 varchar(100) = null output, @PA_PROF_USERNUM_2 float = null output, @PA_PROF_USERNUM_3 float = null output, @PA_PROF_STATUS varchar(25) = null output, @PA_PROF_SPOUSE_NAM varchar(50) = null output, @PA_PROF_DIET1 varchar(50) = null output, @PA_PROF_DIET2 varchar(50) = null output, @PA_PROF_ACCPT_DTE datetime = null output, @PA_PROF_PGP_ID varchar(11) = null output, @PA_PROF_VALUE2 varchar(40) = null output, @PA_PROF_LINK_ID varchar(11) = null output, @PA_PROF_LINK_TYPE tinyint = null output, @PA_PROF_PROJ_ID varchar(11) = null output, @PA_PROF_COST decimal(12, 2) = null output, @PA_PROF_QUAL_ID varchar(11) = null output, @PA_PROF_LOC_ID varchar(11) = null output, @PA_PROF_ATTRIB_TINT_01 tinyint = null output, @PA_PROF_PDS_ID varchar(11) = null output, @PA_PROF_TRAIN_ID varchar(11) = null output, @PA_PROF_MEM_ID varchar(11) = null output, @PA_PROF_DEL_ID varchar(11) = null output, @PA_PROF_CERT_ID varchar(11) = null output, @PA_PROF_VOL_ID varchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Profile set
    PROF_MOD_DATE = getDate(),
    PROF_MOD_BY = @_AUDIT_USER_ID,
    PROF_ORG_ID = @PA_PROF_ORG_ID,
    PROF_PERSON_ID = @PA_PROF_PERSON_ID,
    PROF_ROLE_ID = @PA_PROF_ROLE_ID,
    PROF_PROD_ID = @PA_PROF_PROD_ID,
    PROF_KEY = @PA_PROF_KEY,
    PROF_VALUE = @PA_PROF_VALUE,
    PROF_NOTES = @PA_PROF_NOTES,
    PROF_DATE = @PA_PROF_DATE,
    PROF_MR_TOP = @PA_PROF_MR_TOP,
    PROF_MR_ID = @PA_PROF_MR_ID,
    PROF_MR_QUEST_PAR = @PA_PROF_MR_QUEST_PAR,
    PROF_MR_QUEST_KEY = @PA_PROF_MR_QUEST_KEY,
    PROF_MR_ANSW_TYPE = @PA_PROF_MR_ANSW_TYPE,
    PROF_MR_NUM = @PA_PROF_MR_NUM,
    PROF_MR_ALPHA = @PA_PROF_MR_ALPHA,
    PROF_MR_CHK1 = @PA_PROF_MR_CHK1,
    PROF_MR_CHK2 = @PA_PROF_MR_CHK2,
    PROF_MR_CHK3 = @PA_PROF_MR_CHK3,
    PROF_MR_CHK4 = @PA_PROF_MR_CHK4,
    PROF_MR_CHK5 = @PA_PROF_MR_CHK5,
    PROF_MR_OPT = @PA_PROF_MR_OPT,
    PROF_MR_CHILD = @PA_PROF_MR_CHILD,
    PROF_LOCK = @PA_PROF_LOCK,
    PROF_OPP_ID = @PA_PROF_OPP_ID,
    PROF_MR_LINK_TYPE = @PA_PROF_MR_LINK_TYPE,
    PROF_VALUE3 = @PA_PROF_VALUE3,
    PROF_USERCHAR_1 = @PA_PROF_USERCHAR_1,
    PROF_USERNUM_1 = @PA_PROF_USERNUM_1,
    PROF_USERCHAR_2 = @PA_PROF_USERCHAR_2,
    PROF_COURSE_ID = @PA_PROF_COURSE_ID,
    PROF_SELECT_DTE = @PA_PROF_SELECT_DTE,
    PROF_MAIL_DATE = @PA_PROF_MAIL_DATE,
    PROF_DTE_PASSED = @PA_PROF_DTE_PASSED,
    PROF_PHONE_DTE = @PA_PROF_PHONE_DTE,
    PROF_USERDATE_1 = @PA_PROF_USERDATE_1,
    PROF_USERDATE_2 = @PA_PROF_USERDATE_2,
    PROF_USERDATE_3 = @PA_PROF_USERDATE_3,
    PROF_USERCHAR_3 = @PA_PROF_USERCHAR_3,
    PROF_USERNUM_2 = @PA_PROF_USERNUM_2,
    PROF_USERNUM_3 = @PA_PROF_USERNUM_3,
    PROF_STATUS = @PA_PROF_STATUS,
    PROF_SPOUSE_NAM = @PA_PROF_SPOUSE_NAM,
    PROF_DIET1 = @PA_PROF_DIET1,
    PROF_DIET2 = @PA_PROF_DIET2,
    PROF_ACCPT_DTE = @PA_PROF_ACCPT_DTE,
    PROF_PGP_ID = @PA_PROF_PGP_ID,
    PROF_VALUE2 = @PA_PROF_VALUE2,
    PROF_LINK_ID = @PA_PROF_LINK_ID,
    PROF_LINK_TYPE = @PA_PROF_LINK_TYPE,
    PROF_PROJ_ID = @PA_PROF_PROJ_ID,
    PROF_COST = @PA_PROF_COST,
    PROF_QUAL_ID = @PA_PROF_QUAL_ID,
    PROF_LOC_ID = @PA_PROF_LOC_ID,
    PROF_ATTRIB_TINT_01 = @PA_PROF_ATTRIB_TINT_01,
    PROF_PDS_ID = @PA_PROF_PDS_ID,
    PROF_TRAIN_ID = @PA_PROF_TRAIN_ID,
    PROF_MEM_ID = @PA_PROF_MEM_ID,
    PROF_DEL_ID = @PA_PROF_DEL_ID,
    PROF_CERT_ID = @PA_PROF_CERT_ID,
    PROF_VOL_ID = @PA_PROF_VOL_ID
  where PROF_ID = @PA_PROF_ID;
end
go
