if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactTrainProdXrefRemoveById')
  exec ('create procedure dbo.spConsensusContactTrainProdXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactTrainProdXrefRemoveById(@PA_TPXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.TRAIN_PROD_XREF
  where TPXREF_ID = @PA_TPXREF_ID
end
go
