if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchStep')
  exec ('create procedure dbo.spConsensusSearchStep as select 1 as temp')
go

alter procedure dbo.spConsensusSearchStep
( 
	@PA_STEP_ID		varchar(100) = null,
    @PA_STEP_OWNER	nvarchar(150) = null,
    @PA_STEP_NAME	varchar(100) = null,
    @PA_STEP_DESC	varchar(200) = null
) 
as
begin

	select STEP_ID, STEP_NAME, STEP_DESC, 
		uri = 'marketing/saqstep/' + CAST(STEP_ID as varchar(25)),
		PROLE_PN_NAME as STEP_PROLE_OWNER_NAME, STEP_LINK_DEFAULT
	from Saq_Step
	join Person_Role
		on [STEP_PROLE_ID] = PROLE_ID
	join Person
		on PROLE_PERSON_ID = PN_ID
	where STEP_ID = isNull(CAST(nullIf(@PA_STEP_ID, '') as bigint), STEP_ID)
	  and isnull(STEP_NAME, '') like isNull(nullIf(@PA_STEP_NAME, '') + '%', isnull(STEP_NAME, ''))
	  and isnull(PN_SURNAME, '') like isNull(nullIf(@PA_STEP_OWNER, '') + '%', isnull(PN_SURNAME, ''))
	  and isnull(STEP_DESC, '') like isNull(nullIf(@PA_STEP_DESC, '') + '%', isnull(STEP_DESC, ''))
	order by STEP_NAME, STEP_ID

end