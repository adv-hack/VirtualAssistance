if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonCodeHeaderFetchById')
  exec ('create procedure dbo.spConsensusCommonCodeHeaderFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonCodeHeaderFetchById(@PA_CDHDR_CODE_TYPE varchar(5) = null output) as 
begin
  select 
    CDHDR_CODE_TYPE,
    CDHDR_NAME,
    CDHDR_LENGTH,
    CDHDR_TYPE,
    CDHDR_TV1,
    CDHDR_TV2,
    CDHDR_TV3,
    CDHDR_TV4,
    CDHDR_TV1_LEN,
    CDHDR_COL_NAME,
    CDHDR_TAB_NAME,
    CDHDR_READ_ONLY,
    CDHDR_CODE_VALUE3_LIST,
    CDHDR_IMMUTABLE
  from dbo.Code_Header
  where CDHDR_CODE_TYPE = @PA_CDHDR_CODE_TYPE
end
go
