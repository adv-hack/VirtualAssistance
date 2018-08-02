if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceCostCodeFetchAllBySelcospid')
  exec ('create procedure dbo.spConsensusFinanceCostCodeFetchAllBySelcospid as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceCostCodeFetchAllBySelcospid(@PA_COST_SELCO_SP_ID varchar(11) = null output) as 
begin
  select 
    COST_ID,
    COST_LOCK,
    COST_ADD_DATE,
    COST_ADD_BY,
    COST_MOD_DATE,
    COST_MOD_BY,
    COST_RCV_DATE,
    COST_RCV_FROM,
    COST_CODE,
    COST_DESC,
    COST_SELCO_SP_ID
  from dbo.Cost_Code
  where COST_SELCO_SP_ID = @PA_COST_SELCO_SP_ID
end
go
