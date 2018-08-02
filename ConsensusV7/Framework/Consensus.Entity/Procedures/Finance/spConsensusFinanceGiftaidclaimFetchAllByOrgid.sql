if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceGiftaidclaimFetchAllByOrgid')
  exec ('create procedure dbo.spConsensusFinanceGiftaidclaimFetchAllByOrgid as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceGiftaidclaimFetchAllByOrgid(@PA_GAC_ORG_ID varchar(11) = null output) as 
begin
  select 
    GAC_ID,
    GAC_ADD_DATE,
    GAC_ADD_BY,
    GAC_MOD_DATE,
    GAC_MOD_BY,
    GAC_SUBMITTER_PROLE_ID,
    GAC_TRUSTEE_PROLE_ID,
    GAC_ORG_ID,
    GAC_CLAIM_DATE,
    GAC_DONATIONS_FROM,
    GAC_DONATIONS_TO,
    GAC_ACCOUNTING_PERIOD_END,
    GAC_HMRC_REFERENCE,
    GAC_REGULATOR_NAME,
    GAC_REGULATOR_NUMBER,
    GAC_ADJUSTMENT,
    GAC_PROCESS,
    GAC_SELCO_SP_ID
  from dbo.GiftAidClaim
  where GAC_ORG_ID = @PA_GAC_ORG_ID
end
go
