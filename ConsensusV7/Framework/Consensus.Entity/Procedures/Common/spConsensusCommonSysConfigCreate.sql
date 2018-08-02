if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonSysConfigCreate')
  exec ('create procedure dbo.spConsensusCommonSysConfigCreate as select 1 as temp')
go
alter procedure dbo.spConsensusCommonSysConfigCreate(@PA_SC_ID integer = null output, @PA_SC_SP_ID varchar(11) = null output, @PA_SC_KEY_NAME varchar(50) = null output, @PA_SC_VALUE_TO_USE tinyint = null output, @PA_SC_LABEL_NAME varchar(100) = null output, @PA_SC_CHAR_VALUE varchar(2048) = null output, @PA_SC_RECORD_ID varchar(11) = null output, @PA_SC_INT_VALUE integer = null output, @PA_SC_DATETIME_VALUE datetime = null output, @PA_SC_DECIMAL_VALUE decimal(19, 2) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.SYS_CONFIG(
    SC_ADD_DATE,
    SC_ADD_BY,
    SC_MOD_DATE,
    SC_MOD_BY,
    SC_RCV_DATE,
    SC_RCV_FROM,
    SC_SP_ID,
    SC_KEY_NAME,
    SC_VALUE_TO_USE,
    SC_LABEL_NAME,
    SC_CHAR_VALUE,
    SC_RECORD_ID,
    SC_INT_VALUE,
    SC_DATETIME_VALUE,
    SC_DECIMAL_VALUE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_SC_SP_ID,
    @PA_SC_KEY_NAME,
    @PA_SC_VALUE_TO_USE,
    @PA_SC_LABEL_NAME,
    @PA_SC_CHAR_VALUE,
    @PA_SC_RECORD_ID,
    @PA_SC_INT_VALUE,
    @PA_SC_DATETIME_VALUE,
    @PA_SC_DECIMAL_VALUE
  );
    set @PA_SC_ID = @@identity;
end
go
