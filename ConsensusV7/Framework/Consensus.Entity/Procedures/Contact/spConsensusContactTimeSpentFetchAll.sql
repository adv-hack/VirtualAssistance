if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactTimeSpentFetchAll')
  exec ('create procedure dbo.spConsensusContactTimeSpentFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusContactTimeSpentFetchAll as 
begin
  select 
    TIM_ID,
    TIM_ADD_DATE,
    TIM_ADD_BY,
    TIM_MOD_DATE,
    TIM_MOD_BY,
    TIM_RCV_DATE,
    TIM_RCV_FROM,
    TIM_ACT_ID,
    TIM_ROLE_ID,
    TIM_HOURS,
    TIM_DATE,
    TIM_TYPE,
    TIM_COST_CODE,
    TIM_DESC,
    TIM_LOCK,
    TIM_ORG_ID,
    TIM_PROJ_ID,
    TIM_TRA_HOURS,
    TIM_HOU_CHARGE,
    TIM_TRA_CHARGE,
    TIM_MILEAGE,
    TIM_EXPENSES,
    TIM_BAT_ID,
    TIM_CST_AC,
    TIM_UNT_TYPE,
    TIM_DROPDOWN_1,
    TIM_TRAIN_SY_TYPE
  from dbo.Time_Spent
end
go
