if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceQuickaccesslinkFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceQuickaccesslinkFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceQuickaccesslinkFetchById(@PA_QAL_ID integer = null output) as 
begin
  select 
    QAL_ID,
    QAL_ADD_DATE,
    QAL_ADD_BY,
    QAL_MOD_DATE,
    QAL_MOD_BY,
    QAL_USER_ID,
    QAL_DESCRIPTION,
    QAL_URL,
    QAL_ICON
  from dbo.QuickAccessLink
  where QAL_ID = @PA_QAL_ID
end
go
