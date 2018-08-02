IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusInvoiceLines'))
BEGIN
	exec ('create view [dbo].[vConsensusInvoiceLines] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusInvoiceLines

AS

Select 
INVLN_ID,
INVLN_INV_ID, 
INVLN_PROD_NAME, 
INVLN_COST_CODE, 
INVLN_PRD_REV_CODE, 
MEM_REF, 
INVLN_BOOK_ID,
INVLN_QTY,
INVLN_UNIT_PRICE,
INVLN_NET,
INVLN_VAT_CODE,
INVLN_TOTAL_PRICE,
INVLN_DESCRIPTION,
INVLN_ADD_DATE,
INVLN_PRODUCT_ID,
PROD_NAME,
MEL_MEP_ID,
case PROD_SY_PRODUCT
	when 0 then 'learning/productpage.aspx?id=' + cast(PROD_ID as varchar(11))
	when 1 then 'learning/coursepage.aspx?id=' + cast(PROD_ID as varchar(11))
	when 29 then 'learning/donationpage.aspx?id=' + cast(PROD_ID as varchar(11))
	when 10 then 'membership/membershipproductpage.aspx?id='+ cast(PROD_ID as varchar(11))
	when 8 then 'learning/elearningpage.aspx?id='+ cast(PROD_ID as varchar(11))
	else ''
end PROD_URL,
case dbo.fnGetElementIdByBookId(INVLN_BOOK_ID)
	when 29 then 'learning/donationbookingpage.aspx?id=' + cast(INVLN_BOOK_ID as varchar(11))	
	else 'learning/bookingpage.aspx?id=' + cast(INVLN_BOOK_ID as varchar(11))
end book_URL,
uri = 'finance/InvoiceLine/' + convert(varchar, INVLN_ID)
from dbo.INVLINE 
left join dbo.MEMBER_LOCATION on MEL_ID =  INVLN_MEL_ID
left join dbo.MEMBERSHIP on MEM_ID = MEL_MEM_ID
left join dbo.Product ON PROD_ID=INVLN_PRODUCT_ID

GO