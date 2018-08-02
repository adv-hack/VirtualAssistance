if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusxrefRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusxrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusxrefRemoveById(@PA_SMXREF_ID integer = null output) as 
begin
  delete 
  from dbo.SystemMenusXRef
  where SMXREF_ID = @PA_SMXREF_ID
end
go
