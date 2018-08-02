if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldCreate(@PA_CFIELD_ID integer = null output, @PA_CFIELD_URL nvarchar(250) = null output, @PA_CFIELD_PARENT_CONTROL nvarchar(max) = null output, @PA_CFIELD_NAME nvarchar(40) = null output, @PA_CFIELD_LABEL nvarchar(max) = null output, @PA_CFIELD_CFTYPE_ID varchar(40) = null output, @PA_CFIELD_POPUP_URL varchar(150) = null output, @PA_CFIELD_DECIMALS integer = null output, @PA_CFIELD_PAGE nvarchar(250) = null output, @PA_CFIELD_TABLE nvarchar(128) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Screen_Custom_Field(
    CFIELD_ADD_DATE,
    CFIELD_ADD_BY,
    CFIELD_MOD_DATE,
    CFIELD_MOD_BY,
    CFIELD_URL,
    CFIELD_PARENT_CONTROL,
    CFIELD_NAME,
    CFIELD_LABEL,
    CFIELD_CFTYPE_ID,
    CFIELD_POPUP_URL,
    CFIELD_DECIMALS,
    CFIELD_PAGE,
    CFIELD_TABLE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_CFIELD_URL,
    @PA_CFIELD_PARENT_CONTROL,
    @PA_CFIELD_NAME,
    @PA_CFIELD_LABEL,
    @PA_CFIELD_CFTYPE_ID,
    @PA_CFIELD_POPUP_URL,
    @PA_CFIELD_DECIMALS,
    @PA_CFIELD_PAGE,
    @PA_CFIELD_TABLE
  );
    set @PA_CFIELD_ID = @@identity;
end
go
