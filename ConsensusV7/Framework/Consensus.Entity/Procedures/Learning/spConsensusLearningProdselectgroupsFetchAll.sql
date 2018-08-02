if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProdselectgroupsFetchAll')
  exec ('create procedure dbo.spConsensusLearningProdselectgroupsFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProdselectgroupsFetchAll as 
begin
  select 
    PSG_ID,
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
  from dbo.ProdSelectGroups
end
go
