if not exists (select object_id from sys.objects where name = 'vConsensusDelegates' and type = 'v')
  exec ('create view dbo.vConsensusDelegates as select 1 as temp')
go

alter view dbo.vConsensusDelegates as 
select distinct DEL_ID, 
								PN_SURNAME,PROLE_PHONE, PROLE_EMAIL,
								CASE DEL_PROLE_ID WHEN 'TBA'
									THEN 'TBA (' + LTRIM(STR(DEL_QUANTITY, 5, 0))  + ')'
									ELSE PROLE_PN_NAME END AS PROLE_PN_NAME, 
									ELEM_STATUS, 
								CASE ISNULL(ELEM_STATUS,0) 
								WHEN 0 THEN 'Provisional' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 1 THEN 'Confirmed' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 2 THEN	'Cancelled' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 7 THEN	'Transfered' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 8 THEN	'Confirmed' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 9 THEN	'Substituted' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 10 THEN 'Waiting' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 11 THEN 'Reservation' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 12 THEN 'Lapsed Wait' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 13 THEN 'Lapsed Res' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 99 THEN 'Incomplete' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								WHEN 98 THEN 'Payment Error' +  CASE ELEM_ATTENDED when 0 then ' (Not Attended)' when 1 then ' (Attended)' else '' end
								ELSE '' END AS STATUS,
								ELEM_TYPE,ELEM_MAIN_SESSION, 
								PROLE_POS_TITLE,PROLE_MEM_C_TOT,PROLE_MEM_R_TOT,PROLE_MEM_L_TOT, 
								DelOrg.ORG_NAME,DelOrg.ORG_ID,
								COURSE_ID,COURSE_NAME, 
								DEL_PERSON_ID,DEL_PROLE_ID,DEL_BOOK_ID, 
								BookOrg.ORG_NAME BOOK_ORG_NAME,BOOK_ORG_ID, 
									
								isnull(DelOrg.ORG_MEM_C_TOT,0) ORG_MEM_C_TOT,isnull(DelOrg.ORG_MEM_R_TOT,0) ORG_MEM_R_TOT,isnull(DelOrg.ORG_MEM_L_TOT,0) ORG_MEM_L_TOT, 
								ELEM_GRP_ID  
								from dbo.Delegate 
								inner join dbo.ELEMENT on ELEM_DEL_ID = DEL_ID and ELEM_CHOSEN=1 and isnull(ELEM_BLOCK_DEL,0)=0 
								left outer join dbo.COURSE on COURSE_ID = ELEM_COURSE_ID 
								left outer join dbo.ACTIVITY on ACT_ID = ELEM_ACT_ID 
								left outer join dbo.PERSON on PN_ID = DEL_PERSON_ID 
								left outer join dbo.PERSON_ROLE  on PROLE_ID = DEL_PROLE_ID 
								Left outer join dbo.ORGANISATION DelOrg  on DelOrg.ORG_ID = PROLE_ORG_ID 
								left outer join dbo.Position_Xref on posxref_Prole_id = PROLE_ID   
								left outer join dbo.position on pos_id = posxref_pos_id   
								left outer join dbo.position_type  on postype_id = pos_postype_id  
								Left outer join dbo.BOOKING on BOOK_ID = ELEM_BOOK_ID 
								Left outer join dbo.ORGANISATION BookOrg on BookOrg.ORG_ID = BOOK_ORG_ID 

go

