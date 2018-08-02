if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessagetypeModify')
  exec ('create procedure dbo.spConsensusDocumentIcalmessagetypeModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessagetypeModify(@PA_ICMT_ID integer = null output, @PA_ICMT_NAME varchar(40) = null output, @PA_ICMT_VIEW varchar(128) = null output, @PA_ICMT_PROC varchar(128) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.ICalMessageType set
    ICMT_MOD_DATE = getDate(),
    ICMT_MOD_BY = @_AUDIT_USER_ID,
    ICMT_NAME = @PA_ICMT_NAME,
    ICMT_VIEW = @PA_ICMT_VIEW,
    ICMT_PROC = @PA_ICMT_PROC
  where ICMT_ID = @PA_ICMT_ID;
end
go
