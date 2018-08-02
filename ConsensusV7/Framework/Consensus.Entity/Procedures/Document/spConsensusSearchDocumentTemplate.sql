if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchDocumentTemplate')
  exec ('create procedure dbo.spConsensusSearchDocumentTemplate as select 1 as temp')
go
alter procedure dbo.spConsensusSearchDocumentTemplate
( 
@DOC_TMP_NAME varchar(500) = null, 
@PACK_TYPE_ID int,
@DOC_TMP_TYPE int,
@SELCO_SP_ID varchar(10)
) 
as
begin
DECLARE @PACK_TYPE_NAME varchar(100)
SET @PACK_TYPE_NAME = (SELECT PACKTYP_DESC from PackType WHERE PACKTYP_TYPE = @PACK_TYPE_ID)

IF(@DOC_TMP_TYPE = 0)

		select LIT_NAME AS Name,'Word' As [Type],LIT_ID AS ID,SP_SELL_COMP_NAME 
		from
		literature 
		left join 
		dbo.LetterTmplt on LT_ID=LIT_LT_ID
		left join LetTmpltType on lt_type = ltt_id
		left join Sys_Params on SP_ID = LT_SELCO_SP_ID
		WHERE LIT_CURRENT=1
		AND LIT_NAME like isNull(nullIf(@DOC_TMP_NAME, '') + '%', LIT_NAME)
		AND LIT_TYPE = @PACK_TYPE_ID
		AND LT_SELCO_SP_ID = isNull(nullIf(@SELCO_SP_ID,''),LT_SELCO_SP_ID)
		order by LT_NAME

ELSE IF (@DOC_TMP_TYPE = 1)

		Select SMS_NAME As Name,'SMS' As [Type],SMS_ID AS ID,SP_SELL_COMP_NAME
		From dbo.SMS_Message 
		join dbo.SMS_Type on SMT_ID=SMS_SMT_ID
		left join Sys_Params on SP_ID = SMS_SELCO_SP_ID
		WHERE
		SMS_Current = 1
		AND SMS_SELCO_SP_ID = isNull(nullIf(@SELCO_SP_ID,''),SMS_SELCO_SP_ID)
		AND SMS_NAME like isNull(nullIf(@DOC_TMP_NAME, '') + '%', SMS_NAME)		
		AND ((@PACK_TYPE_ID <> 0 AND  [SMT_NAME] = @PACK_TYPE_NAME)
		OR (@PACK_TYPE_ID = 0  AND [SMT_NAME] in ('Booking', 'Delegate') ))
ELSE
		
		select ICM_NAME As Name, 'iCalendar' As [Type],ICM_ID AS ID,SP_SELL_COMP_NAME
        	from [dbo].[iCalMessage] 
       		inner join [dbo].[iCalMessageType] on [iCalMessageType].[ICMT_ID] = [iCalMessage].[ICM_ICMT_ID] 
		left join Sys_Params on SP_ID = ICM_SELCO_SP_ID
        	where ICM_CURRENT = 1 		
		AND ICM_SELCO_SP_ID = isNull(nullIf(@SELCO_SP_ID,''),ICM_SELCO_SP_ID)
		AND ICM_NAME like isNull(nullIf(@DOC_TMP_NAME, '') + '%', ICM_NAME)  
		AND ((@PACK_TYPE_ID <> 0 AND  [ICMT_NAME] = @PACK_TYPE_NAME)
		OR (@PACK_TYPE_ID = 0  AND [ICMT_NAME] in ('Booking', 'Delegate') ))	  
		  
end
