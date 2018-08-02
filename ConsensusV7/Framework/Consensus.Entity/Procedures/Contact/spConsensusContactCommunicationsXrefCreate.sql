if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsXrefCreate')
  exec ('create procedure dbo.spConsensusContactCommunicationsXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsXrefCreate(@PA_COMMXREF_ID bigint = null output, @PA_COMMXREF_TABLE_NAME varchar(100) = null output, @PA_COMMXREF_RECORD_ID varchar(11) = null output, @PA_COMMXREF_COMM_ID bigint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Communications_Xref(
    COMMXREF_ADD_DATE,
    COMMXREF_ADD_BY,
    COMMXREF_MOD_DATE,
    COMMXREF_MOD_BY,
    COMMXREF_TABLE_NAME,
    COMMXREF_RECORD_ID,
    COMMXREF_COMM_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_COMMXREF_TABLE_NAME,
    @PA_COMMXREF_RECORD_ID,
    @PA_COMMXREF_COMM_ID
  );
    set @PA_COMMXREF_ID = @@identity;
end
go
