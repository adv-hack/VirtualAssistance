if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceMasterClubFetchAllByOrgid')
  exec ('create procedure dbo.spConsensusFinanceMasterClubFetchAllByOrgid as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceMasterClubFetchAllByOrgid(@PA_MSTC_ORG_ID varchar(11) = null output) as 
begin
  select 
    MSTC_ID,
    MSTC_LOCK,
    MSTC_ADD_DATE,
    MSTC_ADD_BY,
    MSTC_MOD_DATE,
    MSTC_MOD_BY,
    MSTC_RCV_DATE,
    MSTC_RCV_FROM,
    MSTC_ORG_ID,
    MSTC_DAYS_NO,
    MSTC_PERIOD,
    MSTC_MEMB_VAL,
    MSTC_EXP_DATE,
    MSTC_CONTACT,
    MSTC_MEMB_NO,
    MSTC_START_DATE,
    MSTC_FINISH_DATE,
    MSTC_PAY_DATE,
    MSTC_TOT_POINTS,
    MSTC_REMAIN_PTS,
    MSTC_STATUS,
    MSTC_NOTES,
    MSTC_TYPE,
    MSTC_USED_VALUE,
    MSTC_RESTRICT,
    MSTC_DELEGATE,
    MSTC_PL_ID,
    MSTC_PROD_ID,
    MSTC_PROD_TYPE,
    MSTC_STOP_FLAG,
    MSTC_NAMED_USERS,
    MSTC_CURRENCY_TYPE,
    MSTC_CEN_ID,
    MSTC_MEP_ID,
    MSTC_NAMED_BOOKERS,
    MSTC_NAME,
    MSTC_UNIQUE_REF
  from dbo.Master_Club
  where MSTC_ORG_ID = @PA_MSTC_ORG_ID
end
go
