if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberBomCreate')
  exec ('create procedure dbo.spConsensusMembershipMemberBomCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberBomCreate(@PA_MBOM_ID varchar(11) = null output, @PA_MBOM_LOCK varchar(10) = null output, @PA_MBOM_PARENT_ID varchar(11) = null output, @PA_MBOM_PROD_ID varchar(11) = null output, @PA_MBOM_GRADE_ID varchar(11) = null output, @PA_MBOM_MAIN tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 274, @PA_MBOM_ID output
  
  insert into dbo.MEMBER_BOM(
    MBOM_ID,
    MBOM_ADD_DATE,
    MBOM_ADD_BY,
    MBOM_MOD_DATE,
    MBOM_MOD_BY,
    MBOM_RCV_DATE,
    MBOM_RCV_FROM,
    MBOM_LOCK,
    MBOM_PARENT_ID,
    MBOM_PROD_ID,
    MBOM_GRADE_ID,
    MBOM_MAIN
  ) values (
    @PA_MBOM_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_MBOM_LOCK,
    @PA_MBOM_PARENT_ID,
    @PA_MBOM_PROD_ID,
    @PA_MBOM_GRADE_ID,
    @PA_MBOM_MAIN
  );
end
go
