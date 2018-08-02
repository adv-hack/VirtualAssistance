if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPackXrefFetchAllBySmsid')
  exec ('create procedure dbo.spConsensusDocumentPackXrefFetchAllBySmsid as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPackXrefFetchAllBySmsid(@PA_PACKXREF_SMS_ID integer = null output) as 
begin
  select 
    PACKXREF_ID,
    PACKXREF_LOCK,
    PACKXREF_ADD_DATE,
    PACKXREF_ADD_BY,
    PACKXREF_MOD_DATE,
    PACKXREF_MOD_BY,
    PACKXREF_RCV_DATE,
    PACKXREF_RCV_FROM,
    PACKXREF_PACK_ID,
    PACKXREF_LIT_ID,
    PACKXREF_SEQ,
    PACKXREF_SMS_ID,
    PACKXREF_ICM_ID
  from dbo.Pack_Xref
  where PACKXREF_SMS_ID = @PA_PACKXREF_SMS_ID
end
go
