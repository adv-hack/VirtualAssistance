if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeXrefRemoveById')
  exec ('create procedure dbo.spConsensusMembershipCommitteeXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeXrefRemoveById(@PA_COMXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Committee_Xref
  where COMXREF_ID = @PA_COMXREF_ID
end
go
