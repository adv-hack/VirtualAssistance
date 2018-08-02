if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchReport')
  exec ('create procedure dbo.spConsensusSearchReport as select 1 as temp')
go

ALTER PROCEDURE dbo.spConsensusSearchReport (
 @PA_REP_ID varchar(11) = null,
 @PA_REP_NAME varchar(150) = null,
 @PA_REP_CAT varchar(40) = null,
 @PA_REP_CURRENT tinyint = null
 ) AS

BEGIN

  SELECT REP_ID,
		REP_NAME,
		REP_CAT,
		REP_CURRENT,
		REP_STATUS = case REP_CURRENT
		when 0 then 'Disabled' 
		when 1 then 'Current'  
		else '' 
		end  
	FROM [Report]
	WHERE REP_TYPE = 'LTM Report' 
		  and REP_ID like isNull(nullIf(@PA_REP_ID, '')+ '%', REP_ID)
		  and REP_NAME like isNull(nullIf(@PA_REP_NAME, '') + '%', REP_NAME)		  
		  and isnull(REP_CAT,'') like isNull(nullIf(@PA_REP_CAT, '') + '%', isnull(REP_CAT,''))
		  and REP_CURRENT = isNull(@PA_REP_CURRENT, REP_CURRENT)
	ORDER BY REP_NAME, REP_STATUS	

END