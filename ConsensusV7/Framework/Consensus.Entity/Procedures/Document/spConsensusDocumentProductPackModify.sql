if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentProductPackModify')
  exec ('create procedure dbo.spConsensusDocumentProductPackModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentProductPackModify(@PA_PPA_ID integer = null output, @PA_PPA_PROD_ID varchar(11) = null output, @PA_PPA_PACK_ID varchar(11) = null output, @PA_PPA_TYPE varchar(40) = null output, @PA_PPA_SUPPRESS tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Product_Pack set
    PPA_MOD_DATE = getDate(),
    PPA_MOD_BY = @_AUDIT_USER_ID,
    PPA_PROD_ID = @PA_PPA_PROD_ID,
    PPA_PACK_ID = @PA_PPA_PACK_ID,
    PPA_TYPE = @PA_PPA_TYPE,
    PPA_SUPPRESS = @PA_PPA_SUPPRESS
  where PPA_ID = @PA_PPA_ID;
end
go
