if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchAccount')
  exec ('create procedure dbo.spConsensusSearchAccount as select 1 as temp')
go
alter procedure dbo.spConsensusSearchAccount
( 
@PA_ACC_SYSTEM_REF varchar(50) = null , 
@PA_ACC_TITLE varchar(80) = null,
@PA_ORG_ID varchar(11) = null,
@PA_PROLE_ID varchar(11) = null,
@PA_PN_ID varchar(11) = null
) 
as
begin

	select ACC_ID, ACC_SYSTEM_REF, ACC_STATUS ,PROLE_PN_NAME,PROLE_ID, PN_ID, ORG_NAME, ORG_ID, SP_SELL_COMP_NAME, SP_ID, ACC_TITLE,
    ADD_ID, ADD_BUILDING, ADD_STREET, ADD_AREA, ADD_TOWN, ADD_COUNTY, ADD_POSTCODE, ADD_COUNTRY, ADD_MAILSTRING
	from dbo.Account
	inner join Sys_Params  on ACC_SELCO_SP_ID = SP_ID 
	inner join Account_Xref on ACXREF_ACC_ID = ACC_ID and ACXREF_MAIN = 1
	inner join Address on ADD_ID = ACXREF_ADD_ID
	left outer join Organisation on ORG_ID = ACXREF_ORG_ID 
    left outer join Person_Role on PROLE_ID = ACXREF_PROLE_ID 
	left outer join Person on PN_ID = PROLE_PERSON_ID
	where ACC_SYSTEM_REF like isNull(nullIf(@PA_ACC_SYSTEM_REF, '') + '%', ACC_SYSTEM_REF)
	  and ACC_TITLE like isNull(nullIf(@PA_ACC_TITLE, '') + '%', ACC_TITLE)
	  and ORG_ID = isNull(nullIf(@PA_ORG_ID, ''), ORG_ID)
	  and PROLE_ID = isNull(nullIf(@PA_PROLE_ID, ''), PROLE_ID)
	  and PN_ID = isNull(nullIf(@PA_PN_ID, ''), PN_ID)
	order by ACC_TITLE

end