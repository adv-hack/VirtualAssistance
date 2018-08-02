if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonCodeHeaderCreate')
  exec ('create procedure dbo.spConsensusCommonCodeHeaderCreate as select 1 as temp')
go
alter procedure dbo.spConsensusCommonCodeHeaderCreate(@PA_CDHDR_CODE_TYPE varchar(5) = null output, @PA_CDHDR_NAME varchar(40) = null output, @PA_CDHDR_LENGTH tinyint = null output, @PA_CDHDR_TYPE tinyint = null output, @PA_CDHDR_TV1 tinyint = null output, @PA_CDHDR_TV2 tinyint = null output, @PA_CDHDR_TV3 tinyint = null output, @PA_CDHDR_TV4 tinyint = null output, @PA_CDHDR_TV1_LEN tinyint = null output, @PA_CDHDR_COL_NAME varchar(50) = null output, @PA_CDHDR_TAB_NAME varchar(35) = null output, @PA_CDHDR_READ_ONLY tinyint = null output, @PA_CDHDR_CODE_VALUE3_LIST varchar(5) = null output, @PA_CDHDR_IMMUTABLE tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Code_Header(
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
  ) values (
    @PA_CDHDR_NAME,
    @PA_CDHDR_LENGTH,
    @PA_CDHDR_TYPE,
    @PA_CDHDR_TV1,
    @PA_CDHDR_TV2,
    @PA_CDHDR_TV3,
    @PA_CDHDR_TV4,
    @PA_CDHDR_TV1_LEN,
    @PA_CDHDR_COL_NAME,
    @PA_CDHDR_TAB_NAME,
    @PA_CDHDR_READ_ONLY,
    @PA_CDHDR_CODE_VALUE3_LIST,
    @PA_CDHDR_IMMUTABLE
  );
    set @PA_CDHDR_CODE_TYPE = @@identity;
end
go
