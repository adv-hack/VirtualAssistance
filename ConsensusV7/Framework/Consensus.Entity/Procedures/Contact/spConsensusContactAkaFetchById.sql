if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAkaFetchById')
  exec ('create procedure dbo.spConsensusContactAkaFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusContactAkaFetchById(@PA_AKA_ID integer = null output) as 
begin
  select 
    AKA_ID,
    AKA_ADD_BY,
    AKA_ADD_DATE,
    AKA_MOD_BY,
    AKA_MOD_DATE,
    AKA_RCV_FROM,
    AKA_RCV_DATE,
    AKA_NAME,
    AKA_ORG_ID,
    AKA_PN_ID,
    AKA_TYPE
  from dbo.AKA
  where AKA_ID = @PA_AKA_ID
end
go
