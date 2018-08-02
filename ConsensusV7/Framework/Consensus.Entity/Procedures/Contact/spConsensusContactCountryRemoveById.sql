if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCountryRemoveById')
  exec ('create procedure dbo.spConsensusContactCountryRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactCountryRemoveById(@PA_CO_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Country
  where CO_ID = @PA_CO_ID
end
go
