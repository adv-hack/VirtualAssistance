if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusxrefModify')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusxrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusxrefModify(@PA_SMXREF_ID integer = null output, @PA_SMXREF_SMENU_ID integer = null output, @PA_SMXREF_MOD_ID uniqueidentifier = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.SystemMenusXRef set
    SMXREF_SMENU_ID = @PA_SMXREF_SMENU_ID,
    SMXREF_MOD_ID = @PA_SMXREF_MOD_ID
  where SMXREF_ID = @PA_SMXREF_ID;
end
go
