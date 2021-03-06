if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLettmplttypeCreate')
  exec ('create procedure dbo.spConsensusDocumentLettmplttypeCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLettmplttypeCreate(@PA_LTT_ID varchar(11) = null output, @PA_LTT_LOCK varchar(11) = null output, @PA_LTT_NAME varchar(40) = null output, @PA_LTT_DESC varchar(240) = null output, @PA_LTT_LEVELS integer = null output, @PA_LTT_TYPE tinyint = null output, @PA_LTT_PROC_NAME varchar(255) = null output, @PA_LTT_EQUIVALENT varchar(40) = null output, @PA_LTT_DEFAULT_PR_TYPE varchar(20) = null output, @PA_LTT_URL varchar(250) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.LetTmpltType(
    LTT_ADD_DATE,
    LTT_ADD_BY,
    LTT_MOD_DATE,
    LTT_MOD_BY,
    LTT_RCV_DATE,
    LTT_RCV_FROM,
    LTT_LOCK,
    LTT_NAME,
    LTT_DESC,
    LTT_LEVELS,
    LTT_TYPE,
    LTT_PROC_NAME,
    LTT_EQUIVALENT,
    LTT_DEFAULT_PR_TYPE,
    LTT_URL
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_LTT_LOCK,
    @PA_LTT_NAME,
    @PA_LTT_DESC,
    @PA_LTT_LEVELS,
    @PA_LTT_TYPE,
    @PA_LTT_PROC_NAME,
    @PA_LTT_EQUIVALENT,
    @PA_LTT_DEFAULT_PR_TYPE,
    @PA_LTT_URL
  );
    set @PA_LTT_ID = @@identity;
end
go
