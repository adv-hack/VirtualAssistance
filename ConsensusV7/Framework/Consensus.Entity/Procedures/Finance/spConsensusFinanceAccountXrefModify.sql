if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceAccountXrefModify')
  exec ('create procedure dbo.spConsensusFinanceAccountXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceAccountXrefModify(@PA_ACXREF_ID varchar(11) = null output, @PA_ACXREF_LOCK varchar(11) = null output, @PA_ACXREF_ACC_ID varchar(11) = null output, @PA_ACXREF_ORG_ID varchar(11) = null output, @PA_ACXREF_ADD_ID varchar(11) = null output, @PA_ACXREF_MAIN tinyint = null output, @PA_ACXREF_INVOICE tinyint = null output, @PA_ACXREF_STATEMENT tinyint = null output, @PA_ACXREF_NO_ADD_CHANGE tinyint = null output, @PA_ACXREF_PROLE_ID varchar(11) = null output, @PA_ACXREF_FOR_ATTN_OF nvarchar(410) = null output, @PA_ACXREF_CODE varchar(3) = null output, @PA_ACXREF_NOMINATED tinyint = null output, @PA_ACXREF_INCL_HIERARCHY tinyint = null output, @PA_ACXREF_FROM_HIERARCHY tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Account_Xref set
    ACXREF_MOD_DATE = getDate(),
    ACXREF_MOD_BY = @_AUDIT_USER_ID,
    ACXREF_LOCK = @PA_ACXREF_LOCK,
    ACXREF_ACC_ID = @PA_ACXREF_ACC_ID,
    ACXREF_ORG_ID = @PA_ACXREF_ORG_ID,
    ACXREF_ADD_ID = @PA_ACXREF_ADD_ID,
    ACXREF_MAIN = @PA_ACXREF_MAIN,
    ACXREF_INVOICE = @PA_ACXREF_INVOICE,
    ACXREF_STATEMENT = @PA_ACXREF_STATEMENT,
    ACXREF_NO_ADD_CHANGE = @PA_ACXREF_NO_ADD_CHANGE,
    ACXREF_PROLE_ID = @PA_ACXREF_PROLE_ID,
    ACXREF_FOR_ATTN_OF = @PA_ACXREF_FOR_ATTN_OF,
    ACXREF_CODE = @PA_ACXREF_CODE,
    ACXREF_NOMINATED = @PA_ACXREF_NOMINATED,
    ACXREF_INCL_HIERARCHY = @PA_ACXREF_INCL_HIERARCHY,
    ACXREF_FROM_HIERARCHY = @PA_ACXREF_FROM_HIERARCHY
  where ACXREF_ID = @PA_ACXREF_ID;
end
go
