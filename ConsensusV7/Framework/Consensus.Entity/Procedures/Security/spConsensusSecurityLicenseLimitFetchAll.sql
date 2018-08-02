if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseLimitFetchAll')
  exec ('create procedure dbo.spConsensusSecurityLicenseLimitFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseLimitFetchAll as 
begin
  select 
    LL_ID,
    LL_LIC_ID,
    LL_TYPE,
    LL_VALUE
  from dbo.License_Limit
end
go
