if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductProdXrefFetchAllBySchnid')
  exec ('create procedure dbo.spConsensusLearningProductProdXrefFetchAllBySchnid as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductProdXrefFetchAllBySchnid(@PA_PPX_SCHN_ID varchar(11) = null output) as 
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
  where PPX_SCHN_ID = @PA_PPX_SCHN_ID
end
go
