if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusxrefCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusxrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusxrefCreate(@PA_SMXREF_ID integer = null output, @PA_SMXREF_SMENU_ID integer = null output, @PA_SMXREF_MOD_ID uniqueidentifier = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.SystemMenusXRef(
    SMXREF_SMENU_ID,
    SMXREF_MOD_ID
  ) values (
    @PA_SMXREF_SMENU_ID,
    @PA_SMXREF_MOD_ID
  );
    set @PA_SMXREF_ID = @@identity;
end
go
