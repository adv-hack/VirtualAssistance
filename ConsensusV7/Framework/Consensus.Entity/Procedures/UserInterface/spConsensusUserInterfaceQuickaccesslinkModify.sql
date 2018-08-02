if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceQuickaccesslinkModify')
  exec ('create procedure dbo.spConsensusUserInterfaceQuickaccesslinkModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceQuickaccesslinkModify(@PA_QAL_ID integer = null output, @PA_QAL_USER_ID integer = null output, @PA_QAL_DESCRIPTION nvarchar(max) = null output, @PA_QAL_URL nvarchar(max) = null output, @PA_QAL_ICON nvarchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.QuickAccessLink set
    QAL_MOD_DATE = getDate(),
    QAL_MOD_BY = @_AUDIT_USER_ID,
    QAL_USER_ID = @PA_QAL_USER_ID,
    QAL_DESCRIPTION = @PA_QAL_DESCRIPTION,
    QAL_URL = @PA_QAL_URL,
    QAL_ICON = @PA_QAL_ICON
  where QAL_ID = @PA_QAL_ID;
end
go
