if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceCostCodeCreate')
  exec ('create procedure dbo.spConsensusFinanceCostCodeCreate as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceCostCodeCreate(@PA_COST_ID varchar(11) = null output, @PA_COST_LOCK varchar(11) = null output, @PA_COST_CODE varchar(40) = null output, @PA_COST_DESC varchar(255) = null output, @PA_COST_SELCO_SP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 611, @PA_COST_ID output
  
  insert into dbo.Cost_Code(
    COST_ID,
    COST_ADD_DATE,
    COST_ADD_BY,
    COST_MOD_DATE,
    COST_MOD_BY,
    COST_RCV_DATE,
    COST_RCV_FROM,
    COST_LOCK,
    COST_CODE,
    COST_DESC,
    COST_SELCO_SP_ID
  ) values (
    @PA_COST_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_COST_LOCK,
    @PA_COST_CODE,
    @PA_COST_DESC,
    @PA_COST_SELCO_SP_ID
  );
end
go
