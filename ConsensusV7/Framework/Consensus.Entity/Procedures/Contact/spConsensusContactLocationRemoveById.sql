if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactLocationRemoveById')
  exec ('create procedure dbo.spConsensusContactLocationRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactLocationRemoveById(@PA_LOC_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Location
  where LOC_ID = @PA_LOC_ID
end
go
