if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseFetchAllByOwner')
  exec ('create procedure dbo.spConsensusSecurityLicenseFetchAllByOwner as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseFetchAllByOwner(@PA_LIC_OWNER varchar(11) = null output) as 
begin
  select 
    LIC_ID,
    LIC_ACTIVE,
    LIC_EXPIRY,
    LIC_OWNER,
    LIC_SIGNATURE
  from dbo.License
  where LIC_OWNER = @PA_LIC_OWNER
end
go
