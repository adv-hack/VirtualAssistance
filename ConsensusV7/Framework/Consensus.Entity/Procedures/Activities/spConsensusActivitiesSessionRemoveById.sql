if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesSessionRemoveById')
  exec ('create procedure dbo.spConsensusActivitiesSessionRemoveById as select 1 as temp')
go
alter PROCEDURE [dbo].[spConsensusActivitiesSessionRemoveById] (
	@PA_USER_LOGIN_ID varchar(3) = null,
	@PA_ERRORCODE int = null OUTPUT,
	@PA_ERRORDESC varchar(1000) = null OUTPUT,
	@PA_RETURN_ID varchar(11) = null OUTPUT,
	@PA_ACT_ID     varchar(11) = null
)

AS

declare
 	@ERRORCODE int, -- Local @@ERROR
 	@ERRORDESC varchar(1000), -- Local @@ERROR
 	@ROWCOUNT int, -- Local @@ROWCOUNT
 	@TRANCOUNT int,
	@SP_DB_ID varchar(3),
	@PA_USER_LOGIN_ID2 varchar(11),
	@OUTPUT_ERRORCODE int,
	@OUTPUT_ERRORDESC varchar(1000),
	@COURSE_ID VARCHAR(1000),
	@ELEM_COUNT int,
	@MAIN_SESSION int

if @PA_ACT_ID is null
BEGIN
	SELECT @ERRORCODE = -1,@ROWCOUNT = 1,@ERRORDESC = 'The ACT_ID must be passed'
	IF @ERRORCODE != 0 GOTO HANDLE_ERROR
END

--Cannot delete session if delegates are attached
set @COURSE_ID = (select top(1) SXREF_COURSE_ID FROM session_xref where SXREF_ACT_ID = @PA_ACT_ID)
Select @ELEM_COUNT = Count(ELEM_ID) from ELEMENT  where ELEM_ACT_ID = @PA_ACT_ID and ELEM_COURSE_ID = @COURSE_ID
if (@ELEM_COUNT > 0)
BEGIN
	SELECT @ERRORCODE = -1,@ROWCOUNT = 1,@ERRORDESC = 'This session canot be deleted because there are delegates attached to it.'
	IF @ERRORCODE != 0 GOTO HANDLE_ERROR
END

--Cannot delete main session
set @MAIN_SESSION = (Select top 1 SXREF_MAIN_SESSION from SESSION_XREF  where SXREF_ACT_ID = @PA_ACT_ID and SXREF_COURSE_ID = @COURSE_ID)
if(@MAIN_SESSION > 0)		
BEGIN
	SELECT @ERRORCODE = -1,@ROWCOUNT = 1,@ERRORDESC = 'You can not delete this session as it is the main session.'
	IF @ERRORCODE != 0 GOTO HANDLE_ERROR
END


set @PA_USER_LOGIN_ID2 = @PA_USER_LOGIN_ID
select @SP_DB_ID=SP_DB_ID from Sys_Params  where SP_ID = '1'

if datalength(@SP_DB_ID) > 0
BEGIN
	select @PA_USER_LOGIN_ID2 = @PA_USER_LOGIN_ID2 + '-' + @SP_DB_ID
END

BEGIN
	-- Now Delete the Session Records
	delete from SESSION_XREF where SXREF_ACT_ID = @PA_ACT_ID and SXREF_COURSE_ID = @COURSE_ID

	update EVENT_TICKET_TYPE set ETT_PRICE = 
	(Select sum(isnull(SXREF_PRICE,0)) from SESSION_XREF
		where SXREF_ETT_ID = ETT_ID 
		and SXREF_COURSE_ID = @COURSE_ID
		and SXREF_MANDATORY = 1 
		and SXREF_ELEMENT = 1)
	where ETT_COURSE_ID = @COURSE_ID

	update EVENT_TICKET_TYPE set ETT_BLOCK_PRICE = 
	(Select sum(isnull(SXREF_BLOCK_PRICE,0)) from SESSION_XREF 
		where SXREF_ETT_ID = ETT_ID 
		and SXREF_COURSE_ID = @COURSE_ID
		and SXREF_MANDATORY = 1 
		and SXREF_ELEMENT = 1) 
	where ETT_COURSE_ID = @COURSE_ID

	declare @XREF_COUNT int = (Select Count(*) from SESSION_XREF  where SXREF_ACT_ID = @PA_ACT_ID and SXREF_COURSE_ID <> @COURSE_ID)
	if @XREF_COUNT = 0 
	BEGIN	
		exec spDeleteActivityXrefs @PA_USER_LOGIN_ID ,null,null,null, @PA_ACT_ID, null
		Delete FROM ACTIVITY where ACT_ID = @PA_ACT_ID
	END

	exec spCalculateCourseNumbers @PA_USER_LOGIN_ID,@PA_ACT_ID
END


set @PA_ERRORCODE = 0
set @PA_RETURN_ID = @PA_ACT_ID
set @PA_ERRORDESC = ''
Return

HANDLE_ERROR:
	if @TRANCOUNT = 0
	BEGIN
		ROLLBACK TRAN
	END
	set @PA_ERRORCODE = @ERRORCODE
	set @PA_ERRORDESC = @ERRORDESC
	Return

GO
