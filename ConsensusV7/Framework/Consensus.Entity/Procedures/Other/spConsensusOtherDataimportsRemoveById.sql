if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherDataimportsRemoveById')
  exec ('create procedure dbo.spConsensusOtherDataimportsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusOtherDataimportsRemoveById(@PA_DI_ID integer = null output) as 
begin
  delete 
  from dbo.DataImports
  where DI_ID = @PA_DI_ID
end
go
