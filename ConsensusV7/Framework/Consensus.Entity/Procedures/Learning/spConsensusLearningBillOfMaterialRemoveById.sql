if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningBillOfMaterialRemoveById')
  exec ('create procedure dbo.spConsensusLearningBillOfMaterialRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningBillOfMaterialRemoveById(@PA_BOM_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Bill_Of_Material
  where BOM_ID = @PA_BOM_ID
end
go
