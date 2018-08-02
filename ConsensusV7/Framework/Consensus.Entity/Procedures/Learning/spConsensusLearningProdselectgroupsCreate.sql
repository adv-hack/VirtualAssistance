if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProdselectgroupsCreate')
  exec ('create procedure dbo.spConsensusLearningProdselectgroupsCreate as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProdselectgroupsCreate(@PA_PSG_ID integer = null output, @PA_PSG_PROD_ID varchar(11) = null output, @PA_PSG_TYPE tinyint = null output, @PA_PSG_NAME varchar(100) = null output, @PA_PSG_DESCRIPTION varchar(250) = null output, @PA_PSG_MIN tinyint = null output, @PA_PSG_MAX tinyint = null output, @PA_PSG_ORDER tinyint = null output, @PA_PSG_ERROR_MESSAGE varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.ProdSelectGroups(
    PSG_ADD_DATE,
    PSG_ADD_BY,
    PSG_MOD_DATE,
    PSG_MOD_BY,
    PSG_PROD_ID,
    PSG_TYPE,
    PSG_NAME,
    PSG_DESCRIPTION,
    PSG_MIN,
    PSG_MAX,
    PSG_ORDER,
    PSG_ERROR_MESSAGE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_PSG_PROD_ID,
    @PA_PSG_TYPE,
    @PA_PSG_NAME,
    @PA_PSG_DESCRIPTION,
    @PA_PSG_MIN,
    @PA_PSG_MAX,
    @PA_PSG_ORDER,
    @PA_PSG_ERROR_MESSAGE
  );
    set @PA_PSG_ID = @@identity;
end
go
