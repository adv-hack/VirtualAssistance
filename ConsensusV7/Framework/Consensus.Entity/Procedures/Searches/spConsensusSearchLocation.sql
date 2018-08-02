if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchLocation')
  exec ('create procedure dbo.spConsensusSearchLocation as select 1 as temp')
go

--exec spConsensusSearchLocation '','','','',0

alter procedure dbo.spConsensusSearchLocation (
 @PA_LOC_NAME varchar(250) = null,
 @PA_LOC_REF varchar(250) = null,
 @PA_ORG_NAME varchar(250) = null,
 @PA_ADD_TOWN varchar(250) = null,
 @PA_LOC_ACTIVE varchar(40) = null,
 @PA_LOC_VENUE_TYPE varchar(100) = null
 ) AS

BEGIN

SELECT DISTINCT LOC_ID,LOC_NAME,LOC_REF,LOC_PROLE_ID,PROLE_PN_NAME,LOC_ORG_ID,LOC_ADD_ID,ORG_NAME,LOC_TRAIN_LOCATION as LOC_ACTIVE, LOC_VENUE_TYPE,
		ADD_BUILDING,ADD_STREET,ADD_AREA,ADD_TOWN,ADD_COUNTY,ADD_POSTCODE,ADD_COUNTRY,ADD_MAILSTRING,
		LOC_ANALYSIS_1, LOC_ANALYSIS_2,LOC_REGION,LOC_COST_CODE,LOC_SELCO_SP_ID 
		FROM Location
		INNER JOIN ORGANISATION on LOC_ORG_ID = ORG_ID 
		INNER JOIN ADDRESS on LOC_ADD_ID = ADD_ID 
		LEFT  JOIN PERSON_ROLE on LOC_PROLE_ID = PROLE_ID 
		WHERE LOC_NAME like isNull(nullIf(@PA_LOC_NAME, '')+'%', LOC_NAME) 
	  and LOC_REF like isNull(nullIf(@PA_LOC_REF, '') + '%', LOC_REF)
	  and isnull(ORG_NAME,'') like isNull(nullIf(@PA_ORG_NAME, '') + '%', isnull(ORG_NAME,''))
	  and isnull(ADD_TOWN,'') like isNull(nullIf(@PA_ADD_TOWN, '') + '%', isnull(ADD_TOWN,''))
	  and isnull(LOC_VENUE_TYPE,'') = isNull(nullIf(@PA_LOC_VENUE_TYPE, ''), isnull(LOC_VENUE_TYPE,''))
	  and isnull(LOC_TRAIN_LOCATION,'') like isNull(nullIf(@PA_LOC_ACTIVE, '') + '%', isnull(LOC_TRAIN_LOCATION,''))

	order by LOC_NAME,LOC_REF

END
