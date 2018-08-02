IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusPacks'))
BEGIN
	exec ('create view [dbo].[vConsensusPacks] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusPacks

AS

Select 
PACK_ID,
PACK_NAME, 
PACK_TYPE,
PACK_PQ_ID,
PACK_SEND_PROLE_ID,
Person_Role.PROLE_PN_NAME PACK_SEND_PERSON_NAME,
CASE PACK_TYPE
	WHEN 0 THEN 'learning/booking'
	WHEN 3 THEN 'membership/memberperiod'
	WHEN 4 THEN 'learning/event'
	WHEN 5 THEN 'finance/invoice'
	WHEN 6 THEN 'other/batch'
	WHEN 10 THEN 'contact/person'
	WHEN 12 THEN 'activities/helpdesk'
	WHEN 13 THEN 'activities/complaint'
	WHEN 15 THEN 'activities/activity'
	WHEN 19 THEN 'contact/giftaid'
		END as PARENT_URL,
uri = 'document/pack/' + convert(varchar, PACK_ID)
from dbo.PACK 
left join dbo.Person_Role on PACK_SEND_PROLE_ID = PROLE_ID

GO