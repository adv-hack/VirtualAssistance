if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonGenericmodeltableValidateDelegate')
  exec ('create procedure dbo.spConsensusCommonGenericmodeltableValidateDelegate as select 1 as temp')
go
alter procedure dbo.spConsensusCommonGenericmodeltableValidateDelegate
(
@PA_USER_LOGIN_ID varchar(10) = null output,
@PA_COURSE_ID varchar(11) = null,
@PA_PROLE_ID varchar(11) = null output,
@PA_QUAL_ID varchar(11) = null output,
@PA_IGNORE_FREE_PLACES tinyint = 0 output,
@PA_PROLE_IDs varchar(240) = null output,
@PA_SCHN_NUMBER tinyint = 1 output, -- 1 = Application (Back Office), 2 = Web (API), 3 = On Site (Portal),
@PA_DEL_QUANTITY int = 1 output,
@PA_CURRENT_USER bit = 0 output
) as 
begin

	declare 
	@ERRORCODE int,
	@ERRORDESC varchar(1000),
	@WARNINGS varchar(500),
	@RETURN_ID varchar(11)

	exec dbo.spValidateNewDelegate
		@PA_USER_LOGIN_ID = @PA_USER_LOGIN_ID,
		@PA_ERRORCODE = @ERRORCODE OUTPUT,
		@PA_ERRORDESC = @ERRORDESC OUTPUT,
		@PA_RETURN_ID = @RETURN_ID OUTPUT,
		@PA_WARNINGS = @WARNINGS OUTPUT,
		@PA_COURSE_ID = @PA_COURSE_ID,
		@PA_PROLE_ID = @PA_PROLE_ID,
		@PA_QUAL_ID = @PA_QUAL_ID,
		@PA_IGNORE_FREE_PLACES = @PA_IGNORE_FREE_PLACES,
		@PA_PROLE_IDs = @PA_PROLE_IDs,
		@PA_SCHN_NUMBER = @PA_SCHN_NUMBER,
		@PA_DEL_QUANTITY = @PA_DEL_QUANTITY,
		@PA_CURRENT_USER = @PA_CURRENT_USER


	if (@RETURN_ID = '0') --warning
	begin
		  select '' GMT_ID,'' GMT_ID1,'' GMT_ID2,'' GMT_ID3,'' GMT_ID4,'' GMT_ID5,'' GMT_DESC1,'' GMT_DESC2,'' GMT_DESC3,'' GMT_DESC4,'' GMT_DESC5,@WARNINGS GMT_LONGDESC,null GMT_DATE1,null GMT_DATE2,null GMT_DATE3,1 GMT_INT1,0 GMT_INT2,0 GMT_INT3,0 GMT_MONEY1,0 GMT_MONEY2,0 GMT_MONEY3
	end
	else if (@RETURN_ID = '-1') --stop
	begin
		select '' GMT_ID,'' GMT_ID1,'' GMT_ID2,'' GMT_ID3,'' GMT_ID4,'' GMT_ID5,@ERRORCODE GMT_DESC1,'' GMT_DESC2,'' GMT_DESC3,'' GMT_DESC4,'' GMT_DESC5,@ERRORDESC GMT_LONGDESC,null GMT_DATE1,null GMT_DATE2,null GMT_DATE3,2 GMT_INT1,0 GMT_INT2,0 GMT_INT3,0 GMT_MONEY1,0 GMT_MONEY2,0 GMT_MONEY3
	end
	else
	begin
		  select '' GMT_ID,'' GMT_ID1,'' GMT_ID2,'' GMT_ID3,'' GMT_ID4,'' GMT_ID5,'' GMT_DESC1,'' GMT_DESC2,'' GMT_DESC3,'' GMT_DESC4,'' GMT_DESC5,'' GMT_LONGDESC,null GMT_DATE1,null GMT_DATE2,null GMT_DATE3,0 GMT_INT1,0 GMT_INT2,0 GMT_INT3,0 GMT_MONEY1,0 GMT_MONEY2,0 GMT_MONEY3
	end
end