if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachlearningzonecategoriesCreate')
  exec ('create procedure dbo.spConsensusCommonAttachlearningzonecategoriesCreate as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachlearningzonecategoriesCreate(@PA_ATTLZC_ID integer = null output, @PA_ATTLZC_ATT_ID varchar(11) = null output, @PA_ATTLZC_LZC_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.AttachLearningZoneCategories(
    ATTLZC_ADD_DATE,
    ATTLZC_ADD_BY,
    ATTLZC_MOD_DATE,
    ATTLZC_MOD_BY,
    ATTLZC_ATT_ID,
    ATTLZC_LZC_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_ATTLZC_ATT_ID,
    @PA_ATTLZC_LZC_ID
  );
    set @PA_ATTLZC_ID = @@identity;
end
go
