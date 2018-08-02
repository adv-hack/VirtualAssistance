if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeFetchAllByDisid')
  exec ('create procedure dbo.spConsensusMembershipCommitteeFetchAllByDisid as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeFetchAllByDisid(@PA_COM_DIS_ID varchar(11) = null output) as 
begin
  select 
    COM_ID,
    COM_ADD_BY,
    COM_ADD_DATE,
    COM_MOD_BY,
    COM_MOD_DATE,
    COM_RCV_FROM,
    COM_RCV_DATE,
    COM_NAME,
    COM_STATUS,
    COM_TYPE,
    COM_START_DATE,
    COM_CATEGORY,
    COM_GROUP,
    COM_DIS_ID,
    COM_PROD_ID,
    COM_BR_ID,
    COM_EXT_URL,
    COM_SHOW_ON_ORG,
    COM_NO_PEOPLE
  from dbo.Committee
  where COM_DIS_ID = @PA_COM_DIS_ID
end
go
