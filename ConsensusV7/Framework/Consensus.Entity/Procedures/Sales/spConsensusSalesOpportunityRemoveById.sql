if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesOpportunityRemoveById')
  exec ('create procedure dbo.spConsensusSalesOpportunityRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSalesOpportunityRemoveById(@PA_OPP_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Opportunity
  where OPP_ID = @PA_OPP_ID
end
go
