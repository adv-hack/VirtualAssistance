if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeXrefCreate')
  exec ('create procedure dbo.spConsensusMembershipCommitteeXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeXrefCreate(@PA_COMXREF_ID varchar(11) = null output, @PA_COMXREF_COM_ID varchar(11) = null output, @PA_COMXREF_TABLE_NAME varchar(80) = null output, @PA_COMXREF_RECORD_ID varchar(11) = null output, @PA_COMXREF_DISABLED tinyint = null output, @PA_COMXREF_ROLE varchar(80) = null output, @PA_COMXREF_DATE datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 335, @PA_COMXREF_ID output
  
  insert into dbo.Committee_Xref(
    COMXREF_ID,
    COMXREF_ADD_DATE,
    COMXREF_ADD_BY,
    COMXREF_MOD_DATE,
    COMXREF_MOD_BY,
    COMXREF_RCV_DATE,
    COMXREF_RCV_FROM,
    COMXREF_COM_ID,
    COMXREF_TABLE_NAME,
    COMXREF_RECORD_ID,
    COMXREF_DISABLED,
    COMXREF_ROLE,
    COMXREF_DATE
  ) values (
    @PA_COMXREF_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_COMXREF_COM_ID,
    @PA_COMXREF_TABLE_NAME,
    @PA_COMXREF_RECORD_ID,
    @PA_COMXREF_DISABLED,
    @PA_COMXREF_ROLE,
    @PA_COMXREF_DATE
  );
end
go
