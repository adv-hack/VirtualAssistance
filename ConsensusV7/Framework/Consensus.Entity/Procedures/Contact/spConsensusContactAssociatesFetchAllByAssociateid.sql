if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAssociatesFetchAllByAssociateid')
  exec ('create procedure dbo.spConsensusContactAssociatesFetchAllByAssociateid as select 1 as temp')
go
alter procedure dbo.spConsensusContactAssociatesFetchAllByAssociateid(@PA_ASSO_ASSOCIATE_ID varchar(11) = null output) as 
begin
  select 
    ASSO_ID,
    ASSO_ADD_DATE,
    ASSO_ADD_BY,
    ASSO_MOD_DATE,
    ASSO_MOD_BY,
    ASSO_RCV_DATE,
    ASSO_RCV_FROM,
    ASSO_ASSOCIATE_ID,
    ASSO_PROLE_ID,
    ASSO_ORG_ID,
    ASSO_TYPE,
    ASSO_TYPE_NAME,
    ASSO_TYPE_CODE,
    ASSO_START_DATE,
    ASSO_END_DATE
  from dbo.Associates
  where ASSO_ASSOCIATE_ID = @PA_ASSO_ASSOCIATE_ID
end
go
