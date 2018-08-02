if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsXrefModify')
  exec ('create procedure dbo.spConsensusContactCommunicationsXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsXrefModify(@PA_COMMXREF_ID bigint = null output, @PA_COMMXREF_TABLE_NAME varchar(100) = null output, @PA_COMMXREF_RECORD_ID varchar(11) = null output, @PA_COMMXREF_COMM_ID bigint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Communications_Xref set
    COMMXREF_MOD_DATE = getDate(),
    COMMXREF_MOD_BY = @_AUDIT_USER_ID,
    COMMXREF_TABLE_NAME = @PA_COMMXREF_TABLE_NAME,
    COMMXREF_RECORD_ID = @PA_COMMXREF_RECORD_ID,
    COMMXREF_COMM_ID = @PA_COMMXREF_COMM_ID
  where COMMXREF_ID = @PA_COMMXREF_ID;
end
go
