if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceQuickaccesslinkFetchAll')
  exec ('create procedure dbo.spConsensusUserInterfaceQuickaccesslinkFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceQuickaccesslinkFetchAll as 
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
end
go
