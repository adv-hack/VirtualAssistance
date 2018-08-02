if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceAccountFetchByXrefRoleIdandOrgId')
  exec ('create procedure dbo.spConsensusFinanceAccountFetchByXrefRoleIdandOrgId as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceAccountFetchByXrefRoleIdandOrgId(@PA_ACXREF_PROLE_ID varchar(11) = null output,@PA_ACXREF_ORG_ID varchar(11) = null output,@PA_ACC_SELCO_SP_ID varchar(11) = null output) as 
begin

	declare @Account_Xref table
	(
		A_ID int identity(1,1),
		A_ACC_ID varchar(11)
	)
	insert into @Account_Xref
	select ACXREF_ACC_ID from dbo.Account_Xref where ACXREF_PROLE_ID = @PA_ACXREF_PROLE_ID and isnull(@PA_ACXREF_PROLE_ID,'')<>'' 
	order by ACXREF_ADD_DATE

	insert into @Account_Xref
	select ACXREF_ACC_ID from dbo.Account_Xref 
	left join @Account_Xref ON A_ACC_ID = ACXREF_ACC_ID
	where isnull(A_ACC_ID,'')='' and ACXREF_ORG_ID = @PA_ACXREF_ORG_ID and isnull(@PA_ACXREF_ORG_ID,'')<>'' and isnull(ACXREF_PROLE_ID,'') <> @PA_ACXREF_PROLE_ID 
	order by ACXREF_ADD_DATE

	--delete any duplicates that have appeared
	declare @A_ID int,
	@A_ACC_ID varchar(11)

	DECLARE Accounts CURSOR LOCAL FORWARD_ONLY FOR
	select A_ID,A_ACC_ID from @Account_Xref order by A_ID
	OPEN Accounts
	FETCH Accounts INTO @A_ID,@A_ACC_ID
	WHILE (@@fetch_status=0)
	begin
		delete from @Account_Xref where A_ACC_ID = @A_ACC_ID and A_ID > @A_ID
		FETCH Accounts INTO @A_ID,@A_ACC_ID
	end 
	CLOSE Accounts
	DEALLOCATE Accounts

	insert into @Account_Xref
	select ACC_ID from dbo.Account
	left join @Account_Xref ON A_ACC_ID = ACC_ID
	where isnull(A_ACC_ID,'')='' and ACC_SELCO_SP_ID = @PA_ACC_SELCO_SP_ID and isnull(@PA_ACC_SELCO_SP_ID,'')<>'' and ACC_DEFAULT = 1 and substring(ACC_STATUS,1,1) not in ('9','3')


  select 
    ACC_ID,
    ACC_LOCK,
    ACC_ADD_DATE,
    ACC_ADD_BY,
    ACC_MOD_DATE,
    ACC_MOD_BY,
    ACC_RCV_DATE,
    ACC_RCV_FROM,
    ACC_SYSTEM,
    ACC_SYSTEM_REF,
    ACC_ORG_ID,
    ACC_PRINCIPAL,
    ACC_PROLE_ID,
    ACC_CONTACT_ID,
    ACC_ADD_ID,
    ACC_SELCO_SP_ID,
    ACC_NO_ADD_CHANGE,
    ACC_PAYMENT_DAYS,
    ACC_STATUS,
    ACC_PAYMENT_TYPE,
    ACC_PAY_TERMS_1,
    ACC_PAY_TERMS_2,
    ACC_PAY_TERMS_3,
    ACC_PAY_TERMS_4,
    ACC_CREDIT,
    ACC_SPECIAL_TERMS,
    ACC_VATCD,
    ACC_INV_FOR_ATTN_OF,
    ACC_INVOICE_RULE,
    ACC_INVOICE_RULE_OFFSET,
    ACC_INVOICE_CONSOLIDATE,
    ACC_INVOICE_WHEN_STATUS,
    ACC_INVOICE_FORMAT,
    ACC_INVOICE_MUST_USE_RULE,
    ACC_INVOICE_FORMAT_0_TEXT,
    ACC_INVOICE_FORMAT_1_TEXT,
    ACC_INVOICE_OFFSET_TYPE,
    ACC_INV_ADD_TO,
    ACC_NAT_ACCOUNT,
    ACC_BANK_NAME,
    ACC_BANK_SORT_CODE,
    ACC_BANK_NO,
    ACC_BANK_ADD_ID,
    ACC_PAYMENT_METHD,
    ACC_DOC_TYPE,
    ACC_COUT_OFF_DAYS,
    ACC_TYPE,
    ACC_TITLE,
    ACC_STATUS_DATE,
    ACC_BAT_ID,
    ACC_REQ_CREDIT,
    ACC_DOCS_METHOD,
    ACC_DO_NOT_CHASE,
    ACC_INV_PACK_ID,
    ACC_REQ_PAYMENT_TYPE,
    ACC_REQ_PAYMENT_DAYS,
    ACC_DEFAULT_INV_STATUS,
    ACC_CURRENCY_TYPE,
    ACC_VAT_REG_NUM,
    ACC_MEM_PAYMENT_DAYS,
    ACC_PO_REQ,
    ACC_RUN_DATE,
    ACC_PSH_ID,
    ACC_DEFAULT,
    ACC_RULE_TYPE,
    ACC_NAT_ACCOUNT_DATE,
    ACC_COURSE_LEN,
    ACC_RENEW_DAYS,
    ACC_FIXED_RENEWAL,
    ACC_RENEWAL_MONTH,
    ACC_RENEWAL_DAY,
    ACC_RENEW,
    ACC_EXCL_DAY
  from @Account_Xref
	join dbo.Account ON ACC_ID=A_ACC_ID
  where substring(ACC_STATUS,1,1) not in ('9','3') and ACC_SELCO_SP_ID = COALESCE(@PA_ACC_SELCO_SP_ID,ACC_SELCO_SP_ID)	
  order by A_ID

end
go
