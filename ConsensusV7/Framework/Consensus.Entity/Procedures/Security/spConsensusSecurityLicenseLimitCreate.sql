if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseLimitCreate')
  exec ('create procedure dbo.spConsensusSecurityLicenseLimitCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseLimitCreate(@PA_LL_ID integer = null output, @PA_LL_LIC_ID uniqueidentifier = null output, @PA_LL_TYPE integer = null output, @PA_LL_VALUE integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.License_Limit(
    LL_LIC_ID,
    LL_TYPE,
    LL_VALUE
  ) values (
    @PA_LL_LIC_ID,
    @PA_LL_TYPE,
    @PA_LL_VALUE
  );
    set @PA_LL_ID = @@identity;
end
go
