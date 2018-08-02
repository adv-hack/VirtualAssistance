if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachlearningzonecategoriesFetchAll')
  exec ('create procedure dbo.spConsensusCommonAttachlearningzonecategoriesFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachlearningzonecategoriesFetchAll as 
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
end
go
