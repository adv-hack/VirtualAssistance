if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeXrefModify')
  exec ('create procedure dbo.spConsensusMembershipCommitteeXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeXrefModify(@PA_COMXREF_ID varchar(11) = null output, @PA_COMXREF_COM_ID varchar(11) = null output, @PA_COMXREF_TABLE_NAME varchar(80) = null output, @PA_COMXREF_RECORD_ID varchar(11) = null output, @PA_COMXREF_DISABLED tinyint = null output, @PA_COMXREF_ROLE varchar(80) = null output, @PA_COMXREF_DATE datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Committee_Xref set
    COMXREF_MOD_DATE = getDate(),
    COMXREF_MOD_BY = @_AUDIT_USER_ID,
    COMXREF_COM_ID = @PA_COMXREF_COM_ID,
    COMXREF_TABLE_NAME = @PA_COMXREF_TABLE_NAME,
    COMXREF_RECORD_ID = @PA_COMXREF_RECORD_ID,
    COMXREF_DISABLED = @PA_COMXREF_DISABLED,
    COMXREF_ROLE = @PA_COMXREF_ROLE,
    COMXREF_DATE = @PA_COMXREF_DATE
  where COMXREF_ID = @PA_COMXREF_ID;
end
go
