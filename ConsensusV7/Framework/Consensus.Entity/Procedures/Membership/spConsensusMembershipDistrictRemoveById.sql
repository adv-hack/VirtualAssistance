if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipDistrictRemoveById')
  exec ('create procedure dbo.spConsensusMembershipDistrictRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipDistrictRemoveById(@PA_DIS_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.District
  where DIS_ID = @PA_DIS_ID
end
go
