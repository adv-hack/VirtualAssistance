if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachlearningzonecategoriesFetchAllByLzcid')
  exec ('create procedure dbo.spConsensusCommonAttachlearningzonecategoriesFetchAllByLzcid as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachlearningzonecategoriesFetchAllByLzcid(@PA_ATTLZC_LZC_ID integer = null output) as 
begin
  select 
    ATTLZC_ID,
    ATTLZC_ADD_DATE,
    ATTLZC_ADD_BY,
    ATTLZC_MOD_DATE,
    ATTLZC_MOD_BY,
    ATTLZC_ATT_ID,
    ATTLZC_LZC_ID
  from dbo.AttachLearningZoneCategories
  where ATTLZC_LZC_ID = @PA_ATTLZC_LZC_ID
end
go
