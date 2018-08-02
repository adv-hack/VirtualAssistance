if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseFetchById')
  exec ('create procedure dbo.spConsensusSecurityLicenseFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseFetchById(@PA_LIC_ID uniqueidentifier = null output) as 
begin
  select 
    LIC_ID,
    LIC_ACTIVE,
    LIC_EXPIRY,
    LIC_OWNER,
    LIC_SIGNATURE
  from dbo.License
  where LIC_ID = @PA_LIC_ID
end
go
