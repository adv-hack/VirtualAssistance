if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseModuleRemoveById')
  exec ('create procedure dbo.spConsensusSecurityLicenseModuleRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseModuleRemoveById(@PA_LM_ID integer = null output) as 
begin
  delete 
  from dbo.License_Module
  where LM_ID = @PA_LM_ID
end
go
