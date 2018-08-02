if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductEventFetchAllByProdid')
  exec ('create procedure dbo.spConsensusLearningProductEventFetchAllByProdid as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductEventFetchAllByProdid(@PA_PE_PROD_ID varchar(11) = null output) as 
begin
  select 
    PE_ID,
    PE_ADD_BY,
    PE_ADD_DATE,
    PE_MOD_BY,
    PE_MOD_DATE,
    PE_RCV_FROM,
    PE_RCV_DATE,
    PE_PROD_ID,
    PE_INSTANCE,
    PE_ACADY_CODE
  from dbo.Product_Event
  where PE_PROD_ID = @PA_PE_PROD_ID
end
go
