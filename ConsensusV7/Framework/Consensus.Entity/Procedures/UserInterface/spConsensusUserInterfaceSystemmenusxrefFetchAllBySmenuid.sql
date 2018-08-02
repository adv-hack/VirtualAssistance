if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusxrefFetchAllBySmenuid')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusxrefFetchAllBySmenuid as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusxrefFetchAllBySmenuid(@PA_SMXREF_SMENU_ID integer = null output) as 
begin
  select 
    SMXREF_ID,
    SMXREF_SMENU_ID,
    SMXREF_MOD_ID
  from dbo.SystemMenusXRef
  where SMXREF_SMENU_ID = @PA_SMXREF_SMENU_ID
end
go
