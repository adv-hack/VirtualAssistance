if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchActivityList')
  exec ('create procedure dbo.spConsensusSearchActivityList as select 1 as temp')
go
alter procedure dbo.spConsensusSearchActivityList
( 
@PA_PROLE_ID varchar(11) = null , 
@PA_ORG_ID varchar(11) = null,
@PA_PN_ID varchar(11) = null,
@PA_OPP_ID varchar(11) = null,
@PA_ACT_TYPE varchar(40) = null,
@PA_REC_ID varchar(11) = null,
@PA_TABLE_NUM int = null,
@PA_OPP_SY_TYPE int = null
) 
as
begin

	if @PA_ACT_TYPE = 'Letter'
	begin
		select distinct ACT_ID,ACT_TYPE, ACT_SESSION_NAME,ACT_ACTION_DATE, 
		EndUser.ACTXREF_ORG_ID ORG_ID,EndUser.ACTXREF_PROLE_ID PROLE_ID,EndUser.ACTXREF_PERSON_ID PN_ID,
		EndUser.ACTXREF_ORG_NAME ACTXREF_ORG_NAME,EndUser.ACTXREF_PN_NAME ACTXREF_PN_NAME,substring(ACT_NOTE,1,50)  ACT_NOTE,
		PN_SURNAME,PN_FIRST_NAME, uri = 'activities/activity/' + convert(varchar, ACT_ID),ACT_OPP_ID, OPP_SY_TYPE
		from dbo.Activity
		join dbo.Activity_Xref EndUser ON EndUser.ACTXREF_ACT_ID=ACT_ID and ACTXREF_TYPE=2
		join dbo.Activity_Xref AllXref ON AllXref.ACTXREF_ACT_ID = ACT_ID
		join dbo.Person ON PN_ID=EndUser.ACTXREF_PERSON_ID
		left join dbo.Opportunity on OPP_ID = ACT_OPP_ID
		where isnull(ACT_OPP_ID,'') = isNull(nullIf(@PA_OPP_ID, ''), isnull(ACT_OPP_ID,''))
			and isnull(AllXref.ACTXREF_ORG_ID,'') = isNull(nullIf(@PA_ORG_ID, ''), isnull(AllXref.ACTXREF_ORG_ID,''))
			and isnull(AllXref.ACTXREF_PROLE_ID,'') = isNull(nullIf(@PA_PROLE_ID, ''), isnull(AllXref.ACTXREF_PROLE_ID,''))
			and isnull(AllXref.ACTXREF_PERSON_ID,'') = isNull(nullIf(@PA_PN_ID, ''), isnull(AllXref.ACTXREF_PERSON_ID,''))
			and ACT_TYPE in ('Letter','Email','Phone') 
			AND isnull(OPP_SY_TYPE,'') = isNull(nullIf(@PA_OPP_SY_TYPE, ''), isnull(OPP_SY_TYPE,''))
		order by PN_SURNAME,PN_FIRST_NAME
	end
	else if @PA_TABLE_NUM is not null
	begin
		select distinct ACT_ID,ACT_TYPE, ACT_SESSION_NAME,ACT_ACTION_DATE, 
		EndUser.ACTXREF_ORG_ID ORG_ID,EndUser.ACTXREF_PROLE_ID PROLE_ID,EndUser.ACTXREF_PERSON_ID PN_ID,
		EndUser.ACTXREF_ORG_NAME ACTXREF_ORG_NAME,EndUser.ACTXREF_PN_NAME ACTXREF_PN_NAME,substring(ACT_NOTE,1,50)  ACT_NOTE,
		PN_SURNAME,PN_FIRST_NAME, ACT_TIME, ACT_ADD_DATE, uri = 'activities/activity/' + convert(varchar, ACT_ID),ACT_OPP_ID, OPP_SY_TYPE
		From dbo.ACT_LINK_XREF 
		inner join dbo.Activity on ACTLINK_ACT_ID = ACT_ID 
		left join dbo.Activity_Xref EndUser ON EndUser.ACTXREF_ACT_ID=ACT_ID and ACTXREF_TYPE=2
		left join dbo.Person ON PN_ID=EndUser.ACTXREF_PERSON_ID
		left join dbo.Opportunity on OPP_ID = ACT_OPP_ID
		where ACTLINK_REC_ID = @PA_REC_ID
		and ACTLINK_TABLE_NUM = @PA_TABLE_NUM
		and ACT_TYPE like isNull(nullIf(@PA_ACT_TYPE, '') + '%', ACT_TYPE)
		AND isnull(OPP_SY_TYPE,'') = isNull(nullIf(@PA_OPP_SY_TYPE, ''), isnull(OPP_SY_TYPE,''))
		order by ACT_ACTION_DATE desc, ACT_TIME desc, ACT_ADD_DATE Desc 
	end
	else 
	begin
		select distinct ACT_ID,ACT_TYPE, ACT_SESSION_NAME,ACT_ACTION_DATE, 
		EndUser.ACTXREF_ORG_ID ORG_ID,EndUser.ACTXREF_PROLE_ID PROLE_ID,EndUser.ACTXREF_PERSON_ID PN_ID,
		EndUser.ACTXREF_ORG_NAME ACTXREF_ORG_NAME,EndUser.ACTXREF_PN_NAME ACTXREF_PN_NAME,substring(ACT_NOTE,1,50)  ACT_NOTE,
		PN_SURNAME,PN_FIRST_NAME, uri = 'activities/activity/' + convert(varchar, ACT_ID), ACT_OPP_ID, OPP_SY_TYPE
		from dbo.Activity
		join dbo.Activity_Xref EndUser ON EndUser.ACTXREF_ACT_ID=ACT_ID and ACTXREF_TYPE=2
		join dbo.Activity_Xref AllXref ON AllXref.ACTXREF_ACT_ID = ACT_ID
		join dbo.Person ON PN_ID=EndUser.ACTXREF_PERSON_ID
		left join dbo.Opportunity on OPP_ID = ACT_OPP_ID
		where isnull(ACT_OPP_ID,'') = isNull(nullIf(@PA_OPP_ID, ''), isnull(ACT_OPP_ID,''))
			and isnull(AllXref.ACTXREF_ORG_ID,'') = isNull(nullIf(@PA_ORG_ID, ''), isnull(AllXref.ACTXREF_ORG_ID,''))
			and isnull(AllXref.ACTXREF_PROLE_ID,'') = isNull(nullIf(@PA_PROLE_ID, ''), isnull(AllXref.ACTXREF_PROLE_ID,''))
			and isnull(AllXref.ACTXREF_PERSON_ID,'') = isNull(nullIf(@PA_PN_ID, ''), isnull(AllXref.ACTXREF_PERSON_ID,''))
			and ACT_TYPE like isNull(nullIf(@PA_ACT_TYPE, '') + '%', ACT_TYPE)
			AND isnull(OPP_SY_TYPE,'') = isNull(nullIf(@PA_OPP_SY_TYPE, ''), isnull(OPP_SY_TYPE,''))
		order by PN_SURNAME,PN_FIRST_NAME
	end
end
