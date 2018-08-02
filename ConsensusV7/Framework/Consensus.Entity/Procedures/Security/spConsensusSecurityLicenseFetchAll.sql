if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseFetchAll')
  exec ('create procedure dbo.spConsensusSecurityLicenseFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseFetchAll as 
begin
  select 
    LIC_ID,
    LIC_ACTIVE,
    LIC_EXPIRY,
    LIC_OWNER,
    LIC_SIGNATURE
  from dbo.License
end
go
