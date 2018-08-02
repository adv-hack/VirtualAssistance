if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactGiftaidFetchAllByPnid')
  exec ('create procedure dbo.spConsensusContactGiftaidFetchAllByPnid as select 1 as temp')
go
alter procedure dbo.spConsensusContactGiftaidFetchAllByPnid(@PA_GIF_PN_ID varchar(11) = null output) as 
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
  where GIF_PN_ID = @PA_GIF_PN_ID
end
go
