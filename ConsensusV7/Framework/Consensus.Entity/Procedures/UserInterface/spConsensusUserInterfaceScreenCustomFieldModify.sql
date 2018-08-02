if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldModify')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldModify(@PA_CFIELD_ID integer = null output, @PA_CFIELD_URL nvarchar(250) = null output, @PA_CFIELD_PARENT_CONTROL nvarchar(max) = null output, @PA_CFIELD_NAME nvarchar(40) = null output, @PA_CFIELD_LABEL nvarchar(max) = null output, @PA_CFIELD_CFTYPE_ID varchar(40) = null output, @PA_CFIELD_POPUP_URL varchar(150) = null output, @PA_CFIELD_DECIMALS integer = null output, @PA_CFIELD_PAGE nvarchar(250) = null output, @PA_CFIELD_TABLE nvarchar(128) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Screen_Custom_Field set
    CFIELD_MOD_DATE = getDate(),
    CFIELD_MOD_BY = @_AUDIT_USER_ID,
    CFIELD_URL = @PA_CFIELD_URL,
    CFIELD_PARENT_CONTROL = @PA_CFIELD_PARENT_CONTROL,
    CFIELD_NAME = @PA_CFIELD_NAME,
    CFIELD_LABEL = @PA_CFIELD_LABEL,
    CFIELD_CFTYPE_ID = @PA_CFIELD_CFTYPE_ID,
    CFIELD_POPUP_URL = @PA_CFIELD_POPUP_URL,
    CFIELD_DECIMALS = @PA_CFIELD_DECIMALS,
    CFIELD_PAGE = @PA_CFIELD_PAGE,
    CFIELD_TABLE = @PA_CFIELD_TABLE
  where CFIELD_ID = @PA_CFIELD_ID;
end
go
