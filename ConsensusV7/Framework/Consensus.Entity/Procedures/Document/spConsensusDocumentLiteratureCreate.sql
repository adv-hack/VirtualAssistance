if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLiteratureCreate')
  exec ('create procedure dbo.spConsensusDocumentLiteratureCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLiteratureCreate(@PA_LIT_ID varchar(11) = null output, @PA_LIT_LOCK varchar(10) = null output, @PA_LIT_NAME varchar(500) = null output, @PA_LIT_COST float = null output, @PA_LIT_TEMPLATE varchar(500) = null output, @PA_LIT_EXAM tinyint = null output, @PA_LIT_ATTENDANCE tinyint = null output, @PA_LIT_TYPE tinyint = null output, @PA_LIT_CURRENT tinyint = null output, @PA_LIT_LT_ID varchar(11) = null output, @PA_LIT_SEND_OVERRIDE tinyint = null output, @PA_LIT_EMAIL_ONLY tinyint = null output, @PA_LIT_PRINT_ONLY tinyint = null output, @PA_LIT_FILE_NAME varchar(255) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 602, @PA_LIT_ID output
  
  insert into dbo.Literature(
    LIT_ID,
    LIT_ADD_DATE,
    LIT_ADD_BY,
    LIT_MOD_DATE,
    LIT_MOD_BY,
    LIT_RCV_DATE,
    LIT_RCV_FROM,
    LIT_LOCK,
    LIT_NAME,
    LIT_COST,
    LIT_TEMPLATE,
    LIT_EXAM,
    LIT_ATTENDANCE,
    LIT_TYPE,
    LIT_CURRENT,
    LIT_LT_ID,
    LIT_SEND_OVERRIDE,
    LIT_EMAIL_ONLY,
    LIT_PRINT_ONLY,
    LIT_FILE_NAME
  ) values (
    @PA_LIT_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_LIT_LOCK,
    @PA_LIT_NAME,
    @PA_LIT_COST,
    @PA_LIT_TEMPLATE,
    @PA_LIT_EXAM,
    @PA_LIT_ATTENDANCE,
    @PA_LIT_TYPE,
    @PA_LIT_CURRENT,
    @PA_LIT_LT_ID,
    @PA_LIT_SEND_OVERRIDE,
    @PA_LIT_EMAIL_ONLY,
    @PA_LIT_PRINT_ONLY,
    @PA_LIT_FILE_NAME
  );
end
go
