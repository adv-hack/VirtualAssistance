if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchPortalUserRolesList')
  exec ('create procedure dbo.spConsensusSearchPortalUserRolesList as select 1 as temp')
go
alter procedure dbo.spConsensusSearchPortalUserRolesList
( 
@PA_PU_ID varchar(11) = null 
) 
as
begin

	select PR_ID, 
	PR_TITLE, 
	PUR_ID, 
	SELECTED = case when PUR_ID is not null then 1 else 0 end,
	uri = 'portal/portaluserrole/' + isnull(convert(varchar, pur_id),'') 
	from dbo.Portal_Role
	left outer join dbo.PortalUserRole on PUR_PU_ID = @PA_PU_ID and PUR_PR_ID = PR_ID 			 
	order by PR_TITLE

end
