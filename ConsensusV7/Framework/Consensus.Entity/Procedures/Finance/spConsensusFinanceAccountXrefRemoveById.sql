if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceAccountXrefRemoveById')
  exec ('create procedure dbo.spConsensusFinanceAccountXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceAccountXrefRemoveById(@PA_ACXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Account_Xref
  where ACXREF_ID = @PA_ACXREF_ID
end
go
