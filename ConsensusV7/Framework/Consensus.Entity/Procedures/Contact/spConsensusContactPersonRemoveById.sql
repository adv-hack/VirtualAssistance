if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactPersonRemoveById')
  exec ('create procedure dbo.spConsensusContactPersonRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactPersonRemoveById(@PA_PN_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Person
  where PN_ID = @PA_PN_ID
end
go
