if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonCodeRemoveById')
  exec ('create procedure dbo.spConsensusCommonCodeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonCodeRemoveById(@PA_CODE_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Code
  where CODE_ID = @PA_CODE_ID
end
go
