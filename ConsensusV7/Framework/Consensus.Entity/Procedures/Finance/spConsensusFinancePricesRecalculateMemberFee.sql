if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePricesRecalculateMemberFee')
  exec ('create procedure dbo.spConsensusFinancePricesRecalculateMemberFee as select 1 as temp')
go
alter procedure [dbo].[spConsensusFinancePricesRecalculateMemberFee] (@PA_PRODUCT_ID varchar(11) = null output,@PA_START_DATE datetime = null,
@PA_END_DATE datetime = null,@PA_PRICE_LIST_ID varchar(11) = null, @PA_QTY_TOTAL int = 0) as 
begin
SELECT  PRS_ID
      ,PRS_LOCK
      ,PRS_ADD_DATE
      ,PRS_ADD_BY
      ,PRS_MOD_DATE
      ,PRS_MOD_BY
      ,PRS_RCV_DATE
      ,PRS_RCV_FROM
      ,PRS_PL_ID
      ,PRS_PROD_ID
      ,mp.PRS_PRICE
      ,PRS_BLOCK_PRICE
      ,PRS_SPARE_PRICE
      ,PRS_COST_PRICE
      ,PRS_COST_CODE
      ,PRS_REV_CODE
      ,PRS_DISC_SCHED
      ,mp.PRS_VAT_CODE
      ,PRS_RETAIL_PRICE
      ,PRS_NO_COST_NO_SEL
      ,PRS_DEFAULT
      ,PRS_GL_CODE1
      ,PRS_GL_CODE2
      ,PRS_PROD_CATEGORY
      ,PRS_DISC_PERCENT
      ,mp.PRS_PRICE_A
      ,PRS_PRICE_B
      ,PRS_PRICE_C
      ,PRS_PRICE_D
      ,PRS_PRICE_E
      ,PRS_GROUP_QTY
      ,PRS_GROUP_DTE
      ,PRS_GROUP_QTY_ID
      ,PRS_GROUP_DTE_ID
      ,PRS_QTY_MIN
      ,PRS_QTY_MAX
      ,PRS_VALID_FROM
      ,PRS_VALID_UNTIL
      ,PRS_BEFORE_DAYS
      ,mp.PRS_VAT_CODE2
      ,PRS_START_DATE
      ,PRS_END_DATE
      ,PRS_QUAL_ID
      ,PRS_PREPAY_PROD_ID
      ,PRS_LINE_ID
      ,PRS_SEAS_ID
      ,PRS_INC_PLACES
      ,PRS_SUB_PRICE_1
      ,PRS_SUB_PRICE_2
      ,PRS_SUB_PRICE_3
      ,PRS_SUB_PRICE_4
      ,PRS_SUB_PRICE_5
      ,PRS_SUB_PRICE_6
      ,PRS_SUB_PRICE_7
      ,PRS_SUB_PRICE_8
      ,PRS_SUB_PRICE_9
      ,PRS_CURR_TYPE
      ,PRS_DO_NOT_RECALC
      ,PRS_SCHN_NUMBER
      ,PRS_MEMB_PRICE
      ,PRS_START
      ,PRS_END
      ,PRS_DESC
      ,PRS_PRS_ID
      ,PRS_WEB
      ,PRS_VALID_DATE
      ,PRS_REGION
      ,PRS_TYPE
      ,PRS_SEA_ID
      ,PRS_PRO_RATA
	FROM dbo.fnGetMemberPrice(@PA_PRODUCT_ID, @PA_PRICE_LIST_ID, @PA_QTY_TOTAL ,@PA_START_DATE,@PA_END_DATE) mp
	LEFT JOIN Prices p on prs_id =null
end

GO


