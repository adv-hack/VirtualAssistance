if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesParameterFieldsRemoveById')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesParameterFieldsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesParameterFieldsRemoveById(@PA_SYSSP_ID integer = null output) as 
begin
  delete 
  from dbo.System_Searches_Parameter_Fields
  where SYSSP_ID = @PA_SYSSP_ID
end
go
