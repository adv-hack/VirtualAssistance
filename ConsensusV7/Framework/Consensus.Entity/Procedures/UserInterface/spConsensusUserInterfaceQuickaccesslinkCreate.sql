if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceQuickaccesslinkCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceQuickaccesslinkCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceQuickaccesslinkCreate(@PA_QAL_ID integer = null output, @PA_QAL_USER_ID integer = null output, @PA_QAL_DESCRIPTION nvarchar(max) = null output, @PA_QAL_URL nvarchar(max) = null output, @PA_QAL_ICON nvarchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.QuickAccessLink(
    QAL_ADD_DATE,
    QAL_ADD_BY,
    QAL_MOD_DATE,
    QAL_MOD_BY,
    QAL_USER_ID,
    QAL_DESCRIPTION,
    QAL_URL,
    QAL_ICON
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_QAL_USER_ID,
    @PA_QAL_DESCRIPTION,
    @PA_QAL_URL,
    @PA_QAL_ICON
  );
    set @PA_QAL_ID = @@identity;
end
go
