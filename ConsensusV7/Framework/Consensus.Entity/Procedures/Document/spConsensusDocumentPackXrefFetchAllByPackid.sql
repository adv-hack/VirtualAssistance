if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPackXrefFetchAllByPackid')
  exec ('create procedure dbo.spConsensusDocumentPackXrefFetchAllByPackid as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPackXrefFetchAllByPackid(@PA_PACKXREF_PACK_ID varchar(11) = null output) as 
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
  where PACKXREF_PACK_ID = @PA_PACKXREF_PACK_ID
end
go
