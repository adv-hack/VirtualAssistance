if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMembershipFetchAll')
  exec ('create procedure dbo.spConsensusMembershipMembershipFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMembershipFetchAll as 
begin
  select 
    MEM_ID,
    MEM_ADD_BY,
    MEM_ADD_DATE,
    MEM_MOD_BY,
    MEM_MOD_DATE,
    MEM_RCV_FROM,
    MEM_RCV_DATE,
    MEM_REF,
    MEM_NOTES,
    MEM_PM_ID,
    MEM_START,
    MEM_CUST_ORDER_NO,
    MEM_USERNAME,
    MEM_PASSWORD,
    MEM_REG_STATUS,
    MEM_TYPE,
    MEM_STATUS,
    MEM_GRADE,
    MEM_SUB_ONLY,
    MEM_BIOG_HTML
  from dbo.Membership
end
go
