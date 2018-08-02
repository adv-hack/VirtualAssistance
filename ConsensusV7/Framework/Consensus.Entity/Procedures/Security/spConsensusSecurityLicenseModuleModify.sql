if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseModuleModify')
  exec ('create procedure dbo.spConsensusSecurityLicenseModuleModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseModuleModify(@PA_LM_ID integer = null output, @PA_LM_LIC_ID uniqueidentifier = null output, @PA_LM_MOD_ID uniqueidentifier = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.License_Module set
    LM_LIC_ID = @PA_LM_LIC_ID,
    LM_MOD_ID = @PA_LM_MOD_ID
  where LM_ID = @PA_LM_ID;
end
go
