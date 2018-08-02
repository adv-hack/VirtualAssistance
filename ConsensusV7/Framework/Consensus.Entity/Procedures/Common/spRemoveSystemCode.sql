IF not exists (select object_id from sys.objects where type = 'P' and name = 'spRemoveSystemCode')
  EXEC ('create procedure dbo.spRemoveSystemCode as select 1 as temp')
go

-- EXEC spRemoveSystemCode 1582, null
ALTER procedure [dbo].[spRemoveSystemCode]
(@PA_CODE_ID varchar(11) = null, @PA_CODE_SYSTEM tinyint = null) as 
BEGIN
IF(@PA_CODE_SYSTEM = 1)
	BEGIN
	  UPDATE 
	  dbo.Code
	  SET CODE_DELETED = 1
	  where CODE_ID = @PA_CODE_ID AND CODE_SYSTEM = 1
	END
ELSE
	BEGIN
		DELETE FROM dbo.Code
		WHERE CODE_ID = @PA_CODE_ID
	END
END

 