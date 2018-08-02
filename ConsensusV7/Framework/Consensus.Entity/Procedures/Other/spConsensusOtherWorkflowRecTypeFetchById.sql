if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherWorkflowRecTypeFetchById')
  exec ('create procedure dbo.spConsensusOtherWorkflowRecTypeFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusOtherWorkflowRecTypeFetchById(@PA_WRT_ID varchar(11) = null output) as 
begin
  select 
    WRT_ID,
    WRT_LOCK,
    WRT_ADD_DATE,
    WRT_ADD_BY,
    WRT_MOD_DATE,
    WRT_MOD_BY,
    WRT_RCV_DATE,
    WRT_RCV_FROM,
    WRT_REC_TYPE,
    WRT_DESC,
    WRT_TABLE,
    WRT_TABLE_KEY,
    WRT_SQL,
    WRT_PR_TYPE,
    WRT_SEARCH_ENTITY,
    WRT_LINK_TO,
    WRT_PR_TYPE_TYPE,
    WRT_QUERY,
    WRT_QUERY_SELECT,
    WRT_QUERY_MERGE,
    WRT_ACT_TYPES,
    WRT_PR_ARG
  from dbo.Workflow_Rec_Type
  where WRT_ID = @PA_WRT_ID
end
go
