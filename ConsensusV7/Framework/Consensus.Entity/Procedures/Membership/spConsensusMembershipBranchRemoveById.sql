if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipBranchRemoveById')
  exec ('create procedure dbo.spConsensusMembershipBranchRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipBranchRemoveById(@PA_BR_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Branch
  where BR_ID = @PA_BR_ID
end
go
