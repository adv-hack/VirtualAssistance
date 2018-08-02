if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductProdXrefModify')
  exec ('create procedure dbo.spConsensusLearningProductProdXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductProdXrefModify(@PA_PPX_ID integer = null output, @PA_PPX_MAST_PROD_ID varchar(11) = null output, @PA_PPX_SIM_PROD_ID varchar(11) = null output, @PA_PPX_NOTES varchar(500) = null output, @PA_PPX_PREREQ tinyint = null output, @PA_PPX_SCHN_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Product_Prod_Xref set
    PPX_MOD_DATE = getDate(),
    PPX_MOD_BY = @_AUDIT_USER_ID,
    PPX_MAST_PROD_ID = @PA_PPX_MAST_PROD_ID,
    PPX_SIM_PROD_ID = @PA_PPX_SIM_PROD_ID,
    PPX_NOTES = @PA_PPX_NOTES,
    PPX_PREREQ = @PA_PPX_PREREQ,
    PPX_SCHN_ID = @PA_PPX_SCHN_ID
  where PPX_ID = @PA_PPX_ID;
end
go
