if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningEventProductFetchById')
  exec ('create procedure dbo.spConsensusLearningEventProductFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningEventProductFetchById(@PA_EP_ID integer = null output) as 
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
  where EP_ID = @PA_EP_ID
end
go
