if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductEventModify')
  exec ('create procedure dbo.spConsensusLearningProductEventModify as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductEventModify(@PA_PE_ID integer = null output, @PA_PE_PROD_ID varchar(11) = null output, @PA_PE_INSTANCE integer = null output, @PA_PE_ACADY_CODE nvarchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Product_Event set
    PE_MOD_DATE = getDate(),
    PE_MOD_BY = @_AUDIT_USER_ID,
    PE_PROD_ID = @PA_PE_PROD_ID,
    PE_INSTANCE = @PA_PE_INSTANCE,
    PE_ACADY_CODE = @PA_PE_ACADY_CODE
  where PE_ID = @PA_PE_ID;
end
go
