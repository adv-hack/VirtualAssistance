if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningTemplateXrefModify')
  exec ('create procedure dbo.spConsensusLearningTemplateXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusLearningTemplateXrefModify(@PA_TXREF_ID varchar(11) = null output, @PA_TXREF_LOCK varchar(11) = null output, @PA_TXREF_BOM_ID varchar(11) = null output, @PA_TXREF_PROD_ID varchar(11) = null output, @PA_TXREF_USAGE tinyint = null output, @PA_TXREF_QTY float = null output, @PA_TXREF_DEL_QTY float = null output, @PA_TXREF_PER_DAY tinyint = null output, @PA_TXREF_ARG_ID varchar(11) = null output, @PA_TXREF_TYPE tinyint = null output, @PA_TXREF_PROF_KEY varchar(40) = null output, @PA_TXREF_PROF_VALUE varchar(40) = null output, @PA_TXREF_PROF_VALUE2 varchar(40) = null output, @PA_TXREF_RATIO integer = null output, @PA_TXREF_UNT_TYPE varchar(1) = null output, @PA_TXREF_TRAINER tinyint = null output, @PA_TXREF_COST decimal(19, 2) = null output, @PA_TXREF_ROOM_TYPE varchar(40) = null output, @PA_TXREF_INC_IN_BUDGET tinyint = null output, @PA_TXREF_TRAIN_PROLE_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Template_Xref set
    TXREF_MOD_DATE = getDate(),
    TXREF_MOD_BY = @_AUDIT_USER_ID,
    TXREF_LOCK = @PA_TXREF_LOCK,
    TXREF_BOM_ID = @PA_TXREF_BOM_ID,
    TXREF_PROD_ID = @PA_TXREF_PROD_ID,
    TXREF_USAGE = @PA_TXREF_USAGE,
    TXREF_QTY = @PA_TXREF_QTY,
    TXREF_DEL_QTY = @PA_TXREF_DEL_QTY,
    TXREF_PER_DAY = @PA_TXREF_PER_DAY,
    TXREF_ARG_ID = @PA_TXREF_ARG_ID,
    TXREF_TYPE = @PA_TXREF_TYPE,
    TXREF_PROF_KEY = @PA_TXREF_PROF_KEY,
    TXREF_PROF_VALUE = @PA_TXREF_PROF_VALUE,
    TXREF_PROF_VALUE2 = @PA_TXREF_PROF_VALUE2,
    TXREF_RATIO = @PA_TXREF_RATIO,
    TXREF_UNT_TYPE = @PA_TXREF_UNT_TYPE,
    TXREF_TRAINER = @PA_TXREF_TRAINER,
    TXREF_COST = @PA_TXREF_COST,
    TXREF_ROOM_TYPE = @PA_TXREF_ROOM_TYPE,
    TXREF_INC_IN_BUDGET = @PA_TXREF_INC_IN_BUDGET,
    TXREF_TRAIN_PROLE_ID = @PA_TXREF_TRAIN_PROLE_ID
  where TXREF_ID = @PA_TXREF_ID;
end
go
