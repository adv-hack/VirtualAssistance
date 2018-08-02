if not exists (select object_id from sys.objects where name = 'vConsensusAttachments' and type = 'v')
  exec ('create view dbo.vConsensusAttachments as select 1 as temp')
go

alter view dbo.vConsensusAttachments as 
    select
    ATT_ID				= Attachment.ATT_ID,
    ATT_MIME			= Attachment.ATT_MIME,
    ATT_FILE_NAME		= Attachment.ATT_FILE_NAME,
    ATT_ADD_BY			= Attachment.ATT_ADD_BY,
    ATT_ADD_DATE		= Attachment.ATT_ADD_DATE,
    ATT_CATEGORY		= Attachment.ATT_CATEGORY,
    ATT_VISIBILITY		= CASE Attachment.ATT_VISIBILITY
							WHEN 0 THEN 'Booked On'
							WHEN 1 THEN 'Training On'
							WHEN 2 THEN 'Always'
							END,
    ATT_WEB				= Attachment.ATT_WEB,
    ATT_TABLE_URL		= Attachment.ATT_TABLE_URL,
    ATT_RECORD_ID		= Attachment.ATT_RECORD_ID,
	ATT_ORDER_NUM		= Attachment.ATT_ORDER_NUM,
	stuff((SELECT distinct ', ' + LZC_CATEGORY_TITLE + '' from dbo.LearningZoneCategories join dbo.AttachLearningZoneCategories on LZC_ID = ATTLZC_LZC_ID  where ATTLZC_ATT_ID = ATT_ID FOR XML PATH('')),1,2, '') LZC_CATEGORY_TITLE,

	uri                  = 'common/attachment/' + convert(varchar, ATT_ID)
  from dbo.Attachment
  where isnull(ATT_TYPE,0) in (0,1,2,3,4,5,6)
go