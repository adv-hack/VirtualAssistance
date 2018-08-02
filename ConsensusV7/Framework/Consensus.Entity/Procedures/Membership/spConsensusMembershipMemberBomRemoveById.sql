if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberBomRemoveById')
  exec ('create procedure dbo.spConsensusMembershipMemberBomRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberBomRemoveById(@PA_MBOM_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.MEMBER_BOM
  where MBOM_ID = @PA_MBOM_ID
end
go
