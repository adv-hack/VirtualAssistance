IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusMergeFields'))
BEGIN
	exec ('create view [dbo].[vConsensusMergeFields] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusMergeFields
AS

	select [Columns].[COLUMN_NAME],[ICMT_ID] 
	from [dbo].[ICalMessageType] 
	join [Information_Schema].[Columns] on [Columns].[TABLE_NAME] = [ICalMessageType].[ICMT_VIEW] 

GO
