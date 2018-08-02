if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayAllocationCreate')
  exec ('create procedure dbo.spConsensusFinancePayAllocationCreate as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayAllocationCreate(@PA_PA_ID varchar(11) = null output, @PA_PA_LOCK varchar(11) = null output, @PA_PA_DATE datetime = null output, @PA_PA_INV_ID varchar(11) = null output, @PA_PA_INV_REF varchar(25) = null output, @PA_PA_PAY_ID varchar(11) = null output, @PA_PA_HIDDEN tinyint = null output, @PA_PA_CURR_TYPE varchar(3) = null output, @PA_PA_VALUE decimal(19, 4) = null output, @PA_PA_VALUE_BC decimal(19, 4) = null output, @PA_PA_CREDIT_ID varchar(11) = null output, @PA_PA_CREDIT_REF varchar(25) = null output, @PA_PA_BOOK_ID varchar(11) = null output, @PA_PA_MEP_ID varchar(11) = null output, @PA_PA_BAT_ID varchar(11) = null output, @PA_PA_VALUE_BC2 decimal(19, 4) = null output, @PA_PA_DEL_ID varchar(11) = null output, @PA_PA_DESCRIPTION varchar(500) = null output, @PA_PA_EXTERNAL tinyint = null output, @PA_PA_REFUND_ID varchar(11) = null output, @PA_PA_DEALLOCATION tinyint = null output, @PA_PA_REVERSES_PA_ID varchar(11) = null output, @PA_PA_ELEM_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 555, @PA_PA_ID output
  
  insert into dbo.Pay_Allocation(
    PA_ID,
    PA_ADD_DATE,
    PA_ADD_BY,
    PA_MOD_DATE,
    PA_MOD_BY,
    PA_RCV_DATE,
    PA_RCV_FROM,
    PA_LOCK,
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
  ) values (
    @PA_PA_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PA_LOCK,
    @PA_PA_DATE,
    @PA_PA_INV_ID,
    @PA_PA_INV_REF,
    @PA_PA_PAY_ID,
    @PA_PA_HIDDEN,
    @PA_PA_CURR_TYPE,
    @PA_PA_VALUE,
    @PA_PA_VALUE_BC,
    @PA_PA_CREDIT_ID,
    @PA_PA_CREDIT_REF,
    @PA_PA_BOOK_ID,
    @PA_PA_MEP_ID,
    @PA_PA_BAT_ID,
    @PA_PA_VALUE_BC2,
    @PA_PA_DEL_ID,
    @PA_PA_DESCRIPTION,
    @PA_PA_EXTERNAL,
    @PA_PA_REFUND_ID,
    @PA_PA_DEALLOCATION,
    @PA_PA_REVERSES_PA_ID,
    @PA_PA_ELEM_ID
  );
end
go
