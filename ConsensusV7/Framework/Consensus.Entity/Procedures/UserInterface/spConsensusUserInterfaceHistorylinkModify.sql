if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceHistorylinkModify')
  exec ('create procedure dbo.spConsensusUserInterfaceHistorylinkModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceHistorylinkModify(@PA_HL_ID integer = null output, @PA_HL_USER_ID integer = null output, @PA_HL_DESCRIPTION nvarchar(max) = null output, @PA_HL_URL nvarchar(max) = null output, @PA_HL_ICON nvarchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.HistoryLink set
    HL_MOD_DATE = getDate(),
    HL_MOD_BY = @_AUDIT_USER_ID,
    HL_USER_ID = @PA_HL_USER_ID,
    HL_DESCRIPTION = @PA_HL_DESCRIPTION,
    HL_URL = @PA_HL_URL,
    HL_ICON = @PA_HL_ICON
  where HL_ID = @PA_HL_ID;
end
go
