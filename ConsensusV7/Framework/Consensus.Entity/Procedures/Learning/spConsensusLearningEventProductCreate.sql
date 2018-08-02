if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningEventProductCreate')
  exec ('create procedure dbo.spConsensusLearningEventProductCreate as select 1 as temp')
go
alter procedure dbo.spConsensusLearningEventProductCreate(@PA_EP_ID integer = null output, @PA_EP_COURSE_ID varchar(11) = null output, @PA_EP_PROD_ID varchar(11) = null output, @PA_EP_NOTES varchar(11) = null output, @PA_EP_QTY integer = null output, @PA_EP_DELEGATE_QTY integer = null output, @PA_EP_BOM_ID varchar(11) = null output, @PA_EP_PREDELIV tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.EVENT_PRODUCT(
    EP_ADD_DATE,
    EP_ADD_BY,
    EP_MOD_DATE,
    EP_MOD_BY,
    EP_COURSE_ID,
    EP_PROD_ID,
    EP_NOTES,
    EP_QTY,
    EP_DELEGATE_QTY,
    EP_BOM_ID,
    EP_PREDELIV
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_EP_COURSE_ID,
    @PA_EP_PROD_ID,
    @PA_EP_NOTES,
    @PA_EP_QTY,
    @PA_EP_DELEGATE_QTY,
    @PA_EP_BOM_ID,
    @PA_EP_PREDELIV
  );
    set @PA_EP_ID = @@identity;
end
go
