IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusAccountInvoiceCreditNotes'))
BEGIN
	exec ('create view [dbo].[vConsensusAccountInvoiceCreditNotes] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusAccountInvoiceCreditNotes]

AS

SELECT distinct INV_ID,
INV_REF,
INV_DATE,
INV_BK_ORG_CUST_AC,
INV_PERSON_ID,
PROLE_PN_NAME,
INV_ORG_ID,
INV_INV_ORG_NAME,
INV_CURRENCY_TYPE,
INV_GROSS_TOTAL,
INV_DUE_DATE,
INV_UNPAID_VAL,
INV_ACC_ID,
INV_IN_RESPECT_OF,
INV_TYPE,
uri = 'finance/Invoice/' + convert(varchar, INV_ID)
from invheader
join Account on acc_id=INV_ACC_ID
left outer join dbo.PERSON_ROLE on PROLE_PERSON_ID = INV_PERSON_ID
GO


