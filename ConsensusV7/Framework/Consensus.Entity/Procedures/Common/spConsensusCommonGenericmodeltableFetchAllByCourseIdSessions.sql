if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonGenericmodeltableFetchAllByCourseIdSessions')
  exec ('create procedure dbo.spConsensusCommonGenericmodeltableFetchAllByCourseIdSessions as select 1 as temp')
go
alter procedure dbo.spConsensusCommonGenericmodeltableFetchAllByCourseIdSessions(@PA_COURSE_ID varchar(11) = null output) as 
begin

	declare @Products table
	(
    GMT_ID varchar(11),
    GMT_ID1 varchar(11),
    GMT_ID2 varchar(11),
    GMT_ID3 varchar(11),
    GMT_ID4 varchar(11),
    GMT_ID5 varchar(11),
    GMT_DESC1 varchar(200),
    GMT_DESC2 varchar(200),
    GMT_DESC3 varchar(200),
    GMT_DESC4 varchar(200),
    GMT_DESC5 varchar(200),
    GMT_LONGDESC varchar(500),
    GMT_DATE1 datetime,
    GMT_DATE2 datetime,
    GMT_DATE3 datetime,
    GMT_INT1 int,
    GMT_INT2 int,
    GMT_INT3 int,
    GMT_MONEY1 money,
		GMT_MONEY2 money,
    GMT_MONEY3 money	
	)

	insert into @Products
	select distinct
    '' GMT_ID,
    EP_PROD_ID GMT_ID1,
    @PA_COURSE_ID GMT_ID2,
    '' GMT_ID3,
    '' GMT_ID4,
    '' GMT_ID5,
    PROD_NAME GMT_DESC1,
    '' GMT_DESC2,
    '' GMT_DESC3,
    P_PROD_SY_PRODUCT_DESC GMT_DESC4,
    case SXREF_MANDATORY when 1 then 'Mandatory'
												when 0 then 'Optional'
												when 2 then 'Recommended'
		end GMT_DESC5,
    '' GMT_LONGDESC,
    null GMT_DATE1,
		null GMT_DATE2,
    null GMT_DATE3,
    0 GMT_INT1,
    SXREF_MANDATORY GMT_INT2,
    P_ELEM_TYPE GMT_INT3,
    case SXREF_MANDATORY when 1 then 2
												when 0 then 0
												when 2 then 1
		end GMT_MONEY1,
	  0 GMT_MONEY2,
    0 GMT_MONEY3	
	FROM dbo.Session_Xref  
	join dbo.event_product on ep_id = sxref_ep_id 
	join dbo.product on prod_id = ep_prod_id	
	join dbo.vPROD_SY_PRODUCT_TO_ELEM_TYPE ON P_PROD_SY_PRODUCT = PROD_SY_PRODUCT
	where SXREF_COURSE_ID=@PA_COURSE_ID

	declare @ELEM_START_DATE datetime

	update p  set @ELEM_START_DATE
		= GMT_DATE1 =  
			case
              when PROD_START_DATE_TYPE = 1 and PROD_START_DATE_FIXED>=Course_Start_Date then PROD_START_DATE_FIXED
              when PROD_START_DATE_TYPE = 2 and PROD_START_DATE_OFFSET_TYPE = 'hh' then dateadd(hour,PROD_START_DATE_OFFSET,Course_Start_Date)
              when PROD_START_DATE_TYPE = 2 and PROD_START_DATE_OFFSET_TYPE = 'd' then dateadd(day,PROD_START_DATE_OFFSET,Course_Start_Date)
              when PROD_START_DATE_TYPE = 2 and PROD_START_DATE_OFFSET_TYPE = 'wk' then dateadd(week,PROD_START_DATE_OFFSET,Course_Start_Date)
              when PROD_START_DATE_TYPE = 2 and PROD_START_DATE_OFFSET_TYPE = 'mm' then dateadd(month,PROD_START_DATE_OFFSET,Course_Start_Date)
              when PROD_START_DATE_TYPE = 2 and PROD_START_DATE_OFFSET_TYPE = 'yy' then dateadd(year,PROD_START_DATE_OFFSET,Course_Start_Date)
              else Course_Start_Date
              end,
		GMT_DATE2 =
			case
              when PROD_END_DATE_TYPE = 1 and @ELEM_START_DATE<=PROD_END_DATE_FIXED then PROD_END_DATE_FIXED
              when PROD_END_DATE_TYPE = 2 and PROD_END_DATE_OFFSET_TYPE = 'hh' then dateadd(hour,PROD_END_DATE_OFFSET,@ELEM_START_DATE)
              when PROD_END_DATE_TYPE = 2 and PROD_END_DATE_OFFSET_TYPE = 'd' then dateadd(day,PROD_END_DATE_OFFSET,@ELEM_START_DATE)
              when PROD_END_DATE_TYPE = 2 and PROD_END_DATE_OFFSET_TYPE = 'wk' then dateadd(week,PROD_END_DATE_OFFSET,@ELEM_START_DATE)
              when PROD_END_DATE_TYPE = 2 and PROD_END_DATE_OFFSET_TYPE = 'mm' then dateadd(month,PROD_END_DATE_OFFSET,@ELEM_START_DATE)
              when PROD_END_DATE_TYPE = 2 and PROD_END_DATE_OFFSET_TYPE = 'yy' then dateadd(year,PROD_END_DATE_OFFSET,@ELEM_START_DATE)
              else Course_Start_Date
              end
              from @Products p
              join dbo.Product ON PROD_ID=p.GMT_ID1
							join dbo.Course ON COURSE_ID=@PA_COURSE_ID

	insert into @Products
	select distinct 
    ACT_ID GMT_ID,
    '' GMT_ID1,
    @PA_COURSE_ID GMT_ID2,
    '' GMT_ID3,
    '' GMT_ID4,
    '' GMT_ID5,
    ACT_SESSION_NAME GMT_DESC1,
    convert(varchar(5),ACT_TIME,108) GMT_DESC2,
    convert(varchar(5),ACT_END_TIME,108) GMT_DESC3,
    case ACT_TYPE when 'D-Accom' then 'Accommodation'
									when 'D-CBA' then 'CBA'
									when 'D-Exam' then 'Scheduled Exam'
									when 'D-Session' then 'Session'
		end GMT_DESC4,
    case SXREF_MANDATORY when 1 then 'Mandatory'
												when 0 then 'Optional'
												when 2 then 'Recommended'
		end GMT_DESC5,
    '' GMT_LONGDESC,
    ACT_ACTION_DATE GMT_DATE1,
    ACT_END_DATE GMT_DATE2,
    null GMT_DATE3,
    SXREF_MAIN_SESSION GMT_INT1,
    SXREF_MANDATORY GMT_INT2,
    case ACT_TYPE when 'D-Accom' then 1
									when 'D-CBA' then 28
									when 'D-Exam' then 21
									when 'D-Session' then 0
		end GMT_INT3,
    case SXREF_MANDATORY when 1 then 2
												when 0 then 0
												when 2 then 1
		end GMT_MONEY1,
		0 GMT_MONEY2,
    0 GMT_MONEY3	
	from dbo.Session_Xref
	join dbo.Activity ON ACT_ID=SXREF_ACT_ID
	where SXREF_COURSE_ID=@PA_COURSE_ID
	
	select * from @Products
	order by GMT_INT1 desc,GMT_INT3,GMT_MONEY1 desc,GMT_DATE1,GMT_DESC2
end
go
