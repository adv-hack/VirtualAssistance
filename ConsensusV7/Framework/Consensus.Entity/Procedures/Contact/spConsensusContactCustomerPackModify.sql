if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCustomerPackModify')
  exec ('create procedure dbo.spConsensusContactCustomerPackModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactCustomerPackModify(@PA_CPA_ID integer = null output, @PA_CPA_ORG_ID varchar(11) = null output, @PA_CPA_PACK_ID varchar(11) = null output, @PA_CPA_TYPE varchar(40) = null output, @PA_CPA_SUPPRESS tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Customer_Pack set
    CPA_MOD_DATE = getDate(),
    CPA_MOD_BY = @_AUDIT_USER_ID,
    CPA_ORG_ID = @PA_CPA_ORG_ID,
    CPA_PACK_ID = @PA_CPA_PACK_ID,
    CPA_TYPE = @PA_CPA_TYPE,
    CPA_SUPPRESS = @PA_CPA_SUPPRESS
  where CPA_ID = @PA_CPA_ID;
end
go
