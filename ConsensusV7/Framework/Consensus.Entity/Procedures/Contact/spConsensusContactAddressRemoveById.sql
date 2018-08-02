if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAddressRemoveById')
  exec ('create procedure dbo.spConsensusContactAddressRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactAddressRemoveById(@PA_ADD_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Address
  where ADD_ID = @PA_ADD_ID
end
go
