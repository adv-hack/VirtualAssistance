if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactTrainerRemoveById')
  exec ('create procedure dbo.spConsensusContactTrainerRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactTrainerRemoveById(@PA_TRAIN_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Trainer
  where TRAIN_ID = @PA_TRAIN_ID
end
go
