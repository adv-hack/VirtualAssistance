if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceBookingTermsRemoveById')
  exec ('create procedure dbo.spConsensusFinanceBookingTermsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceBookingTermsRemoveById(@PA_BKT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Booking_Terms
  where BKT_ID = @PA_BKT_ID
end
go
