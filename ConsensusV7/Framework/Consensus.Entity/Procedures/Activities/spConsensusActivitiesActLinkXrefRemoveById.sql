if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesActLinkXrefRemoveById')
  exec ('create procedure dbo.spConsensusActivitiesActLinkXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesActLinkXrefRemoveById(@PA_ACTLINK_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.ACT_LINK_XREF
  where ACTLINK_ID = @PA_ACTLINK_ID
end
go
