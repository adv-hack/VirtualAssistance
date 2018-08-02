if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseModuleFetchAll')
  exec ('create procedure dbo.spConsensusSecurityLicenseModuleFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseModuleFetchAll as 
begin
  select 
    LM_ID,
    LM_LIC_ID,
    LM_MOD_ID
  from dbo.License_Module
end
go
