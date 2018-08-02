if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessageCreate')
  exec ('create procedure dbo.spConsensusDocumentIcalmessageCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessageCreate(@PA_ICM_ID integer = null output, @PA_ICM_ICMT_ID integer = null output, @PA_ICM_CURRENT tinyint = null output, @PA_ICM_METHOD tinyint = null output, @PA_ICM_NAME varchar(500) = null output, @PA_ICM_DESCRIPTION varchar(256) = null output, @PA_ICM_SUBJECT varchar(256) = null output, @PA_ICM_LOCATION varchar(256) = null output, @PA_ICM_TEXT varchar(max) = null output, @PA_ICM_SELCO_SP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.ICalMessage(
    ICM_ADD_DATE,
    ICM_ADD_BY,
    ICM_MOD_DATE,
    ICM_MOD_BY,
    ICM_ICMT_ID,
    ICM_CURRENT,
    ICM_METHOD,
    ICM_NAME,
    ICM_DESCRIPTION,
    ICM_SUBJECT,
    ICM_LOCATION,
    ICM_TEXT,
    ICM_SELCO_SP_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_ICM_ICMT_ID,
    @PA_ICM_CURRENT,
    @PA_ICM_METHOD,
    @PA_ICM_NAME,
    @PA_ICM_DESCRIPTION,
    @PA_ICM_SUBJECT,
    @PA_ICM_LOCATION,
    @PA_ICM_TEXT,
    @PA_ICM_SELCO_SP_ID
  );
    set @PA_ICM_ID = @@identity;
end
go
