if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceCostCodeModify')
  exec ('create procedure dbo.spConsensusFinanceCostCodeModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceCostCodeModify(@PA_COST_ID varchar(11) = null output, @PA_COST_LOCK varchar(11) = null output, @PA_COST_CODE varchar(40) = null output, @PA_COST_DESC varchar(255) = null output, @PA_COST_SELCO_SP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Cost_Code set
    COST_MOD_DATE = getDate(),
    COST_MOD_BY = @_AUDIT_USER_ID,
    COST_LOCK = @PA_COST_LOCK,
    COST_CODE = @PA_COST_CODE,
    COST_DESC = @PA_COST_DESC,
    COST_SELCO_SP_ID = @PA_COST_SELCO_SP_ID
  where COST_ID = @PA_COST_ID;
end
go
