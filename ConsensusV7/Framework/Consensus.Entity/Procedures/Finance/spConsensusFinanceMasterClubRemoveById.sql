if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceMasterClubRemoveById')
  exec ('create procedure dbo.spConsensusFinanceMasterClubRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceMasterClubRemoveById(@PA_MSTC_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Master_Club
  where MSTC_ID = @PA_MSTC_ID
end
go
