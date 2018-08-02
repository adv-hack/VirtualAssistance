if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMembershipRemoveById')
  exec ('create procedure dbo.spConsensusMembershipMembershipRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMembershipRemoveById(@PA_MEM_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Membership
  where MEM_ID = @PA_MEM_ID
end
go
