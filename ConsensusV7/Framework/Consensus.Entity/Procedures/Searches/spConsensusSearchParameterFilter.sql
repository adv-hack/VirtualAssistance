if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchParameterFilter')
  exec ('create procedure dbo.spConsensusSearchParameterFilter as select 1 as temp')
go

alter procedure dbo.spConsensusSearchParameterFilter
( 
	@PA_F_FIELD varchar(100) = null,
	@PA_F_TABLE varchar(100) = null
) 
as
begin

	select F_ID, F_COLUMN_DESC, F_COLUMN_NAME, F_TABLE_DESC
	from dbo.SAQ_FILTER 	
	where isnull(F_TABLE_DESC,'') like isNull(nullIf(@PA_F_TABLE, '') + '%', isnull(F_TABLE_DESC,''))
	and (isnull(F_COLUMN_NAME,'') like isNull(nullIf(@PA_F_FIELD, '') + '%', isnull(F_COLUMN_NAME,''))
		or isnull(F_COLUMN_DESC,'') like isNull(nullIf(@PA_F_FIELD, '') + '%', isnull(F_COLUMN_DESC,'')))
	and F_DISPLAY = 1
	order by F_TABLE_DESC, F_COLUMN_DESC


end