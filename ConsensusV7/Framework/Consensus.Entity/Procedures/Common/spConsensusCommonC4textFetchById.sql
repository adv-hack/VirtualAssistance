if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonC4textFetchById')
  exec ('create procedure dbo.spConsensusCommonC4textFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonC4textFetchById(@PA_TEXT_ID varchar(11) = null output) as 
begin
  select 
    TEXT_ID,
    TEXT_ADD_DATE,
    TEXT_ADD_BY,
    TEXT_MOD_DATE,
    TEXT_MOD_BY,
    TEXT_RCV_DATE,
    TEXT_RCV_FROM,
    TEXT_TYPE,
    TEXT_OWNER_ID,
    TEXT_BODY,
    TEXT_RTF,
    TEXT_HTML,
    TEXT_OWNER_URL
  from dbo.C4Text
  where TEXT_ID = @PA_TEXT_ID
end
go
