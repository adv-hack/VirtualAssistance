if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCustomerPackFetchAllByType')
  exec ('create procedure dbo.spConsensusContactCustomerPackFetchAllByType as select 1 as temp')
go
alter procedure dbo.spConsensusContactCustomerPackFetchAllByType(@PA_CPA_TYPE varchar(40) = null output) as 
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
  where CPA_TYPE = @PA_CPA_TYPE
end
go
