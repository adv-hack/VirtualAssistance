IF NOT EXISTS (SELECT OBJECT_ID FROM sys.objects where type='P' and name='spConsensusSearchCommittee')
	exec('create procedure dbo.spConsensusSearchCommittee as select 1 as temp')
GO

ALTER PROCEDURE [dbo].[spConsensusSearchCommittee](
 @PA_COM_ID varchar(11) = null,
 @PA_COM_NAME varchar(255) = null,
 @PA_COM_STATUS varchar(40) = null,
 @PA_COM_TYPE varchar(40) = null,
 @PA_COM_CATEGORY varchar(40) = null,
 @PA_COM_GROUP varchar(40) = null
 )AS

 BEGIN

 SELECT COM_ID,
	COM_NAME,
	COM_STATUS,	
	COM_TYPE,
	COM_CATEGORY,
	COM_GROUP
	FROM Committee
	where COM_ID=ISNULL(nullIf(@PA_COM_ID,''),COM_ID)
		and COM_NAME like ISNULL(nullIf(@PA_COM_NAME,'')+'%',COM_NAME)
		and ISNULL(COM_STATUS,'') like ISNULL(nullIf(@PA_COM_STATUS,'')+'%',ISNULL(COM_STATUS,''))
		and ISNULL(COM_TYPE,'') like ISNULL(nullIf(@PA_COM_TYPE,'')+'%',ISNULL(COM_TYPE,''))
		and ISNULL(COM_CATEGORY,'') like ISNULL(nullIf(@PA_COM_CATEGORY,'')+'%',ISNULL(COM_CATEGORY,''))
		and ISNULL(COM_GROUP,'') like ISNULL(nullIf(@PA_COM_GROUP,'')+'%',ISNULL(COM_GROUP,''))
		ORDER BY COM_NAME, COM_STATUS	
END

