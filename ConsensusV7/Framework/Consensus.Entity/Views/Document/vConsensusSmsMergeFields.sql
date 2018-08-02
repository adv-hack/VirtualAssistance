IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusSmsMergeFields'))
BEGIN
	exec ('create view [dbo].[vConsensusSmsMergeFields] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusSmsMergeFields

AS
	select [Columns].[COLUMN_NAME],[SMT_ID] 
	from dbo.SMS_TYPE 
	JOIN [INFORMATION_SCHEMA].[COLUMNS] ON [Columns].[TABLE_NAME]=[SMS_TYPE].[SMT_VIEW]

GO

 