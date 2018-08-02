if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldTypeFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeFetchById(@PA_CFTYPE_ID varchar(40) = null output) as 
begin
  select 
    CFTYPE_ID,
    CFTYPE_ADD_DATE,
    CFTYPE_ADD_BY,
    CFTYPE_MOD_DATE,
    CFTYPE_MOD_BY,
    CFTYPE_NAME
  from dbo.Screen_Custom_Field_Type
  where CFTYPE_ID = @PA_CFTYPE_ID
end
go
