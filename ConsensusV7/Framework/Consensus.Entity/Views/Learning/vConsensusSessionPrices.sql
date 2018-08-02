if not exists (select object_id from sys.objects where name = 'vConsensusSessionPrices' and type = 'v')
  exec ('create view dbo.vConsensusSessionPrices as select 1 as temp')
go

alter view dbo.vConsensusSessionPrices as 
		SELECT 
		SXREF_ID AS PRS_ID, 
		SXREF_PL_ID,
		SXREF_ACT_ID,
		SXREF_EP_ID,
		PL_NAME AS PL_NAME,
		SXREF_VALID_FROM AS PRS_VALID_FROM,
		SXREF_VALID_UNTIL AS PRS_VALID_UNTIL,
		SXREF_REGION AS PRS_REGION,
		ISNULL(SXREF_QTY_MIN,0) PRS_QTY_MIN,
		ISNULL(SXREF_QTY_MAX,0) PRS_QTY_MAX,
		ISNULL(sxref_start_day,0) PRS_START,
		ISNULL(sxref_end_day,0) PRS_END,
		CASE WHEN SXREF_BLOCK_PRICE > 0 THEN 'Block'
			WHEN SXREF_MEMBER > 0 THEN 'Member'
			ELSE 'Standard' 
			END AS PRS_TYPE, 
		SXREF_CURRENCY as PRS_CURR_TYPE,
		CASE  WHEN SXREF_BLOCK_PRICE > 0 THEN SXREF_BLOCK_PRICE ELSE SXREF_PRICE END AS PRS_PRICE,
		SXREF_COST_PRICE AS PRS_COST_PRICE,
		SXREF_RETAIL_PRICE AS PRS_RETAIL_PRICE,
		CASE SXREF_VALID_DATE WHEN 0 THEN 'Booking' WHEN 1 THEN 'Event' ELSE 'N/A' END AS PRS_VALID_DATE, 
		uri = 'learning/sessionxref/' + CONVERT(VARCHAR, SXREF_ID)
	FROM dbo.session_xref
	JOIN dbo.Price_List ON PL_ID=SXREF_PL_ID

go