if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceHistoryLinkCleanUp')
  exec ('create procedure dbo.spConsensusUserInterfaceHistoryLinkCleanUp as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceHistoryLinkCleanUp(@PA_USER_ID integer) as 
begin
 if (select count(HL_ID) from dbo.HistoryLink where HL_USER_ID = @PA_USER_ID group by HL_USER_ID) > 20
	begin
	  delete 
	  from dbo.HistoryLink
	  where HL_USER_ID = @PA_USER_ID
	  and HL_ID not in (select top 20 HL_ID from dbo.HistoryLink where HL_USER_ID = @PA_USER_ID order by HL_ADD_DATE desc)
	end
end
go
