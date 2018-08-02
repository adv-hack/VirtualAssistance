if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAkaRemoveById')
  exec ('create procedure dbo.spConsensusContactAkaRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactAkaRemoveById(@PA_AKA_ID integer = null output) as 
begin
  delete 
  from dbo.AKA
  where AKA_ID = @PA_AKA_ID
end
go
