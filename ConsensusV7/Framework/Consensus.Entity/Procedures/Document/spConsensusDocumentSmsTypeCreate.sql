if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentSmsTypeCreate')
  exec ('create procedure dbo.spConsensusDocumentSmsTypeCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentSmsTypeCreate(@PA_SMT_ID integer = null output, @PA_SMT_NAME varchar(40) = null output, @PA_SMT_VIEW varchar(200) = null output, @PA_SMT_STORED_PROC varchar(200) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.SMS_Type(
    SMT_ADD_DATE,
    SMT_ADD_BY,
    SMT_MOD_DATE,
    SMT_MOD_BY,
    SMT_NAME,
    SMT_VIEW,
    SMT_STORED_PROC
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_SMT_NAME,
    @PA_SMT_VIEW,
    @PA_SMT_STORED_PROC
  );
    set @PA_SMT_ID = @@identity;
end
go
