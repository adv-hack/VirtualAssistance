if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAddressXrefModify')
  exec ('create procedure dbo.spConsensusContactAddressXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactAddressXrefModify(@PA_ADDXREF_ID varchar(11) = null output, @PA_ADDXREF_ADD_ID varchar(11) = null output, @PA_ADDXREF_START datetime = null output, @PA_ADDXREF_END datetime = null output, @PA_ADDXREF_TYPE varchar(40) = null output, @PA_ADDXREF_ORG_ID varchar(11) = null output, @PA_ADDXREF_PRINCIPAL tinyint = null output, @PA_ADDXREF_SALES_REP varchar(35) = null output, @PA_ADDXREF_ADD_POSTCODE varchar(12) = null output, @PA_ADDXREF_ORG_NAME nvarchar(240) = null output, @PA_ADDXREF_ORG_DUNS varchar(12) = null output, @PA_ADDXREF_PROLE_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Address_Xref set
    ADDXREF_MOD_DATE = getDate(),
    ADDXREF_MOD_BY = @_AUDIT_USER_ID,
    ADDXREF_ADD_ID = @PA_ADDXREF_ADD_ID,
    ADDXREF_START = @PA_ADDXREF_START,
    ADDXREF_END = @PA_ADDXREF_END,
    ADDXREF_TYPE = @PA_ADDXREF_TYPE,
    ADDXREF_ORG_ID = @PA_ADDXREF_ORG_ID,
    ADDXREF_PRINCIPAL = @PA_ADDXREF_PRINCIPAL,
    ADDXREF_SALES_REP = @PA_ADDXREF_SALES_REP,
    ADDXREF_ADD_POSTCODE = @PA_ADDXREF_ADD_POSTCODE,
    ADDXREF_ORG_NAME = @PA_ADDXREF_ORG_NAME,
    ADDXREF_ORG_DUNS = @PA_ADDXREF_ORG_DUNS,
    ADDXREF_PROLE_ID = @PA_ADDXREF_PROLE_ID
  where ADDXREF_ID = @PA_ADDXREF_ID;
end
go
