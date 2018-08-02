if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProdselectgroupsModify')
  exec ('create procedure dbo.spConsensusLearningProdselectgroupsModify as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProdselectgroupsModify(@PA_PSG_ID integer = null output, @PA_PSG_PROD_ID varchar(11) = null output, @PA_PSG_TYPE tinyint = null output, @PA_PSG_NAME varchar(100) = null output, @PA_PSG_DESCRIPTION varchar(250) = null output, @PA_PSG_MIN tinyint = null output, @PA_PSG_MAX tinyint = null output, @PA_PSG_ORDER tinyint = null output, @PA_PSG_ERROR_MESSAGE varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.ProdSelectGroups set
    PSG_MOD_DATE = getDate(),
    PSG_MOD_BY = @_AUDIT_USER_ID,
    PSG_PROD_ID = @PA_PSG_PROD_ID,
    PSG_TYPE = @PA_PSG_TYPE,
    PSG_NAME = @PA_PSG_NAME,
    PSG_DESCRIPTION = @PA_PSG_DESCRIPTION,
    PSG_MIN = @PA_PSG_MIN,
    PSG_MAX = @PA_PSG_MAX,
    PSG_ORDER = @PA_PSG_ORDER,
    PSG_ERROR_MESSAGE = @PA_PSG_ERROR_MESSAGE
  where PSG_ID = @PA_PSG_ID;
end
go
