if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeRemoveById')
  exec ('create procedure dbo.spConsensusMembershipCommitteeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeRemoveById(@PA_COM_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Committee
  where COM_ID = @PA_COM_ID
end
go
