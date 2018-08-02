if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldTypeFetchAll')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeFetchAll as 
begin
  select 
    CFTYPE_ID,
    CFTYPE_ADD_DATE,
    CFTYPE_ADD_BY,
    CFTYPE_MOD_DATE,
    CFTYPE_MOD_BY,
    CFTYPE_NAME
  from dbo.Screen_Custom_Field_Type
end
go
