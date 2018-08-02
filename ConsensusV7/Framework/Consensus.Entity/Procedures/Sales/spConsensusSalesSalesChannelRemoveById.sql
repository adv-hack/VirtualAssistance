if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesSalesChannelRemoveById')
  exec ('create procedure dbo.spConsensusSalesSalesChannelRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSalesSalesChannelRemoveById(@PA_SCHN_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Sales_Channel
  where SCHN_ID = @PA_SCHN_ID
end
go
