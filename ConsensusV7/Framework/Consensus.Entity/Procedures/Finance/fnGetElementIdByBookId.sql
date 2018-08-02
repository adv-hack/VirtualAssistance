if exists (select object_id from sys.objects where type = 'FN' and name = 'fnGetElementIdByBookId')
  DROP FUNCTION fnGetElementIdByBookId
go


Create function [dbo].[fnGetElementIdByBookId](@bookid nvarchar(30)) Returns NVARCHAR(20)
AS
BEGIN
	
	DECLARE @ELEM_ID nvarchar(20)

	set @ELEM_ID = (select TOP 1 ELEM_TYPE from booking
	left join dbo.Delegate on DEL_BOOK_ID = BOOK_ID
	left join dbo.Element on ELEM_DEL_ID = DEL_ID
	where BOOK_ID=@bookid)

	RETURN @ELEM_ID
END

GO


