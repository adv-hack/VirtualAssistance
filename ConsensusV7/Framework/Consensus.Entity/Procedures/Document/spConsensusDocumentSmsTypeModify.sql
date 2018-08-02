if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentSmsTypeModify')
  exec ('create procedure dbo.spConsensusDocumentSmsTypeModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentSmsTypeModify(@PA_SMT_ID integer = null output, @PA_SMT_NAME varchar(40) = null output, @PA_SMT_VIEW varchar(200) = null output, @PA_SMT_STORED_PROC varchar(200) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.SMS_Type set
    SMT_MOD_DATE = getDate(),
    SMT_MOD_BY = @_AUDIT_USER_ID,
    SMT_NAME = @PA_SMT_NAME,
    SMT_VIEW = @PA_SMT_VIEW,
    SMT_STORED_PROC = @PA_SMT_STORED_PROC
  where SMT_ID = @PA_SMT_ID;
end
go
