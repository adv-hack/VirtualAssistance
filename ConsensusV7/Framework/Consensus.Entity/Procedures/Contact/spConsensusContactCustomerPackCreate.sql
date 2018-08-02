if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCustomerPackCreate')
  exec ('create procedure dbo.spConsensusContactCustomerPackCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactCustomerPackCreate(@PA_CPA_ID integer = null output, @PA_CPA_ORG_ID varchar(11) = null output, @PA_CPA_PACK_ID varchar(11) = null output, @PA_CPA_TYPE varchar(40) = null output, @PA_CPA_SUPPRESS tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Customer_Pack(
    CPA_ADD_DATE,
    CPA_ADD_BY,
    CPA_MOD_DATE,
    CPA_MOD_BY,
    CPA_ORG_ID,
    CPA_PACK_ID,
    CPA_TYPE,
    CPA_SUPPRESS
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_CPA_ORG_ID,
    @PA_CPA_PACK_ID,
    @PA_CPA_TYPE,
    @PA_CPA_SUPPRESS
  );
    set @PA_CPA_ID = @@identity;
end
go
