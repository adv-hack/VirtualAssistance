if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAddressXrefCreate')
  exec ('create procedure dbo.spConsensusContactAddressXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactAddressXrefCreate(@PA_ADDXREF_ID varchar(11) = null output, @PA_ADDXREF_ADD_ID varchar(11) = null output, @PA_ADDXREF_START datetime = null output, @PA_ADDXREF_END datetime = null output, @PA_ADDXREF_TYPE varchar(40) = null output, @PA_ADDXREF_ORG_ID varchar(11) = null output, @PA_ADDXREF_PRINCIPAL tinyint = null output, @PA_ADDXREF_SALES_REP varchar(35) = null output, @PA_ADDXREF_ADD_POSTCODE varchar(12) = null output, @PA_ADDXREF_ORG_NAME nvarchar(240) = null output, @PA_ADDXREF_ORG_DUNS varchar(12) = null output, @PA_ADDXREF_PROLE_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 31, @PA_ADDXREF_ID output
  
  insert into dbo.Address_Xref(
    ADDXREF_ID,
    ADDXREF_ADD_DATE,
    ADDXREF_ADD_BY,
    ADDXREF_MOD_DATE,
    ADDXREF_MOD_BY,
    ADDXREF_RCV_DATE,
    ADDXREF_RCV_FROM,
    ADDXREF_ADD_ID,
    ADDXREF_START,
    ADDXREF_END,
    ADDXREF_TYPE,
    ADDXREF_ORG_ID,
    ADDXREF_PRINCIPAL,
    ADDXREF_SALES_REP,
    ADDXREF_ADD_POSTCODE,
    ADDXREF_ORG_NAME,
    ADDXREF_ORG_DUNS,
    ADDXREF_PROLE_ID
  ) values (
    @PA_ADDXREF_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_ADDXREF_ADD_ID,
    @PA_ADDXREF_START,
    @PA_ADDXREF_END,
    @PA_ADDXREF_TYPE,
    @PA_ADDXREF_ORG_ID,
    @PA_ADDXREF_PRINCIPAL,
    @PA_ADDXREF_SALES_REP,
    @PA_ADDXREF_ADD_POSTCODE,
    @PA_ADDXREF_ORG_NAME,
    @PA_ADDXREF_ORG_DUNS,
    @PA_ADDXREF_PROLE_ID
  );
end
go
