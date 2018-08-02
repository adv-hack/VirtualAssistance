if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchPromotion')
  exec ('create procedure dbo.spConsensusSearchPromotion as select 1 as temp')
go
alter procedure dbo.spConsensusSearchPromotion 
( 
@PA_CMP_NAME varchar(250) = null,
@PA_PM_MST_NAME varchar(250) = null,
@PA_PM_NAME varchar(250) = null,
@PA_CMP_START_DATE datetime = null,
@PA_CMP_END_DATE datetime = null,
@PA_PM_MEDIA_NAME varchar(250) = null,
@PA_PM_CHANNEL varchar(250) = null,
@PA_PM_TYPE varchar(250) = null,
@PA_CMP_QCODE varchar(250) = null
) 
as
begin

	select CMP_ID,CMP_NAME,PM_MST_ID,PM_MST_NAME,PM_ID,PM_NAME,PM_MEDIA_NAME,PM_CHANNEL,substring(TEXT_BODY,1,200) TEXT_BODY 
	from Campaign 
	left outer join Promotion_Master ON PM_MST_CMP_ID = CMP_ID 
	left outer join Promotion ON PM_CMP_ID = PM_MST_ID 
	Left outer join C4Text on PM_TEXT_ID = TEXT_ID
	
	where PM_CURRENT = 1
	  and CMP_NAME like isNull(nullIf(@PA_CMP_NAME, '') + '%', CMP_NAME)
	  and PM_MST_NAME like isNull(nullIf(@PA_PM_MST_NAME, '') + '%', PM_MST_NAME)
	  and PM_NAME like isNull(nullIf(@PA_PM_NAME, '') + '%', PM_NAME)
	  and (CMP_START_DATE >= (nullIf(@PA_CMP_START_DATE, '')) or isNull(@PA_CMP_START_DATE, '') = '')	  
	  and (isnull(CMP_END_DATE,'') <= (nullIf(@PA_CMP_END_DATE, '')) or isNull(@PA_CMP_END_DATE, '') = '')	
	  and isnull(PM_MEDIA_NAME,'') like isNull(nullIf(@PA_PM_MEDIA_NAME, '') + '%', isnull(PM_MEDIA_NAME,''))
	  and isnull(PM_CHANNEL,'') like isNull(nullIf(@PA_PM_CHANNEL, '') + '%', isnull(PM_CHANNEL,''))
	  and isnull(PM_TYPE,'') like isNull(nullIf(@PA_PM_TYPE, '') + '%', isnull(PM_TYPE,''))
	  and isnull(CMP_QCODE,'') like isNull(nullIf(@PA_CMP_QCODE, '') + '%', isnull(CMP_QCODE,''))
			
	order by PM_NAME,PM_MST_NAME,CMP_NAME

end


