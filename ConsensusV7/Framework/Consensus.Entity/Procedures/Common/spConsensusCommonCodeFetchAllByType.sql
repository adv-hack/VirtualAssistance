if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonCodeFetchAllByType')
  exec ('create procedure dbo.spConsensusCommonCodeFetchAllByType as select 1 as temp')
go
alter procedure dbo.spConsensusCommonCodeFetchAllByType(@PA_CODE_TYPE varchar(5) = null) as 
begin
  select 
    CODE_ID,
    CODE_LOCK,
    CODE_ADD_DATE,
    CODE_ADD_BY,
    CODE_MOD_DATE,
    CODE_MOD_BY,
    CODE_RCV_DATE,
    CODE_RCV_FROM,
    CODE_TYPE,
    CODE_VALUE1,
    CODE_VALUE2,
    CODE_VALUE3,
    CODE_DESCRIPTION,
    CODE_NOTES,
    CODE_VALUE4,
    CODE_SYSTEM,
    CODE_DELETED,
    CODE_INSTRUCT,
    CODE_READ_ONLY,
    CODE_ORIG_VALUE,
    CODE_VALUE5,
    CODE_ORDER
  from dbo.Code
  where CODE_TYPE = @PA_CODE_TYPE AND isnull(CODE_DELETED,0) = 0
  order by CODE_VALUE1

end
go
