if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductProdXrefRemoveById')
  exec ('create procedure dbo.spConsensusLearningProductProdXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductProdXrefRemoveById(@PA_PPX_ID integer = null output) as 
begin
  delete 
  from dbo.Product_Prod_Xref
  where PPX_ID = @PA_PPX_ID
end
go
