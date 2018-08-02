if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberLocationRemoveById')
  exec ('create procedure dbo.spConsensusMembershipMemberLocationRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberLocationRemoveById(@PA_MEL_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Member_location
  where MEL_ID = @PA_MEL_ID
end
go
