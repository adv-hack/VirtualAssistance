if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesComplaintCreate')
  exec ('create procedure dbo.spConsensusActivitiesComplaintCreate as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesComplaintCreate(@PA_CMPL_ID varchar(11) = null output, @PA_CMPL_TITLE varchar(100) = null output, @PA_CMPL_FROM_PROLE_ID varchar(11) = null output, @PA_CMPL_RE_PROLE_ID varchar(11) = null output, @PA_CMPL_MGR_PROLE_ID varchar(11) = null output, @PA_CMPL_MEDTR_PROLE_ID varchar(11) = null output, @PA_CMPL_STATUS_1 varchar(40) = null output, @PA_CMPL_STATUS_2 varchar(40) = null output, @PA_CMPL_STATUS_3 varchar(40) = null output, @PA_CMPL_TYPE_1 varchar(40) = null output, @PA_CMPL_TYPE_2 varchar(40) = null output, @PA_CMPL_TYPE_3 varchar(40) = null output, @PA_CMPL_SCHEME varchar(40) = null output, @PA_CMPL_DATE_OF_COMPL datetime = null output, @PA_CMPL_DATE_RCVD datetime = null output, @PA_CMPL_DATE_END datetime = null output, @PA_CMPL_DATE_NEXT_ACT datetime = null output, @PA_CMPL_NOTES varchar(max) = null output, @PA_CMPL_01_VALUE varchar(500) = null output, @PA_CMPL_02_VALUE varchar(500) = null output, @PA_CMPL_03_VALUE varchar(500) = null output, @PA_CMPL_04_VALUE varchar(500) = null output, @PA_CMPL_05_VALUE varchar(500) = null output, @PA_CMPL_06_VALUE varchar(500) = null output, @PA_CMPL_07_VALUE varchar(500) = null output, @PA_CMPL_08_VALUE varchar(500) = null output, @PA_CMPL_09_VALUE varchar(500) = null output, @PA_CMPL_10_VALUE varchar(500) = null output, @PA_CMPL_PM_ID varchar(11) = null output, @PA_CMPL_OUR_PERSON tinyint = null output, @PA_CMPL_DETAILS_ID varchar(11) = null output, @PA_CMPL_RESOL_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 320, @PA_CMPL_ID output
  
  insert into dbo.Complaint(
    CMPL_ID,
    CMPL_ADD_DATE,
    CMPL_ADD_BY,
    CMPL_MOD_DATE,
    CMPL_MOD_BY,
    CMPL_RCV_DATE,
    CMPL_RCV_FROM,
    CMPL_TITLE,
    CMPL_FROM_PROLE_ID,
    CMPL_RE_PROLE_ID,
    CMPL_MGR_PROLE_ID,
    CMPL_MEDTR_PROLE_ID,
    CMPL_STATUS_1,
    CMPL_STATUS_2,
    CMPL_STATUS_3,
    CMPL_TYPE_1,
    CMPL_TYPE_2,
    CMPL_TYPE_3,
    CMPL_SCHEME,
    CMPL_DATE_OF_COMPL,
    CMPL_DATE_RCVD,
    CMPL_DATE_END,
    CMPL_DATE_NEXT_ACT,
    CMPL_NOTES,
    CMPL_01_VALUE,
    CMPL_02_VALUE,
    CMPL_03_VALUE,
    CMPL_04_VALUE,
    CMPL_05_VALUE,
    CMPL_06_VALUE,
    CMPL_07_VALUE,
    CMPL_08_VALUE,
    CMPL_09_VALUE,
    CMPL_10_VALUE,
    CMPL_PM_ID,
    CMPL_OUR_PERSON,
    CMPL_DETAILS_ID,
    CMPL_RESOL_ID
  ) values (
    @PA_CMPL_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_CMPL_TITLE,
    @PA_CMPL_FROM_PROLE_ID,
    @PA_CMPL_RE_PROLE_ID,
    @PA_CMPL_MGR_PROLE_ID,
    @PA_CMPL_MEDTR_PROLE_ID,
    @PA_CMPL_STATUS_1,
    @PA_CMPL_STATUS_2,
    @PA_CMPL_STATUS_3,
    @PA_CMPL_TYPE_1,
    @PA_CMPL_TYPE_2,
    @PA_CMPL_TYPE_3,
    @PA_CMPL_SCHEME,
    @PA_CMPL_DATE_OF_COMPL,
    @PA_CMPL_DATE_RCVD,
    @PA_CMPL_DATE_END,
    @PA_CMPL_DATE_NEXT_ACT,
    @PA_CMPL_NOTES,
    @PA_CMPL_01_VALUE,
    @PA_CMPL_02_VALUE,
    @PA_CMPL_03_VALUE,
    @PA_CMPL_04_VALUE,
    @PA_CMPL_05_VALUE,
    @PA_CMPL_06_VALUE,
    @PA_CMPL_07_VALUE,
    @PA_CMPL_08_VALUE,
    @PA_CMPL_09_VALUE,
    @PA_CMPL_10_VALUE,
    @PA_CMPL_PM_ID,
    @PA_CMPL_OUR_PERSON,
    @PA_CMPL_DETAILS_ID,
    @PA_CMPL_RESOL_ID
  );
end
go
