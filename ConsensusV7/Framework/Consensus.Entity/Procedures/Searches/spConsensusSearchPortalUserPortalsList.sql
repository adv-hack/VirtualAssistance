if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchPortalUserPortalsList')
  exec ('create procedure dbo.spConsensusSearchPortalUserPortalsList as select 1 as temp')
go
alter procedure dbo.spConsensusSearchPortalUserPortalsList
( 
@PA_PU_ID varchar(11) = null 
) 
as
begin

	select PS_ID,
	PS_PORTAL_TITLE, 
	PS_PORTAL_URL, 
	PUSTE_ID, 
	SELECTED = case when PUSTE_ID is null then 0 else 1 end,
	uri = 'portal/portalusersite/' + isnull(convert(varchar, puste_id),'')
	from dbo.Portal_Setup 
	left outer join dbo.PU_SITE on PUSTE_PU_ID = @PA_PU_ID and PUSTE_PS_ID = PS_ID 
	order by PS_PORTAL_TITLE

end
