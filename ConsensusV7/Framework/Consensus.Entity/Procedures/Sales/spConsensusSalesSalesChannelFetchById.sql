if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesSalesChannelFetchById')
  exec ('create procedure dbo.spConsensusSalesSalesChannelFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSalesSalesChannelFetchById(@PA_SCHN_ID varchar(11) = null output) as 
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
  where SCHN_ID = @PA_SCHN_ID
end
go
