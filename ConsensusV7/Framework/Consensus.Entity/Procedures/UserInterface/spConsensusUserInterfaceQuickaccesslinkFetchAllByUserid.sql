if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceQuickaccesslinkFetchAllByUserid')
  exec ('create procedure dbo.spConsensusUserInterfaceQuickaccesslinkFetchAllByUserid as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceQuickaccesslinkFetchAllByUserid(@PA_QAL_USER_ID integer = null output) as 
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
  where QAL_USER_ID = @PA_QAL_USER_ID
end
go
