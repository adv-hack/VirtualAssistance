IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusAssociateTimeLog'))
BEGIN
	exec ('create view [dbo].[vConsensusAssociateTimeLog] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusAssociateTimeLog]
AS

	select DISTINCT TIM_ID,TIM_HOURS,TIM_HOU_CHARGE,TIM_TRA_HOURS,TIM_TRA_CHARGE
	,TIM_TYPE,TIM_ACT_ID, SXREF.SXREF_ACT_ID
	,CASE WHEN UPPER(TIM_Type) = 'SESSION' THEN A2.ACT_SESSION_NAME ELSE A1.ACT_SESSION_NAME END AS LoggedAgainst,Tim_Desc
	,TIM_ROLE_ID,TIM_TRAIN_SY_TYPE
	,uri = 'contact/timespent/' + convert(varchar, TIM_ID)
	From Time_Spent  
					Inner Join person_Role on TIM_ROLE_ID = PROLE_ID  
					--LEFT OUTER JOIN Trainer T ON TIM_ROLE_ID = T.TRAIN_PROLE_ID
					Left Outer Join Project on TIM_PROJ_ID = PROJ_ID  
					Left Outer Join Course A on TIM_ACT_ID = A.COURSE_ID   
						And (Upper(A.COURSE_DIARY_TYPE) = 'WORK PACKAGE'  
						or Upper(A.COURSE_DIARY_TYPE) = 'MILESTONE') and Upper(TIM_TYPE) = 'WORK PACKAGE'  
					Left Outer Join Activity A1 on TIM_ACT_ID = A1.ACT_ID and Upper(TIM_TYPE) = 'ACTIVITY'  
					Left Outer Join Course B on A1.ACT_COURSE_ID = B.COURSE_ID  
						And (Upper(B.COURSE_DIARY_TYPE) = 'WORK PACKAGE'  
						or Upper(B.COURSE_DIARY_TYPE) = 'MILESTONE')  
					Left outer join Session_Xref SXREF on SXREF_ACT_ID = TIM_ACT_ID and Upper(TIM_TYPE) = 'SESSION'  
					Left outer join Activity A2 on A2.ACT_ID = SXREF_ACT_ID  
					Left outer join Course C on C.COURSE_ID = SXREF_COURSE_ID  
					Left outer join Helpdesk on TIM_ACT_ID = HD_ID and Upper(TIM_TYPE) = 'HELPCALL'  
					Left outer join Issue_Line on TIM_ACT_ID = convert(varchar(11),IL_ID) and Upper(TIM_TYPE) = 'ISSUE' 				
					--WHERE TRAIN_SY_TYPE=0

GO
