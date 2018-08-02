if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceGiftaidclaimModify')
  exec ('create procedure dbo.spConsensusFinanceGiftaidclaimModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceGiftaidclaimModify(@PA_GAC_ID integer = null output, @PA_GAC_SUBMITTER_PROLE_ID varchar(11) = null output, @PA_GAC_TRUSTEE_PROLE_ID varchar(11) = null output, @PA_GAC_ORG_ID varchar(11) = null output, @PA_GAC_CLAIM_DATE datetime = null output, @PA_GAC_DONATIONS_FROM datetime = null output, @PA_GAC_DONATIONS_TO datetime = null output, @PA_GAC_ACCOUNTING_PERIOD_END datetime = null output, @PA_GAC_HMRC_REFERENCE varchar(50) = null output, @PA_GAC_REGULATOR_NAME varchar(200) = null output, @PA_GAC_REGULATOR_NUMBER varchar(20) = null output, @PA_GAC_ADJUSTMENT decimal(19, 4) = null output, @PA_GAC_PROCESS tinyint = null output, @PA_GAC_SELCO_SP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.GiftAidClaim set
    GAC_MOD_DATE = getDate(),
    GAC_MOD_BY = @_AUDIT_USER_ID,
    GAC_SUBMITTER_PROLE_ID = @PA_GAC_SUBMITTER_PROLE_ID,
    GAC_TRUSTEE_PROLE_ID = @PA_GAC_TRUSTEE_PROLE_ID,
    GAC_ORG_ID = @PA_GAC_ORG_ID,
    GAC_CLAIM_DATE = @PA_GAC_CLAIM_DATE,
    GAC_DONATIONS_FROM = @PA_GAC_DONATIONS_FROM,
    GAC_DONATIONS_TO = @PA_GAC_DONATIONS_TO,
    GAC_ACCOUNTING_PERIOD_END = @PA_GAC_ACCOUNTING_PERIOD_END,
    GAC_HMRC_REFERENCE = @PA_GAC_HMRC_REFERENCE,
    GAC_REGULATOR_NAME = @PA_GAC_REGULATOR_NAME,
    GAC_REGULATOR_NUMBER = @PA_GAC_REGULATOR_NUMBER,
    GAC_ADJUSTMENT = @PA_GAC_ADJUSTMENT,
    GAC_PROCESS = @PA_GAC_PROCESS,
    GAC_SELCO_SP_ID = @PA_GAC_SELCO_SP_ID
  where GAC_ID = @PA_GAC_ID;
end
go
