if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldValueFetchByFieldIdAndRecordId')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldValueFetchByFieldIdAndRecordId as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldValueFetchByFieldIdAndRecordId(
	@PA_CFIELD_ID integer = null output,
	@PA_RECORD_ID varchar(11) = null output
	) 
as 
begin
  select 
    CFVALUE_ID,
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
  from dbo.Screen_Custom_Field_Value
  where CFVALUE_CFIELD_ID = @PA_CFIELD_ID
  and CFVALUE_RECORD_ID = @PA_RECORD_ID
end
go
