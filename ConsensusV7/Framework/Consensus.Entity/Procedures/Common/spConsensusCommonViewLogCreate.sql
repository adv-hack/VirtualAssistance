if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonViewLogCreate')
  exec ('create procedure dbo.spConsensusCommonViewLogCreate as select 1 as temp')
go
alter procedure dbo.spConsensusCommonViewLogCreate(@PA_VIEW_ID integer = null output, @PA_VIEW_TABLE varchar(50) = null output, @PA_VIEW_REC_ID varchar(11) = null output, @PA_VIEW_SOURCE tinyint = null output, @PA_VIEW_TYPE tinyint = null output, @PA_VIEW_REC_ID2 varchar(11) = null output, @PA_VIEW_TABLE2 varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.VIEW_LOG(
    VIEW_ADD_DATE,
    VIEW_ADD_BY,
    VIEW_MOD_DATE,
    VIEW_MOD_BY,
    VIEW_RCV_DATE,
    VIEW_RCV_FROM,
    VIEW_TABLE,
    VIEW_REC_ID,
    VIEW_SOURCE,
    VIEW_TYPE,
    VIEW_REC_ID2,
    VIEW_TABLE2
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_VIEW_TABLE,
    @PA_VIEW_REC_ID,
    @PA_VIEW_SOURCE,
    @PA_VIEW_TYPE,
    @PA_VIEW_REC_ID2,
    @PA_VIEW_TABLE2
  );
    set @PA_VIEW_ID = @@identity;
end
go
