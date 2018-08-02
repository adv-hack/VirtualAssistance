if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonC4textRemoveById')
  exec ('create procedure dbo.spConsensusCommonC4textRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonC4textRemoveById(@PA_TEXT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.C4Text
  where TEXT_ID = @PA_TEXT_ID
end
go
