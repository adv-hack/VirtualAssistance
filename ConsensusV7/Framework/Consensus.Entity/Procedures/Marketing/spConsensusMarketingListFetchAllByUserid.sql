if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingListFetchAllByUserid')
  exec ('create procedure dbo.spConsensusMarketingListFetchAllByUserid as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingListFetchAllByUserid(@PA_LIST_USER_ID varchar(11) = null output) as 
begin
  select 
    LIST_ID,
    LIST_LOCK,
    LIST_ADD_DATE,
    LIST_ADD_BY,
    LIST_MOD_DATE,
    LIST_MOD_BY,
    LIST_RCV_DATE,
    LIST_RCV_FROM,
    LIST_TITLE,
    LIST_SUPPLIER_ID,
    LIST_PROLE_ID,
    LIST_DATE,
    LIST_USER_ID,
    LIST_ENTRIES,
    LIST_DUPLICATES,
    LIST_NEW_ORG,
    LIST_NEW_PERSON,
    LIST_PRICE,
    LIST_STATUS,
    LIST_NOTES,
    LIST_NEW_ADDRESSES,
    LIST_LIMIT,
    LIST_UNTIL,
    LIST_USERCHAR_1,
    LIST_USERCHAR_2,
    LIST_USERCHAR_3,
    LIST_USERCHAR_4,
    LIST_USERCHAR_5,
    LIST_USERCHAR_6,
    LIST_COURSE_ID,
    LIST_PROCESS,
    LIST_COUNTRY,
    LIST_IMP_STATUS,
    LIST_JOB_LU,
    LIST_LINES,
    LIST_COUNTRY_LU,
    LIST_INCOMPLETE,
    LIST_INVALID_IND,
    LIST_INVALID_CO,
    LIST_DELIMIT,
    LIST_HEADER,
    LIST_ETT_ID,
    LIST_WEB_ENABLED,
    LIST_NOTES_HTML,
    LIST_IS_DYNAMIC
  from dbo.List
  where LIST_USER_ID = @PA_LIST_USER_ID
end
go
