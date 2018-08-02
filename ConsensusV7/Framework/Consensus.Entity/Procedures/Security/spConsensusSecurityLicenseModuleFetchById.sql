if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseModuleFetchById')
  exec ('create procedure dbo.spConsensusSecurityLicenseModuleFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseModuleFetchById(@PA_LM_ID integer = null output) as 
begin
  select 
    LM_ID,
    LM_LIC_ID,
    LM_MOD_ID
  from dbo.License_Module
  where LM_ID = @PA_LM_ID
end
go
