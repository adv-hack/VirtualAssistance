if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchEvent')
  exec ('create procedure dbo.spConsensusSearchEvent as select 1 as temp')
go

--exec spConsensusSearchEvent

alter procedure dbo.spConsensusSearchEvent (
 @PA_COURSE_NAME varchar(250) = null,
 @PA_COURSE_REF varchar(250) = null,
 @PA_COURSE_ID varchar(250) = null,
 @PA_COURSE_START_DATE_AFTER DATETIME = null,
 @PA_COURSE_START_DATE_BEFORE DATETIME = null,
 @PA_ADD_TOWN varchar(250) = null,
 @PA_PROD_GROUP varchar(100) = null,
 @PA_COURSE_STATUS varchar(100) = null,
 @PA_COURSE_TYPE varchar(100) = null,
 @PA_PROD_CATEGORY varchar(100) = null,
 @PA_LOC_NAME varchar(250) = null
 ) AS

BEGIN

Select DISTINCT COURSE_ID,COURSE_NAME,COURSE_REF,COURSE_PRODUCT_ID,PROD_NAME, 
		            COURSE_START_DATE,COURSE_END_DATE,
					COURSE_START_TIME,
					convert(varchar(8),COURSE_START_TIME,108) as EVENT_START_TIME,
					COURSE_END_TIME,
					convert(varchar(8),COURSE_END_TIME,108) as EVENT_END_TIME,
		            COURSE_TYPE,COURSE_ORG_ID,ORG_NAME VENUE_ORG_NAME,COURSE_STATUS, 
		            COURSE_MAX_PLACES,COURSE_MIN_PLACES,COURSE_URL,COURSE_PERSON_ID,COURSE_STUDT_PRICE, 
		            PN_FIRST_NAME + PN_SURNAME MANAGER_NAME,COURSE_PRIVATE,COURSE_WEB, 
		            ADD_ID,ADD_BUILDING,ADD_STREET,ADD_AREA,ADD_TOWN,ADD_COUNTY,ADD_POSTCODE,ADD_COUNTRY, 
		            COURSE_PROVIS_BKGS,COURSE_CONF_PLACES,COURSE_RESV_PLACES, 
		            PROJ_ID, PROJ_NAME, 
		            ACT_FREE_PLACES= 
			            ISNULL(( 
			            select min(ACT_FREE_PLACES) from Activity,Session_Xref 
			            where ACT_ID=SXREF_ACT_ID and SXREF_MANDATORY=1 
			            and SXREF_COURSE_ID = COURSE_ID 
			            and ACT_TYPE = 'D-Session' 
			            ), 0),					
					PROD_CATEGORY,
					PROD_GROUP,
					LOC_NAME,
					COALESCE(LOC_NAME,ORG_NAME) VENUE,
					isnull(convert(int,LEFT(NULLIF(COURSE_DEF_ELEM_ST,''),2)),0) COURSE_DEF_ELEM_ST,COURSE_OVERBOOK
		            From COURSE 
		            inner join Organisation on ORG_ID=COURSE_ORG_ID
		            inner join ADDRESS on ADD_ID=COURSE_ADD_ID 
		            inner join Product on PROD_ID = COURSE_PRODUCT_ID 
		            left outer join Person on PN_ID = COURSE_PERSON_ID 
		            left outer join Project on PROJ_ID = COURSE_PROJ_ID 
					left outer join Location on LOC_ID = COURSE_LOC_ID
		            where upper(COURSE_STATUS) <> 'CANCELLED' 					
					and isnull(COURSE_NAME,'') like isNull(nullIf(@PA_COURSE_NAME, '') + '%', isnull(COURSE_NAME,''))
					and isnull(COURSE_REF,'') like isNull(nullIf(@PA_COURSE_REF, '') + '%', isnull(COURSE_REF,''))					
					and isnull(COURSE_ID,'') = isNull(nullIf(@PA_COURSE_ID, ''), isnull(COURSE_ID,''))
					and (COURSE_START_DATE >= (nullIf(@PA_COURSE_START_DATE_AFTER, '')) or isNull(@PA_COURSE_START_DATE_AFTER, '') = '')	 
					and (COURSE_START_DATE <= (nullIf(@PA_COURSE_START_DATE_BEFORE, '')) or isNull(@PA_COURSE_START_DATE_BEFORE, '') = '')	 
					and isnull(ADD_TOWN,'') like isNull(nullIf(@PA_ADD_TOWN, '') + '%', isnull(ADD_TOWN,''))
					and isnull(PROD_GROUP,'') = isNull(nullIf(@PA_PROD_GROUP, ''), isnull(PROD_GROUP,''))
					and isnull(COURSE_STATUS,'') = isNull(nullIf(@PA_COURSE_STATUS, ''), isnull(COURSE_STATUS,''))
					and isnull(COURSE_TYPE,'') = isNull(nullIf(@PA_COURSE_TYPE, ''), isnull(COURSE_TYPE,''))
					and isnull(PROD_CATEGORY,'') = isNull(nullIf(@PA_PROD_CATEGORY, ''), isnull(PROD_CATEGORY,''))
					and isnull(LOC_NAME,'') like isNull(nullIf(@PA_LOC_NAME, '') + '%', isnull(LOC_NAME,''))
					order by COURSE_START_DATE asc,COURSE_NAME

END
