if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductProdXrefCreate')
  exec ('create procedure dbo.spConsensusLearningProductProdXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductProdXrefCreate(@PA_PPX_ID integer = null output, @PA_PPX_MAST_PROD_ID varchar(11) = null output, @PA_PPX_SIM_PROD_ID varchar(11) = null output, @PA_PPX_NOTES varchar(500) = null output, @PA_PPX_PREREQ tinyint = null output, @PA_PPX_SCHN_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Product_Prod_Xref(
    PPX_ADD_DATE,
    PPX_ADD_BY,
    PPX_MOD_DATE,
    PPX_MOD_BY,
    PPX_RCV_DATE,
    PPX_RCV_FROM,
    PPX_MAST_PROD_ID,
    PPX_SIM_PROD_ID,
    PPX_NOTES,
    PPX_PREREQ,
    PPX_SCHN_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PPX_MAST_PROD_ID,
    @PA_PPX_SIM_PROD_ID,
    @PA_PPX_NOTES,
    @PA_PPX_PREREQ,
    @PA_PPX_SCHN_ID
  );
    set @PA_PPX_ID = @@identity;
end
go
