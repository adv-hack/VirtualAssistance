if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceAccountXrefCreate')
  exec ('create procedure dbo.spConsensusFinanceAccountXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceAccountXrefCreate(@PA_ACXREF_ID varchar(11) = null output, @PA_ACXREF_LOCK varchar(11) = null output, @PA_ACXREF_ACC_ID varchar(11) = null output, @PA_ACXREF_ORG_ID varchar(11) = null output, @PA_ACXREF_ADD_ID varchar(11) = null output, @PA_ACXREF_MAIN tinyint = null output, @PA_ACXREF_INVOICE tinyint = null output, @PA_ACXREF_STATEMENT tinyint = null output, @PA_ACXREF_NO_ADD_CHANGE tinyint = null output, @PA_ACXREF_PROLE_ID varchar(11) = null output, @PA_ACXREF_FOR_ATTN_OF nvarchar(410) = null output, @PA_ACXREF_CODE varchar(3) = null output, @PA_ACXREF_NOMINATED tinyint = null output, @PA_ACXREF_INCL_HIERARCHY tinyint = null output, @PA_ACXREF_FROM_HIERARCHY tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 610, @PA_ACXREF_ID output
  
  insert into dbo.Account_Xref(
    ACXREF_ID,
    ACXREF_ADD_DATE,
    ACXREF_ADD_BY,
    ACXREF_MOD_DATE,
    ACXREF_MOD_BY,
    ACXREF_RCV_DATE,
    ACXREF_RCV_FROM,
    ACXREF_LOCK,
    ACXREF_ACC_ID,
    ACXREF_ORG_ID,
    ACXREF_ADD_ID,
    ACXREF_MAIN,
    ACXREF_INVOICE,
    ACXREF_STATEMENT,
    ACXREF_NO_ADD_CHANGE,
    ACXREF_PROLE_ID,
    ACXREF_FOR_ATTN_OF,
    ACXREF_CODE,
    ACXREF_NOMINATED,
    ACXREF_INCL_HIERARCHY,
    ACXREF_FROM_HIERARCHY
  ) values (
    @PA_ACXREF_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_ACXREF_LOCK,
    @PA_ACXREF_ACC_ID,
    @PA_ACXREF_ORG_ID,
    @PA_ACXREF_ADD_ID,
    @PA_ACXREF_MAIN,
    @PA_ACXREF_INVOICE,
    @PA_ACXREF_STATEMENT,
    @PA_ACXREF_NO_ADD_CHANGE,
    @PA_ACXREF_PROLE_ID,
    @PA_ACXREF_FOR_ATTN_OF,
    @PA_ACXREF_CODE,
    @PA_ACXREF_NOMINATED,
    @PA_ACXREF_INCL_HIERARCHY,
    @PA_ACXREF_FROM_HIERARCHY
  );
end
go
