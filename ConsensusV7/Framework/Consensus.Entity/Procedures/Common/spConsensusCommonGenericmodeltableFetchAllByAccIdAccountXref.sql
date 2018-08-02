if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonGenericmodeltableFetchAllByAccIdAccountXref')
  exec ('create procedure dbo.spConsensusCommonGenericmodeltableFetchAllByAccIdAccountXref as select 1 as temp')
go
alter procedure dbo.spConsensusCommonGenericmodeltableFetchAllByAccIdAccountXref(@PA_ACC_ID varchar(11) = null output,@PA_PROLE_ID varchar(11) = null output) as 
begin

	declare @Accountxref table
	(
	ID int identity(1,1),
	ACXREF_ID varchar(11),
	ACXREF_ACC_ID varchar(11),
	ACXREF_ORG_ID varchar(11),
	ACXREF_PROLE_ID varchar(11),
	ACXREF_ADD_ID varchar(11),
	ACXREF_MUST_USE tinyint
	)

	insert into @Accountxref
	select ACXREF_ID,ACXREF_ACC_ID,ACXREF_ORG_ID,ACXREF_PROLE_ID,ACXREF_ADD_ID,ACXREF_NO_ADD_CHANGE
	from dbo.Account_Xref
	where ACXREF_ACC_ID=@PA_ACC_ID and ACXREF_NO_ADD_CHANGE = 1

	if (select count(1) from @Accountxref) = 0
	begin
		insert into @Accountxref
		select ACXREF_ID,ACXREF_ACC_ID,ACXREF_ORG_ID,ACXREF_PROLE_ID,ACXREF_ADD_ID,ACXREF_NO_ADD_CHANGE
		from dbo.Account_Xref
		where ACXREF_ACC_ID=@PA_ACC_ID and ACXREF_INVOICE = 1	

		insert into @Accountxref
		select '',@PA_ACC_ID,PROLE_ORG_ID,PROLE_ID,PROLE_ADD_ID,0 from dbo.Person_Role 
		left join @Accountxref ON isnull(ACXREF_ORG_ID,'') = isnull(PROLE_ORG_ID,'') and ACXREF_PROLE_ID = PROLE_ID and ACXREF_ADD_ID = PROLE_ADD_ID
		where PROLE_ID=@PA_PROLE_ID and ID is null
	end


  select 
    ID GMT_ID,
    ACXREF_ID GMT_ID1,
    ACXREF_ORG_ID GMT_ID2,
    ACXREF_PROLE_ID GMT_ID3,
    ACXREF_ADD_ID GMT_ID4,
    '' GMT_ID5,
    ORG_NAME GMT_DESC1,
    PROLE_PN_NAME GMT_DESC2,
    ACC_SYSTEM_REF GMT_DESC3,
    ACC_VATCD GMT_DESC4,
    ACC_PO_REQ GMT_DESC5,
    ADD_MAILSTRING GMT_LONGDESC,
    null GMT_DATE1,
    null GMT_DATE2,
    null GMT_DATE3,
    ACXREF_MUST_USE GMT_INT1,
    case substring(isnull(ACR_ACTION,'00'),1,2) when '01' then 1 else 0 end GMT_INT2,
    0 GMT_INT3,
    0 GMT_MONEY1,
    0 GMT_MONEY2,
    0 GMT_MONEY3
  from @Accountxref
	join dbo.Address ON ADD_ID=ACXREF_ADD_ID
	join dbo.Account ON ACC_ID=ACXREF_ACC_ID
	left join dbo.Person_Role ON PROLE_ID=ACXREF_PROLE_ID
	left join dbo.Organisation ON ORG_ID=ACXREF_ORG_ID
	left join dbo.Account_Rules ON ACR_CODE=ACC_STATUS and ACR_SELCO_SP_ID = ACC_SELCO_SP_ID
end
go
