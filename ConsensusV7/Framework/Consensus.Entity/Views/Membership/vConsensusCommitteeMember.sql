if not exists (select object_id from sys.objects where name = 'vConsensusCommitteeMember')
  exec ('create view dbo.vConsensusCommitteeMember as select 1 as temp')
go

ALTER view [dbo].[vConsensusCommitteeMember] as 
	select 
	COMXREF_ID,
	COMXREF_COM_ID,
	COM_ID,
	COM_NAME,
	COMXREF_ROLE,
	COMXREF_RECORD_ID,
	PROLE_PERSON_ID,
	PROLE_PHONE,
	PROLE_EMAIL,
	PROLE_ORG_ID,
	PROLE_ORG_NAME,
	PROLE_PN_NAME,
	COMXREF_DATE,
	uri ='membership/committeexref/'+convert(varchar,COMXREF_ID)
	from Committee_Xref
	join Committee on COM_ID=COMXREF_COM_ID
	join Person_Role on PROLE_ID=COMXREF_RECORD_ID



GO





