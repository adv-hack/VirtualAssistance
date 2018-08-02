if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactGiftaidRemoveById')
  exec ('create procedure dbo.spConsensusContactGiftaidRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactGiftaidRemoveById(@PA_GIF_ID integer = null output) as 
begin
  delete 
  from dbo.GiftAid
  where GIF_ID = @PA_GIF_ID
end
go
