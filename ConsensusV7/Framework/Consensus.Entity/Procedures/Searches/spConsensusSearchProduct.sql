if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchProduct')
  exec ('create procedure dbo.spConsensusSearchProduct as select 1 as temp')
go

-- EXEC spConsensusSearchProduct @PA_PROD_SY_PRODUCT = 17
alter procedure dbo.spConsensusSearchProduct 
( 
@PA_PROD_ID varchar(11) = null , 
@PA_PROD_NAME varchar(250) = null,
@PA_PROD_REF varchar(250) = null,
@PA_PROD_TYPE varchar(250) = null,
@PA_PROD_CATEGORY varchar(250) = null,
@PA_PROD_GROUP varchar(100) = null,
@PA_PROD_SY_PRODUCT varchar(100) = null,
@PA_PROD_STATE integer = null
) 
as
begin

	declare @SyProduct table
	(
	SY_PROD_SY_PRODUCT varchar(10)
	)

	insert into @SyProduct select * from dbo.fnGetTableFromColumn(@PA_PROD_SY_PRODUCT,'|') 
	if (select count(1) from @SyProduct)=0
	begin
		insert into @SyProduct select PROD_SY_PRODUCT from dbo.vPROD_SY_PRODUCT
	end

	SELECT PROD_ID, PROD_NAME, PROD_REF, PROD_SY_PRODUCT_DESC, PROD_TYPE,PRS_PRICE ,
	PROD_PRICE = CASE ISNULL(PRS_PRICE, '')  WHEN '' THEN  0 ELSE PRS_PRICE END,
	 --ISNULL(PRS_PRICE, 0) as PROD_PRICE, 
	PROD_VAT_CODE,PROD_CATEGORY,PROD_GROUP,p.PROD_SY_PRODUCT PROD_SY_PRODUCT, CODE_VALUE3,isnull(convert(int,LEFT(NULLIF(PROD_DEF_ELEM_ST,''),2)),0) PROD_DEF_ELEM_ST
	FROM dbo.Product p
	Join dbo.vPROD_SY_PRODUCT sy ON p.PROD_SY_PRODUCT = sy.PROD_SY_PRODUCT
	join @SyProduct ON SY_PROD_SY_PRODUCT = sy.PROD_SY_PRODUCT
	Left Join(SELECT  distinct PRS_PRICE,PRS_PROD_ID
    FROM(SELECT *,DENSE_RANK()  OVER (PARTITION BY PRS_PROD_ID ORDER BY PRS_PRICE ) as Rank    
    FROM dbo.Prices ) AS Derived where rank=1 )GroupPrices1 on GroupPrices1.PRS_PROD_ID = PROD_ID 
	left join Code on CODE_VALUE1 =  PROD_VAT_CODE
	where  Code.CODE_TYPE = 'VATCD'
	AND PROD_ID = isNull(nullIf(@PA_PROD_ID, ''), PROD_ID)
	  and PROD_NAME like isNull(nullIf(@PA_PROD_NAME, '') + '%', PROD_NAME)
	  and isnull(PROD_REF,'') like isNull(nullIf(@PA_PROD_REF, '') + '%', isnull(PROD_REF,''))
	  and isnull(PROD_TYPE,'') like isNull(nullIf(@PA_PROD_TYPE, '') + '%', isnull(PROD_TYPE,''))
	  and isnull(PROD_CATEGORY,'') like isNull(nullIf(@PA_PROD_CATEGORY, '') + '%', isnull(PROD_CATEGORY,''))
	  and isnull(PROD_GROUP,'') like isNull(nullIf(@PA_PROD_GROUP, '') + '%', isnull(PROD_GROUP,''))
	  and isNull(@PA_PROD_STATE, PROD_STATE) = PROD_STATE
	  --and p.PROD_SY_PRODUCT = isNull(nullIf(@PA_PROD_SY_PRODUCT, ''), p.PROD_SY_PRODUCT)
			
	order by PROD_NAME

end