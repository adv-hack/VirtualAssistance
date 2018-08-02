if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseModuleCreate')
  exec ('create procedure dbo.spConsensusSecurityLicenseModuleCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseModuleCreate(@PA_LM_ID integer = null output, @PA_LM_LIC_ID uniqueidentifier = null output, @PA_LM_MOD_ID uniqueidentifier = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.License_Module(
    LM_LIC_ID,
    LM_MOD_ID
  ) values (
    @PA_LM_LIC_ID,
    @PA_LM_MOD_ID
  );
    set @PA_LM_ID = @@identity;
end
go
