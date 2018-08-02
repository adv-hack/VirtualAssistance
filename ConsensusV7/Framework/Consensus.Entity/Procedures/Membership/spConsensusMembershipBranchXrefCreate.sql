if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipBranchXrefCreate')
  exec ('create procedure dbo.spConsensusMembershipBranchXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipBranchXrefCreate(@PA_BRXREF_ID varchar(11) = null output, @PA_BRXREF_BR_ID varchar(11) = null output, @PA_BRXREF_TABLE_NAME varchar(80) = null output, @PA_BRXREF_RECORD_ID varchar(11) = null output, @PA_BRXREF_DISABLED tinyint = null output, @PA_BRXREF_POSITION varchar(40) = null output, @PA_BRXREF_DISTRICT varchar(40) = null output, @PA_BRXREF_DIS_ID varchar(11) = null output, @PA_BRXREF_STATUS varchar(40) = null output, @PA_BRXREF_START_DATE datetime = null output, @PA_BRXREF_END_DATE datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 331, @PA_BRXREF_ID output
  
  insert into dbo.Branch_Xref(
    BRXREF_ID,
    BRXREF_ADD_DATE,
    BRXREF_ADD_BY,
    BRXREF_MOD_DATE,
    BRXREF_MOD_BY,
    BRXREF_RCV_DATE,
    BRXREF_RCV_FROM,
    BRXREF_BR_ID,
    BRXREF_TABLE_NAME,
    BRXREF_RECORD_ID,
    BRXREF_DISABLED,
    BRXREF_POSITION,
    BRXREF_DISTRICT,
    BRXREF_DIS_ID,
    BRXREF_STATUS,
    BRXREF_START_DATE,
    BRXREF_END_DATE
  ) values (
    @PA_BRXREF_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_BRXREF_BR_ID,
    @PA_BRXREF_TABLE_NAME,
    @PA_BRXREF_RECORD_ID,
    @PA_BRXREF_DISABLED,
    @PA_BRXREF_POSITION,
    @PA_BRXREF_DISTRICT,
    @PA_BRXREF_DIS_ID,
    @PA_BRXREF_STATUS,
    @PA_BRXREF_START_DATE,
    @PA_BRXREF_END_DATE
  );
end
go
