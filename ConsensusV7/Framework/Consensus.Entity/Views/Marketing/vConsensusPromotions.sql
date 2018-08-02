IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusPromotions'))
BEGIN
	exec ('create view [dbo].[vConsensusPromotions] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusPromotions]

AS

Select PM_CMP_ID as PM_MST_ID, PM_ID, PM_NAME, PM_START_DATE, PM_CHANNEL, PM_MEDIA_NAME, CAST(PM_CURRENT AS BIT) as PM_CURRENT, 
	uri = 'marketing/promotion/' + convert(varchar, PM_ID)
from dbo.Promotion

GO