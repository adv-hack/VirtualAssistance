if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCustomerPackFetchAllByOrgid')
  exec ('create procedure dbo.spConsensusContactCustomerPackFetchAllByOrgid as select 1 as temp')
go
alter procedure dbo.spConsensusContactCustomerPackFetchAllByOrgid(@PA_CPA_ORG_ID varchar(11) = null output) as 
begin
  select 
    CPA_ID,
    CPA_ADD_DATE,
    CPA_ADD_BY,
    CPA_MOD_DATE,
    CPA_MOD_BY,
    CPA_ORG_ID,
    CPA_PACK_ID,
    CPA_TYPE,
    CPA_SUPPRESS
  from dbo.Customer_Pack
  where CPA_ORG_ID = @PA_CPA_ORG_ID
end
go
