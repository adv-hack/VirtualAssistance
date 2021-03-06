if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonCodeModify')
  exec ('create procedure dbo.spConsensusCommonCodeModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonCodeModify(@PA_CODE_ID varchar(11) = null output, @PA_CODE_LOCK varchar(10) = null output, @PA_CODE_TYPE varchar(5) = null output, @PA_CODE_VALUE1 varchar(50) = null output, @PA_CODE_VALUE2 varchar(40) = null output, @PA_CODE_VALUE3 varchar(40) = null output, @PA_CODE_DESCRIPTION varchar(max) = null output, @PA_CODE_NOTES varchar(max) = null output, @PA_CODE_VALUE4 varchar(40) = null output, @PA_CODE_SYSTEM tinyint = null output, @PA_CODE_DELETED tinyint = null output, @PA_CODE_INSTRUCT varchar(255) = null output, @PA_CODE_READ_ONLY tinyint = null output, @PA_CODE_ORIG_VALUE varchar(40) = null output, @PA_CODE_VALUE5 varchar(40) = null output, @PA_CODE_ORDER integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Code set
    CODE_MOD_DATE = getDate(),
    CODE_MOD_BY = @_AUDIT_USER_ID,
    CODE_LOCK = @PA_CODE_LOCK,
    CODE_TYPE = @PA_CODE_TYPE,
    CODE_VALUE1 = @PA_CODE_VALUE1,
    CODE_VALUE2 = @PA_CODE_VALUE2,
    CODE_VALUE3 = @PA_CODE_VALUE3,
    CODE_DESCRIPTION = @PA_CODE_DESCRIPTION,
    CODE_NOTES = @PA_CODE_NOTES,
    CODE_VALUE4 = @PA_CODE_VALUE4,
    CODE_SYSTEM = @PA_CODE_SYSTEM,
    CODE_DELETED = @PA_CODE_DELETED,
    CODE_INSTRUCT = @PA_CODE_INSTRUCT,
    CODE_READ_ONLY = @PA_CODE_READ_ONLY,
    CODE_ORIG_VALUE = @PA_CODE_ORIG_VALUE,
    CODE_VALUE5 = @PA_CODE_VALUE5,
    CODE_ORDER = @PA_CODE_ORDER
  where CODE_ID = @PA_CODE_ID;
end
go
