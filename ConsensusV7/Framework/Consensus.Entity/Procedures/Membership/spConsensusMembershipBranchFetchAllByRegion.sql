if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipBranchFetchAllByRegion')
  exec ('create procedure dbo.spConsensusMembershipBranchFetchAllByRegion as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipBranchFetchAllByRegion(@PA_BR_REGION varchar(40) = null output) as 
begin
  select 
    BR_ID,
    BR_ADD_BY,
    BR_ADD_DATE,
    BR_MOD_BY,
    BR_MOD_DATE,
    BR_RCV_FROM,
    BR_RCV_DATE,
    BR_NAME,
    BR_STATUS,
    BR_TYPE,
    BR_CATEGORY,
    BR_GROUP,
    BR_REGION,
    BR_WEB,
    BR_EXT_URL
  from dbo.Branch
  where BR_REGION = @PA_BR_REGION
end
go
