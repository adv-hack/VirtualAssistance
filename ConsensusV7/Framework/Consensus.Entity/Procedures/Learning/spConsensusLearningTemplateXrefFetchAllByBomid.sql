if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningTemplateXrefFetchAllByBomid')
  exec ('create procedure dbo.spConsensusLearningTemplateXrefFetchAllByBomid as select 1 as temp')
go
alter procedure dbo.spConsensusLearningTemplateXrefFetchAllByBomid(@PA_TXREF_BOM_ID varchar(11) = null output) as 
begin
  select 
    TXREF_ID,
    TXREF_LOCK,
    TXREF_ADD_DATE,
    TXREF_ADD_BY,
    TXREF_MOD_DATE,
    TXREF_MOD_BY,
    TXREF_RCV_DATE,
    TXREF_RCV_FROM,
    TXREF_BOM_ID,
    TXREF_PROD_ID,
    TXREF_USAGE,
    TXREF_QTY,
    TXREF_DEL_QTY,
    TXREF_PER_DAY,
    TXREF_ARG_ID,
    TXREF_TYPE,
    TXREF_PROF_KEY,
    TXREF_PROF_VALUE,
    TXREF_PROF_VALUE2,
    TXREF_RATIO,
    TXREF_UNT_TYPE,
    TXREF_TRAINER,
    TXREF_COST,
    TXREF_ROOM_TYPE,
    TXREF_INC_IN_BUDGET,
    TXREF_TRAIN_PROLE_ID
  from dbo.Template_Xref
  where TXREF_BOM_ID = @PA_TXREF_BOM_ID
end
go
