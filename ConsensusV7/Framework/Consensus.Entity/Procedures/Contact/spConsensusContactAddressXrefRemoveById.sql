if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAddressXrefRemoveById')
  exec ('create procedure dbo.spConsensusContactAddressXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactAddressXrefRemoveById(@PA_ADDXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Address_Xref
  where ADDXREF_ID = @PA_ADDXREF_ID
end
go
