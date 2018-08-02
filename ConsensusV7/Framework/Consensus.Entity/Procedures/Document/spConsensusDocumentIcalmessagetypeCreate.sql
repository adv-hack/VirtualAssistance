if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessagetypeCreate')
  exec ('create procedure dbo.spConsensusDocumentIcalmessagetypeCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessagetypeCreate(@PA_ICMT_ID integer = null output, @PA_ICMT_NAME varchar(40) = null output, @PA_ICMT_VIEW varchar(128) = null output, @PA_ICMT_PROC varchar(128) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.ICalMessageType(
    ICMT_ADD_DATE,
    ICMT_ADD_BY,
    ICMT_MOD_DATE,
    ICMT_MOD_BY,
    ICMT_NAME,
    ICMT_VIEW,
    ICMT_PROC
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_ICMT_NAME,
    @PA_ICMT_VIEW,
    @PA_ICMT_PROC
  );
    set @PA_ICMT_ID = @@identity;
end
go
