if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningEventProductFetchAllByNotes')
  exec ('create procedure dbo.spConsensusLearningEventProductFetchAllByNotes as select 1 as temp')
go
alter procedure dbo.spConsensusLearningEventProductFetchAllByNotes(@PA_EP_NOTES varchar(11) = null output) as 
begin
  select 
    EP_ID,
    EP_ADD_BY,
    EP_ADD_DATE,
    EP_MOD_BY,
    EP_MOD_DATE,
    EP_COURSE_ID,
    EP_PROD_ID,
    EP_NOTES,
    EP_QTY,
    EP_DELEGATE_QTY,
    EP_BOM_ID,
    EP_PREDELIV
  from dbo.EVENT_PRODUCT
  where EP_NOTES = @PA_EP_NOTES
end
go
