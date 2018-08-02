if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesSalesChannelFetchAll')
  exec ('create procedure dbo.spConsensusSalesSalesChannelFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSalesSalesChannelFetchAll as 
begin
  select 
    SCHN_ID,
    SCHN_LOCK,
    SCHN_ADD_DATE,
    SCHN_ADD_BY,
    SCHN_MOD_DATE,
    SCHN_MOD_BY,
    SCHN_RCV_DATE,
    SCHN_RCV_FROM,
    SCHN_NUMBER,
    SCHN_NAME,
    SCHN_REF,
    SCHN_PL_ID,
    SCHN_STATE,
    SCHN_CUTOFF_TIME,
    SCHN_TIMEOUT,
    SCHN_NO_BOOK
  from dbo.Sales_Channel
end
go
