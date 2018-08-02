IF not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningDelegatesToCancel')
  EXEC ('create procedure dbo.spConsensusLearningDelegatesToCancel as select 1 as temp')
go

--EXEC spConsensusLearningDelegatesToCancel '82','web'
ALTER procedure [dbo].[spConsensusLearningDelegatesToCancel]
(
@PA_BOOK_ID varchar(11),
@PA_USER_LOGIN_ID varchar(10) = null
) 
AS 

DECLARE @SP_PA_DEL_ID varchar(11) = null
DECLARE @SP_PA_USER_LOGIN_ID varchar(10) = null

SET NOCOUNT ON;

BEGIN

IF ISNULL(@PA_BOOK_ID,'') <> ''
	BEGIN
	-- Create a temporary table that will store delegates to cancel
		DECLARE @TempTable TABLE(
		ID INT IDENTITY(1,1), 
		TEMP_DEL_ID varchar(11),
		TEMP_ELEM_ID varchar(11)
		);

		-- Insert delegates for the Book_ID into temporary table
		INSERT INTO @TempTable 
		SELECT DISTINCT DELEGATE.DEL_ID, Element.ELEM_ID
			FROM DELEGATE 
			INNER JOIN dbo.Element ON ELEM_DEL_ID=DEL_ID and ELEM_MAIN_SESSION=1 
			--left join dbo.MasterClubXref ON MCXREF_SELL_ELEM_ID = ELEM_ID
			WHERE DEL_BOOK_ID = @PA_BOOK_ID and ELEM_CANCELLED = 0
			AND ELEM_ID  NOT IN (SELECT elem_id FROM element WHERE elem_type = 24 and elem_book_id = DEL_BOOK_ID)
		
		DECLARE @totalDelegates INT
		DECLARE @I INT

		SELECT @I = 1
		SELECT @totalDelegates = COUNT(ID) FROM @TempTable

		--Loop into the delegates and call the stored procedure to cancel them
		WHILE (@I <= @totalDelegates)
			BEGIN
				SELECT @SP_PA_DEL_ID = TEMP_DEL_ID FROM @TempTable WHERE ID = @I
					SET @SP_PA_USER_LOGIN_ID = @PA_USER_LOGIN_ID

				EXEC spfnCancelDelegateOrElement @PA_DEL_ID = @SP_PA_DEL_ID, @PA_USER_LOGIN_ID = @SP_PA_USER_LOGIN_ID
				SET @I = @I+1
			END 

		SELECT *
		FROM DELEGATE 
		JOIN dbo.Element ON ELEM_DEL_ID=DEL_ID and ELEM_MAIN_SESSION = 1 
		WHERE DEL_BOOK_ID = @PA_BOOK_ID 
		AND ELEM_CANCELLED = 1
		AND Element.ELEM_STATUS in(2,9)
		AND  ELEM_ID not in (SELECT elem_id FROM element WHERE elem_type = 24 and elem_book_id = DEL_BOOK_ID)
			
	END
END
GO
