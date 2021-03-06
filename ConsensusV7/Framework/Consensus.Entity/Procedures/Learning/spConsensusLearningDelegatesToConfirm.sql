IF not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningDelegatesToConfirm')
  EXEC ('create procedure dbo.spConsensusLearningDelegatesToConfirm as select 1 as temp')
go

--EXEC spConsensusLearningDelegatesToConfirm 131,'Sup'
ALTER procedure [dbo].[spConsensusLearningDelegatesToConfirm]
(
@PA_BOOK_ID varchar(11) = null, @PA_USER_LOGIN_ID varchar(10),
@PA_ERRORCODE int = null OUTPUT,
@PA_ERRORDESC varchar(1000) = null OUTPUT,
@PA_RETURN_ID varchar(11) = null OUTPUT
) 
AS 

DECLARE @SP_PA_USER_LOGIN_ID varchar(10)
DECLARE @SP_PA_ERRORCODE int = null
DECLARE @SP_PA_ERRORDESC varchar(1000) = null
DECLARE @SP_PA_RETURN_ID varchar(11) = null
DECLARE @SP_PA_ELEM_ID varchar(11) = null
DECLARE @SP_PA_DEL_ID varchar(11) = null
DECLARE @SP_PA_APPROVER varchar(10) = null

SET NOCOUNT ON;

BEGIN
-- Create/ Declare Temporary Table variable
declare @TempTable table(
	ID INT IDENTITY(1,1), 
	Temp_DEL_ID varchar(11),
	Temp_ELEM_GRP_ID varchar(11)
	);

-- Insert the delegates into Temporary Variable if Delegates Exist
declare @delCount int

SELECT @delCount = count(DELEGATE.DEL_ID) FROM DELEGATE join dbo.Element ON ELEM_DEL_ID=DEL_ID and ELEM_MAIN_SESSION=1 WHERE DEL_BOOK_ID = @PA_BOOK_ID and ELEM_STATUS in (0,11) and ELEM_ID not in (SELECT elem_id FROM element WHERE elem_type = 24 and elem_book_id = DEL_BOOK_ID)
print @delCount
IF(SELECT count(DELEGATE.DEL_ID) FROM DELEGATE join dbo.Element ON ELEM_DEL_ID=DEL_ID and ELEM_MAIN_SESSION=1 WHERE DEL_BOOK_ID = @PA_BOOK_ID and ELEM_STATUS in (0,11) and ELEM_ID not in (SELECT elem_id FROM element WHERE elem_type = 24 and elem_book_id = DEL_BOOK_ID)) > 0
	BEGIN	
		INSERT INTO @TempTable 
			SELECT DELEGATE.DEL_ID, Element.ELEM_GRP_ID
			FROM DELEGATE 
			join dbo.Element ON ELEM_DEL_ID=DEL_ID and ELEM_MAIN_SESSION=1 
			WHERE DEL_BOOK_ID = @PA_BOOK_ID
			and ELEM_STATUS in (0,11) 
			and ELEM_ID not in (SELECT elem_id FROM element WHERE elem_type = 24 and elem_book_id = DEL_BOOK_ID)
	
	
		DECLARE @totalRecords INT
		DECLARE @I INT

		SELECT @I = 1
		SELECT @totalRecords = COUNT(ID) FROM @TempTable

		--Loop into the delegates and call the stored procedure to confirm them
			WHILE (@I <= @totalRecords)
			BEGIN
				SELECT @SP_PA_DEL_ID = Temp_DEL_ID FROM @TempTable WHERE ID = @I
					SET @SP_PA_USER_LOGIN_ID = @PA_USER_LOGIN_ID
					SET @SP_PA_APPROVER = @PA_USER_LOGIN_ID
			
				EXEC spfnConfirmDelegateOrElement @SP_PA_USER_LOGIN_ID, @PA_ERRORCODE output, @PA_ERRORDESC OUTPUT, @PA_RETURN_ID OUTPUT,NULL,@SP_PA_DEL_ID, @SP_PA_APPROVER
				set @I = @I+1
			END 

			--Return the delegates that ha Element Status = 1 (40- confirmed)
			SELECT *
			FROM DELEGATE 
			JOIN dbo.Element ON ELEM_DEL_ID=DEL_ID and ELEM_MAIN_SESSION = 1 
			WHERE DEL_BOOK_ID = @PA_BOOK_ID 
			AND Element.ELEM_STATUS = 1
			AND  ELEM_ID not in (SELECT elem_id FROM element WHERE elem_type = 24 and elem_book_id = DEL_BOOK_ID)

	END
END
GO
