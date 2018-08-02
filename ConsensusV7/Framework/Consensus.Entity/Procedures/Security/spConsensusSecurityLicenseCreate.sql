if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseCreate')
  exec ('create procedure dbo.spConsensusSecurityLicenseCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseCreate(@PA_LIC_ID uniqueidentifier = null output, @PA_LIC_ACTIVE datetime = null output, @PA_LIC_EXPIRY datetime = null output, @PA_LIC_OWNER varchar(11) = null output, @PA_LIC_SIGNATURE varbinary(512) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  set @PA_LIC_ID = newid();
  
  insert into dbo.License(
    LIC_ID,
    LIC_ACTIVE,
    LIC_EXPIRY,
    LIC_OWNER,
    LIC_SIGNATURE
  ) values (
    @PA_LIC_ID,
    @PA_LIC_ACTIVE,
    @PA_LIC_EXPIRY,
    @PA_LIC_OWNER,
    @PA_LIC_SIGNATURE
  );
end
go
