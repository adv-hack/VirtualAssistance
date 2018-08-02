IF not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningConfirmedEvents')
  EXEC ('create procedure dbo.spConsensusLearningConfirmedEvents as select 1 as temp')
go
--EXEC spConsensusLearningConfirmedEvents 12
ALTER procedure [dbo].[spConsensusLearningConfirmedEvents]
(@PA_BOOK_ID varchar(11) = null output) as 
BEGIN
	SELECT *
				from BOOKING 
				inner join ELEMENT  on ELEM_BOOK_ID = BOOK_ID 
				inner join COURSE  on ELEM_COURSE_ID = COURSE_ID 
                left join dbo.Sys_Config ON SC_KEY_NAME = 'SC_CONFIRM_FINISHED_EVENT' and SC_SP_ID='1' 
				where BOOK_ID = @PA_BOOK_ID
				and isnull(ELEM_CANCELLED,0) = 0 
				and ELEM_STATUS <> 1 
				and substring(COURSE_STATUS,1,2) <> '38' 
				and substring(COURSE_STATUS,1,2) <> '39' 
                and (isnull(SC_INT_VALUE,0)=0 or substring(COURSE_STATUS,1,2) <> '80') 
END
GO

