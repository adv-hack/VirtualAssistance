if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePriceListFetchAllByProductId')
  exec ('create procedure dbo.spConsensusFinancePriceListFetchAllByProductId as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePriceListFetchAllByProductId ( @PA_PROD_ID varchar(11) = null output) as 
begin

  select distinct Price_List.*
  from dbo.Price_List
  join dbo.Prices on PRS_PL_ID = PL_ID
  join dbo.Product on PROD_ID = PRS_PROD_ID
  where isNull(PRS_VALID_FROM, convert(datetime, convert(varchar, getDate(), 106))) <= convert(datetime, convert(varchar, getDate(), 106))
    and isNull(PRS_VALID_UNTIL, convert(datetime, convert(varchar, getDate(), 106))) >= convert(datetime, convert(varchar, getDate(), 106))
    and isNull(PL_VALID_FROM, convert(datetime, convert(varchar, getDate(), 106))) <= convert(datetime, convert(varchar, getDate(), 106))
    and isNull(PL_VALID_UNTIL, convert(datetime, convert(varchar, getDate(), 106))) >= convert(datetime, convert(varchar, getDate(), 106))
    and isNull(nullIf(@PA_PROD_ID, ''), PROD_ID) = Product.PROD_ID

end
