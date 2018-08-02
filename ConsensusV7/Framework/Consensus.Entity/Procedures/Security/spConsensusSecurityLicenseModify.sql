if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseModify')
  exec ('create procedure dbo.spConsensusSecurityLicenseModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseModify(@PA_LIC_ID uniqueidentifier = null output, @PA_LIC_ACTIVE datetime = null output, @PA_LIC_EXPIRY datetime = null output, @PA_LIC_OWNER varchar(11) = null output, @PA_LIC_SIGNATURE varbinary(512) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.License set
    LIC_ACTIVE = @PA_LIC_ACTIVE,
    LIC_EXPIRY = @PA_LIC_EXPIRY,
    LIC_OWNER = @PA_LIC_OWNER,
    LIC_SIGNATURE = @PA_LIC_SIGNATURE
  where LIC_ID = @PA_LIC_ID;
end
go
