if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseLimitFetchById')
  exec ('create procedure dbo.spConsensusSecurityLicenseLimitFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseLimitFetchById(@PA_LL_ID integer = null output) as 
begin
  select 
    LL_ID,
    LL_LIC_ID,
    LL_TYPE,
    LL_VALUE
  from dbo.License_Limit
  where LL_ID = @PA_LL_ID
end
go
