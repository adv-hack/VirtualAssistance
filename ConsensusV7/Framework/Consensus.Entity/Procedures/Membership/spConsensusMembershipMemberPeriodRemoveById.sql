if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberPeriodRemoveById')
  exec ('create procedure dbo.spConsensusMembershipMemberPeriodRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberPeriodRemoveById(@PA_MEP_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Member_period
  where MEP_ID = @PA_MEP_ID
end
go
