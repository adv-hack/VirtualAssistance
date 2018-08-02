if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusxrefFetchAll')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusxrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusxrefFetchAll as 
begin
  select 
    SMXREF_ID,
    SMXREF_SMENU_ID,
    SMXREF_MOD_ID
  from dbo.SystemMenusXRef
end
go
