if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesComplaintFetchAllByPmid')
  exec ('create procedure dbo.spConsensusActivitiesComplaintFetchAllByPmid as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesComplaintFetchAllByPmid(@PA_CMPL_PM_ID varchar(11) = null output) as 
begin
  select 
    CMPL_ID,
    CMPL_ADD_BY,
    CMPL_ADD_DATE,
    CMPL_MOD_BY,
    CMPL_MOD_DATE,
    CMPL_RCV_FROM,
    CMPL_RCV_DATE,
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
  from dbo.Complaint
  where CMPL_PM_ID = @PA_CMPL_PM_ID
end
go
