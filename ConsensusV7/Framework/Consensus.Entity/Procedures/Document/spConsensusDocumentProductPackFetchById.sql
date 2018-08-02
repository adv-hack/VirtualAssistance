if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentProductPackFetchById')
  exec ('create procedure dbo.spConsensusDocumentProductPackFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentProductPackFetchById(@PA_PPA_ID integer = null output) as 
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
  where PPA_ID = @PA_PPA_ID
end
go
