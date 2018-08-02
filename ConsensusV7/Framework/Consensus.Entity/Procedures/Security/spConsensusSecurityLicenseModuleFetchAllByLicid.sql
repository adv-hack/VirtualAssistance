if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseModuleFetchAllByLicid')
  exec ('create procedure dbo.spConsensusSecurityLicenseModuleFetchAllByLicid as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseModuleFetchAllByLicid(@PA_LM_LIC_ID uniqueidentifier = null output) as 
begin
  select 
    LM_ID,
    LM_LIC_ID,
    LM_MOD_ID
  from dbo.License_Module
  where LM_LIC_ID = @PA_LM_LIC_ID
end
go
