if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldValueCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldValueCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldValueCreate(@PA_CFVALUE_ID integer = null output, @PA_CFVALUE_CFIELD_ID integer = null output, @PA_CFVALUE_RECORD_ID varchar(11) = null output, @PA_CFVALUE_TEXT varchar(max) = null output, @PA_CFVALUE_NUMBER decimal(18, 3) = null output, @PA_CFVALUE_ID_VALUE varchar(11) = null output, @PA_CFVALUE_DATE datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Screen_Custom_Field_Value(
    CFVALUE_ADD_DATE,
    CFVALUE_ADD_BY,
    CFVALUE_MOD_DATE,
    CFVALUE_MOD_BY,
    CFVALUE_CFIELD_ID,
    CFVALUE_RECORD_ID,
    CFVALUE_TEXT,
    CFVALUE_NUMBER,
    CFVALUE_ID_VALUE,
    CFVALUE_DATE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_CFVALUE_CFIELD_ID,
    @PA_CFVALUE_RECORD_ID,
    @PA_CFVALUE_TEXT,
    @PA_CFVALUE_NUMBER,
    @PA_CFVALUE_ID_VALUE,
    @PA_CFVALUE_DATE
  );
    set @PA_CFVALUE_ID = @@identity;
end
go
