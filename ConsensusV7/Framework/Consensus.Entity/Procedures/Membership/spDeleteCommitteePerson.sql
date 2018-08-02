if not exists (select object_id from sys.objects where type = 'P' and name = 'spDeleteCommitteePerson')
  exec ('create procedure dbo.spDeleteCommitteePerson as select 1 as temp')
go

ALTER PROCEDURE [dbo].[spDeleteCommitteePerson]
	@PA_COMXREF_ID varchar(11) = null,
	@PA_COMXREF_COM_ID varchar(11) = null
AS


begin tran
 
delete from Committee_Xref where COMXREF_ID=@PA_COMXREF_ID

if len(@PA_COMXREF_COM_ID) > 0
BEGIN
	update Committee 
	set COM_NO_PEOPLE = (select count(1) from Committee_Xref where COMXREF_COM_ID = @PA_COMXREF_COM_ID and COMXREF_TABLE_NAME = 'Person_role') 
	where COM_ID = @PA_COMXREF_COM_ID
END

commit tran
