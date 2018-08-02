if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesActivityXrefRemoveById')
  exec ('create procedure dbo.spConsensusActivitiesActivityXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesActivityXrefRemoveById(@PA_ACTXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Activity_Xref
  where ACTXREF_ID = @PA_ACTXREF_ID
end
go
