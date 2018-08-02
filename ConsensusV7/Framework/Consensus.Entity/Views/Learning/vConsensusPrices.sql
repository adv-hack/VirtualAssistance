if not exists (select object_id from sys.objects where name = 'vConsensusPrices' and type = 'v')
  exec ('create view dbo.vConsensusPrices as select 1 as temp')
go

alter view dbo.vConsensusPrices as 
	select PRS_ID,PRS_PL_ID,PRS_PROD_ID,PL_NAME,PRS_VALID_FROM,PRS_VALID_UNTIL,PRS_REGION,isnull(PRS_QTY_MIN,0) PRS_QTY_MIN,isnull(PRS_QTY_MAX,0) PRS_QTY_MAX,
		isnull(PRS_START,0) PRS_START,isnull(PRS_END,0) PRS_END,COALESCE(CODE_VALUE1,'Standard') PRS_TYPE,PRS_CURR_TYPE,
		PRS_PRICE,PRS_COST_PRICE,PRS_RETAIL_PRICE,
		case PRS_VALID_DATE when 0 then 'Booking' when 1 then 'Event' else 'N/A' end PRS_VALID_DATE, uri = 'finance/price/' + convert(varchar, PRS_ID)
	from dbo.Prices
	join dbo.Price_List ON PL_ID=PRS_PL_ID
	left join dbo.Code ON CODE_VALUE3 = PRS_TYPE and CODE_TYPE = 'PRSTY'

go