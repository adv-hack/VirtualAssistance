if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAkaModify')
  exec ('create procedure dbo.spConsensusContactAkaModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactAkaModify(@PA_AKA_ID integer = null output, @PA_AKA_NAME varchar(80) = null output, @PA_AKA_ORG_ID varchar(11) = null output, @PA_AKA_PN_ID varchar(11) = null output, @PA_AKA_TYPE varchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.AKA set
    AKA_MOD_DATE = getDate(),
    AKA_MOD_BY = @_AUDIT_USER_ID,
    AKA_NAME = @PA_AKA_NAME,
    AKA_ORG_ID = @PA_AKA_ORG_ID,
    AKA_PN_ID = @PA_AKA_PN_ID,
    AKA_TYPE = @PA_AKA_TYPE
  where AKA_ID = @PA_AKA_ID;
end
go
