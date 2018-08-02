if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonViewLogFetchAll')
  exec ('create procedure dbo.spConsensusCommonViewLogFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusCommonViewLogFetchAll as 
begin
  select 
    VIEW_ID,
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
  from dbo.VIEW_LOG
end
go
