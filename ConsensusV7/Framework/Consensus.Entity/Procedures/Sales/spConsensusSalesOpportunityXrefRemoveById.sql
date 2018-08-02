if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesOpportunityXrefRemoveById')
  exec ('create procedure dbo.spConsensusSalesOpportunityXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSalesOpportunityXrefRemoveById(@PA_OPPXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Opportunity_Xref
  where OPPXREF_ID = @PA_OPPXREF_ID
end
go
