if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchArticle')
  exec ('create procedure dbo.spConsensusSearchArticle as select 1 as temp')
go

ALTER PROCEDURE dbo.spConsensusSearchArticle (
 @PA_ARTI_ID int,
 @PA_ARTI_NAME varchar(500) = null,
 @PA_ARTI_STATE tinyint
 ) AS

BEGIN

  SELECT ARTI_NAME,ARTI_STATE,ARTI_ID,
  CASE ARTI_STATE WHEN 0 THEN 'Planning'
                  WHEN 1 THEN 'Current'
				  WHEN 2 THEN 'Cancelled'
				  END 
  AS ARTI_STATUS,
  ARTI_SUMMARY
  FROM 
  Article
  WHERE ARTI_NAME like isNull(nullIf(@PA_ARTI_NAME, '') + '%', ARTI_NAME)
        AND  isNull(@PA_ARTI_STATE, ARTI_STATE) = ARTI_STATE
		AND  isNUll(@PA_ARTI_ID,ARTI_ID) <> ARTI_ID
END