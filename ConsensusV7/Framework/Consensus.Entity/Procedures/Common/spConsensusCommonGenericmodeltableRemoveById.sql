if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonGenericmodeltableRemoveById')
  exec ('create procedure dbo.spConsensusCommonGenericmodeltableRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonGenericmodeltableRemoveById(@PA_GMT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.GenericModelTable
  where GMT_ID = @PA_GMT_ID
end
go
