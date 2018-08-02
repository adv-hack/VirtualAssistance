if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchTemplate')
  exec ('create procedure dbo.spConsensusSearchTemplate as select 1 as temp')
go
alter procedure dbo.spConsensusSearchTemplate
( 
@PA_LT_NAME varchar(500) = null, 
@PA_LTT_NAME varchar(40) = null
) 
as
begin

	select LT_ID, LT_NAME, LTT_NAME, LT_FILE_NAME
	from dbo.LetterTmplt
	inner join LetTmpltType on lt_type = ltt_id
	where LT_NAME like isNull(nullIf(@PA_LT_NAME, '') + '%', LT_NAME)
	  and LTT_NAME like isNull(nullIf(@PA_LTT_NAME, '') + '%', LTT_NAME)
	order by LT_NAME

end