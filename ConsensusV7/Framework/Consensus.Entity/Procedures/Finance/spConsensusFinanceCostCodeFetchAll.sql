if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceCostCodeFetchAll')
  exec ('create procedure dbo.spConsensusFinanceCostCodeFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceCostCodeFetchAll as 
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
end
go
