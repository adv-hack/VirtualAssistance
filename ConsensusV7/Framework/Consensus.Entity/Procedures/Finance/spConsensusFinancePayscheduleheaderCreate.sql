if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayscheduleheaderCreate')
  exec ('create procedure dbo.spConsensusFinancePayscheduleheaderCreate as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayscheduleheaderCreate(@PA_PSH_ID integer = null output, @PA_PSH_DESCRIPTION varchar(200) = null output, @PA_PSH_NOTES varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.PayScheduleHeader(
    PSH_ADD_DATE,
    PSH_ADD_BY,
    PSH_MOD_DATE,
    PSH_MOD_BY,
    PSH_DESCRIPTION,
    PSH_NOTES
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_PSH_DESCRIPTION,
    @PA_PSH_NOTES
  );
    set @PA_PSH_ID = @@identity;
end
go
