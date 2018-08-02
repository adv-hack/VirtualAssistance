if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherExportconfigurationsRemoveById')
  exec ('create procedure dbo.spConsensusOtherExportconfigurationsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusOtherExportconfigurationsRemoveById(@PA_EC_ID integer = null output) as 
begin
  delete 
  from dbo.ExportConfigurations
  where EC_ID = @PA_EC_ID
end
go
