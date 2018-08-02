if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchPayment')
  exec ('create procedure dbo.spConsensusSearchPayment as select 1 as temp')
go

alter procedure dbo.spConsensusSearchPayment (
 @PA_PAY_DATE DATETIME = null,
 @PA_PAY_CUSTOMER_ACC varchar(250) = null,
 @PA_PAY_REF varchar(250) = null,
 @PA_PAY_TYPE varchar(250) = null,
 @PA_PN_SURNAME  varchar(250) = null,
 @PA_ORG_NAME varchar(250) = null,
 @PA_PAY_STATUS varchar(100) = null,
 @PA_PAY_CURR_TYPE varchar(100) = null,
 @PA_PAY_UNUSED_VAL varchar(100) = null
 ) AS

BEGIN


SELECT PAY_ID, PAY_NUMBER, PAY_CUSTOMER_ACC, PAY_ACC_ID, PAY_REF, PAY_TYPE, PAY_TXN_TYPE, 
		PAY_DATE, PAY_CURR_TYPE, PAY_RECVD, PAY_UNUSED_VAL, PAY_UNUSED_VAL_BC, PAY_CURR_RATE_BC,
		PAY_PN_ID, PAY_ORG_ID, PAY_STATUS, PN_FIRST_NAME, PN_SURNAME, ORG_NAME, PN_ID, PN_TITLE, PROLE_PN_NAME  
		FROM Payment
		LEFT OUTER JOIN Person on PN_ID = PAY_PN_ID
		LEFT OUTER JOIN Organisation on ORG_ID = PAY_ORG_ID
		LEFT OUTER JOIN (
			SELECT DISTINCT PROLE_PERSON_ID, PROLE_PN_NAME from Person_Role			
		) as Person_Role on PROLE_PERSON_ID = PN_ID
		WHERE (PAY_DATE = (nullIf(@PA_PAY_DATE, '')) or isNull(@PA_PAY_DATE, '') = '')	
					AND isnull(PAY_CUSTOMER_ACC,'') like isNull(nullIf(@PA_PAY_CUSTOMER_ACC, '') + '%', isnull(PAY_CUSTOMER_ACC,''))
					AND isnull(PAY_REF,'') like isNull(nullIf(@PA_PAY_REF, '') + '%', isnull(PAY_REF,''))	
					AND isnull(PAY_TYPE,'') = isNull(nullIf(@PA_PAY_TYPE, ''), isnull(PAY_TYPE,''))			
					AND isnull(PN_SURNAME,'') like isNull(nullIf(@PA_PN_SURNAME, '') + '%', isnull(PN_SURNAME,''))
					AND isnull(ORG_NAME,'') like isNull(nullIf(@PA_ORG_NAME, '') + '%', isnull(ORG_NAME,''))
					AND isnull(PAY_STATUS,'') = isNull(nullIf(@PA_PAY_STATUS, ''), isnull(PAY_STATUS,''))	
					AND isnull(PAY_CURR_TYPE,'') = isNull(nullIf(@PA_PAY_CURR_TYPE, ''), isnull(PAY_CURR_TYPE,''))
					AND (isnull(PAY_UNUSED_VAL, '') > (nullIf(@PA_PAY_UNUSED_VAL, '')) or isNull(@PA_PAY_UNUSED_VAL, '') = '')															
					AND PAY_TXN_TYPE <> 3
					AND PAY_HIDDEN = 0
					order by PAY_ADD_DATE
	
END
