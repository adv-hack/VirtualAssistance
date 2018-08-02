if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductProdXrefFetchAll')
  exec ('create procedure dbo.spConsensusLearningProductProdXrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductProdXrefFetchAll as 
begin
  select 
    PPX_ID,
    PPX_ADD_BY,
    PPX_ADD_DATE,
    PPX_MOD_BY,
    PPX_MOD_DATE,
    PPX_RCV_FROM,
    PPX_RCV_DATE,
    PPX_MAST_PROD_ID,
    PPX_SIM_PROD_ID,
    PPX_NOTES,
    PPX_PREREQ,
    PPX_SCHN_ID
  from dbo.Product_Prod_Xref
end
go
