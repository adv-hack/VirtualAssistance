if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPacktypeModify')
  exec ('create procedure dbo.spConsensusDocumentPacktypeModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPacktypeModify(@PA_PACKTYP_ID integer = null output, @PA_PACKTYP_TYPE tinyint = null output, @PA_PACKTYP_DESC varchar(500) = null output, @PA_PACKTYP_STORED_PROC varchar(500) = null output, @PA_PACKTYP_URL varchar(250) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.PackType set
    PACKTYP_MOD_DATE = getDate(),
    PACKTYP_MOD_BY = @_AUDIT_USER_ID,
    PACKTYP_TYPE = @PA_PACKTYP_TYPE,
    PACKTYP_DESC = @PA_PACKTYP_DESC,
    PACKTYP_STORED_PROC = @PA_PACKTYP_STORED_PROC,
    PACKTYP_URL = @PA_PACKTYP_URL
  where PACKTYP_ID = @PA_PACKTYP_ID;
end
go
