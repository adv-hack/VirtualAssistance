IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusPromotionMasters'))
BEGIN
	exec ('create view [dbo].[vConsensusPromotionMasters] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusPromotionMasters]

AS

Select PM_MST_CMP_ID, PM_MST_ID, PM_MST_NAME, PM_MST_START_DATE, PM_MST_END_DATE, PM_MST_REGION, PM_MST_COURSE_ID, PM_MST_TYPE,
	CASE PM_MST_TYPE WHEN 1 THEN 'Event' ELSE 'Campaign' END AS PM_MST_TYPE_DESC, COURSE_NAME , uri = 'marketing/promotionmaster/' + convert(varchar, PM_MST_ID)
from dbo.Promotion_Master
left join dbo.Course on COURSE_ID = PM_MST_COURSE_ID 

GO