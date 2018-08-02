if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberBomModify')
  exec ('create procedure dbo.spConsensusMembershipMemberBomModify as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberBomModify(@PA_MBOM_ID varchar(11) = null output, @PA_MBOM_LOCK varchar(10) = null output, @PA_MBOM_PARENT_ID varchar(11) = null output, @PA_MBOM_PROD_ID varchar(11) = null output, @PA_MBOM_GRADE_ID varchar(11) = null output, @PA_MBOM_MAIN tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.MEMBER_BOM set
    MBOM_MOD_DATE = getDate(),
    MBOM_MOD_BY = @_AUDIT_USER_ID,
    MBOM_LOCK = @PA_MBOM_LOCK,
    MBOM_PARENT_ID = @PA_MBOM_PARENT_ID,
    MBOM_PROD_ID = @PA_MBOM_PROD_ID,
    MBOM_GRADE_ID = @PA_MBOM_GRADE_ID,
    MBOM_MAIN = @PA_MBOM_MAIN
  where MBOM_ID = @PA_MBOM_ID;
end
go
