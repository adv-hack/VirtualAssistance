if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLiteratureModify')
  exec ('create procedure dbo.spConsensusDocumentLiteratureModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLiteratureModify(@PA_LIT_ID varchar(11) = null output, @PA_LIT_LOCK varchar(10) = null output, @PA_LIT_NAME varchar(500) = null output, @PA_LIT_COST float = null output, @PA_LIT_TEMPLATE varchar(500) = null output, @PA_LIT_EXAM tinyint = null output, @PA_LIT_ATTENDANCE tinyint = null output, @PA_LIT_TYPE tinyint = null output, @PA_LIT_CURRENT tinyint = null output, @PA_LIT_LT_ID varchar(11) = null output, @PA_LIT_SEND_OVERRIDE tinyint = null output, @PA_LIT_EMAIL_ONLY tinyint = null output, @PA_LIT_PRINT_ONLY tinyint = null output, @PA_LIT_FILE_NAME varchar(255) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Literature set
    LIT_MOD_DATE = getDate(),
    LIT_MOD_BY = @_AUDIT_USER_ID,
    LIT_LOCK = @PA_LIT_LOCK,
    LIT_NAME = @PA_LIT_NAME,
    LIT_COST = @PA_LIT_COST,
    LIT_TEMPLATE = @PA_LIT_TEMPLATE,
    LIT_EXAM = @PA_LIT_EXAM,
    LIT_ATTENDANCE = @PA_LIT_ATTENDANCE,
    LIT_TYPE = @PA_LIT_TYPE,
    LIT_CURRENT = @PA_LIT_CURRENT,
    LIT_LT_ID = @PA_LIT_LT_ID,
    LIT_SEND_OVERRIDE = @PA_LIT_SEND_OVERRIDE,
    LIT_EMAIL_ONLY = @PA_LIT_EMAIL_ONLY,
    LIT_PRINT_ONLY = @PA_LIT_PRINT_ONLY,
    LIT_FILE_NAME = @PA_LIT_FILE_NAME
  where LIT_ID = @PA_LIT_ID;
end
go
