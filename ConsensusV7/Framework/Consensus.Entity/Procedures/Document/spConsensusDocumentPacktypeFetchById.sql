if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPacktypeFetchById')
  exec ('create procedure dbo.spConsensusDocumentPacktypeFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPacktypeFetchById(@PA_PACKTYP_ID integer = null output) as 
begin
  select 
    PACKTYP_ID,
    PACKTYP_ADD_DATE,
    PACKTYP_ADD_BY,
    PACKTYP_MOD_DATE,
    PACKTYP_MOD_BY,
    PACKTYP_TYPE,
    PACKTYP_DESC,
    PACKTYP_STORED_PROC,
    PACKTYP_URL
  from dbo.PackType
  where PACKTYP_ID = @PA_PACKTYP_ID
end
go
