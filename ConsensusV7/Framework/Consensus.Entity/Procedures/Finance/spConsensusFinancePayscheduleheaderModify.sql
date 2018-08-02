if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayscheduleheaderModify')
  exec ('create procedure dbo.spConsensusFinancePayscheduleheaderModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayscheduleheaderModify(@PA_PSH_ID integer = null output, @PA_PSH_DESCRIPTION varchar(200) = null output, @PA_PSH_NOTES varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.PayScheduleHeader set
    PSH_MOD_DATE = getDate(),
    PSH_MOD_BY = @_AUDIT_USER_ID,
    PSH_DESCRIPTION = @PA_PSH_DESCRIPTION,
    PSH_NOTES = @PA_PSH_NOTES
  where PSH_ID = @PA_PSH_ID;
end
go
