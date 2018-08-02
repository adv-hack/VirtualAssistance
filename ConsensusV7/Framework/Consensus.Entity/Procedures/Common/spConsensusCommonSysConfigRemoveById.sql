if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonSysConfigRemoveById')
  exec ('create procedure dbo.spConsensusCommonSysConfigRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonSysConfigRemoveById(@PA_SC_ID integer = null output) as 
begin
  delete 
  from dbo.SYS_CONFIG
  where SC_ID = @PA_SC_ID
end
go
