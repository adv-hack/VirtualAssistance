if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAkaCreate')
  exec ('create procedure dbo.spConsensusContactAkaCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactAkaCreate(@PA_AKA_ID integer = null output, @PA_AKA_NAME varchar(80) = null output, @PA_AKA_ORG_ID varchar(11) = null output, @PA_AKA_PN_ID varchar(11) = null output, @PA_AKA_TYPE varchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.AKA(
    AKA_ADD_DATE,
    AKA_ADD_BY,
    AKA_MOD_DATE,
    AKA_MOD_BY,
    AKA_RCV_DATE,
    AKA_RCV_FROM,
    AKA_NAME,
    AKA_ORG_ID,
    AKA_PN_ID,
    AKA_TYPE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_AKA_NAME,
    @PA_AKA_ORG_ID,
    @PA_AKA_PN_ID,
    @PA_AKA_TYPE
  );
    set @PA_AKA_ID = @@identity;
end
go
