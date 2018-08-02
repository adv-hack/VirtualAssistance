IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusProfiles'))
BEGIN
	exec ('create view [dbo].[vConsensusProfiles] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusProfiles

AS

Select PROF_ID,PROF_ORG_ID,PROF_PERSON_ID,PROF_ROLE_ID,PROF_PROD_ID,PROF_VOL_ID,
PROF_CERT_ID,PROF_DEL_ID,PROF_COURSE_ID,PROF_LOC_ID,PROF_QUAL_ID,PROF_TRAIN_ID,PROF_MEM_ID,
PROF_KEY,PROF_VALUE,PROF_VALUE2,PROF_DATE,PROF_STATUS,PROF_NOTES, uri = 'common/profile/' + convert(varchar, PROF_ID)
From [dbo].[Profile]
GO