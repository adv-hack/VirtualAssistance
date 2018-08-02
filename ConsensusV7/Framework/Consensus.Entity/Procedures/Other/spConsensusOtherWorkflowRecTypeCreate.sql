if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherWorkflowRecTypeCreate')
  exec ('create procedure dbo.spConsensusOtherWorkflowRecTypeCreate as select 1 as temp')
go
alter procedure dbo.spConsensusOtherWorkflowRecTypeCreate(@PA_WRT_ID varchar(11) = null output, @PA_WRT_LOCK varchar(11) = null output, @PA_WRT_REC_TYPE varchar(50) = null output, @PA_WRT_DESC varchar(2000) = null output, @PA_WRT_TABLE varchar(25) = null output, @PA_WRT_TABLE_KEY varchar(25) = null output, @PA_WRT_SQL varchar(2000) = null output, @PA_WRT_PR_TYPE varchar(100) = null output, @PA_WRT_SEARCH_ENTITY varchar(50) = null output, @PA_WRT_LINK_TO varchar(500) = null output, @PA_WRT_PR_TYPE_TYPE varchar(5) = null output, @PA_WRT_QUERY tinyint = null output, @PA_WRT_QUERY_SELECT varchar(500) = null output, @PA_WRT_QUERY_MERGE varchar(500) = null output, @PA_WRT_ACT_TYPES varchar(50) = null output, @PA_WRT_PR_ARG tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Workflow_Rec_Type(
    WRT_ADD_DATE,
    WRT_ADD_BY,
    WRT_MOD_DATE,
    WRT_MOD_BY,
    WRT_RCV_DATE,
    WRT_RCV_FROM,
    WRT_LOCK,
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
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_WRT_LOCK,
    @PA_WRT_REC_TYPE,
    @PA_WRT_DESC,
    @PA_WRT_TABLE,
    @PA_WRT_TABLE_KEY,
    @PA_WRT_SQL,
    @PA_WRT_PR_TYPE,
    @PA_WRT_SEARCH_ENTITY,
    @PA_WRT_LINK_TO,
    @PA_WRT_PR_TYPE_TYPE,
    @PA_WRT_QUERY,
    @PA_WRT_QUERY_SELECT,
    @PA_WRT_QUERY_MERGE,
    @PA_WRT_ACT_TYPES,
    @PA_WRT_PR_ARG
  );
    set @PA_WRT_ID = @@identity;
end
go
