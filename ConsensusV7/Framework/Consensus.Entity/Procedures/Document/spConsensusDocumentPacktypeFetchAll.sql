if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPacktypeFetchAll')
  exec ('create procedure dbo.spConsensusDocumentPacktypeFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPacktypeFetchAll as 
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
end
go
