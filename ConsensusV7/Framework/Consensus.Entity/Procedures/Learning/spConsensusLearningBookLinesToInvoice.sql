IF not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningBookLinesToInvoice')
  EXEC ('create procedure dbo.spConsensusLearningBookLinesToInvoice as select 1 as temp')
go
--EXEC spConsensusLearningBookLinesToInvoice 12
ALTER procedure [dbo].[spConsensusLearningBookLinesToInvoice]
(@PA_BOOK_ID varchar(11) = null output) as 
BEGIN
	SELECT *
				from BOOKING 
				inner join ELEMENT  on ELEM_BOOK_ID = BOOK_ID 
				where BOOK_ID = @PA_BOOK_ID
				AND ISNULL(ELEM_INVOICED,0)=0 AND ISNULL(ELEM_CANCELLED,0)=0
				and ELEM_STATUS NOT IN (10,11,99,98) 
				AND ELEM_TYPE <> 41
				
END
GO
