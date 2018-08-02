if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchBranch')
  exec ('create procedure dbo.spConsensusSearchBranch as select 1 as temp')
go

--exec spConsensusSearchBranch

ALTER PROCEDURE dbo.spConsensusSearchBranch (
 @PA_BR_ID varchar(11) = null,
 @PA_BR_NAME varchar(255) = null,
 @PA_BR_REGION varchar(40) = null,
 @PA_BR_STATUS varchar(40) = null,
 @PA_BR_TYPE varchar(40) = null,
 @PA_BR_CATEGORY varchar(40) = null,
 @PA_BR_GROUP varchar(40) = null
 ) AS

BEGIN

  SELECT BR_ID
		,BR_NAME
		,BR_REGION
		,BR_STATUS
		,BR_TYPE
		,BR_CATEGORY
		,BR_GROUP
	FROM Branch
	WHERE BR_ID = isNull(nullIf(@PA_BR_ID, ''), BR_ID)
		  and BR_NAME like isNull(nullIf(@PA_BR_NAME, '') + '%', BR_NAME)
		  and isnull(BR_REGION,'') like isNull(nullIf(@PA_BR_REGION, '') + '%', isnull(BR_REGION,''))
		  and isnull(BR_STATUS,'') like isNull(nullIf(@PA_BR_STATUS, '') + '%', isnull(BR_STATUS,''))
		  and isnull(BR_TYPE,'') like isNull(nullIf(@PA_BR_TYPE, '') + '%', isnull(BR_TYPE,''))
		  and isnull(BR_CATEGORY,'') like isNull(nullIf(@PA_BR_CATEGORY, '') + '%', isnull(BR_CATEGORY,''))
		  and isnull(BR_GROUP,'') like isNull(nullIf(@PA_BR_GROUP, '') + '%', isnull(BR_GROUP,''))
	ORDER BY BR_NAME, BR_STATUS	

END