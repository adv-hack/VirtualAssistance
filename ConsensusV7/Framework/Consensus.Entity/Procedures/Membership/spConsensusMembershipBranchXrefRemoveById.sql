if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipBranchXrefRemoveById')
  exec ('create procedure dbo.spConsensusMembershipBranchXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipBranchXrefRemoveById(@PA_BRXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Branch_Xref
  where BRXREF_ID = @PA_BRXREF_ID
end
go
