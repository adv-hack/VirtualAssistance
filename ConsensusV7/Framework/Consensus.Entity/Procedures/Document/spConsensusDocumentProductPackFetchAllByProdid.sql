if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentProductPackFetchAllByProdid')
  exec ('create procedure dbo.spConsensusDocumentProductPackFetchAllByProdid as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentProductPackFetchAllByProdid(@PA_PPA_PROD_ID varchar(11) = null output) as 
begin
  select 
    PPA_ID,
    PPA_ADD_DATE,
    PPA_ADD_BY,
    PPA_MOD_DATE,
    PPA_MOD_BY,
    PPA_PROD_ID,
    PPA_PACK_ID,
    PPA_TYPE,
    PPA_SUPPRESS
  from dbo.Product_Pack
  where PPA_PROD_ID = @PA_PPA_PROD_ID
end
go
