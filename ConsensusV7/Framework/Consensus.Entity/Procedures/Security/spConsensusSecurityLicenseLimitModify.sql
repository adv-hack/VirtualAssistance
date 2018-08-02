if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseLimitModify')
  exec ('create procedure dbo.spConsensusSecurityLicenseLimitModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseLimitModify(@PA_LL_ID integer = null output, @PA_LL_LIC_ID uniqueidentifier = null output, @PA_LL_TYPE integer = null output, @PA_LL_VALUE integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.License_Limit set
    LL_LIC_ID = @PA_LL_LIC_ID,
    LL_TYPE = @PA_LL_TYPE,
    LL_VALUE = @PA_LL_VALUE
  where LL_ID = @PA_LL_ID;
end
go
