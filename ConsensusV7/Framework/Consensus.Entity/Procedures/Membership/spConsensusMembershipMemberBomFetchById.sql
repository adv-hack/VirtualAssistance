if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberBomFetchById')
  exec ('create procedure dbo.spConsensusMembershipMemberBomFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberBomFetchById(@PA_MBOM_ID varchar(11) = null output) as 
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
  where MBOM_ID = @PA_MBOM_ID
end
go
