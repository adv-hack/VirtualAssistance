if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchStepParameter')
  exec ('create procedure dbo.spConsensusSearchStepParameter as select 1 as temp')
go

alter procedure dbo.spConsensusSearchStepParameter
( 
	@PA_STEP_ID bigint = null
) 
as
begin

declare @Ops table (O_OPERAND varchar(15) PRIMARY KEY, O_OP_DESC nvarchar(35))

INSERT INTO @Ops(O_OPERAND, O_OP_DESC)
select 'EQUALS', 'is equal to'
union all
select 'CONTAINS', 'contains'
union all
select 'STARTS WITH', 'starts with'
union all
select 'ENDS WITH', 'ends with'
union all
select '<>', 'does not equal'
union all
select '>', 'is greater than'
union all
select '<', 'is less than'
union all
select '>=', 'is greater than or equal to'
union all
select '<=', 'is less than or equal to'
--  IN and NOT IN were not mentioned in the user story, but may be in the database
union all
select 'IN', 'is in'
union all
select 'NOT IN', 'is not in'


	select STPRM_ID, STPRM_F_ID, F_COLUMN_DESC, 
		/*CASE STPRM_ORDER WHEN MIN_ORDER THEN NULL ELSE STPRM_CONDITION END AS*/ STPRM_CONDITION, STPRM_VALUE,
		ISNULL(O_OP_DESC, STPRM_OPERAND) AS OPERAND_DESC, STPRM_ORDER, STPRM_PRE_BRACKET, STPRM_POST_BRACKET,
		uri = 'marketing/saqparameter/' + CAST(STPRM_ID as varchar(25))
	from dbo.SAQ_STEP_PARAMS
	left join dbo.SAQ_FILTER on STPRM_F_ID = F_ID
	left join @Ops on STPRM_OPERAND = O_OPERAND
	--join (SELECT MIN(STPRM_ORDER) as MIN_ORDER, STPRM_STEP_ID as MIN_STEP_ID
	--		from dbo.SAQ_STEP_PARAMS
	--		group by STPRM_STEP_ID) AS M
	--	on M.MIN_STEP_ID = STPRM_STEP_ID
	where @PA_STEP_ID = STPRM_STEP_ID
	order by STPRM_ORDER, F_COLUMN_NAME


end