if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchOrganisation')
  exec ('create procedure dbo.spConsensusSearchOrganisation as select 1 as temp')
go
alter procedure dbo.spConsensusSearchOrganisation ( @PA_ORG_ID varchar(11) = null , @PA_ORG_NAME varchar(250) = null) as
begin

	select ORG_ID, ORG_NAME, ORG_TYPE, ADD_MAILSTRING, ADD_ID,ADD_BUILDING,ADD_STREET,ADD_TOWN,ADD_AREA,ADD_COUNTY,ADD_POSTCODE,ADD_COUNTRY
	from dbo.Organisation
	join dbo.Address_XRef on ADDXREF_ORG_ID = ORG_ID and ADDXREF_PRINCIPAL = 1
	join dbo.Address on ADD_ID = ADDXREF_ADD_ID
	where ORG_ID = isNull(nullIf(@PA_ORG_ID, ''), ORG_ID)
	  and ORG_NAME like isNull(nullIf(@PA_ORG_NAME, '') + '%', ORG_NAME)
	  and ORG_DISABLED !=1
	order by ORG_NAME

end