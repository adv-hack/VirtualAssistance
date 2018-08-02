if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceMasterClubModify')
  exec ('create procedure dbo.spConsensusFinanceMasterClubModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceMasterClubModify(@PA_MSTC_ID varchar(11) = null output, @PA_MSTC_LOCK varchar(10) = null output, @PA_MSTC_ORG_ID varchar(11) = null output, @PA_MSTC_DAYS_NO tinyint = null output, @PA_MSTC_PERIOD float = null output, @PA_MSTC_MEMB_VAL decimal(19, 2) = null output, @PA_MSTC_EXP_DATE datetime = null output, @PA_MSTC_CONTACT varchar(11) = null output, @PA_MSTC_MEMB_NO varchar(20) = null output, @PA_MSTC_START_DATE datetime = null output, @PA_MSTC_FINISH_DATE datetime = null output, @PA_MSTC_PAY_DATE datetime = null output, @PA_MSTC_TOT_POINTS decimal(19, 2) = null output, @PA_MSTC_REMAIN_PTS decimal(19, 2) = null output, @PA_MSTC_STATUS varchar(50) = null output, @PA_MSTC_NOTES varchar(500) = null output, @PA_MSTC_TYPE varchar(20) = null output, @PA_MSTC_USED_VALUE float = null output, @PA_MSTC_RESTRICT tinyint = null output, @PA_MSTC_DELEGATE varchar(10) = null output, @PA_MSTC_PL_ID varchar(11) = null output, @PA_MSTC_PROD_ID varchar(11) = null output, @PA_MSTC_PROD_TYPE varchar(20) = null output, @PA_MSTC_STOP_FLAG tinyint = null output, @PA_MSTC_NAMED_USERS tinyint = null output, @PA_MSTC_CURRENCY_TYPE varchar(3) = null output, @PA_MSTC_CEN_ID varchar(11) = null output, @PA_MSTC_MEP_ID varchar(11) = null output, @PA_MSTC_NAMED_BOOKERS tinyint = null output, @PA_MSTC_NAME varchar(150) = null output, @PA_MSTC_UNIQUE_REF varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Master_Club set
    MSTC_MOD_DATE = getDate(),
    MSTC_MOD_BY = @_AUDIT_USER_ID,
    MSTC_LOCK = @PA_MSTC_LOCK,
    MSTC_ORG_ID = @PA_MSTC_ORG_ID,
    MSTC_DAYS_NO = @PA_MSTC_DAYS_NO,
    MSTC_PERIOD = @PA_MSTC_PERIOD,
    MSTC_MEMB_VAL = @PA_MSTC_MEMB_VAL,
    MSTC_EXP_DATE = @PA_MSTC_EXP_DATE,
    MSTC_CONTACT = @PA_MSTC_CONTACT,
    MSTC_MEMB_NO = @PA_MSTC_MEMB_NO,
    MSTC_START_DATE = @PA_MSTC_START_DATE,
    MSTC_FINISH_DATE = @PA_MSTC_FINISH_DATE,
    MSTC_PAY_DATE = @PA_MSTC_PAY_DATE,
    MSTC_TOT_POINTS = @PA_MSTC_TOT_POINTS,
    MSTC_REMAIN_PTS = @PA_MSTC_REMAIN_PTS,
    MSTC_STATUS = @PA_MSTC_STATUS,
    MSTC_NOTES = @PA_MSTC_NOTES,
    MSTC_TYPE = @PA_MSTC_TYPE,
    MSTC_USED_VALUE = @PA_MSTC_USED_VALUE,
    MSTC_RESTRICT = @PA_MSTC_RESTRICT,
    MSTC_DELEGATE = @PA_MSTC_DELEGATE,
    MSTC_PL_ID = @PA_MSTC_PL_ID,
    MSTC_PROD_ID = @PA_MSTC_PROD_ID,
    MSTC_PROD_TYPE = @PA_MSTC_PROD_TYPE,
    MSTC_STOP_FLAG = @PA_MSTC_STOP_FLAG,
    MSTC_NAMED_USERS = @PA_MSTC_NAMED_USERS,
    MSTC_CURRENCY_TYPE = @PA_MSTC_CURRENCY_TYPE,
    MSTC_CEN_ID = @PA_MSTC_CEN_ID,
    MSTC_MEP_ID = @PA_MSTC_MEP_ID,
    MSTC_NAMED_BOOKERS = @PA_MSTC_NAMED_BOOKERS,
    MSTC_NAME = @PA_MSTC_NAME,
    MSTC_UNIQUE_REF = @PA_MSTC_UNIQUE_REF
  where MSTC_ID = @PA_MSTC_ID;
end
go
