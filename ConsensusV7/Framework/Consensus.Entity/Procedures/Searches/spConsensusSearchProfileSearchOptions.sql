if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchProfileSearchOptions')
  exec ('create procedure dbo.spConsensusSearchProfileSearchOptions as select 1 as temp')
go

alter procedure dbo.spConsensusSearchProfileSearchOptions
( 
	@PA_PROFILE_TYPE varchar(100) = null,
	@PA_EXTRA_WHERE varchar(max) = null,
	@PA_LEVEL_1 varchar(50) = null,
	@PA_LEVEL_2 varchar(40) = null
) 
as
begin

	declare @sSQL varchar(max)

	create table #t_prof (T_PROF_ID varchar(11) collate database_default NOT NULL PRIMARY KEY)

	set @sSQL = 'INSERT INTO #t_prof '
		+ 'SELECT PROF_ID '
		+ 'FROM PROFILE '
		+ 'WHERE ' + ISNULL(NULLIF(@PA_PROFILE_TYPE, ''), 'NULL') + ' IS NOT NULL '
		+ ISNULL(@PA_EXTRA_WHERE, '')

	--print @sSQL
	EXEC(@sSQL)

SELECT 
	CASE 
		WHEN NULLIF(@PA_LEVEL_1, '') IS NULL THEN PROF_KEY
		WHEN NULLIF(@PA_LEVEL_2, '') IS NULL THEN PROF_VALUE 
		ELSE PROF_VALUE2 
			END as [PROFILE_DESC],
	CASE WHEN COUNT(CASE 
		WHEN NULLIF(@PA_LEVEL_1, '') IS NULL THEN NULLIF(PROF_VALUE, '')
		WHEN NULLIF(@PA_LEVEL_2, '') IS NULL THEN NULLIF(PROF_VALUE2, '') 
		ELSE NULL 
			END) > 0 THEN 1 ELSE 0 END as NEXT_EXISTS
FROM PROFILE
join #t_prof on T_PROF_ID = PROF_ID
WHERE (NULLIF(@PA_LEVEL_1, '') IS NULL OR PROF_KEY = @PA_LEVEL_1)
AND (NULLIF(@PA_LEVEL_2, '') IS NULL OR PROF_VALUE = @PA_LEVEL_2)
AND NULLIF(CASE 
		WHEN NULLIF(@PA_LEVEL_1, '') IS NULL THEN PROF_KEY
		WHEN NULLIF(@PA_LEVEL_2, '') IS NULL THEN PROF_VALUE 
		ELSE PROF_VALUE2 
			END, '') IS NOT NULL
GROUP BY CASE 
		WHEN NULLIF(@PA_LEVEL_1, '') IS NULL THEN PROF_KEY
		WHEN NULLIF(@PA_LEVEL_2, '') IS NULL THEN PROF_VALUE 
		ELSE PROF_VALUE2 
			END
ORDER BY [PROFILE_DESC]

drop table #t_prof

end