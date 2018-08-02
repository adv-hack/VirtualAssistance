if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchPack')
  exec ('create procedure dbo.spConsensusSearchPack as select 1 as temp')
go
alter procedure dbo.spConsensusSearchPack
( 
@PA_PACK_NAME varchar(500) = null, 
@PA_PACKTYP_DESC varchar(40) = null
) 
as
begin

	select PACK_ID, PACK_NAME, PACKTYP_DESC
	from dbo.Pack
	inner join PackType on pack_type = packtyp_type
	where PACK_NAME like isNull(nullIf(@PA_PACK_NAME, '') + '%', PACK_NAME)
	  and PACKTYP_DESC like isNull(nullIf(@PA_PACKTYP_DESC, '') + '%', PACKTYP_DESC)
	order by PACK_NAME

end