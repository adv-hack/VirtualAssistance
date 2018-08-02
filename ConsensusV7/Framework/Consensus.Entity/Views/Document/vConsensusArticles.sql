IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusArticles'))
BEGIN
	exec ('create view [dbo].[vConsensusArticles] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusArticles]

AS

Select ARTIXREF_ID
      , CONVERT(VARCHAR(25)
	  , ARTIXREF_ADD_DATE, 113)as ARTIXREF_ADD_DATE
	  , ARTIXREF_ARTI_ID
	  , ARTIXREF_REL_ARTI_ID
	  ,ARTI_NAME
	  ,ARTI_SUMMARY
	  ,ARTI_SUMMARY_HTML
	  ,uri = 'document/articlexref/' + convert(varchar, ARTIXREF_ID)
From ArticleXref
inner join Article on ARTI_ID = ARTIXREF_REL_ARTI_ID 

GO


