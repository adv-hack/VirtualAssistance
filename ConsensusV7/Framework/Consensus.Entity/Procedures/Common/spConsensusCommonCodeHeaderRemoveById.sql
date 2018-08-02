if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonCodeHeaderRemoveById')
  exec ('create procedure dbo.spConsensusCommonCodeHeaderRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonCodeHeaderRemoveById(@PA_CDHDR_CODE_TYPE varchar(5) = null output) as 
begin
  delete 
  from dbo.Code_Header
  where CDHDR_CODE_TYPE = @PA_CDHDR_CODE_TYPE
end
go
