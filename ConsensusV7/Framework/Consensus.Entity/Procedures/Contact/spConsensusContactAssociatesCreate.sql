if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAssociatesCreate')
  exec ('create procedure dbo.spConsensusContactAssociatesCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactAssociatesCreate(@PA_ASSO_ID integer = null output, @PA_ASSO_ASSOCIATE_ID varchar(11) = null output, @PA_ASSO_PROLE_ID varchar(11) = null output, @PA_ASSO_ORG_ID varchar(11) = null output, @PA_ASSO_TYPE tinyint = null output, @PA_ASSO_TYPE_NAME varchar(40) = null output, @PA_ASSO_TYPE_CODE varchar(100) = null output, @PA_ASSO_START_DATE datetime = null output, @PA_ASSO_END_DATE datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Associates(
    ASSO_ADD_DATE,
    ASSO_ADD_BY,
    ASSO_MOD_DATE,
    ASSO_MOD_BY,
    ASSO_RCV_DATE,
    ASSO_RCV_FROM,
    ASSO_ASSOCIATE_ID,
    ASSO_PROLE_ID,
    ASSO_ORG_ID,
    ASSO_TYPE,
    ASSO_TYPE_NAME,
    ASSO_TYPE_CODE,
    ASSO_START_DATE,
    ASSO_END_DATE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_ASSO_ASSOCIATE_ID,
    @PA_ASSO_PROLE_ID,
    @PA_ASSO_ORG_ID,
    @PA_ASSO_TYPE,
    @PA_ASSO_TYPE_NAME,
    @PA_ASSO_TYPE_CODE,
    @PA_ASSO_START_DATE,
    @PA_ASSO_END_DATE
  );
    set @PA_ASSO_ID = @@identity;
end
go
