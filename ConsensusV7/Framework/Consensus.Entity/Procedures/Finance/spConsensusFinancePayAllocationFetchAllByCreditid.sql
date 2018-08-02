if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayAllocationFetchAllByCreditid')
  exec ('create procedure dbo.spConsensusFinancePayAllocationFetchAllByCreditid as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayAllocationFetchAllByCreditid(@PA_PA_CREDIT_ID varchar(11) = null output) as 
begin
  select 
    PA_ID,
    PA_LOCK,
    PA_ADD_DATE,
    PA_ADD_BY,
    PA_MOD_DATE,
    PA_MOD_BY,
    PA_RCV_DATE,
    PA_RCV_FROM,
    PA_DATE,
    PA_INV_ID,
    PA_INV_REF,
    PA_PAY_ID,
    PA_HIDDEN,
    PA_CURR_TYPE,
    PA_VALUE,
    PA_VALUE_BC,
    PA_CREDIT_ID,
    PA_CREDIT_REF,
    PA_BOOK_ID,
    PA_MEP_ID,
    PA_BAT_ID,
    PA_VALUE_BC2,
    PA_DEL_ID,
    PA_DESCRIPTION,
    PA_EXTERNAL,
    PA_REFUND_ID,
    PA_DEALLOCATION,
    PA_REVERSES_PA_ID,
    PA_ELEM_ID
  from dbo.Pay_Allocation
  where PA_CREDIT_ID = @PA_PA_CREDIT_ID
end
go
