if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessageModify')
  exec ('create procedure dbo.spConsensusDocumentIcalmessageModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessageModify(@PA_ICM_ID integer = null output, @PA_ICM_ICMT_ID integer = null output, @PA_ICM_CURRENT tinyint = null output, @PA_ICM_METHOD tinyint = null output, @PA_ICM_NAME varchar(500) = null output, @PA_ICM_DESCRIPTION varchar(256) = null output, @PA_ICM_SUBJECT varchar(256) = null output, @PA_ICM_LOCATION varchar(256) = null output, @PA_ICM_TEXT varchar(max) = null output, @PA_ICM_SELCO_SP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.ICalMessage set
    ICM_MOD_DATE = getDate(),
    ICM_MOD_BY = @_AUDIT_USER_ID,
    ICM_ICMT_ID = @PA_ICM_ICMT_ID,
    ICM_CURRENT = @PA_ICM_CURRENT,
    ICM_METHOD = @PA_ICM_METHOD,
    ICM_NAME = @PA_ICM_NAME,
    ICM_DESCRIPTION = @PA_ICM_DESCRIPTION,
    ICM_SUBJECT = @PA_ICM_SUBJECT,
    ICM_LOCATION = @PA_ICM_LOCATION,
    ICM_TEXT = @PA_ICM_TEXT,
    ICM_SELCO_SP_ID = @PA_ICM_SELCO_SP_ID
  where ICM_ID = @PA_ICM_ID;
end
go
