if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingFetchURL')
  exec ('create procedure dbo.spConsensusReportingFetchURL as select 1 as temp')
go
alter procedure dbo.spConsensusReportingFetchURL(@PA_PMENU_ID varchar(11)) as 
begin
	select
		PS_PORTAL_URL + '/desktopdefault.aspx?HideAdminMode=true&ViewMode=Embedded&PortalPage=' + isnull(nullif(@PA_PMENU_ID,''),convert(varchar,PMENU_ID)) REPORT_URL
	from Portal_Setup
		left join dbo.Portal_Menu on PMENU_PS_ID = PS_ID and PMENU_UNIQUE_NAME = 'LTMReportDataSetCreator'
	where PS_PORTAL_TITLE = 'LTM Reporting Portal'
end
go
