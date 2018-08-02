if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactGiftaidFetchById')
  exec ('create procedure dbo.spConsensusContactGiftaidFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusContactGiftaidFetchById(@PA_GIF_ID integer = null output) as 
begin
  select 
    GIF_ID,
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
  from dbo.GiftAid
  where GIF_ID = @PA_GIF_ID
end
go
