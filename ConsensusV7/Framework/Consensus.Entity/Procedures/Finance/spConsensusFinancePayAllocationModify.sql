if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayAllocationModify')
  exec ('create procedure dbo.spConsensusFinancePayAllocationModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayAllocationModify(@PA_PA_ID varchar(11) = null output, @PA_PA_LOCK varchar(11) = null output, @PA_PA_DATE datetime = null output, @PA_PA_INV_ID varchar(11) = null output, @PA_PA_INV_REF varchar(25) = null output, @PA_PA_PAY_ID varchar(11) = null output, @PA_PA_HIDDEN tinyint = null output, @PA_PA_CURR_TYPE varchar(3) = null output, @PA_PA_VALUE decimal(19, 4) = null output, @PA_PA_VALUE_BC decimal(19, 4) = null output, @PA_PA_CREDIT_ID varchar(11) = null output, @PA_PA_CREDIT_REF varchar(25) = null output, @PA_PA_BOOK_ID varchar(11) = null output, @PA_PA_MEP_ID varchar(11) = null output, @PA_PA_BAT_ID varchar(11) = null output, @PA_PA_VALUE_BC2 decimal(19, 4) = null output, @PA_PA_DEL_ID varchar(11) = null output, @PA_PA_DESCRIPTION varchar(500) = null output, @PA_PA_EXTERNAL tinyint = null output, @PA_PA_REFUND_ID varchar(11) = null output, @PA_PA_DEALLOCATION tinyint = null output, @PA_PA_REVERSES_PA_ID varchar(11) = null output, @PA_PA_ELEM_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Pay_Allocation set
    PA_MOD_DATE = getDate(),
    PA_MOD_BY = @_AUDIT_USER_ID,
    PA_LOCK = @PA_PA_LOCK,
    PA_DATE = @PA_PA_DATE,
    PA_INV_ID = @PA_PA_INV_ID,
    PA_INV_REF = @PA_PA_INV_REF,
    PA_PAY_ID = @PA_PA_PAY_ID,
    PA_HIDDEN = @PA_PA_HIDDEN,
    PA_CURR_TYPE = @PA_PA_CURR_TYPE,
    PA_VALUE = @PA_PA_VALUE,
    PA_VALUE_BC = @PA_PA_VALUE_BC,
    PA_CREDIT_ID = @PA_PA_CREDIT_ID,
    PA_CREDIT_REF = @PA_PA_CREDIT_REF,
    PA_BOOK_ID = @PA_PA_BOOK_ID,
    PA_MEP_ID = @PA_PA_MEP_ID,
    PA_BAT_ID = @PA_PA_BAT_ID,
    PA_VALUE_BC2 = @PA_PA_VALUE_BC2,
    PA_DEL_ID = @PA_PA_DEL_ID,
    PA_DESCRIPTION = @PA_PA_DESCRIPTION,
    PA_EXTERNAL = @PA_PA_EXTERNAL,
    PA_REFUND_ID = @PA_PA_REFUND_ID,
    PA_DEALLOCATION = @PA_PA_DEALLOCATION,
    PA_REVERSES_PA_ID = @PA_PA_REVERSES_PA_ID,
    PA_ELEM_ID = @PA_PA_ELEM_ID
  where PA_ID = @PA_PA_ID;
end
go
