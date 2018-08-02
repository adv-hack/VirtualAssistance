if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchQueryStep')
  exec ('create procedure dbo.spConsensusSearchQueryStep as select 1 as temp')
go

alter procedure dbo.spConsensusSearchQueryStep
( 
	@PA_QRY_ID bigint = null
) 
as
begin

	select QSTEP_ID, STEP_ID, STEP_NAME, STEP_DESC, QSTEP_LINK, QSTEP_ORDER, QSTEP_ROLE_TOTAL, 
		QSTEP_PERSON_TOTAL, QSTEP_ORG_TOTAL, QSTEP_RESULT_COUNT, QSTEP_LINK_CHANGE,
		uri = 'marketing/saqquerystep/' + CAST(QSTEP_ID as varchar(25))
	from dbo.Saq_Query_Steps
	inner join Saq_Step on STEP_ID = QSTEP_STEP_ID
	where @PA_QRY_ID = QSTEP_QRY_ID
	order by QSTEP_QRY_ID, QSTEP_ORDER

end