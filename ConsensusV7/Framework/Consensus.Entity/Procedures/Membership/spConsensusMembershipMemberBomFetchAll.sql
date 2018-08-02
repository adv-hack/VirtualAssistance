if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberBomFetchAll')
  exec ('create procedure dbo.spConsensusMembershipMemberBomFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberBomFetchAll as 
begin
  select 
    MBOM_ID,
    MBOM_LOCK,
    MBOM_ADD_BY,
    MBOM_ADD_DATE,
    MBOM_MOD_BY,
    MBOM_MOD_DATE,
    MBOM_RCV_FROM,
    MBOM_RCV_DATE,
    MBOM_PARENT_ID,
    MBOM_PROD_ID,
    MBOM_GRADE_ID,
    MBOM_MAIN
  from dbo.MEMBER_BOM
end
go
