if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingListMemberRemoveById')
  exec ('create procedure dbo.spConsensusMarketingListMemberRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingListMemberRemoveById(@PA_LM_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.List_Member
  where LM_ID = @PA_LM_ID
end
go
