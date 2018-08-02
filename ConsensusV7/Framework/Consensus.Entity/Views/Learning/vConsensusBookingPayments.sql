if not exists (select object_id from sys.objects where name = 'vConsensusBookingPayments' and type = 'v')
  exec ('create view dbo.vConsensusBookingPayments as select 1 as temp')
go

alter view dbo.vConsensusBookingPayments as 
	select PAY_ID,
		PAY_BOOK_ID,
		PAY_DATE,
		PAY_TYPE,
		ACC_SYSTEM_REF,
		PAY_NAME,
		ORG_NAME,
		PAY_UNUSED_VAL,
		PAY_RECVD,
		PAY_ACC_ID,
		PAY_CURR_TYPE,
		PAY_ORG_ID,
		case PAY_TXN_TYPE when 0 then 'Payment' when 1 then 'Reversal' when 2 then 'Write off' when 3 then 'Refund' end PAYMENT_TYPE,
		isnull(nullif(PAY_REF,''),PAY_ID) PAY_REF,
		uri = 'finance/payment/' + convert(varchar, PAY_ID)
	from dbo.Payment
	left join Account ON Account.ACC_ID = Payment.PAY_ACC_ID
	Left join Organisation O ON O.ORG_ID = PAY_ORG_ID
	where PAY_TYPE not in ('Prepayment')

go

