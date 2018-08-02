if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactOrganisationRemoveById')
  exec ('create procedure dbo.spConsensusContactOrganisationRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactOrganisationRemoveById(@PA_ORG_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Organisation
  where ORG_ID = @PA_ORG_ID
end
go
