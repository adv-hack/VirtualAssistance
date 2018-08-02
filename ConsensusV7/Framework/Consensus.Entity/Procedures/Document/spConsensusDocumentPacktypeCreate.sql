if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPacktypeCreate')
  exec ('create procedure dbo.spConsensusDocumentPacktypeCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPacktypeCreate(@PA_PACKTYP_ID integer = null output, @PA_PACKTYP_TYPE tinyint = null output, @PA_PACKTYP_DESC varchar(500) = null output, @PA_PACKTYP_STORED_PROC varchar(500) = null output, @PA_PACKTYP_URL varchar(250) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.PackType(
    PACKTYP_ADD_DATE,
    PACKTYP_ADD_BY,
    PACKTYP_MOD_DATE,
    PACKTYP_MOD_BY,
    PACKTYP_TYPE,
    PACKTYP_DESC,
    PACKTYP_STORED_PROC,
    PACKTYP_URL
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_PACKTYP_TYPE,
    @PA_PACKTYP_DESC,
    @PA_PACKTYP_STORED_PROC,
    @PA_PACKTYP_URL
  );
    set @PA_PACKTYP_ID = @@identity;
end
go
