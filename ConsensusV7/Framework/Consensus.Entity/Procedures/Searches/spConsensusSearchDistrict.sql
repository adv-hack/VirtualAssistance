IF NOT EXISTS (SELECT OBJECT_ID FROM sys.objects where type='P' and name='spConsensusSearchDistrict')
	exec('create procedure dbo.spConsensusSearchDistrict as select 1 as temp')
GO

ALTER PROCEDURE dbo.spConsensusSearchDistrict(
 @PA_DIS_ID varchar(11) = null,
 @PA_DIS_NAME varchar(255) = null,
 @PA_DIS_REGION varchar(40) = null,
 @PA_DIS_STATUS varchar(40) = null,
 @PA_DIS_TYPE varchar(40) = null,
 @PA_DIS_CATEGORY varchar(40) = null,
 @PA_DIS_GROUP varchar(40) = null
 )AS

 BEGIN

 SELECT DIS_ID,
	DIS_NAME,
	DIS_STATUS,
	DIS_REGION,
	DIS_TYPE,
	DIS_CATEGORY,
	DIS_GROUP
	FROM District
	where DIS_ID=ISNULL(nullIf(@PA_DIS_ID,''),DIS_ID)
		and DIS_NAME like ISNULL(nullIf(@PA_DIS_NAME,'')+'%',DIS_NAME)
		and ISNULL(DIS_STATUS,'') like ISNULL(nullIf(@PA_DIS_STATUS,'')+'%',ISNULL(DIS_STATUS,''))
		and ISNULL(DIS_REGION,'') like ISNULL(nullIf(@PA_DIS_REGION,'')+'%',ISNULL(DIS_REGION,''))
		and ISNULL(DIS_TYPE,'') like ISNULL(nullIf(@PA_DIS_TYPE,'')+'%',ISNULL(DIS_TYPE,''))
		and ISNULL(DIS_CATEGORY,'') like ISNULL(nullIf(@PA_DIS_CATEGORY,'')+'%',ISNULL(DIS_CATEGORY,''))
		and ISNULL(DIS_GROUP,'') like ISNULL(nullIf(@PA_DIS_GROUP,'')+'%',ISNULL(DIS_GROUP,''))
		ORDER BY DIS_NAME, DIS_STATUS	
END

