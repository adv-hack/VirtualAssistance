if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesC4textModify')
  exec ('create procedure dbo.spConsensusActivitiesC4textModify as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesC4textModify(@PA_TEXT_ID varchar(11) = null output, @PA_TEXT_TYPE varchar(4) = null output, @PA_TEXT_OWNER_ID varchar(11) = null output, @PA_TEXT_BODY varchar(max) = null output, @PA_TEXT_RTF varchar(255) = null output, @PA_TEXT_HTML varchar(max) = null output, @PA_TEXT_OWNER_URL varchar(250) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.C4Text set
    TEXT_MOD_DATE = getDate(),
    TEXT_MOD_BY = @_AUDIT_USER_ID,
    TEXT_TYPE = @PA_TEXT_TYPE,
    TEXT_OWNER_ID = @PA_TEXT_OWNER_ID,
    TEXT_BODY = @PA_TEXT_BODY,
    TEXT_RTF = @PA_TEXT_RTF,
    TEXT_HTML = @PA_TEXT_HTML,
    TEXT_OWNER_URL = @PA_TEXT_OWNER_URL
  where TEXT_ID = @PA_TEXT_ID;
end
go
