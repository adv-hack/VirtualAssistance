if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachlearningzonecategoriesFetchById')
  exec ('create procedure dbo.spConsensusCommonAttachlearningzonecategoriesFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachlearningzonecategoriesFetchById(@PA_ATTLZC_ID integer = null output) as 
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
  where ATTLZC_ID = @PA_ATTLZC_ID
end
go
