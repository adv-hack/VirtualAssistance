if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseLimitRemoveById')
  exec ('create procedure dbo.spConsensusSecurityLicenseLimitRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseLimitRemoveById(@PA_LL_ID integer = null output) as 
begin
  delete 
  from dbo.License_Limit
  where LL_ID = @PA_LL_ID
end
go
