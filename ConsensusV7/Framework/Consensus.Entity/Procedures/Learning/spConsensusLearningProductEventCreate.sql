if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductEventCreate')
  exec ('create procedure dbo.spConsensusLearningProductEventCreate as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductEventCreate(@PA_PE_ID integer = null output, @PA_PE_PROD_ID varchar(11) = null output, @PA_PE_INSTANCE integer = null output, @PA_PE_ACADY_CODE nvarchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Product_Event(
    PE_ADD_DATE,
    PE_ADD_BY,
    PE_MOD_DATE,
    PE_MOD_BY,
    PE_RCV_DATE,
    PE_RCV_FROM,
    PE_PROD_ID,
    PE_INSTANCE,
    PE_ACADY_CODE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PE_PROD_ID,
    @PA_PE_INSTANCE,
    @PA_PE_ACADY_CODE
  );
    set @PA_PE_ID = @@identity;
end
go
