if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchPerson')
  exec ('create procedure dbo.spConsensusSearchPerson as select 1 as temp')
go
ALTER procedure [dbo].[spConsensusSearchPerson] 
( 
@PA_PN_ID varchar(11) = null , 
@PA_PN_FIRST_NAME varchar(250) = null,
@PA_PN_SURNAME varchar(250) = null,
@PA_ORG_NAME varchar(250) = null,
@PA_ADD_POSTCODE varchar(12) = null,
@PA_PROLE_EMAIL varchar(100) = null,
@PA_PROLE_TYPE varchar(40) = null,
@PA_PROLE_POS_TYPE varchar(40) = null,
@PA_PN_PARTNER_SYS_REF varchar(100) = null,
@PA_SY_Person_Type varchar(20) = null
) 
as
begin
	IF(@PA_SY_Person_Type IS NOT NULL AND @PA_SY_Person_Type != '')
	BEGIN				
		select PN_ID, PROLE_ID, PN_FIRST_NAME, PN_SURNAME, PROLE_PN_NAME, PROLE_ORG_ID, PROLE_ORG_NAME, PROLE_PRINCIP_ROLE, PROLE_PHONE, PROLE_FAX, PROLE_EMAIL, 
		ADD_ID, ADD_MAILSTRING,ADD_BUILDING,ADD_STREET,ADD_TOWN,ADD_AREA,ADD_COUNTY,ADD_POSTCODE,ADD_COUNTRY,PN_SALUTATION
		from dbo.Person_Role
		join dbo.Person on PROLE_PERSON_ID = PN_ID
		left join address on PROLE_ADD_ID = add_id	
		left join Trainer on PROLE_ID = Trainer.TRAIN_PROLE_ID
		where PROLE_DIS_FLAG != 1 AND PN_ID = isNull(nullIf(@PA_PN_ID, ''), PN_ID)
		  and isnull(PN_FIRST_NAME,'') like isNull(nullIf(@PA_PN_FIRST_NAME, '') + '%', isnull(PN_FIRST_NAME,''))
		  and PN_SURNAME like isNull(nullIf(@PA_PN_SURNAME, '') + '%', PN_SURNAME)
		  and isnull(PROLE_ORG_NAME,'') like isNull(nullIf(@PA_ORG_NAME, '') + '%', isnull(PROLE_ORG_NAME,''))
		  and isnull(ADD_POSTCODE,'') like isNull(nullIf(@PA_ADD_POSTCODE, '') + '%', isnull(ADD_POSTCODE,''))
		  and isnull(PROLE_EMAIL,'') like isNull(nullIf(@PA_PROLE_EMAIL, '') + '%', isnull(PROLE_EMAIL,''))
		  and isnull(PROLE_TYPE,'') = isNull(nullIf(@PA_PROLE_TYPE, ''), isnull(PROLE_TYPE,''))
		  and isnull(PROLE_POS_TYPE,'') like isNull(nullIf(@PA_PROLE_POS_TYPE, '') + '%', isnull(PROLE_POS_TYPE,''))
		  and isnull(PN_PARTNER_SYS_REF,'') like isNull(nullIf(@PA_PN_PARTNER_SYS_REF, '') + '%', isnull(PN_PARTNER_SYS_REF,''))		  
		  AND TRAIN_SY_TYPE = CASE WHEN @PA_SY_Person_Type LIKE '%Associate%' Then '0' WHEN @PA_SY_Person_Type LIKE '%Volunteer%' THEN '1' END  
		order by PN_SURNAME,PN_FIRST_NAME
	END
	ELSE
	BEGIN
		select PN_ID, PROLE_ID, PN_FIRST_NAME, PN_SURNAME, PROLE_PN_NAME, PROLE_ORG_ID, PROLE_ORG_NAME, PROLE_PRINCIP_ROLE, PROLE_PHONE, PROLE_FAX, PROLE_EMAIL, 
		ADD_ID, ADD_MAILSTRING,ADD_BUILDING,ADD_STREET,ADD_TOWN,ADD_AREA,ADD_COUNTY,ADD_POSTCODE,ADD_COUNTRY,PN_SALUTATION
		from dbo.Person_Role
		join dbo.Person on PROLE_PERSON_ID = PN_ID
		left join address on PROLE_ADD_ID = add_id
		where PROLE_DIS_FLAG != 1 AND PN_ID = isNull(nullIf(@PA_PN_ID, ''), PN_ID)
		  and isnull(PN_FIRST_NAME,'') like isNull(nullIf(@PA_PN_FIRST_NAME, '') + '%', isnull(PN_FIRST_NAME,''))
		  and PN_SURNAME like isNull(nullIf(@PA_PN_SURNAME, '') + '%', PN_SURNAME)
		  and isnull(PROLE_ORG_NAME,'') like isNull(nullIf(@PA_ORG_NAME, '') + '%', isnull(PROLE_ORG_NAME,''))
		  and isnull(ADD_POSTCODE,'') like isNull(nullIf(@PA_ADD_POSTCODE, '') + '%', isnull(ADD_POSTCODE,''))
		  and isnull(PROLE_EMAIL,'') like isNull(nullIf(@PA_PROLE_EMAIL, '') + '%', isnull(PROLE_EMAIL,''))
		  and isnull(PROLE_TYPE,'') = isNull(nullIf(@PA_PROLE_TYPE, ''), isnull(PROLE_TYPE,''))
		  and isnull(PROLE_POS_TYPE,'') like isNull(nullIf(@PA_PROLE_POS_TYPE, '') + '%', isnull(PROLE_POS_TYPE,''))
		  and isnull(PN_PARTNER_SYS_REF,'') like isNull(nullIf(@PA_PN_PARTNER_SYS_REF, '') + '%', isnull(PN_PARTNER_SYS_REF,''))
		order by PN_SURNAME,PN_FIRST_NAME
	END
end