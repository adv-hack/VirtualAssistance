if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachlearningzonecategoriesModify')
  exec ('create procedure dbo.spConsensusCommonAttachlearningzonecategoriesModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachlearningzonecategoriesModify(@PA_ATTLZC_ID integer = null output, @PA_ATTLZC_ATT_ID varchar(11) = null output, @PA_ATTLZC_LZC_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.AttachLearningZoneCategories set
    ATTLZC_MOD_DATE = getDate(),
    ATTLZC_MOD_BY = @_AUDIT_USER_ID,
    ATTLZC_ATT_ID = @PA_ATTLZC_ATT_ID,
    ATTLZC_LZC_ID = @PA_ATTLZC_LZC_ID
  where ATTLZC_ID = @PA_ATTLZC_ID;
end
go
