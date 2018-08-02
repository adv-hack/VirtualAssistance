if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonGenericmodeltableFetchById')
  exec ('create procedure dbo.spConsensusCommonGenericmodeltableFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonGenericmodeltableFetchById(@PA_GMT_ID varchar(11) = null output) as 
begin
  select 
    GMT_ID,
    GMT_ID1,
    GMT_ID2,
    GMT_ID3,
    GMT_ID4,
    GMT_ID5,
    GMT_DESC1,
    GMT_DESC2,
    GMT_DESC3,
    GMT_DESC4,
    GMT_DESC5,
    GMT_LONGDESC,
    GMT_DATE1,
    GMT_DATE2,
    GMT_DATE3,
    GMT_INT1,
    GMT_INT2,
    GMT_INT3,
    GMT_MONEY1,
    GMT_MONEY2,
    GMT_MONEY3
  from dbo.GenericModelTable
  where GMT_ID = @PA_GMT_ID
end
go
