if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonViewLogModify')
  exec ('create procedure dbo.spConsensusCommonViewLogModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonViewLogModify(@PA_VIEW_ID integer = null output, @PA_VIEW_TABLE varchar(50) = null output, @PA_VIEW_REC_ID varchar(11) = null output, @PA_VIEW_SOURCE tinyint = null output, @PA_VIEW_TYPE tinyint = null output, @PA_VIEW_REC_ID2 varchar(11) = null output, @PA_VIEW_TABLE2 varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.VIEW_LOG set
    VIEW_MOD_DATE = getDate(),
    VIEW_MOD_BY = @_AUDIT_USER_ID,
    VIEW_TABLE = @PA_VIEW_TABLE,
    VIEW_REC_ID = @PA_VIEW_REC_ID,
    VIEW_SOURCE = @PA_VIEW_SOURCE,
    VIEW_TYPE = @PA_VIEW_TYPE,
    VIEW_REC_ID2 = @PA_VIEW_REC_ID2,
    VIEW_TABLE2 = @PA_VIEW_TABLE2
  where VIEW_ID = @PA_VIEW_ID;
end
go
