IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusGiftAidClaimBatches'))
BEGIN
	exec ('create view [dbo].[vConsensusGiftAidClaimBatches] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusGiftAidClaimBatches

AS
SELECT BAT_ID
,BAT_ADD_DATE
,BAT_STATUS
,BAT_RUN_D_T
,BATXR_RECORD_ID,
CONVERT(VARCHAR(10),BAT_RUN_D_T,101) as DatePortion,
CONVERT(VARCHAR(10),BAT_RUN_D_T,108) as TimePortion,
uri = 'other/batch/' + convert(varchar, BAT_ID)
FROM BATCH_XREF 
INNER JOIN BATCH ON BAT_ID = BATXR_BAT_ID
WHERE BATXR_TABLE_NAME = 'Gift Aid Claim'

GO
