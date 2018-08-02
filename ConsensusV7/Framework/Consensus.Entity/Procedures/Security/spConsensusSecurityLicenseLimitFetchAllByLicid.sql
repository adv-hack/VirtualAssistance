if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseLimitFetchAllByLicid')
  exec ('create procedure dbo.spConsensusSecurityLicenseLimitFetchAllByLicid as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseLimitFetchAllByLicid(@PA_LL_LIC_ID uniqueidentifier = null output) as 
begin
  select 
    LL_ID,
    LL_LIC_ID,
    LL_TYPE,
    LL_VALUE
  from dbo.License_Limit
  where LL_LIC_ID = @PA_LL_LIC_ID
end
go
