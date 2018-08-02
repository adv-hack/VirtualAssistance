if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAkaFetchAllByOrgid')
  exec ('create procedure dbo.spConsensusContactAkaFetchAllByOrgid as select 1 as temp')
go
alter procedure dbo.spConsensusContactAkaFetchAllByOrgid(@PA_AKA_ORG_ID varchar(11) = null output) as 
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
  where AKA_ORG_ID = @PA_AKA_ORG_ID
end
go
