if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesC4textCreate')
  exec ('create procedure dbo.spConsensusActivitiesC4textCreate as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesC4textCreate(@PA_TEXT_ID varchar(11) = null output, @PA_TEXT_TYPE varchar(4) = null output, @PA_TEXT_OWNER_ID varchar(11) = null output, @PA_TEXT_BODY varchar(max) = null output, @PA_TEXT_RTF varchar(255) = null output, @PA_TEXT_HTML varchar(max) = null output, @PA_TEXT_OWNER_URL varchar(250) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 8, @PA_TEXT_ID output
  
  insert into dbo.C4Text(
    TEXT_ID,
    TEXT_ADD_DATE,
    TEXT_ADD_BY,
    TEXT_MOD_DATE,
    TEXT_MOD_BY,
    TEXT_RCV_DATE,
    TEXT_RCV_FROM,
    TEXT_TYPE,
    TEXT_OWNER_ID,
    TEXT_BODY,
    TEXT_RTF,
    TEXT_HTML,
    TEXT_OWNER_URL
  ) values (
    @PA_TEXT_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_TEXT_TYPE,
    @PA_TEXT_OWNER_ID,
    @PA_TEXT_BODY,
    @PA_TEXT_RTF,
    @PA_TEXT_HTML,
    @PA_TEXT_OWNER_URL
  );
end
go
