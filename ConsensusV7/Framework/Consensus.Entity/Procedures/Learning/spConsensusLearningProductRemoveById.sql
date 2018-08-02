if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductRemoveById')
  exec ('create procedure dbo.spConsensusLearningProductRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductRemoveById(@PA_PROD_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Product
  where PROD_ID = @PA_PROD_ID
end
go
