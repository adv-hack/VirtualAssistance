if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingListMemberFetchAllByListid')
  exec ('create procedure dbo.spConsensusMarketingListMemberFetchAllByListid as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingListMemberFetchAllByListid(@PA_LM_LIST_ID varchar(11) = null output) as 
begin
  select 
    LM_ID,
    LM_LOCK,
    LM_ADD_BY,
    LM_ADD_DATE,
    LM_MOD_BY,
    LM_MOD_DATE,
    LM_RCV_DATE,
    LM_RCV_FROM,
    LM_LIST_ID,
    LM_PN_ID,
    LM_TITLE,
    LM_USERCHAR_1,
    LM_USERCHAR_2,
    LM_USERCHAR_3,
    LM_USERCHAR_4,
    LM_TERMS_READ,
    LM_TABLE_NAME,
    LM_RECORD_ID,
    LM_DISABLE
  from dbo.List_Member
  where LM_LIST_ID = @PA_LM_LIST_ID
end
go
