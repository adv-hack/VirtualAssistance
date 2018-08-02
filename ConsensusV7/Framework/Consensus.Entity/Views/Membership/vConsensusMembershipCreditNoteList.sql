if not exists (select object_id from sys.objects where name = 'vConsensusMemebershipCreditNotes')
  exec ('create view dbo.vConsensusMemebershipCreditNotes as select 1 as temp')
go

alter view dbo.vConsensusMemebershipCreditNotes as 
	
select distinct
	VIEW_LINK = 1,
	INV1.INV_ID as InvoieID,
	INV1.INV_TYPE as InvoiceType,
	INV1.INV_REF as InvoiceRef,
	convert(datetime,convert(varchar,INV1.INV_DATE,103),103) as INV_DATE,
	INV1.INV_CURRENCY_TYPE as InvoiceCurrType,
	INV1.INV_BK_ORG_CUST_AC as ARNumber,
	INV1.INV_PERSON_ID as InvPersonId,
	PROLE_ID,
	INV_CONTACT_NAME = PROLE_PN_NAME,
	INV_CONTACT_SURNAME = PN_SURNAME,
	INV_CONTACT_FIRSTNAME = PN_FIRST_NAME,
	INV1.INV_GROSS_TOTAL as InvGrossTotal, 
	INV1.INV_ORG_ID as InvOrgID,
	INV1.INV_INV_ORG_NAME as InvOrgName,
	INV1.INV_SELCO_SP_ID as InvSellCoSPID,
	SP_SELL_COMP_NAME,
	INV1.INV_BOOK_ID as InvBookingID,
	INV1.INV_BAT_ID as InvBatID,
	INV1.INV_CREDIT_NTE_REF as CreditedInvoiceID,
	INV1.INV_MEP_ID as InvMemPerID,
	MEP_MEM_ID as InvMembershipID,
	MEM_REF,
	INV2.INV_REF as CreditedInvoiceReference,
	uri = 'finance/invoice/' + convert(varchar, INV1.INV_ID)
from dbo.INVHEADER INV1
join dbo.Sys_Params on SP_ID=INV1.INV_SELCO_SP_ID 
left outer join dbo.PERSON on PN_ID=INV1.INV_PERSON_ID 
left outer join dbo.PERSON_ROLE on PROLE_PERSON_ID = INV1.INV_PERSON_ID and PROLE_PRINCIP_ROLE = 1
left outer join dbo.Member_period on MEP_ID=INV1.INV_MEP_ID
left outer join dbo.Membership on MEM_ID=MEP_MEM_ID
left outer join dbo.INVHEADER INV2 on INV1.INV_CREDIT_NTE_REF = INV2.INV_ID
where INV1.INV_TYPE  = 'Credit'


GO