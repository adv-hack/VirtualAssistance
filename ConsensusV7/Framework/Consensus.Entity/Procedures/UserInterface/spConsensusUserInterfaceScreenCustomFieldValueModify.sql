if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldValueModify')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldValueModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldValueModify(@PA_CFVALUE_ID integer = null output, @PA_CFVALUE_CFIELD_ID integer = null output, @PA_CFVALUE_RECORD_ID varchar(11) = null output, @PA_CFVALUE_TEXT varchar(max) = null output, @PA_CFVALUE_NUMBER decimal(18, 3) = null output, @PA_CFVALUE_ID_VALUE varchar(11) = null output, @PA_CFVALUE_DATE datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Screen_Custom_Field_Value set
    CFVALUE_MOD_DATE = getDate(),
    CFVALUE_MOD_BY = @_AUDIT_USER_ID,
    CFVALUE_CFIELD_ID = @PA_CFVALUE_CFIELD_ID,
    CFVALUE_RECORD_ID = @PA_CFVALUE_RECORD_ID,
    CFVALUE_TEXT = @PA_CFVALUE_TEXT,
    CFVALUE_NUMBER = @PA_CFVALUE_NUMBER,
    CFVALUE_ID_VALUE = @PA_CFVALUE_ID_VALUE,
    CFVALUE_DATE = @PA_CFVALUE_DATE
  where CFVALUE_ID = @PA_CFVALUE_ID;
end
go
