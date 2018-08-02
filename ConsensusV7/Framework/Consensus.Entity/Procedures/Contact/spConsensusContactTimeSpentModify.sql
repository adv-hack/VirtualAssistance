if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactTimeSpentModify')
  exec ('create procedure dbo.spConsensusContactTimeSpentModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactTimeSpentModify(@PA_TIM_ID varchar(11) = null output, @PA_TIM_ACT_ID varchar(11) = null output, @PA_TIM_ROLE_ID varchar(11) = null output, @PA_TIM_HOURS float = null output, @PA_TIM_DATE datetime = null output, @PA_TIM_TYPE varchar(25) = null output, @PA_TIM_COST_CODE varchar(40) = null output, @PA_TIM_DESC varchar(255) = null output, @PA_TIM_LOCK varchar(11) = null output, @PA_TIM_ORG_ID varchar(11) = null output, @PA_TIM_PROJ_ID varchar(11) = null output, @PA_TIM_TRA_HOURS float = null output, @PA_TIM_HOU_CHARGE float = null output, @PA_TIM_TRA_CHARGE float = null output, @PA_TIM_MILEAGE decimal(19, 2) = null output, @PA_TIM_EXPENSES decimal(19, 2) = null output, @PA_TIM_BAT_ID varchar(11) = null output, @PA_TIM_CST_AC float = null output, @PA_TIM_UNT_TYPE varchar(1) = null output, @PA_TIM_DROPDOWN_1 varchar(25) = null output, @PA_TIM_TRAIN_SY_TYPE smallint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Time_Spent set
    TIM_MOD_DATE = getDate(),
    TIM_MOD_BY = @_AUDIT_USER_ID,
    TIM_ACT_ID = @PA_TIM_ACT_ID,
    TIM_ROLE_ID = @PA_TIM_ROLE_ID,
    TIM_HOURS = @PA_TIM_HOURS,
    TIM_DATE = @PA_TIM_DATE,
    TIM_TYPE = @PA_TIM_TYPE,
    TIM_COST_CODE = @PA_TIM_COST_CODE,
    TIM_DESC = @PA_TIM_DESC,
    TIM_LOCK = @PA_TIM_LOCK,
    TIM_ORG_ID = @PA_TIM_ORG_ID,
    TIM_PROJ_ID = @PA_TIM_PROJ_ID,
    TIM_TRA_HOURS = @PA_TIM_TRA_HOURS,
    TIM_HOU_CHARGE = @PA_TIM_HOU_CHARGE,
    TIM_TRA_CHARGE = @PA_TIM_TRA_CHARGE,
    TIM_MILEAGE = @PA_TIM_MILEAGE,
    TIM_EXPENSES = @PA_TIM_EXPENSES,
    TIM_BAT_ID = @PA_TIM_BAT_ID,
    TIM_CST_AC = @PA_TIM_CST_AC,
    TIM_UNT_TYPE = @PA_TIM_UNT_TYPE,
    TIM_DROPDOWN_1 = @PA_TIM_DROPDOWN_1,
    TIM_TRAIN_SY_TYPE = @PA_TIM_TRAIN_SY_TYPE
  where TIM_ID = @PA_TIM_ID;
end
go
