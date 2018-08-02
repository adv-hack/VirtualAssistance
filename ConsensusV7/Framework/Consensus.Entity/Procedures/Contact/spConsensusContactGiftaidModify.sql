if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactGiftaidModify')
  exec ('create procedure dbo.spConsensusContactGiftaidModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactGiftaidModify(@PA_GIF_ID integer = null output, @PA_GIF_PN_ID varchar(11) = null output, @PA_GIF_TYPE varchar(40) = null output, @PA_GIF_ACTIVE tinyint = null output, @PA_GIF_START_DATE datetime = null output, @PA_GIF_END_DATE datetime = null output, @PA_GIF_COMMUNICATION tinyint = null output, @PA_GIF_FIRST_NAME nvarchar(150) = null output, @PA_GIF_SURNAME nvarchar(150) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.GiftAid set
    GIF_MOD_DATE = getDate(),
    GIF_MOD_BY = @_AUDIT_USER_ID,
    GIF_PN_ID = @PA_GIF_PN_ID,
    GIF_TYPE = @PA_GIF_TYPE,
    GIF_ACTIVE = @PA_GIF_ACTIVE,
    GIF_START_DATE = @PA_GIF_START_DATE,
    GIF_END_DATE = @PA_GIF_END_DATE,
    GIF_COMMUNICATION = @PA_GIF_COMMUNICATION,
    GIF_FIRST_NAME = @PA_GIF_FIRST_NAME,
    GIF_SURNAME = @PA_GIF_SURNAME
  where GIF_ID = @PA_GIF_ID;
end
go
