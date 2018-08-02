if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusxrefFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusxrefFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusxrefFetchById(@PA_SMXREF_ID integer = null output) as 
begin
  select 
    SMXREF_ID,
    SMXREF_SMENU_ID,
    SMXREF_MOD_ID
  from dbo.SystemMenusXRef
  where SMXREF_ID = @PA_SMXREF_ID
end
go
