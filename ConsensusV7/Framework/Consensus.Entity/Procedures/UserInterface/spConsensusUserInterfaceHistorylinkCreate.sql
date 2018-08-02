if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceHistorylinkCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceHistorylinkCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceHistorylinkCreate(@PA_HL_ID integer = null output, @PA_HL_USER_ID integer = null output, @PA_HL_DESCRIPTION nvarchar(max) = null output, @PA_HL_URL nvarchar(max) = null output, @PA_HL_ICON nvarchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.HistoryLink(
    HL_ADD_DATE,
    HL_ADD_BY,
    HL_MOD_DATE,
    HL_MOD_BY,
    HL_USER_ID,
    HL_DESCRIPTION,
    HL_URL,
    HL_ICON
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_HL_USER_ID,
    @PA_HL_DESCRIPTION,
    @PA_HL_URL,
    @PA_HL_ICON
  );
    set @PA_HL_ID = @@identity;
end
go
