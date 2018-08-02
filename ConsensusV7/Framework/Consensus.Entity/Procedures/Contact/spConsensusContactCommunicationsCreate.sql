if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsCreate')
  exec ('create procedure dbo.spConsensusContactCommunicationsCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsCreate(@PA_COMM_ID bigint = null output, @PA_COMM_DEVICE_CODE varchar(40) = null output, @PA_COMM_DIALLING_CODE varchar(50) = null output, @PA_COMM_STD_CODE varchar(50) = null output, @PA_COMM_EXTENSION varchar(50) = null output, @PA_COMM_EX_DIRECTORY integer = null output, @PA_COMM_NOTES varchar(255) = null output, @PA_COMM_VALID_FROM datetime = null output, @PA_COMM_ACTIVE integer = null output, @PA_COMM_DEFAULT integer = null output, @PA_COMM_PREFERRED integer = null output, @PA_COMM_DEVICE_VALUE varchar(255) = null output, @PA_COMM_DEVICE_FULL_VALUE varchar(255) = null output, @PA_COMM_ADD_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Communications(
    COMM_ADD_DATE,
    COMM_ADD_BY,
    COMM_MOD_DATE,
    COMM_MOD_BY,
    COMM_DEVICE_CODE,
    COMM_DIALLING_CODE,
    COMM_STD_CODE,
    COMM_EXTENSION,
    COMM_EX_DIRECTORY,
    COMM_NOTES,
    COMM_VALID_FROM,
    COMM_ACTIVE,
    COMM_DEFAULT,
    COMM_PREFERRED,
    COMM_DEVICE_VALUE,
    COMM_DEVICE_FULL_VALUE,
    COMM_ADD_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_COMM_DEVICE_CODE,
    @PA_COMM_DIALLING_CODE,
    @PA_COMM_STD_CODE,
    @PA_COMM_EXTENSION,
    @PA_COMM_EX_DIRECTORY,
    @PA_COMM_NOTES,
    @PA_COMM_VALID_FROM,
    @PA_COMM_ACTIVE,
    @PA_COMM_DEFAULT,
    @PA_COMM_PREFERRED,
    @PA_COMM_DEVICE_VALUE,
    @PA_COMM_DEVICE_FULL_VALUE,
    @PA_COMM_ADD_ID
  );
    set @PA_COMM_ID = @@identity;
end
go
