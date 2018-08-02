if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonGenericmodeltableFetchAllByProdIdPrices')
  exec ('create procedure dbo.spConsensusCommonGenericmodeltableFetchAllByProdIdPrices as select 1 as temp')
go
alter procedure dbo.spConsensusCommonGenericmodeltableFetchAllByProdIdPrices(@PA_PROD_ID varchar(11) = null output,@PA_QTY tinyint = 1 output) as 
begin
	declare @TodaysDate datetime

	set @TodaysDate = getdate()

	select distinct 
    PRS_ID GMT_ID,
    PRS_PL_ID GMT_ID1,
    @PA_PROD_ID GMT_ID2,
    '' GMT_ID3,
    '' GMT_ID4,
    '' GMT_ID5,
    '' GMT_DESC1,
    PL_NAME GMT_DESC2,
    '' GMT_DESC3,
    '' GMT_DESC4,
    '' GMT_DESC5,
    '' GMT_LONGDESC,
    null GMT_DATE1,
    null GMT_DATE2,
    null GMT_DATE3,
    0 GMT_INT1,
    0 GMT_INT2,
    P_ELEM_TYPE GMT_INT3,
    PRS_PRICE GMT_MONEY1,
    0 GMT_MONEY2,
    0 GMT_MONEY3	
	from dbo.Prices
	join dbo.Price_List ON PL_ID=PRS_PL_ID
	join dbo.Product ON PROD_ID=PRS_PROD_ID
	join dbo.vPROD_SY_PRODUCT_TO_ELEM_TYPE ON P_PROD_SY_PRODUCT = PROD_SY_PRODUCT
	where PRS_PROD_ID=@PA_PROD_ID
	and PL_STATUS=1 
	and isNull(PRS_VALID_FROM, convert(datetime, convert(varchar, @TodaysDate, 106))) <= convert(datetime, convert(varchar, @TodaysDate, 106))
    and isNull(PRS_VALID_UNTIL, convert(datetime, convert(varchar, @TodaysDate, 106))) >= convert(datetime, convert(varchar, @TodaysDate, 106))
	and ((@PA_QTY between isnull(PRS_QTY_MIN,0) and isnull(PRS_QTY_MAX,0)) 
	or (isnull(PRS_QTY_MIN,0) = 0 and isnull(PRS_QTY_MAX,0)=0))
end
go
