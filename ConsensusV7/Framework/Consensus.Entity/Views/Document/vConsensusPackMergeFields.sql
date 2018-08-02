IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusPackMergeFields'))
BEGIN
	exec ('create view [dbo].[vConsensusPackMergeFields] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusPackMergeFields

AS
	select COLUMN_NAME, TABLE_NAME from INFORMATION_SCHEMA.[COLUMNS] 

GO

 