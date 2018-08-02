if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonSysParamsRemoveById')
  exec ('create procedure dbo.spConsensusCommonSysParamsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonSysParamsRemoveById(@PA_SP_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Sys_Params
  where SP_ID = @PA_SP_ID
end
go
