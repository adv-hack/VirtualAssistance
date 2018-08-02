if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactTimeSpentRemoveById')
  exec ('create procedure dbo.spConsensusContactTimeSpentRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactTimeSpentRemoveById(@PA_TIM_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Time_Spent
  where TIM_ID = @PA_TIM_ID
end
go
