if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningEventProductModify')
  exec ('create procedure dbo.spConsensusLearningEventProductModify as select 1 as temp')
go
alter procedure dbo.spConsensusLearningEventProductModify(@PA_EP_ID integer = null output, @PA_EP_COURSE_ID varchar(11) = null output, @PA_EP_PROD_ID varchar(11) = null output, @PA_EP_NOTES varchar(11) = null output, @PA_EP_QTY integer = null output, @PA_EP_DELEGATE_QTY integer = null output, @PA_EP_BOM_ID varchar(11) = null output, @PA_EP_PREDELIV tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.EVENT_PRODUCT set
    EP_MOD_DATE = getDate(),
    EP_MOD_BY = @_AUDIT_USER_ID,
    EP_COURSE_ID = @PA_EP_COURSE_ID,
    EP_PROD_ID = @PA_EP_PROD_ID,
    EP_NOTES = @PA_EP_NOTES,
    EP_QTY = @PA_EP_QTY,
    EP_DELEGATE_QTY = @PA_EP_DELEGATE_QTY,
    EP_BOM_ID = @PA_EP_BOM_ID,
    EP_PREDELIV = @PA_EP_PREDELIV
  where EP_ID = @PA_EP_ID;
end
go
