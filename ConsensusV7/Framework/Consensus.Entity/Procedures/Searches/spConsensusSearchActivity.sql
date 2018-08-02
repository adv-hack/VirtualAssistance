if not exists (select object_id from sys.objects where type = 'p' and name = 'spConsensusSearchActivity')
  exec ('create procedure dbo.spConsensusSearchActivity as select 1 as temp')
go
ALTER PROCEDURE dbo.spConsensusSearchActivity
( 
@PA_ACT_TYPE VARCHAR(50) = null , 
@PA_ACT_TITLE VARCHAR(250) = null,
@PA_ACT_START_DATE DATETIME = null,
@PA_ACT_END_DATE DATETIME = null,
@PA_PERSON_ID VARCHAR(11) = null,
@PA_SELLING_COMPANY_ID VARCHAR(11) = null
) 
AS
BEGIN	
	SELECT a.ACT_ID,
	a.ACT_TYPE,
	a.ACT_SESSION_NAME,
	a.ACT_ACTION_DATE,
	[Notes] = CASE WHEN LEN(a.ACT_NOTE) > 99 THEN SUBSTRING(a.ACT_NOTE,0,98) + '...'  ELSE a.ACT_NOTE END,
	PersonName = (SELECT p.PROLE_PN_NAME from Person_Role p inner join Activity_Xref act on 
	 p.PROLE_ID = act.ACTXREF_PROLE_ID and act.ACTXREF_ACT_ID=a.ACT_ID and act.actxref_type = 1),
	actxref.ACTXREF_TYPE,
	actxref.ACTXREF_PROLE_ID
	into #temp
	FROM Activity a
	LEFT JOIN Activity_Xref actxref on actxref.ACTXREF_ACT_ID = a.ACT_ID  and (actxref.actxref_type = 1 or actxref.actxref_type = 2 )
	LEFT JOIN Sys_Params  on SP_ID = a.ACT_SELCO_SP_ID 
	  WHERE
		  ISNULL(ACT_TYPE,'') = ISNULL(NULLIF(@PA_ACT_TYPE, ''), ISNULL(ACT_TYPE,''))
	  AND ISNULL(ACT_SESSION_NAME,'') LIKE ISNULL(NULLIF(@PA_ACT_TITLE, '') + '%', ISNULL(ACT_SESSION_NAME,''))  
	  AND ISNULL(ACT_ACTION_DATE,'') = ISNULL(NULLIF(@PA_ACT_START_DATE, ''), ISNULL(ACT_ACTION_DATE,''))
	  AND ISNULL(ACT_END_DATE,'') = ISNULL(NULLIF(@PA_ACT_END_DATE, ''), ISNULL(ACT_END_DATE,''))	  
	  AND ISNULL(ACTXREF.ACTXREF_PROLE_ID,'') LIKE ISNULL(NULLIF(@PA_PERSON_ID, '') + '%', ISNULL(ACTXREF.ACTXREF_PROLE_ID,''))	  
	  AND ISNULL(ACT_SELCO_SP_ID,'') = ISNULL(NULLIF(@PA_SELLING_COMPANY_ID, ''), ISNULL(ACT_SELCO_SP_ID,'')) 
	  AND a.ACT_TYPE != 'D-Session'
	  order by a.ACT_ADD_DATE,actxref.ACTXREF_TYPE
	  	 
	   select 
	  t1.ACT_ID,
	  t1.ACT_TYPE,
	  t1.ACT_SESSION_NAME,
	  t1.ACT_ACTION_DATE,
	  t1.Notes,
	  MIN(t1.ACTXREF_TYPE) AS [Type]
	  
	  into #result1
	  from #temp t1
	  
	  GROUP BY
	  t1.ACT_ID,
	  t1.ACT_TYPE,
	  t1.ACT_SESSION_NAME,
	  t1.ACT_ACTION_DATE,
	  t1.Notes

	  SELECT t.* FROM #temp t INNER JOIN #result1 r ON t.ACT_ID = r.ACT_ID  AND t.ACTXREF_TYPE = r.[Type]

END
GO