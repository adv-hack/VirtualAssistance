if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMembershipModify')
  exec ('create procedure dbo.spConsensusMembershipMembershipModify as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMembershipModify(@PA_MEM_ID varchar(11) = null output, @PA_MEM_REF varchar(20) = null output, @PA_MEM_NOTES varchar(max) = null output, @PA_MEM_PM_ID varchar(11) = null output, @PA_MEM_START datetime = null output, @PA_MEM_CUST_ORDER_NO varchar(25) = null output, @PA_MEM_USERNAME varchar(25) = null output, @PA_MEM_PASSWORD varchar(25) = null output, @PA_MEM_REG_STATUS varchar(50) = null output, @PA_MEM_TYPE varchar(11) = null output, @PA_MEM_STATUS varchar(20) = null output, @PA_MEM_GRADE varchar(25) = null output, @PA_MEM_SUB_ONLY integer = null output, @PA_MEM_BIOG_HTML varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Membership set
    MEM_MOD_DATE = getDate(),
    MEM_MOD_BY = @_AUDIT_USER_ID,
    MEM_REF = @PA_MEM_REF,
    MEM_NOTES = @PA_MEM_NOTES,
    MEM_PM_ID = @PA_MEM_PM_ID,
    MEM_START = @PA_MEM_START,
    MEM_CUST_ORDER_NO = @PA_MEM_CUST_ORDER_NO,
    MEM_USERNAME = @PA_MEM_USERNAME,
    MEM_PASSWORD = @PA_MEM_PASSWORD,
    MEM_REG_STATUS = @PA_MEM_REG_STATUS,
    MEM_TYPE = @PA_MEM_TYPE,
    MEM_STATUS = @PA_MEM_STATUS,
    MEM_GRADE = @PA_MEM_GRADE,
    MEM_SUB_ONLY = @PA_MEM_SUB_ONLY,
    MEM_BIOG_HTML = @PA_MEM_BIOG_HTML
  where MEM_ID = @PA_MEM_ID;
end
go
