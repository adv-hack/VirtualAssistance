if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsModify')
  exec ('create procedure dbo.spConsensusContactCommunicationsModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsModify(@PA_COMM_ID bigint = null output, @PA_COMM_DEVICE_CODE varchar(40) = null output, @PA_COMM_DIALLING_CODE varchar(50) = null output, @PA_COMM_STD_CODE varchar(50) = null output, @PA_COMM_EXTENSION varchar(50) = null output, @PA_COMM_EX_DIRECTORY integer = null output, @PA_COMM_NOTES varchar(255) = null output, @PA_COMM_VALID_FROM datetime = null output, @PA_COMM_ACTIVE integer = null output, @PA_COMM_DEFAULT integer = null output, @PA_COMM_PREFERRED integer = null output, @PA_COMM_DEVICE_VALUE varchar(255) = null output, @PA_COMM_DEVICE_FULL_VALUE varchar(255) = null output, @PA_COMM_ADD_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Communications set
    COMM_MOD_DATE = getDate(),
    COMM_MOD_BY = @_AUDIT_USER_ID,
    COMM_DEVICE_CODE = @PA_COMM_DEVICE_CODE,
    COMM_DIALLING_CODE = @PA_COMM_DIALLING_CODE,
    COMM_STD_CODE = @PA_COMM_STD_CODE,
    COMM_EXTENSION = @PA_COMM_EXTENSION,
    COMM_EX_DIRECTORY = @PA_COMM_EX_DIRECTORY,
    COMM_NOTES = @PA_COMM_NOTES,
    COMM_VALID_FROM = @PA_COMM_VALID_FROM,
    COMM_ACTIVE = @PA_COMM_ACTIVE,
    COMM_DEFAULT = @PA_COMM_DEFAULT,
    COMM_PREFERRED = @PA_COMM_PREFERRED,
    COMM_DEVICE_VALUE = @PA_COMM_DEVICE_VALUE,
    COMM_DEVICE_FULL_VALUE = @PA_COMM_DEVICE_FULL_VALUE,
    COMM_ADD_ID = @PA_COMM_ADD_ID
  where COMM_ID = @PA_COMM_ID;
end
go
