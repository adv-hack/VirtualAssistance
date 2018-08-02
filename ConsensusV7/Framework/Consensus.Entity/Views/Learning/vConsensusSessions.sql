if not exists (select object_id from sys.objects where name = 'vConsensusSessions' and type = 'v')
  exec ('create view dbo.vConsensusSessions as select 1 as temp')
go

alter view dbo.vConsensusSessions as 
SELECT DISTINCT SXREF_COURSE_ID,ACT_ID, ACT_SESSION_NAME,ACT_ACTION_DATE,ACT_END_DATE,convert(varchar(5), ACT_TIME, 108) as ACT_START_TIME,
convert(varchar(5), ACT_END_TIME, 108) as ACT_END_TIME,
CASE SXREF_MANDATORY WHEN 1 THEN 'Yes'
	WHEN 2 THEN 'Recommended' ELSE 'No' END AS MANDATORY,
SXREF_MAIN_SESSION, ISNULL(SHARED,0) AS SHARED, ACT_MAX_PLACES ,ACT_FREE_PLACES, CSG_NAME, LOC_NAME,
uri = 'learning/session/' + convert(varchar, ACT_ID)
FROM dbo.Session_Xref 
INNER JOIN dbo.Activity ON ACT_ID=SXREF_ACT_ID and ACT_TYPE='D-Session' 
LEFT JOIN dbo.CourseSelectGroups ON CSG_ID = SXREF_CSG_ID 
LEFT JOIN dbo.Location ON LOC_ID = ACT_LOC_ID
LEFT JOIN (SELECT CASE WHEN count(SXREF_ID)>=1 THEN 1 ELSE 0 END AS SHARED,
			SXREF_COURSE_ID S_SXREF_COURSE_ID ,SXREF_ACT_ID S_SXREF_ACT_ID 
			FROM dbo.Session_Xref 
			GROUP BY SXREF_COURSE_ID,SXREF_ACT_ID)z ON S_SXREF_ACT_ID=SXREF_ACT_ID and S_SXREF_COURSE_ID<>SXREF_COURSE_ID 

go