if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactGiftaidCreate')
  exec ('create procedure dbo.spConsensusContactGiftaidCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactGiftaidCreate(@PA_GIF_ID integer = null output, @PA_GIF_PN_ID varchar(11) = null output, @PA_GIF_TYPE varchar(40) = null output, @PA_GIF_ACTIVE tinyint = null output, @PA_GIF_START_DATE datetime = null output, @PA_GIF_END_DATE datetime = null output, @PA_GIF_COMMUNICATION tinyint = null output, @PA_GIF_FIRST_NAME nvarchar(150) = null output, @PA_GIF_SURNAME nvarchar(150) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.GiftAid(
    GIF_ADD_DATE,
    GIF_ADD_BY,
    GIF_MOD_DATE,
    GIF_MOD_BY,
    GIF_PN_ID,
    GIF_TYPE,
    GIF_ACTIVE,
    GIF_START_DATE,
    GIF_END_DATE,
    GIF_COMMUNICATION,
    GIF_FIRST_NAME,
    GIF_SURNAME
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_GIF_PN_ID,
    @PA_GIF_TYPE,
    @PA_GIF_ACTIVE,
    @PA_GIF_START_DATE,
    @PA_GIF_END_DATE,
    @PA_GIF_COMMUNICATION,
    @PA_GIF_FIRST_NAME,
    @PA_GIF_SURNAME
  );
    set @PA_GIF_ID = @@identity;
end
go
