if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentProductPackCreate')
  exec ('create procedure dbo.spConsensusDocumentProductPackCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentProductPackCreate(@PA_PPA_ID integer = null output, @PA_PPA_PROD_ID varchar(11) = null output, @PA_PPA_PACK_ID varchar(11) = null output, @PA_PPA_TYPE varchar(40) = null output, @PA_PPA_SUPPRESS tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Product_Pack(
    PPA_ADD_DATE,
    PPA_ADD_BY,
    PPA_MOD_DATE,
    PPA_MOD_BY,
    PPA_PROD_ID,
    PPA_PACK_ID,
    PPA_TYPE,
    PPA_SUPPRESS
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_PPA_PROD_ID,
    @PA_PPA_PACK_ID,
    @PA_PPA_TYPE,
    @PA_PPA_SUPPRESS
  );
    set @PA_PPA_ID = @@identity;
end
go
