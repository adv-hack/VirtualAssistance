--Created view as converted INV_DATE and INV_DUE_DATE was required
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusSearchInvoice'))
BEGIN
	exec ('create view [dbo].[vConsensusSearchInvoice] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusSearchInvoice]

as

Select INV_ID, INV_TYPE, INV_REF, INV_DATE, convert(datetime,convert(varchar,INV_DATE,103),103) as INV_DATE_CONVERTED, INV_CURRENCY_TYPE, INV_GROSS_TOTAL, INV_UNPAID_VAL, INV_UNPAID_VAL_BC, 
			INV_CURR_RATE_BC,INV_BOOK_ID,INV_MEP_ID, INV_BK_ORG_CUST_AC, INV_PERSON_ID, INV_ORG_ID, PN_FIRST_NAME, 
			PN_SURNAME, ORG_NAME, INV_DUE_DATE, convert(datetime,convert(varchar,INV_DUE_DATE,103),103) as INV_DUE_DATE_CONVERTED, PROLE_PN_NAME, INV_ADD_DATE  
			from InvHeader
			LEFT OUTER JOIN Person on PN_ID = INV_PERSON_ID
			LEFT OUTER JOIN Organisation on ORG_ID = INV_ORG_ID
			LEFT OUTER JOIN (
				SELECT DISTINCT PROLE_PERSON_ID, PROLE_PN_NAME from Person_Role			
			) as Person_Role on PROLE_PERSON_ID = PN_ID			

GO


IF NOT EXISTS (SELECT object_id FROM sys.objects WHERE type = 'P' and name = 'spConsensusSearchInvoice')
  exec ('create procedure dbo.spConsensusSearchInvoice as select 1 as temp')
go

ALTER PROCEDURE dbo.spConsensusSearchInvoice (
 @PA_INV_REF varchar(250) = null,
 @PA_INV_BK_ORG_CUST_AC varchar(250) = null,
 @PA_PN_SURNAME  varchar(250) = null,
 @PA_ORG_NAME varchar(250) = null,
 @PA_INV_DATE_AFTER DATETIME = null,
 @PA_INV_DATE_BEFORE DATETIME = null,
 @PA_INV_DUE_DATE_AFTER DATETIME = null,
 @PA_INV_DUE_DATE_BEFORE DATETIME = null,
 @PA_INV_CURRENCY_TYPE varchar(100) = null,
 @PA_INV_UNPAID_VAL varchar(100) = null
 ) AS

BEGIN

SELECT * FROM vConsensusSearchInvoice
			WHERE isnull(INV_REF,'') like isNull(nullIf(@PA_INV_REF, '') + '%', isnull(INV_REF,''))
					AND isnull(INV_BK_ORG_CUST_AC,'') like isNull(nullIf(@PA_INV_BK_ORG_CUST_AC, '') + '%', isnull(INV_BK_ORG_CUST_AC,''))						
					AND isnull(PN_SURNAME,'') like isNull(nullIf(@PA_PN_SURNAME, '') + '%', isnull(PN_SURNAME,''))
					AND isnull(ORG_NAME,'') like isNull(nullIf(@PA_ORG_NAME, '') + '%', isnull(ORG_NAME,''))
					AND (INV_DATE_CONVERTED <= (nullIf(@PA_INV_DATE_BEFORE, '')) or isNull(@PA_INV_DATE_BEFORE, '') = '')
					AND (INV_DATE_CONVERTED >= (nullIf(@PA_INV_DATE_AFTER, '')) or isNull(@PA_INV_DATE_AFTER, '') = '')	
					AND (INV_DUE_DATE_CONVERTED <= (nullIf(@PA_INV_DUE_DATE_BEFORE, '')) or isNull(@PA_INV_DUE_DATE_BEFORE, '') = '')
					AND (INV_DUE_DATE_CONVERTED >= (nullIf(@PA_INV_DUE_DATE_AFTER, '')) or isNull(@PA_INV_DUE_DATE_AFTER, '') = '')	  											
					AND isnull(INV_CURRENCY_TYPE,'') = isNull(nullIf(@PA_INV_CURRENCY_TYPE, ''), isnull(INV_CURRENCY_TYPE,''))
					AND (isnull(INV_UNPAID_VAL, '') > (nullIf(@PA_INV_UNPAID_VAL, '')) or isNull(@PA_INV_UNPAID_VAL, '') = '')						
					AND INV_TYPE = 'Invoice'											
					ORDER BY INV_ADD_DATE

END
