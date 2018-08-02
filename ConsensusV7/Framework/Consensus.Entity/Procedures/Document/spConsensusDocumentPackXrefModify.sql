if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPackXrefModify')
  exec ('create procedure dbo.spConsensusDocumentPackXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPackXrefModify(@PA_PACKXREF_ID varchar(11) = null output, @PA_PACKXREF_LOCK varchar(10) = null output, @PA_PACKXREF_PACK_ID varchar(11) = null output, @PA_PACKXREF_LIT_ID varchar(11) = null output, @PA_PACKXREF_SEQ integer = null output, @PA_PACKXREF_SMS_ID integer = null output, @PA_PACKXREF_ICM_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Pack_Xref set
    PACKXREF_MOD_DATE = getDate(),
    PACKXREF_MOD_BY = @_AUDIT_USER_ID,
    PACKXREF_LOCK = @PA_PACKXREF_LOCK,
    PACKXREF_PACK_ID = @PA_PACKXREF_PACK_ID,
    PACKXREF_LIT_ID = @PA_PACKXREF_LIT_ID,
    PACKXREF_SEQ = @PA_PACKXREF_SEQ,
    PACKXREF_SMS_ID = @PA_PACKXREF_SMS_ID,
    PACKXREF_ICM_ID = @PA_PACKXREF_ICM_ID
  where PACKXREF_ID = @PA_PACKXREF_ID;
end
go
