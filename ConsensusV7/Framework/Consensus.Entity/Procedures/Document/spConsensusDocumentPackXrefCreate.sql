if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPackXrefCreate')
  exec ('create procedure dbo.spConsensusDocumentPackXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPackXrefCreate(@PA_PACKXREF_ID varchar(11) = null output, @PA_PACKXREF_LOCK varchar(10) = null output, @PA_PACKXREF_PACK_ID varchar(11) = null output, @PA_PACKXREF_LIT_ID varchar(11) = null output, @PA_PACKXREF_SEQ integer = null output, @PA_PACKXREF_SMS_ID integer = null output, @PA_PACKXREF_ICM_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 601, @PA_PACKXREF_ID output
  
  insert into dbo.Pack_Xref(
    PACKXREF_ID,
    PACKXREF_ADD_DATE,
    PACKXREF_ADD_BY,
    PACKXREF_MOD_DATE,
    PACKXREF_MOD_BY,
    PACKXREF_RCV_DATE,
    PACKXREF_RCV_FROM,
    PACKXREF_LOCK,
    PACKXREF_PACK_ID,
    PACKXREF_LIT_ID,
    PACKXREF_SEQ,
    PACKXREF_SMS_ID,
    PACKXREF_ICM_ID
  ) values (
    @PA_PACKXREF_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PACKXREF_LOCK,
    @PA_PACKXREF_PACK_ID,
    @PA_PACKXREF_LIT_ID,
    @PA_PACKXREF_SEQ,
    @PA_PACKXREF_SMS_ID,
    @PA_PACKXREF_ICM_ID
  );
end
go
