if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonGenericmodeltableModify')
  exec ('create procedure dbo.spConsensusCommonGenericmodeltableModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonGenericmodeltableModify(@PA_GMT_ID varchar(11) = null output, @PA_GMT_ID1 varchar(11) = null output, @PA_GMT_ID2 varchar(11) = null output, @PA_GMT_ID3 varchar(11) = null output, @PA_GMT_ID4 varchar(11) = null output, @PA_GMT_ID5 varchar(11) = null output, @PA_GMT_DESC1 varchar(200) = null output, @PA_GMT_DESC2 varchar(200) = null output, @PA_GMT_DESC3 varchar(200) = null output, @PA_GMT_DESC4 varchar(200) = null output, @PA_GMT_DESC5 varchar(200) = null output, @PA_GMT_LONGDESC varchar(500) = null output, @PA_GMT_DATE1 datetime = null output, @PA_GMT_DATE2 datetime = null output, @PA_GMT_DATE3 datetime = null output, @PA_GMT_INT1 integer = null output, @PA_GMT_INT2 integer = null output, @PA_GMT_INT3 integer = null output, @PA_GMT_MONEY1 decimal(19, 4) = null output, @PA_GMT_MONEY2 decimal(19, 4) = null output, @PA_GMT_MONEY3 decimal(19, 4) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.GenericModelTable set
    GMT_ID1 = @PA_GMT_ID1,
    GMT_ID2 = @PA_GMT_ID2,
    GMT_ID3 = @PA_GMT_ID3,
    GMT_ID4 = @PA_GMT_ID4,
    GMT_ID5 = @PA_GMT_ID5,
    GMT_DESC1 = @PA_GMT_DESC1,
    GMT_DESC2 = @PA_GMT_DESC2,
    GMT_DESC3 = @PA_GMT_DESC3,
    GMT_DESC4 = @PA_GMT_DESC4,
    GMT_DESC5 = @PA_GMT_DESC5,
    GMT_LONGDESC = @PA_GMT_LONGDESC,
    GMT_DATE1 = @PA_GMT_DATE1,
    GMT_DATE2 = @PA_GMT_DATE2,
    GMT_DATE3 = @PA_GMT_DATE3,
    GMT_INT1 = @PA_GMT_INT1,
    GMT_INT2 = @PA_GMT_INT2,
    GMT_INT3 = @PA_GMT_INT3,
    GMT_MONEY1 = @PA_GMT_MONEY1,
    GMT_MONEY2 = @PA_GMT_MONEY2,
    GMT_MONEY3 = @PA_GMT_MONEY3
  where GMT_ID = @PA_GMT_ID;
end
go
