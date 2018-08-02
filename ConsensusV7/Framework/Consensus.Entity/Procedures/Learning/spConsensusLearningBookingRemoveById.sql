if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningBookingRemoveById')
  exec ('create procedure dbo.spConsensusLearningBookingRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningBookingRemoveById(@PA_BOOK_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Booking
  where BOOK_ID = @PA_BOOK_ID
end
go
