IF not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipInvoiceToCreate')
  EXEC ('create procedure dbo.spConsensusMembershipInvoiceToCreate as select 1 as temp')
go

--EXEC spConsensusMembershipInvoiceToCreate '81','sup',1
ALTER procedure [dbo].spConsensusMembershipInvoiceToCreate
(
@PA_INV_MEP_ID varchar(11),
@PA_USER_LOGIN_ID varchar(10),
@PA_FROM_MEMBERSHIP tinyint = 0,
@PA_ERRORDESC varchar(1000) = null OUTPUT,
@PA_RETURN_ID varchar(11) = null OUTPUT
)
AS 
DECLARE
@ERRORCODE int, -- Local @@ERROR,
@ERRORDESC varchar(1000),
@ROWCOUNT int,
@OUTPUT_ERRORCODE int,
@OUTPUT_ERRORDESC varchar(1000)

SET NOCOUNT ON;

BEGIN

if @PA_FROM_MEMBERSHIP = 1 AND datalength(isnull(@PA_INV_MEP_ID,'')) > 0 
	BEGIN
	DECLARE @PA_ERRORCODE_1 int,@PA_ERRORDESC_1 varchar(max)
		
		EXEC dbo.spInsertUpdateInvHeader
			@PA_INV_MEP_ID = @PA_INV_MEP_ID, 
			@PA_USER_LOGIN_ID = @PA_USER_LOGIN_ID,
			@PA_FROM_MEMBERSHIP = '1',
			@PA_ERRORCODE=@PA_ERRORCODE_1 OUTPUT,
			@PA_ERRORDESC = @PA_ERRORDESC_1 OUTPUT

	END
		
			--SELECT * FROM dbo.InvHeader
			--WHERE INV_MEP_ID= @PA_INV_MEP_ID and INV_ADD_DATE>convert(DATETIME,convert(VARCHAR,getdate(),106) + ' 00:00') 
			--ORDER BY INV_ADD_DATE DESC

			select top(1) MEL_INVOICED,* from dbo.InvHeader
			left join MEMBER_LOCATION on MEL_MEP_ID =INV_MEP_ID
			where INV_MEP_ID=@PA_INV_MEP_ID and INV_ADD_DATE>convert(datetime,convert(varchar,getdate(),106) + ' 00:00') 
			and MEL_INVOICED = 1
			order by INV_ADD_DATE desc

END
GO




