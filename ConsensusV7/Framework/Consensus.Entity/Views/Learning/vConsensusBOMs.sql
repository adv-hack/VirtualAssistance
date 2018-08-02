if not exists (select object_id from sys.objects where name = 'vConsensusBOMs' and type = 'v')
  exec ('create view dbo.vConsensusBOMs as select 1 as temp')
go


ALTER view dbo.vConsensusBOMs as 
	select BOM_ID,BOM_PARENT_ID,BOM_SYLLABUS_ID,BOM_TYPE,BOM_REAL,BOM_SESSION,BOM_ELEMENT,BOM_CHARGEABLE,BOM_INVOICE_PRINT,BOM_SHOW_SALES,
		COALESCE(Syl.PROD_REF,Acc.PROD_REF) PROD_REF,COALESCE(Syl.PROD_NAME,Acc.PROD_NAME) PROD_NAME,BOM_TYPE_SUB,BOM_MAIN_SESSION,
		case BOM_MANDATORY when 1 then 'Yes' when 2 then 'Recommended' else 'No' end BOM_MANDATORY,BOM_ACT_SESSION_NAME,BOM_ACT_TYPE,BOM_CODE,BOM_START_DAY,BOM_END_DAY,
		convert(varchar(5), BOM_START_TIME, 108) as BOM_START_TIME, convert(varchar(5), BOM_END_TIME, 108) as BOM_END_TIME,
		BOM_START_DAY_TEXT = case when BOM_TYPE = 'Exam' then
								case when BOM_SESSION = 1 then cast(BOM_START_DAY as varchar(20)) else 'N/A' end
							else cast(BOM_START_DAY as varchar(20))
						end,
		BOM_END_DAY_TEXT = case when BOM_TYPE = 'Exam' then
								case when BOM_SESSION = 1 then cast(BOM_END_DAY as varchar(20)) else 'N/A' end
							else cast(BOM_END_DAY as varchar(20))
						end,
		PROD_START_DATE_FIXED =  CASE CAST(Syl.PROD_START_DATE_TYPE   AS VARCHAR) 
			 WHEN '0' then ''  
			 When '1' then Convert(varchar,Syl.PROD_START_DATE_FIXED, 106) 
			 When '2' then '' 
		END, 
        PROD_END_DATE_FIXED =  CASE CAST(Syl.PROD_END_DATE_TYPE   AS VARCHAR) 
			 WHEN '0' then ''  
			 When '1' then Convert(varchar, Syl.PROD_END_DATE_FIXED, 106) 
			 When '2' then '' 
		END,
		PROD_START_DATE_TYPE = CASE when BOM_SESSION = 0 then
								CASE Syl.PROD_START_DATE_TYPE
									when 0 then 'Default'
									when 1 then 'Fixed'
									when 2 then 'Offset'
								end
							else
								'N/A'
							end,

		PROD_END_DATE_TYPE = CASE when BOM_SESSION = 0 then
								CASE Syl.PROD_END_DATE_TYPE
									when 0 then 'Default'
									when 1 then 'Fixed'
									when 2 then 'Offset'
								end
							else
								'N/A'
							end,
		TXREF_DEL_QTY,TXREF_QTY,uri = 'learning/billofmaterial/' + convert(varchar, BOM_ID),
		PSG_NAME = psg.PSG_NAME
	from dbo.Bill_Of_Material
	left join dbo.Product Syl ON Syl.PROD_ID=BOM_SYLLABUS_ID
	left join dbo.Product Acc ON Acc.PROD_ID=BOM_RESOURCE_ID
	left join 
		(select max(TXREF_ID) MAX_TXREF_ID,TXREF_BOM_ID from dbo.Template_Xref
		group by TXREF_BOM_ID)z ON TXREF_BOM_ID =  BOM_ID
	left join dbo.Template_Xref ON TXREF_ID=MAX_TXREF_ID
	left join dbo.ProdSelectGroups psg ON PSG_ID = BOM_PSG_ID

GO





